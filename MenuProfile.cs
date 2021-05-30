using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MUB
{
    public partial class MenuProfile : UserControl
    {
        public MenuProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rpl_db.accdb");
            OleDbCommand cmd = new OleDbCommand("select * from biodata where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", con);
            OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                if (textBox7.Text != "")
                {
                    OleDbCommand ins = new OleDbCommand();
                    ins.Connection = con;

                    con.Open();
                    ins.CommandText = "delete from biodata where username = '"+textBox1.Text+"'";
                    ins.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    ins.CommandText = "insert into biodata values ('" + textBox1.Text.ToString() + "', '" + textBox7.Text.ToString() + "', '" + textBox3.Text.ToString() + "', '" + textBox4.Text.ToString() + "', '" + textBox5.Text.ToString() + "', '" + textBox6.Text.ToString() + "', '" + textBox8.Text.ToString() + "')";
                    ins.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    ins.CommandText = "delete from akun where username = '" + textBox1.Text + "'";
                    ins.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    ins.CommandText = "insert into akun values ('" + textBox1.Text.ToString() + "', '" + textBox7.Text.ToString() + "', 'peserta')";
                    ins.ExecuteNonQuery();
                    con.Close();

                    textBox2.Clear();
                    textBox2.Text = textBox7.Text;
                    textBox7.Clear();

                }
                else
                {
                    OleDbCommand ins = new OleDbCommand();
                    ins.Connection = con;

                    con.Open();
                    ins.CommandText = "delete from biodata where username = '" + textBox1.Text + "'";
                    ins.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    ins.CommandText = "insert into biodata values ('" + textBox1.Text.ToString() + "', '" + textBox2.Text.ToString() + "', '" + textBox3.Text.ToString() + "', '" + textBox4.Text.ToString() + "', '" + textBox5.Text.ToString() + "', '" + textBox6.Text.ToString() + "', '" + textBox8.Text.ToString() + "')";
                    ins.ExecuteNonQuery();
                    con.Close();

                }
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox8.Text = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rpl_db.accdb");
            OleDbCommand cmd = new OleDbCommand("select * from biodata where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", con);
            OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                textBox3.Text = dt.Rows[0][2].ToString();
                textBox4.Text = dt.Rows[0][3].ToString();
                textBox5.Text = dt.Rows[0][4].ToString();
                textBox6.Text = dt.Rows[0][5].ToString();
                textBox8.Text = dt.Rows[0][6].ToString();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private void MenuProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
