using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapTutariHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            listBox1.Items.Clear();
            int kitapsayisi = Convert.ToInt16(textBox1.Text);
            int kitaptutari = 50;
            if ((kitapsayisi >= 1) && (kitapsayisi <= 20))
            {
                double toplamtutar = kitaptutari * kitapsayisi;
                double indirim = (toplamtutar * 20) / 100;
                double odenecektutar = toplamtutar - indirim;
                listBox1.Items.Add(odenecektutar);
            }
            else if ((kitapsayisi >= 21) && (kitapsayisi <= 40))
            {
                double toplamtutar = kitaptutari * kitapsayisi;
                double indirim = (toplamtutar * 40) / 100;
                double odenecektutar = toplamtutar - indirim;
                listBox1.Items.Add(odenecektutar);
            }
            else if (kitapsayisi >= 41)
            {
                double toplamtutar = kitaptutari * kitapsayisi;
                double indirim = (toplamtutar * 50) / 100;
                double odenecektutar = toplamtutar - indirim;
                listBox1.Items.Add(odenecektutar);
            }
            else
            {
                listBox1.Items.Add("Aralık dışı miktar girişi yapıldı.Lütfen kontrol ediniz");
            }
        }
    }
}
