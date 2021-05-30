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
    public partial class MenuJadwal : UserControl
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;

        public MenuJadwal()
        {
            InitializeComponent();
        }

        private void hapus()
        {
            textBox6.Text = null;
            textBox5.Text = null;
            textBox4.Text = null;
            textBox9.Text = null;
            textBox8.Text = null;
            textBox7.Text = null;
            textBox15.Text = null;
            textBox14.Text = null;
            textBox13.Text = null;
            textBox12.Text = null;
            textBox11.Text = null;
            textBox10.Text = null;
        }

        private void hapus2()
        {
            textBox38.Text = null;
            textBox37.Text = null;
            textBox19.Text = null;
            textBox35.Text = null;
            textBox34.Text = null;
            textBox18.Text = null;
            textBox32.Text = null;
            textBox31.Text = null;
            textBox17.Text = null;
            textBox29.Text = null;
            textBox28.Text = null;
            textBox16.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hapus();

            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rpl_db.accdb";
            cmd.Connection = cn;

            cmd.CommandText = "SELECT * FROM jadwalpre where nomor = '1'";
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox6.Text = (dr["tanggal"].ToString());
                textBox5.Text = (dr["map"].ToString());
                textBox4.Text = (dr["mode"].ToString());
            }
            cn.Close();

            cmd.CommandText = "SELECT * FROM jadwalpre where nomor = '2'";
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox9.Text = (dr["tanggal"].ToString());
                textBox8.Text = (dr["map"].ToString());
                textBox7.Text = (dr["mode"].ToString());
            }
            cn.Close();

            cmd.CommandText = "SELECT * FROM jadwalpre where nomor = '3'";
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox15.Text = (dr["tanggal"].ToString());
                textBox14.Text = (dr["map"].ToString());
                textBox13.Text = (dr["mode"].ToString());
            }
            cn.Close();

            cmd.CommandText = "SELECT * FROM jadwalpre where nomor = '4'";
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox12.Text = (dr["tanggal"].ToString());
                textBox11.Text = (dr["map"].ToString());
                textBox10.Text = (dr["mode"].ToString());
            }
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hapus2();

            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rpl_db.accdb";
            cmd.Connection = cn;

            cmd.CommandText = "SELECT * FROM jadwalko where babak = 'TOP 16'";
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox38.Text = (dr["tanggal"].ToString());
                textBox37.Text = (dr["map"].ToString());
                textBox19.Text = (dr["mode"].ToString());
            }
            cn.Close();

            cmd.CommandText = "SELECT * FROM jadwalko where babak = 'TOP 8'";
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox35.Text = (dr["tanggal"].ToString());
                textBox34.Text = (dr["map"].ToString());
                textBox18.Text = (dr["mode"].ToString());
            }
            cn.Close();

            cmd.CommandText = "SELECT * FROM jadwalko where babak = 'SEMI FINAL'";
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox32.Text = (dr["tanggal"].ToString());
                textBox31.Text = (dr["map"].ToString());
                textBox17.Text = (dr["mode"].ToString());
            }
            cn.Close();

            cmd.CommandText = "SELECT * FROM jadwalko where babak = 'FINAL'";
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox29.Text = (dr["tanggal"].ToString());
                textBox28.Text = (dr["map"].ToString());
                textBox16.Text = (dr["mode"].ToString());
            }
            cn.Close();
        }
    }
}
