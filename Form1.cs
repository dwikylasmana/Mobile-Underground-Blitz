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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuProfile2.BringToFront();
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuberanda1.BringToFront();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menuJadwal1.BringToFront();
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menuHasilSkor1.BringToFront();
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            System.Windows.Forms.Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dibaut Oleh Issrahmi Berrly Saputra (065118094)");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dibuat Oleh Dwiky Meidy Lasmana (065118085)");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dibuat Oleh Fazar Zulham Ibrahim (065118097)");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dibuat Oleh Findi Yandarris (065118104)");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dibuat Oleh Fatikh Sadewo (06118067)");
        }

        private void menuberanda1_Load(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
