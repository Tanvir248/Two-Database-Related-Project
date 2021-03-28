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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            seeData();
        }
        void seeData()
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root;password=; database=bank");
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM all_profiles";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtrecord = new DataTable();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
        }

        private void adddatabutton1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void moneytextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void idtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
