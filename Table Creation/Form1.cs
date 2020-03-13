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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Home h = new Home();
            this.Controls.Add(h);
            h.Dock = DockStyle.Fill;
        }
    }
}
