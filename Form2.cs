using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panitiaberanda1.BringToFront();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panitiadata1.BringToFront();
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panitiajadwal1.BringToFront();
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panitiaklasemen1.BringToFront();
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button12.Height;
            SidePanel.Top = button12.Top;
            System.Windows.Forms.Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panitiaakun1.BringToFront();
            SidePanel.Height = button13.Height;
            SidePanel.Top = button13.Top;
        }
    }
}
