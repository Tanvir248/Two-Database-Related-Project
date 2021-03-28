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
namespace Mini_School
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void adddatabutton1_Click(object sender, EventArgs e)
        {

            try
            {
                string MyConnection2 = "datasource=localhost; username=root;password=; database=mini_school";
                string Query = "insert into `teachers`(name,salary_status,phone_no,email,postion,address) values('" + this.nametextBox1.Text + "','" + this.salarytextBox4.Text + "','" + this.phonenotextBox1.Text + "','" + this.emailnametextBox2.Text + "','" + this.comboBox1.SelectedItem.ToString() + "','" + this.addresstextBox5.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                // MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void seedatabutton3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root;password=; database=mini_school");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM `teachers`";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtrecord = new DataTable();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
        }

        private void refreshbutton2_Click(object sender, EventArgs e)
        {
            nametextBox1.Clear();
            emailnametextBox2.Clear();
            phonenotextBox1.Clear();
            salarytextBox4.Clear();
            addresstextBox5.Clear();
            nametextBox1.Focus();
        }
    }
}
