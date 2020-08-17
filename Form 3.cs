Form 3

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QSR6JKT;Initial Catalog=master;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("UPDATE Songs SET Title = '" + textBox12.Text + "', Record_Date = '" + textBox13.Text+ "' WHERE Song_ID=" + textBox1.Text + "");
            cmd.ExecuteNonQuery();
            cmd.CommandText = ("UPDATE Employe SET name = '" + textBox22.Text + "',  C_Address = '" + textBox15.Text + "'WHERE Employe_ID=" + textBox14.Text + "");
            cmd.ExecuteNonQuery();
            cmd.CommandText = ("UPDATE Genre SET type = '" + textBox18.Text + "'WHERE Genre_ID =" + textBox17.Text + "");
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your data has been update successfully!");
        }
        public void displaySong()  
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Song_ID, Title,Record_Date from Songs;";  
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void displayEmployee()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Employe_ID, name, C_Address, Cell_number from Employe;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        public void displayGenre()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Genre_ID, type from genre;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }
        public void displayData()
        {
            displaySong();
            displayEmployee();
            displayGenre();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Song_ID"].FormattedValue.ToString();
            textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells["Title"].FormattedValue.ToString();
            textBox13.Text = dataGridView1.Rows[e.RowIndex].Cells["Record_Date"].FormattedValue.ToString();
            textBox14.Text = dataGridView2.Rows[e.RowIndex].Cells["Employe_ID"].FormattedValue.ToString();
            textBox22.Text = dataGridView2.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            textBox15.Text = dataGridView2.Rows[e.RowIndex].Cells["C_Address"].FormattedValue.ToString();
            textBox16.Text = dataGridView2.Rows[e.RowIndex].Cells["Cell_number"].FormattedValue.ToString();
            textBox17.Text = dataGridView3.Rows[e.RowIndex].Cells["Genre_ID"].FormattedValue.ToString();
            textBox18.Text = dataGridView3.Rows[e.RowIndex].Cells["type"].FormattedValue.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }
    }
  
}
