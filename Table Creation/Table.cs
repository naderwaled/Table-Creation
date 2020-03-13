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

    public partial class Table : UserControl
    {
        int columnIndex;
        string table_name;
        bool found = false;
        bool isfound = false;
        public Table()
        {
            InitializeComponent();
        }
        public Table(string s)
        {
            InitializeComponent();
            table_name = s;
        }

        private void EditBtn_MouseClick(object sender, MouseEventArgs e)
        {
            AddTable addtable = new AddTable();
            this.Parent.Controls.Add(addtable);
            addtable.PKCheckBox.Visible = false;
            addtable.TblNameTxt.Enabled = false;
            addtable.TblNameTxt.Text = table_name;
            addtable.Show();
            addtable.BringToFront();
            addtable.Dock = DockStyle.Fill;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            columnIndex = e.ColumnIndex;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isfound = true;
            found = false;
            XmlDocument doc = new XmlDocument();
            doc.Load("Tables.xml");

            String name = dataGridView1.Columns[e.ColumnIndex].Name;

            XmlNodeList list_tables = doc.SelectNodes("//Table[@name='" + table_name + "']");
            XmlNodeList list_cols = list_tables[0].SelectSingleNode("Columns").SelectNodes("column");

            for (int i = 0; i < list_cols.Count; i++)
            {
                if (list_cols[i].SelectSingleNode("Name").InnerText == name )
                {
                    XmlElement row = doc.CreateElement("row");
                    row.SetAttribute("name", e.RowIndex.ToString());

                    row.InnerText = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    XmlNodeList cols = list_cols[i].ChildNodes;
                    if (cols[2].InnerText == "true")
                    { 
                        int count=dataGridView1.Rows.Count-1;
                        for (int j = 0; j < count; j++)
                        {
                            if (row.InnerText == dataGridView1.Rows[j].Cells[e.ColumnIndex].Value.ToString() && j != e.RowIndex)
                            {
                                found = true;
                            }
                            
                        }


                    }
                    XmlNodeList fk = cols[4].ChildNodes;

                    if (fk.Count != 0)
                    {
                        for (int k = 0; k < fk.Count; k++)
                        {
                            XmlNodeList child = fk[k].ChildNodes;
                            string pk_tablename = child[0].InnerText;
                            string pk_colname = child[1].InnerText;
                            isfound = get_pk_values(pk_colname, pk_tablename, dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                        }
                    }

                    if (found == false&&isfound== true)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = string.Empty;
                        list_cols[i].SelectSingleNode("rows").AppendChild(row);

                    }
                    if (!isfound)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Not found";
                        MessageBox.Show("Value wasn't found in the original column");
                        
                    }
                    
                }

            }
            doc.Save("Tables.xml");

        }

        private void DelBtn_MouseClick(object sender, MouseEventArgs e)
        {
            bool found = false;
            XmlDataDocument doc = new XmlDataDocument();
            doc.Load("Tables.xml");
            XmlNodeList list = doc.GetElementsByTagName("column");
            string colName = dataGridView1.Columns[columnIndex].Name;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].FirstChild.InnerText == colName)
                {
                    XmlNodeList pk = list[i].ChildNodes;

                    if (pk[2].InnerText == "false")
                    {
                        XmlNode removeNode = list[i];
                        list[i].ParentNode.RemoveChild(removeNode);
                        found = true;
                    }
                    else
                        MessageBox.Show("You can't delete column contains pk");
                }
            }
            if (found)
                dataGridView1.Columns.RemoveAt(columnIndex);
            doc.Save("Tables.xml");
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            string Const = "";
            XmlDataDocument doc = new XmlDataDocument();
            doc.Load("Tables.xml");
            XmlNodeList list = doc.GetElementsByTagName("Table");
            for (int i = 0; i < list.Count; i++)
            {
                if (table_name == list[i].Attributes["name"].Value)
                {
                    XmlNodeList columns = list[i].ChildNodes;
                    for (int j = 0; j < columns.Count; j++)
                    {
                        XmlNodeList col = columns[j].ChildNodes;
                        for (int k = 0; k < col.Count; k++)
                        {

                            XmlNodeList child = col[k].ChildNodes;

                            string colName = child[0].InnerText;

                            if (dataGridView1.Columns[e.ColumnIndex].Name == colName)
                            {
                                Const = child[3].InnerText;
                                break;

                            }

                        }

                    }
                }
            }


            string[] temp = Const.Split(' ');
            Const = temp[0] + temp[1];

            if (Const == "NotNULL")
            {

                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = dataGridView1.Columns[e.ColumnIndex].Name + " Dosen't allow NULL Values";
                    e.Cancel = true;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = string.Empty;

                }

            }
            else if (Const == "Greaterthan")
            {

                if (e.FormattedValue.ToString() != "")
                {

                    if (Int32.Parse(e.FormattedValue.ToString()) <= Int32.Parse(temp[3]))
                    {
                        dataGridView1.Rows[e.RowIndex].ErrorText = dataGridView1.Columns[e.ColumnIndex].Name + " Dosen't allow Values Less than" + temp[3];
                        e.Cancel = true;
                    }
                    else
                    {
                        dataGridView1.Rows[e.RowIndex].ErrorText = string.Empty;

                    }
                }
            }
            else if (Const == "Smallerthan")
            {
                if (e.FormattedValue.ToString() != "")
                {
                    if (Int32.Parse(e.FormattedValue.ToString().ToString()) >= Int32.Parse(temp[2]))
                    {
                        dataGridView1.Rows[e.RowIndex].ErrorText = dataGridView1.Columns[e.ColumnIndex].Name + " Dosen't allow Values Greater than" + temp[2];
                        e.Cancel = true;
                    }
                    else
                    {
                        dataGridView1.Rows[e.RowIndex].ErrorText = string.Empty;

                    }
                }
            }
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            ForeignKey fkey = new ForeignKey();
            this.Parent.Controls.Add(fkey);
            fkey.Show();
            fkey.BringToFront();
            fkey.Dock = DockStyle.Fill;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Value already Exists");
            }
        }

        public bool get_pk_values(string col_name,string table_name,string val)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Tables.xml");

            XmlNodeList list_tables = doc.SelectNodes("//Table[@name='" + table_name + "']");
            XmlNodeList list_cols = list_tables[0].SelectSingleNode("Columns").SelectNodes("column");

            for (int i = 0; i < list_cols.Count; i++)
            {
                XmlNodeList cols = list_cols[i].ChildNodes;
                if (list_cols[i].SelectSingleNode("Name").InnerText == col_name)
                {
                    for (int k = 0; k < cols.Count; k++)
                    {
                        XmlNodeList rows = cols[5].ChildNodes;
                        for (int j = 0; j < rows.Count; j++)
                        {
                            if (val == rows[j].InnerText)
                            {
                                return true;
                            }
                        }
                    }
                }

            }
            return false;    
        
        }


    }
}

