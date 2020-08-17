Form 2

using System;
using System.Collections.Generic;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QSR6JKT;Initial Catalog=master;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Songs values(" + textBox11.Text + ",'" + textBox12.Text + "',NULL ,'" + textBox13.Text + "',NULL, NULL, NULL,NULL, NULL, NULL, NULL, NULL)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into Employe values(" + textBox14.Text + ",'" + textBox22.Text + "', '" + textBox15.Text + "', NULL, '" + textBox16.Text + "',NULL, NULL, 1, NULL)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into Genre values(" + textBox17.Text + ",'" + textBox18.Text + "', NULL)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into Instrument values('" + textBox19.Text + "',NULL , NULL)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into Season values(" + textBox20.Text + ",NULL , NULL, NULL)";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The data has been entered successfully!");
                Resetbutton();
            }
           
        }
        private void Resetbutton()
        {
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox13.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox22.Clear();
            textBox17.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resetbutton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

    }
}
