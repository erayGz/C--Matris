using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbMatrisToplami.Clear();
            tbMatris2.Clear();
            tbMatris1.Clear();
            tbMatrisCikarimi.Clear();
            tbMatrisCarpimi.Clear();
            tbMatrisModu.Clear();
            int satir = Convert.ToInt32(tbSatir.Text);
            int sutun = Convert.ToInt32(tbSutun.Text);

            Random random = new Random();

            int[,] matris1 = new int[satir,sutun]; //matris tanımı

            //Matris Doldurma
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    matris1[i, j] = random.Next(1, 10);
                }
            }
            //Matris Yazdırma
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    tbMatris1.Text += matris1[i, j].ToString()+" ";
                }
                tbMatris1.Text += Environment.NewLine;
            }
            //2.Matris

            Random rnd = new Random();
            int[,] matris2 = new int[satir, sutun];
            //Matris Doldurma
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    matris2[i, j] = rnd.Next(10, 20);
                }
            }
            //Matris Yazdırma
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    tbMatris2.Text += matris2[i, j].ToString() + " ";
                }
                tbMatris2.Text += Environment.NewLine;
            }

            // Toplam Matris Yazdırma
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    tbMatrisToplami.Text += matris1[i, j]+matris2[i,j]+" ";
                }
                tbMatrisToplami.Text += Environment.NewLine;
            }

            //Çarpım Matris Yazdırma
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    tbMatrisCarpimi.Text += matris1[i, j] * matris2[i, j] + " ";
                }
                tbMatrisCarpimi.Text += Environment.NewLine;
            }

            //Çıkartma Matris Yazdırma
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    tbMatrisCikarimi.Text += matris2[i, j] - matris1[i, j] + " ";
                   

                }
                tbMatrisCikarimi.Text += Environment.NewLine;
            }

            //Modu Matris Yazdırma
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {

                    tbMatrisModu.Text += matris2[i, j] / matris1[i, j] + " ";

                }
                tbMatrisModu.Text += Environment.NewLine;
            }
        }

       
    }
}
