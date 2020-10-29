using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (listBox2.Items.Contains(comboBox1.SelectedItem.ToString()))
            {

            }
            else
            {
                listBox2.Items.Add(comboBox1.SelectedItem.ToString());

            }
            if (listBox2.Items.Contains(listBox1.SelectedItem.ToString()))
            {
                MessageBox.Show("There seems to be a duplicate item in your listbox");
            }
            else
            {
               listBox2.Items.Add(listBox1.SelectedItem.ToString());
                //comboBox1.Items.Remove(comboBox1.Text);
            }
            button2.Enabled = true;
            comboBox1.Enabled = false;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex >-1)
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);

            textBox1.Text = " ";

            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int price;
            Random random = new Random();
            price = random.Next(50, 150);
            textBox1.Text = "$"+price.ToString();
        }



        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
