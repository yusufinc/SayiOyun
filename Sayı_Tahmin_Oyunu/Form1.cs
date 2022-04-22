using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int puan = 1000;
        int sayı = 0;
        int tahmin_sayısı=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            Random xx=new Random();
            int sayı = xx.Next(1,100);
            label3.Text = " ";
            label2.Text = "0";
            label7.Text = "1000";
            label8.Text=sayı.ToString();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin;
            tahmin_sayısı++;
            if (tahmin_sayısı<=10)
            {
                tahmin = int.Parse(textBox1.Text);
                label2.Text=tahmin_sayısı.ToString();
                if (sayı<tahmin)
                {
                    label3.Text = "Tahmininizi Azaltın Lütfen!";
                    puan = puan - 100;
                    label7.Text=puan.ToString();
                }
                else if (tahmin<sayı)
                {
                    label3.Text = "Tahmini Artırın Lütfen!";
                    puan=puan - 100;
                    label7.Text=puan.ToString();
                }
                else 
                {
                    label3.Text = "Tebrikler!!!" + tahmin_sayısı + " . defada bilip, " + label7.Text + " kazandınız";
                    label7.Text = puan.ToString();
                    button2.Enabled= true;
                    button2.Enabled = false;
                    
                }
                textBox1.Text = " ";
            }
            else
            {
                textBox1.Enabled = false;
                    button1.Enabled= false;
                MessageBox.Show("Maalesef Tahmin Sayınız Bitti!!");
                this.Close();

            }
        }
    }
}
