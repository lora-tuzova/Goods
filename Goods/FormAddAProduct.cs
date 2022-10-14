using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Goods
{
    public partial class FormAddAProduct : Form
    {
        public FormAddAProduct()
        {
            InitializeComponent();

        }

        public int ProductID { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.productsList.Add(new Products(double.Parse(textBox7.Text), textBox3.Text, textBox4.Text, dateTimePicker1.Value, textBox9.Text, dateTimePicker2.Value, int.Parse(textBox2.Text), comboBox1.Text));
            }

            catch
            {
                MessageBox.Show("Incorrect input");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
