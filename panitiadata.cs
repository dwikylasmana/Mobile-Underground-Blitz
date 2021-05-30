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
    public partial class panitiadata : UserControl
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;
        OleDbConnection olcn = null;

        public panitiadata()
        {
            InitializeComponent();
        }

        private void panitiadata_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            ListBox wow = sender as ListBox;
            if (wow.SelectedIndex != -1)
            {
                listBox1.SelectedIndex = wow.SelectedIndex;
                listBox2.SelectedIndex = wow.SelectedIndex;
                listBox3.SelectedIndex = wow.SelectedIndex;
                listBox4.SelectedIndex = wow.SelectedIndex;
                listBox5.SelectedIndex = wow.SelectedIndex;
                listBox6.SelectedIndex = wow.SelectedIndex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=rpl_db.accdb;Persist Security Info=True";
            cmd.Connection = cn;

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();

            cmd.CommandText = "select * from biodata";
            cn.Open();
            dr = cmd.ExecuteReader();
            
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    listBox1.Items.Add(dr["username"].ToString());
                    listBox2.Items.Add(dr["namalengkap"].ToString());
                    listBox3.Items.Add(dr["alamat"].ToString());
                    listBox4.Items.Add(dr["profesi"].ToString());
                    listBox5.Items.Add(dr["no_tlp"].ToString());
                    listBox6.Items.Add(dr["rank"].ToString());
                }
                dr.Close();
                cn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=rpl_db.accdb;Persist Security Info=True";
            cmd.Connection = cn;

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();

            cmd.CommandText = "select * from biodata where username like '%" + textBox1.Text + "%'";
            cn.Open();
            dr = cmd.ExecuteReader();

            if(dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr["username"].ToString());
                    listBox2.Items.Add(dr["namalengkap"].ToString());
                    listBox3.Items.Add(dr["alamat"].ToString());
                    listBox4.Items.Add(dr["profesi"].ToString());
                    listBox5.Items.Add(dr["no_telp"].ToString());
                    listBox6.Items.Add(dr["rank"].ToString());
                }
            }
            dr.Close();
            cn.Close();
        }
    }
}
