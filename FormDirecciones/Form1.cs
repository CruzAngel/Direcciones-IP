using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormDirecciones.ServiceReference1;

namespace FormDirecciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        ServiceReference1.WebService1SoapClient cli = new WebService1SoapClient();
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = cli.ClaseIP(textBox1.Text);
        }
    }
}
