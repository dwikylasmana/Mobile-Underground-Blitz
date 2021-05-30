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
    public partial class MenuHasilSkor : UserControl
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;

        public MenuHasilSkor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rpl_db.accdb;Persist Security Info=True");
            OleDbDataAdapter oda1 = new OleDbDataAdapter("select * from klasemen where babak = 'top 16' order by nomor", cn);
            DataTable dt1 = new DataTable();
            oda1.Fill(dt1);

            b1p1.Text = dt1.Rows[0][1].ToString();
            textBox1.Text = dt1.Rows[1][1].ToString();
            textBox3.Text = dt1.Rows[2][1].ToString();
            textBox2.Text = dt1.Rows[3][1].ToString();
            textBox7.Text = dt1.Rows[4][1].ToString();
            textBox6.Text = dt1.Rows[5][1].ToString();
            textBox5.Text = dt1.Rows[6][1].ToString();
            textBox4.Text = dt1.Rows[7][1].ToString();
            textBox15.Text = dt1.Rows[8][1].ToString();
            textBox14.Text = dt1.Rows[9][1].ToString();
            textBox13.Text = dt1.Rows[10][1].ToString();
            textBox12.Text = dt1.Rows[11][1].ToString();
            textBox11.Text = dt1.Rows[12][1].ToString();
            textBox10.Text = dt1.Rows[13][1].ToString();
            textBox9.Text = dt1.Rows[14][1].ToString();
            textBox8.Text = dt1.Rows[15][1].ToString();


            OleDbDataAdapter oda2 = new OleDbDataAdapter("select * from klasemen where babak = 'top 8' order by nomor", cn);
            DataTable dt2 = new DataTable();
            oda2.Fill(dt2);

            textBox16.Text = dt2.Rows[0][1].ToString();
            textBox17.Text = dt2.Rows[1][1].ToString();
            textBox29.Text = dt2.Rows[2][1].ToString();
            textBox18.Text = dt2.Rows[3][1].ToString();
            textBox23.Text = dt2.Rows[4][1].ToString();
            textBox22.Text = dt2.Rows[5][1].ToString();
            textBox21.Text = dt2.Rows[6][1].ToString();
            textBox20.Text = dt2.Rows[7][1].ToString();


            OleDbDataAdapter oda3 = new OleDbDataAdapter("select * from klasemen where babak = 'semi final' order by nomor", cn);
            DataTable dt3 = new DataTable();
            oda3.Fill(dt3);

            textBox24.Text = dt3.Rows[0][1].ToString();
            textBox25.Text = dt3.Rows[1][1].ToString();
            textBox27.Text = dt3.Rows[2][1].ToString();
            textBox26.Text = dt3.Rows[3][1].ToString();


            OleDbDataAdapter oda4 = new OleDbDataAdapter("select * from klasemen where babak = 'final' order by nomor", cn);
            DataTable dt4 = new DataTable();
            oda4.Fill(dt4);

            textBox28.Text = dt4.Rows[0][1].ToString();
            textBox29.Text = dt4.Rows[1][1].ToString();


            OleDbDataAdapter oda5 = new OleDbDataAdapter("select * from klasemen where babak = 'champion' order by nomor", cn);
            DataTable dt5 = new DataTable();
            oda5.Fill(dt5);

            textBox30.Text = dt5.Rows[0][1].ToString();
        }
    }
}
