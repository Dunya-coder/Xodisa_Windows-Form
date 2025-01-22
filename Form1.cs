using System;
using System.Windows.Forms;

namespace Yakuniiy_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // 1. Delegat turini e'lon qilish
        delegate void CalcFigure(double R);

        // 2. hodisa e'lon qilish
        event CalcFigure ECF;

        // 3. Hodisa qayta ishlovchi metodlar 

        // R radiusli aylana uzunligini hisoblash 
        void GetLength(double R)
        {
            double res;

            res = 2 * Math.PI * R;
            label1.Text += " " + res.ToString();
        }

        // Doira yuzasi
        void GetArea(double R)
        {
            double res;

            res = Math.PI * R * R;
            label2.Text += " " + res.ToString();
        }

        // Shar hajmi
        void GetVolume(double R)
        {
            double res;

            res = 4.0 / 3.0 * Math.PI * R * R * R;
            label3.Text += " " + res.ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double R;
            R = Double.Parse(textBox1.Text);
            // 4. Hodisa bilan metodlarni ro'yxatga olish 

            ECF = GetLength;
            ECF += GetArea;
            ECF += GetVolume;

            // Hodisani ishga tushirish  
            ECF(R);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
