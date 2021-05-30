using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MUB
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rpl_db.accdb");
            OleDbCommand cmd = new OleDbCommand("select * from akun where username = '"+textBox1.Text+"' and password = '"+textBox2.Text+"' and tipeuser = '"+comboBox1.SelectedItem+"'", con);
            OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            String ItemValue = comboBox1.SelectedItem.ToString();

            if (dt.Rows.Count > 0)
            {
                for (int i=0; i<dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["tipeuser"].ToString() == ItemValue) ;
                    {
                        MessageBox.Show("Login Success As " + dt.Rows[i][2]);

                        if(comboBox1.SelectedIndex == 1)
                        {
                            Form1 menu = new Form1();
                            menu.Show();
                        }
                        else
                        {
                            Form2 panitia = new Form2();
                            panitia.Show();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string a = textBox2.Text;
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
