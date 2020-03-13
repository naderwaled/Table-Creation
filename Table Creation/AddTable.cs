using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Table_Creation
{
    public partial class AddTable : UserControl
    {
        public AddTable()
        {
            InitializeComponent();
        }

        private void AddColBtn_Click(object sender, EventArgs e)
        {

            string table_name = TblNameTxt.Text;
            string colomun_name = CNameTxt.Text;
            string data_type = DTypeCBox.SelectedItem.ToString();
            string type_constraint = ConsCBox.SelectedItem.ToString();
            string constraint = ConsTxt.Text;
            bool p_key = PKCheckBox.Checked;

            Table table_gui = new Table(table_name);

            DataTable table = new DataTable();
            DataColumn[] key = new DataColumn[1];

            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System." + data_type);
            column.ColumnName = colomun_name;

            table.Columns.Add(column);
            key[0] = column;

            if (p_key == true)
            {
                table.PrimaryKey = key;
            }

            if (!File.Exists("Tables.xml"))
            {
                XmlWriter writer = XmlWriter.Create("Tables.xml");

                //start
                writer.WriteStartDocument();
                writer.WriteStartElement("Tables");

                writer.WriteStartElement("Table");
                writer.WriteAttributeString("name", table_name);

                writer.WriteStartElement("Columns");


                writer.WriteStartElement("column");

                writer.WriteStartElement("Name");
                writer.WriteString(colomun_name);
                writer.WriteEndElement();

                writer.WriteStartElement("data_type");
                writer.WriteString(data_type);
                writer.WriteEndElement();

                writer.WriteStartElement("Primary_key");
                if (p_key)
                { writer.WriteString("true"); }
                else
                { writer.WriteString("false"); }
                writer.WriteEndElement();

                writer.WriteStartElement("Constarints");
                writer.WriteString(type_constraint + " " + constraint);
                writer.WriteEndElement();

                writer.WriteStartElement("Foreign_keys");
                writer.WriteEndElement();

                writer.WriteStartElement("rows");

                writer.WriteEndElement();

                //<column>
                writer.WriteEndElement();
                //<columns>
                writer.WriteEndElement();
                //<table>
                writer.WriteEndElement();
                //<tables>
                writer.WriteEndElement();
                //end
                writer.WriteEndDocument();
                writer.Close();

                MessageBox.Show("Table is Added!");
                Home h = new Home();
                this.ParentForm.Controls.Add(h);
                h.Show();
                h.BringToFront();
                h.Dock = DockStyle.Fill;
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Tables.xml");

                XmlNodeList list_tables = doc.SelectNodes("//Table[@name='" + table_name + "']");

                if (list_tables.Count > 0)
                {
                    try
                    {
                        XmlNode col = list_tables[0].SelectSingleNode("Columns").AppendChild(doc.CreateElement("column"));

                        XmlElement dt = doc.CreateElement("Name");
                        dt.InnerText = colomun_name;
                        col.AppendChild(dt);

                        dt = doc.CreateElement("data_type");
                        dt.InnerText = data_type;
                        col.AppendChild(dt);

                        dt = doc.CreateElement("Primary_key");
                        if (p_key)
                            dt.InnerText = "true";
                        else
                            dt.InnerText = "false";

                        col.AppendChild(dt);


                        dt = doc.CreateElement("Constraints");
                        dt.InnerText = type_constraint + " " + constraint;

                        col.AppendChild(dt);

                        dt = doc.CreateElement("Foreign_keys");
                        col.AppendChild(dt);

                        dt = doc.CreateElement("rows");
                        col.AppendChild(dt);
                        doc.Save("Tables.xml");
                        MessageBox.Show("Column is Added!");
                        string tname = Home.tableName;
                        Home h = new Home();
                        this.ParentForm.Controls.Add(h);
                        h.Show();
                        h.BringToFront();
                        h.Dock = DockStyle.Fill;
                        h.TblCBox.SelectedItem = tname;
                        h.Display_data();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Table already exist !");
                    }
                    
                }
                else
                {
                    XmlNode node = doc.DocumentElement;
                    XmlElement tablee = doc.CreateElement("Table");

                    tablee.SetAttribute("name", table_name);

                    XmlElement cols = doc.CreateElement("Columns");

                    XmlElement col = doc.CreateElement("column");
                    XmlElement dt = doc.CreateElement("Name");
                    dt.InnerText = colomun_name;
                    col.AppendChild(dt);

                    dt = doc.CreateElement("data_type");
                    dt.InnerText = data_type;
                    col.AppendChild(dt);

                    dt = doc.CreateElement("Primary_key");
                    if (p_key)
                        dt.InnerText = "true";
                    else
                        dt.InnerText = "false";

                    col.AppendChild(dt);

                    dt = doc.CreateElement("Constraints");
                    dt.InnerText = type_constraint + " " + constraint;

                    col.AppendChild(dt);

                    dt = doc.CreateElement("Foreign_keys");
                    col.AppendChild(dt);

                    dt = doc.CreateElement("rows");
                    col.AppendChild(dt);

                    cols.AppendChild(col);
                    tablee.AppendChild(cols);
                    node.AppendChild(tablee);

                    MessageBox.Show("Table is Added!");
                    doc.Save("Tables.xml");
                    Home h = new Home();
                    this.ParentForm.Controls.Add(h);
                    h.Show();
                    h.BringToFront();
                    h.Dock = DockStyle.Fill;
                }
            }
        }
    }
}