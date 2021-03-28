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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           // CommenttextBox5.Text = calculate().ToString();
        }
        
        
           
        
        private void feestextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void adddatabutton1_Click(object sender, EventArgs e)
        {
            if(nametextBox1.Text==""||idtextBox2.Text == "")
            {
                MessageBox.Show("Please Chekck Eror!");
            }
            else
            {
                int ct, mid, final;
                string s1, s2, s3;
                s1 = cttextBox3.Text;
                s2 = midtextBox1.Text;
                s3 = finaltextBox4.Text;
                ct = int.Parse(s1);
                mid = int.Parse(s2);
                final = int.Parse(s3);
                int total = ct + mid + final;
               // MessageBox.Show(total.ToString());
                string grade = "";
                if (total>=40&&total<45)
                {
                    grade = "E";
                }else if(total>= 45&&total<50)
                {
                    grade = "D";
                }
                else if (total >= 50&& total<55)
                {
                    grade = "C";
                }
                else if (total >= 60 && total<65)
                {
                    grade = "B";
                }
                else if (total >= 65&& total<70)
                {
                    grade = "B+";
                }
                else if (total >= 70 && total<75)
                {
                    grade = "A-";
                }
                else if (total >= 75&&total<80)
                {
                    grade = "A";
                }
                else if (total >= 80&&total<90)
                {
                    grade = "A+";
                }
                else
                {
                    grade = "A+(S)";
                }
                //MessageBox.Show(grade);
                try
                {
                    string MyConnection2 = "datasource=localhost; username=root;password=; database=mini_school";
                    string Query = "insert into `results`(id,class,student_name,CT_class,mid,final,total,grade,comments) values('" + this.idtextBox2.Text + "','" + this.comboBox1.SelectedItem.ToString() + "','" + this.nametextBox1.Text + "','" + this.cttextBox3.Text + "','" + this.midtextBox1.Text + "','" + this.finaltextBox4.Text + "','" + total + "','" + grade + "','" + CommenttextBox5.Text + "');";
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

        private void seedatabutton3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root;password=; database=mini_school");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM `results`";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtrecord = new DataTable();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
        }

        private void refreshbutton2_Click(object sender, EventArgs e)
        {
            nametextBox1.Clear();
            idtextBox2.Clear();
            cttextBox3.Clear();
            midtextBox1.Clear();
            finaltextBox4.Clear();
            CommenttextBox5.Clear();
            nametextBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cttextBox3.Text == "" || midtextBox1.Text == "" || finaltextBox4.Text == "")
            {
                MessageBox.Show("Eror! Enter All the Number");
            }
            else
            {
                int ct, mid, final;
                string s1, s2, s3;
                s1 = cttextBox3.Text;
                s2 = midtextBox1.Text;
                s3 = finaltextBox4.Text;
                ct = int.Parse(s1);
                mid = int.Parse(s2);
                final = int.Parse(s3);
                int total = ct + mid + final;
                CommenttextBox5.Text = total.ToString();
            }
        }
    }
}
