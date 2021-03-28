using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "12345";
            string s1 = "team";
            if (passwordtextBox2.Text == s1 && nametextBox1.Text == s)
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
