using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSConsumption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = textBox1.Text;

            using (WSPerson.WSPersonClient client = new WSPerson.WSPersonClient())
            {
                var persona = client.GetPersonById(id);
                richTextBox1.Text = persona.Name;
            }
        }
    }
}
