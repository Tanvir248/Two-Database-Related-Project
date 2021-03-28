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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            userControl11.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl31.Visible = false;
            userControl11.Visible = false;
            userControl21.Visible = false;
            sidepanel2.Height = loanbutton3.Height;
            sidepanel2.Top = loanbutton3.Top;
            userControl51.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl51.Visible = false;
            userControl21.Visible = false;
            userControl11.Visible = false;
            sidepanel2.Height = withdrowbutton2.Height;
            sidepanel2.Top = withdrowbutton2.Top;
            userControl31.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl51.Visible = false;
            userControl31.Visible = false;
            userControl11.Visible = false;
            sidepanel2.Height = depositbutton1.Height;
            sidepanel2.Top = depositbutton1.Top;
            userControl21.Visible = true;
        }

        private void adddatabutton1_Click(object sender, EventArgs e)
        {
            userControl51.Visible = false;
            userControl31.Visible = false;
            sidepanel2.Height = createaccadddatabutton1.Height;
            sidepanel2.Top = createaccadddatabutton1.Top;
            userControl21.Visible = false;
            userControl11.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl51_Load(object sender, EventArgs e)
        {

        }
    }
}
