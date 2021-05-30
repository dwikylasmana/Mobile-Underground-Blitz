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
    public partial class panitiajadwal : UserControl
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;

        public panitiajadwal()
        {
            InitializeComponent();
        }

        private void panitiajadwal_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void load()
        {
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

        private void update_Click(object sender, EventArgs e)
        {
            load();
        }

        private void reset()
        {
            textBox6.Text = "-";
            textBox5.Text = "-";
            textBox4.Text = "-";
            textBox9.Text = "-";
            textBox8.Text = "-";
            textBox7.Text = "-";
            textBox15.Text = "-";
            textBox14.Text = "-";
            textBox13.Text = "-";
            textBox12.Text = "-";
            textBox11.Text = "-";
            textBox10.Text = "-";
            textBox38.Text = "-";
            textBox37.Text = "-";
            textBox19.Text = "-";
            textBox35.Text = "-";
            textBox34.Text = "-";
            textBox18.Text = "-";
            textBox32.Text = "-";
            textBox31.Text = "-";
            textBox17.Text = "-";
            textBox29.Text = "-";
            textBox28.Text = "-";
            textBox16.Text = "-";
        }

        private void delete()
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rpl_db.accdb;Persist Security Info=True";
            cmd.Connection = cn;

            cn.Open();
            cmd.CommandText = "delete from jadwalpre";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "delete from jadwalko";
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void add()
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rpl_db.accdb;Persist Security Info=True";
            cmd.Connection = cn;

            cn.Open();
            cmd.CommandText = "insert into jadwalpre values ('1', '" + textBox6.Text.ToString()+"', '"+textBox5.Text.ToString()+"', '"+textBox4.Text.ToString()+"')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into jadwalpre values ('2', '" + textBox9.Text.ToString() + "', '" + textBox8.Text.ToString() + "', '" + textBox7.Text.ToString() + "')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into jadwalpre values ('3', '" + textBox15.Text.ToString() + "', '" + textBox14.Text.ToString() + "', '" + textBox13.Text.ToString() + "')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into jadwalpre values ('4', '" + textBox12.Text.ToString() + "', '" + textBox11.Text.ToString() + "', '" + textBox10.Text.ToString() + "')";
            cmd.ExecuteNonQuery();
            cn.Close();


            cn.Open();
            cmd.CommandText = "insert into jadwalko values ('"+ textBox39.Text.ToString() + "', '" + textBox38.Text.ToString() + "', '" + textBox37.Text.ToString() + "', '" + textBox19.Text.ToString() + "')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into jadwalko values ('"+ textBox36.Text.ToString() + "', '" + textBox35.Text.ToString() + "', '" + textBox34.Text.ToString() + "', '" + textBox18.Text.ToString() + "')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into jadwalko values ('"+ textBox33.Text.ToString() + "', '" + textBox32.Text.ToString() + "', '" + textBox31.Text.ToString() + "', '" + textBox17.Text.ToString() + "')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into jadwalko values ('"+ textBox30.Text.ToString() + "', '" + textBox29.Text.ToString() + "', '" + textBox28.Text.ToString() + "', '" + textBox16.Text.ToString() + "')";
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            delete();
            add();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
            delete();
            add();
        }
    }
}
