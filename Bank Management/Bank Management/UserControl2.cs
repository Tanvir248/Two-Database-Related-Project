using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Bank_Management
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idtextBox1.Text == "")
            {
                MessageBox.Show("Error!");
            }
            else
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost; username=root;password=; database=bank");
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT *FROM " + idtextBox1.Text + "";
                MySqlDataReader sdr = cmd.ExecuteReader();
                DataTable dtrecord = new DataTable();
                dtrecord.Load(sdr);
                dataGridView1.DataSource = dtrecord;
                dataGridView1.Visible = true;
            }
        }

        private void adddatabutton1_Click(object sender, EventArgs e)
        {
            string s = moneytextBox2.Text;
            int x = int.Parse(s);
            //MessageBox.Show(x.ToString());
            try
            {
                string MyConnection2 = "datasource=localhost; username=root;password=; database=bank";
                string query1 = "SELECT name,total_taka FROM " + idtextBox1.Text + " WHERE(total_taka + " + x + ")=total_taka ";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand3 = new MySqlCommand(query1, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand3.ExecuteReader();
                //MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }

                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (idtextBox1.Text == "")
            {
                MessageBox.Show("Error!");
            }
            else
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost; username=root;password=; database=bank");
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT *FROM " + idtextBox1.Text + "";
                MySqlDataReader sdr = cmd.ExecuteReader();
                DataTable dtrecord = new DataTable();
                dtrecord.Load(sdr);
                dataGridView1.DataSource = dtrecord;
                dataGridView1.Visible = true;
            }
            idtextBox1.Clear();
            moneytextBox2.Clear();
            idtextBox1.Focus();
        }
    }
}
