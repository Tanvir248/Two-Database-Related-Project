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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void refreshbutton2_Click(object sender, EventArgs e)
        {
            nametextBox1.Clear();
            FnametextBox2.Clear();
            MnametextBox3.Clear();
            feestextBox4.Clear();
            phonenotextBox1.Clear();
            addresstextBox5.Clear();
            nametextBox1.Focus();
            
        }

        private void adddatabutton1_Click(object sender, EventArgs e)
        {
            if (nametextBox1.Text == "" || FnametextBox2.Text == "")
            {
                MessageBox.Show("Error");
            }
            else
            {
                try
                {
                    string MyConnection2 = "datasource=localhost; username=root;password=; database=mini_school";
                    string Query = "insert into `students`(student_name,class,father_name,mother_name,address,admission_fees,phone_no) values('" + this.nametextBox1.Text + "','" + this.comboBox1.SelectedItem.ToString() + "','" + this.FnametextBox2.Text + "','" + this.MnametextBox3.Text + "','" + this.addresstextBox5.Text + "','" + this.feestextBox4.Text + "','" + this.phonenotextBox1.Text + "');";
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
                if (comboBox1.SelectedIndex.ToString() == "0")
                {
                    try
                    {
                        int x = 3000;
                        string y = feestextBox4.Text;
                        int found = int.Parse(y);

                        string MyConnection2 = "datasource=localhost; username=root;password=; database=mini_school";
                        string Query = "insert into `class_five`(student_name,Due) values('" + this.nametextBox1.Text + "','" + (x - found) + "');";
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
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
                }

                if (comboBox1.SelectedIndex.ToString() == "1")
                {
                    try
                    {
                        int x = 3000;
                        string y = feestextBox4.Text;
                        int found = int.Parse(y);

                        string MyConnection2 = "datasource=localhost; username=root;password=; database=mini_school";
                        string Query = "insert into `class_eight`(student_name,Due) values('" + this.nametextBox1.Text + "','" + (x - found) + "');";
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
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
                }
                if (comboBox1.SelectedIndex.ToString() == "2")
                {
                    try
                    {
                        int x = 4000;
                        string y = feestextBox4.Text;
                        int found = int.Parse(y);

                        string MyConnection2 = "datasource=localhost; username=root;password=; database=mini_school";
                        string Query = "insert into `class_ten`(student_name,Due) values('" + this.nametextBox1.Text + "','" + (x - found) + "');";
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        //  MessageBox.Show("Save Data");
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
                if (comboBox1.SelectedIndex.ToString() == "3")
                {
                    try
                    {
                        int x = 5000;
                        string y = feestextBox4.Text;
                        int found = int.Parse(y);

                        string MyConnection2 = "datasource=localhost; username=root;password=; database=mini_school";
                        string Query = "insert into `hsc_batch`(student_name,Due) values('" + this.nametextBox1.Text + "','" + (x - found) + "');";
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
            }
            nametextBox1.Clear();
            FnametextBox2.Clear();
            MnametextBox3.Clear();
            feestextBox4.Clear();
            phonenotextBox1.Clear();
            addresstextBox5.Clear();
            nametextBox1.Focus();
        }

        private void seedatabutton3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root;password=; database=mini_school");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM `students`";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtrecord = new DataTable();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
            class5button1.Visible = true;
            class8button1.Visible = true;
            class10button4.Visible = true;
            hscbutton3.Visible = true;
            searchbutton1.Visible = true;
            searchtextBox1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root;password=; database=mini_school");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM `class_five`";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtrecord = new DataTable();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root;password=; database=mini_school");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM `class_ten`";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtrecord = new DataTable();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root;password=; database=mini_school");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM `class_eight`";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtrecord = new DataTable();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root;password=; database=mini_school");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM `hsc_batch`";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtrecord = new DataTable();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
        }

        private void searchbutton1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root;password=; database=mini_school");
            string searchgrid = "select * from `students` where phone_no like '" + searchtextBox1.Text + "%'";
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM `students`";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtrecord = new DataTable();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
        }

        private void resultbutton5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Teachersbutton2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
