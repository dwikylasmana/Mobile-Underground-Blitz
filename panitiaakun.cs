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
    public partial class panitiaakun : UserControl
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;
        OleDbConnection olcn = null;

        public panitiaakun()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rpl_db.accdb;Persist Security Info=True";
            cmd.Connection = cn;

            cn.Open();
            cmd.CommandText = "insert into akun values ('"+textBox5.Text.ToString()+"', '" + textBox6.Text.ToString() + "', 'peserta')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into biodata values ('" + textBox5.Text.ToString() + "', '" + textBox6.Text.ToString() + "', '-', '-', '-', '-', '-')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=rpl_db.accdb;Persist Security Info=True";
            cmd.Connection = cn;

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox5.Text = null;
            textBox6.Text = null;

            cmd.CommandText = "select * from biodata";
            cn.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr["username"].ToString());
                    listBox2.Items.Add(dr["namalengkap"].ToString());
                }
                dr.Close();
                cn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                cn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=rpl_db.accdb;Persist Security Info=True";
                cmd.Connection = cn;

                listBox1.Items.Clear();
                listBox2.Items.Clear();

                cmd.CommandText = "select * from biodata";
                cn.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listBox1.Items.Add(dr["username"].ToString());
                        listBox2.Items.Add(dr["namalengkap"].ToString());
                    }
                    dr.Close();
                    cn.Close();
                }
            }
            else
            {
                cn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=rpl_db.accdb;Persist Security Info=True";
                cmd.Connection = cn;

                listBox1.Items.Clear();
                listBox2.Items.Clear();

                cmd.CommandText = "select * from biodata where username like '%" + textBox1.Text + "%'";
                cn.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listBox1.Items.Add(dr["username"].ToString());
                        listBox2.Items.Add(dr["namalengkap"].ToString());
                    }
                }
                dr.Close();
                cn.Close();
            }
        }
    }
}
