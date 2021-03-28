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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adddatabutton1_Click(object sender, EventArgs e)
        {
            //string s = bankidtextBox2.Text;
            try
            {
                string MyConnection2 = "datasource=localhost; username=root;password=; database=bank";
                string Query = "insert into `all_profiles`(id,name,mobile,email,address,AFP,type) values('" + this.bankidtextBox2.Text + "','" + this.nametextBox1.Text + "','" + this.mobiletextBox2.Text + "','" + this.emailtextBox3.Text + "','" + this.addresstextBox5.Text + "','" + this.accountandpaperstextBox1.Text + "','" + this.comboBox1.SelectedItem.ToString() + "');";
               string query1 = "CREATE TABLE `s`(name varchar(20),total_taka int(9)); ";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlCommand MyCommand3 = new MySqlCommand(query1, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyReader2 = MyCommand3.ExecuteReader();
              //  MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }

                MyConn2.Close();
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.Message);
            }

            try { 
            string MyConnection2 = "datasource=localhost; username=root;password=; database=bank";
            string query1 = "CREATE TABLE "+ bankidtextBox2.Text+"(name varchar(20),total_taka int(9)); ",con;
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand3 = new MySqlCommand(query1, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand3.ExecuteReader();
           // MessageBox.Show("Save Data");
            while (MyReader2.Read())
            {
            }

            MyConn2.Close();
             }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.Message);
            }
            try
            {
                int x = 1000;
                string MyConnection2 = "datasource=localhost; username=root;password=; database=bank";
                string Query = "insert into "+ bankidtextBox2.Text +"(name, total_taka) values('" + this.nametextBox1.Text +"','"+x.ToString() +"');", con;
                string query1 = "CREATE TABLE `s`(name varchar(20),total_taka int(9)); ";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlCommand MyCommand3 = new MySqlCommand(query1, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyReader2 = MyCommand3.ExecuteReader();
             //   MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }

                MyConn2.Close();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }
    }
}
