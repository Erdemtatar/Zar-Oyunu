using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int a, b, c, d, f,g,h,p;
        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label17_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a= rastgele.Next(1,7);
            b= rastgele.Next(1,7);
            c= rastgele.Next(1,7);
            d = a + b + c;
            label9.Text=a.ToString();
            label10.Text=b.ToString();
            label11.Text=c.ToString();
            label12.Text=d.ToString();
            button1.Enabled = false;
            label17.Text = "2.oyuncunun zar atması bekleniyor";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            f = rastgele.Next(1,7);
            g = rastgele.Next(1,7);
            h = rastgele.Next(1,7);
            p = f + g + h;
            label13.Text=f.ToString();
            label14.Text=g.ToString();
            label15.Text=h.ToString();
            label16.Text=p.ToString();
            button2.Enabled = false;
            if (d>p)
            {
                label17.Text = "1. oyuncu kazandı";
            }
            if (p > d)
            {
                label17.Text = "2. oyuncu kazandı";
            }
        }
    }
}