using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Table_Creation
{
    public partial class ForeignKey : UserControl
    {
        public ForeignKey()
        {
            InitializeComponent();
            read_tables();
        }
        string fk_datatype;
        private void read_tables()
        {
            if (File.Exists("Tables.xml"))
            {
                FkTxt.Text = Home.tableName;
                FkTxt.Enabled = false;

                XmlDataDocument doc = new XmlDataDocument();
                doc.Load("Tables.xml");
                XmlNodeList list = doc.GetElementsByTagName("Table");
                for (int i = 0; i < list.Count; i++)
                {
                    if (Home.tableName != list[i].Attributes["name"].Value)
                    {
                        string tableName = list[i].Attributes["name"].Value;
                        RTableCBox.Items.Add(tableName);
                    }
                    else
                    {
                        XmlNodeList columns = list[i].ChildNodes;
                        for (int j = 0; j < columns.Count; j++)
                        {
                            XmlNodeList col = columns[j].ChildNodes;
                            for (int k = 0; k < col.Count; k++)
                            {
                                XmlNodeList child = col[k].ChildNodes;
                                if (child[2].InnerText == "false")
                                {
                                    string colName = child[0].InnerText;
                                    fk_datatype = child[1].InnerText;
                                    CurrCol.Items.Add(colName);
                                }
                            }
                        }
                    }
                }

            }
        }

        private void AddFKBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Table table = new Table();
            XmlDocument doc = new XmlDocument();
            doc.Load("Tables.xml");

            string col_name = CurrCol.SelectedItem.ToString();

            XmlNodeList list_tables = doc.SelectNodes("//Table[@name='" + Home.tableName + "']");
            XmlNodeList list_cols = list_tables[0].SelectSingleNode("Columns").SelectNodes("column");

            for (int i = 0; i < list_cols.Count; i++)
            {
                if (list_cols[i].SelectSingleNode("Name").InnerText == col_name)
                {
                    XmlElement F_K = doc.CreateElement("F_K");
                    XmlElement tablename = doc.CreateElement("Tablem_name");
                    tablename.InnerText = RTableCBox.SelectedItem.ToString();
                    F_K.AppendChild(tablename);

                    XmlElement colname = doc.CreateElement("Column_name");
                    colname.InnerText = RColCBox.SelectedItem.ToString();
                    F_K.AppendChild(colname);

                    list_cols[i].SelectSingleNode("Foreign_keys").AppendChild(F_K);
                }

            }
            doc.Save("Tables.xml");

            string tname = Home.tableName;
            Home h = new Home();
            this.ParentForm.Controls.Add(h);
            h.Show();
            h.BringToFront();
            h.Dock = DockStyle.Fill;
            h.TblCBox.SelectedItem = tname;
            h.Display_data();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RColCBox.Items.Clear();
            if (File.Exists("Tables.xml"))
            {
                XmlDataDocument doc = new XmlDataDocument();
                doc.Load("Tables.xml");
                XmlNodeList list = doc.GetElementsByTagName("Table");
                for (int i = 0; i < list.Count; i++)
                {
                    if (RTableCBox.SelectedItem.ToString() == list[i].Attributes["name"].Value)
                    {
                        XmlNodeList columns = list[i].ChildNodes;
                        for (int j = 0; j < columns.Count; j++)
                        {
                            XmlNodeList col = columns[j].ChildNodes;
                            for (int k = 0; k < col.Count; k++)
                            {
                                XmlNodeList child = col[k].ChildNodes;
                                if (fk_datatype == child[1].InnerText && child[2].InnerText == "true")
                                {
                                    string colName = child[0].InnerText;
                                    RColCBox.Items.Add(colName);
                                }

                            }
                        }
                    }
                }

            }
        }

        
    }
}
