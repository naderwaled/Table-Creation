using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Table_Creation
{
    public partial class Home : UserControl
    {
        public static string tableName;
        public Home()
        {
            InitializeComponent();
            ReadTables();
        }

        private void AddBtn_MouseClick(object sender, MouseEventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            AddTable addtable = new AddTable();
            splitContainer1.Panel2.Controls.Add(addtable);
            addtable.Show();
            addtable.Dock = DockStyle.Fill;
        }

        private void TblCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Display_data();
        }

        public void ReadTables()
        {
            if (File.Exists("Tables.xml"))
            {
                XmlDataDocument doc = new XmlDataDocument();
                doc.Load("Tables.xml");
                XmlNodeList list = doc.GetElementsByTagName("Table");
                for (int i = 0; i < list.Count; i++)
                {
                    string tableName = list[i].Attributes["name"].Value;
                    TblCBox.Items.Add(tableName);
                }

            }
        }
        public void Display_data()
        {
            tableName = TblCBox.SelectedItem.ToString();
            splitContainer1.Panel2.Controls.Clear();
            Table table = new Table(TblCBox.SelectedItem.ToString());
            splitContainer1.Panel2.Controls.Add(table);
            table.Show();
            table.Dock = DockStyle.Fill;
            int isPKFound = -1;

            DataTable dataTable = new DataTable();
            DataColumn[] key = new DataColumn[1];

            int maximum_row = 0, cnt = 0;
            XmlDataDocument doc = new XmlDataDocument();
            doc.Load("Tables.xml");


            XmlNodeList list = doc.GetElementsByTagName("Table");
            for (int i = 0; i < list.Count; i++)
            {
                if (TblCBox.SelectedItem.ToString() == list[i].Attributes["name"].Value)
                {

                    XmlNodeList columns_ = list[i].ChildNodes;
                    for (int j = 0; j < columns_.Count; j++)
                    {
                        cnt = 0;
                        XmlNodeList col_ = columns_[j].ChildNodes;
                        for (int k = 0; k < col_.Count; k++)
                        {

                            XmlNodeList child_ = col_[k].ChildNodes;
                            XmlNodeList rows_ = child_[5].ChildNodes;
                            for (int l = 0; l < rows_.Count; l++)
                            {
                                maximum_row = Math.Max(maximum_row, Int32.Parse(rows_[l].Attributes["name"].Value) + 1);
                            }
                        }

                    }

                    XmlNodeList columns = list[i].ChildNodes;
                    for (int j = 0; j < columns.Count; j++)
                    {
                        XmlNodeList col = columns[j].ChildNodes;
                        for (int k = 0; k < col.Count; k++)
                        {

                            XmlNodeList child = col[k].ChildNodes;
                            DataColumn c = new DataColumn();
                            string colName = child[0].InnerText;
                            c.ColumnName = colName;
                            dataTable.Columns.Add(c);

                            if (c.DataType.Equals(null))
                                c.DataType = System.Type.GetType("System." + child[1].InnerText);

                            string Const;
                            Const = child[3].InnerText;

                            XmlNodeList rows = child[5].ChildNodes;
                            DataRow r = dataTable.NewRow();

                            while (maximum_row > 0)
                            {
                                r.Table.Rows.Add();
                                maximum_row--;
                            }

                            for (int l = 0; l < rows.Count; l++)
                            {

                                Object var = rows[l].InnerText;


                                int x = Int32.Parse(rows[l].Attributes["name"].Value);

                                r.Table.Rows[x][c] = var;
                            }

                            if (child[2].InnerText == "true")
                            {
                                key[0] = c;
                                dataTable.PrimaryKey = key;

                                isPKFound = k;
                            }
                        }
                    }
                }
            }
            table.dataGridView1.DataSource = dataTable;

            for (int i = 0; i < table.dataGridView1.Columns.Count; i++)
            {
                if (isPKFound == i)
                    table.dataGridView1.Columns[i].DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }
    }
}
