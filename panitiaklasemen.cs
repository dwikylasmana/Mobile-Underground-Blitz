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
    public partial class panitiaklasemen : UserControl
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;

        public panitiaklasemen()
        {
            InitializeComponent();
        }

        private void delete()
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rpl_db.accdb;Persist Security Info=True";
            cmd.Connection = cn;

            cn.Open();
            cmd.CommandText = "delete from klasemen";
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void add()
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rpl_db.accdb;Persist Security Info=True";
            cmd.Connection = cn;

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('1', '"+textBox1.Text.ToString()+"', 'top 16')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('2', '" + textBox2.Text.ToString() + "', 'top 16')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('3', '" + textBox4.Text.ToString() + "', 'top 16')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('4', '" + textBox3.Text.ToString() + "', 'top 16')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('5', '" + textBox8.Text.ToString() + "', 'top 16')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('6', '" + textBox7.Text.ToString() + "', 'top 16')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('7', '" + textBox6.Text.ToString() + "', 'top 16')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('8', '" + textBox5.Text.ToString() + "', 'top 16')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('9', '" + textBox16.Text.ToString() + "', 'top 16')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('10', '" + textBox15.Text.ToString() + "', 'top 16')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('11', '" + textBox14.Text.ToString() + "', 'top 16')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('12', '" + textBox13.Text.ToString() + "', 'top 16')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('13', '" + textBox12.Text.ToString() + "', 'top 16')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('14', '" + textBox11.Text.ToString() + "', 'top 16')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('15', '" + textBox10.Text.ToString() + "', 'top 16')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('16', '" + textBox9.Text.ToString() + "', 'top 16')";
            cmd.ExecuteNonQuery();
            cn.Close();


            cn.Open();
            cmd.CommandText = "insert into klasemen values ('17', '" + textBox17.Text.ToString() + "', 'top 8')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('18', '" + textBox18.Text.ToString() + "', 'top 8')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('19', '" + textBox20.Text.ToString() + "', 'top 8')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('20', '" + textBox19.Text.ToString() + "', 'top 8')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('21', '" + textBox24.Text.ToString() + "', 'top 8')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('22', '" + textBox23.Text.ToString() + "', 'top 8')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('23', '" + textBox22.Text.ToString() + "', 'top 8')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('24', '" + textBox21.Text.ToString() + "', 'top 8')";
            cmd.ExecuteNonQuery();
            cn.Close();


            cn.Open();
            cmd.CommandText = "insert into klasemen values ('25', '" + textBox25.Text.ToString() + "', 'semi final')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('26', '" + textBox26.Text.ToString() + "', 'semi final')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('27', '" + textBox28.Text.ToString() + "', 'semi final')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('28', '" + textBox27.Text.ToString() + "', 'semi final')";
            cmd.ExecuteNonQuery();
            cn.Close();


            cn.Open();
            cmd.CommandText = "insert into klasemen values ('29', '" + textBox29.Text.ToString() + "', 'final')";
            cmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            cmd.CommandText = "insert into klasemen values ('30', '" + textBox30.Text.ToString() + "', 'final')";
            cmd.ExecuteNonQuery();
            cn.Close();


            cn.Open();
            cmd.CommandText = "insert into klasemen values ('31', '" + textBox31.Text.ToString() + "', 'champion')";
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            delete();
            add();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rpl_db.accdb;Persist Security Info=True");
            OleDbDataAdapter oda1 = new OleDbDataAdapter("select * from klasemen where babak = 'top 16' order by nomor", cn);
            DataTable dt1 = new DataTable();
            oda1.Fill(dt1);

            textBox1.Text = dt1.Rows[0][1].ToString();
            textBox2.Text = dt1.Rows[1][1].ToString();
            textBox4.Text = dt1.Rows[2][1].ToString();
            textBox3.Text = dt1.Rows[3][1].ToString();
            textBox8.Text = dt1.Rows[4][1].ToString();
            textBox7.Text = dt1.Rows[5][1].ToString();
            textBox6.Text = dt1.Rows[6][1].ToString();
            textBox5.Text = dt1.Rows[7][1].ToString();
            textBox16.Text = dt1.Rows[8][1].ToString();
            textBox15.Text = dt1.Rows[9][1].ToString();
            textBox14.Text = dt1.Rows[10][1].ToString();
            textBox13.Text = dt1.Rows[11][1].ToString();
            textBox12.Text = dt1.Rows[12][1].ToString();
            textBox11.Text = dt1.Rows[13][1].ToString();
            textBox10.Text = dt1.Rows[14][1].ToString();
            textBox9.Text = dt1.Rows[15][1].ToString();


            OleDbDataAdapter oda2 = new OleDbDataAdapter("select * from klasemen where babak = 'top 8' order by nomor", cn);
            DataTable dt2 = new DataTable();
            oda2.Fill(dt2);

            textBox17.Text = dt2.Rows[0][1].ToString();
            textBox18.Text = dt2.Rows[1][1].ToString();
            textBox20.Text = dt2.Rows[2][1].ToString();
            textBox19.Text = dt2.Rows[3][1].ToString();
            textBox24.Text = dt2.Rows[4][1].ToString();
            textBox23.Text = dt2.Rows[5][1].ToString();
            textBox22.Text = dt2.Rows[6][1].ToString();
            textBox21.Text = dt2.Rows[7][1].ToString();


            OleDbDataAdapter oda3 = new OleDbDataAdapter("select * from klasemen where babak = 'semi final' order by nomor", cn);
            DataTable dt3 = new DataTable();
            oda3.Fill(dt3);

            textBox25.Text = dt3.Rows[0][1].ToString();
            textBox26.Text = dt3.Rows[1][1].ToString();
            textBox28.Text = dt3.Rows[2][1].ToString();
            textBox27.Text = dt3.Rows[3][1].ToString();


            OleDbDataAdapter oda4 = new OleDbDataAdapter("select * from klasemen where babak = 'final' order by nomor", cn);
            DataTable dt4 = new DataTable();
            oda4.Fill(dt4);

            textBox29.Text = dt4.Rows[0][1].ToString();
            textBox30.Text = dt4.Rows[1][1].ToString();


            OleDbDataAdapter oda5 = new OleDbDataAdapter("select * from klasemen where babak = 'champion' order by nomor", cn);
            DataTable dt5 = new DataTable();
            oda5.Fill(dt5);

            textBox31.Text = dt5.Rows[0][1].ToString();
        }
    }
}
