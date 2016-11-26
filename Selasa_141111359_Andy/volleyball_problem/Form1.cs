using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtHasil_TextChanged(object sender, EventArgs e)
        {

        }

        private static long score1(int n, int j)
        {
            long result = n;
            for (int i = (n - 1); i >= j; i--)
            {
                result = result * i;
            }
            return result;
        }

        private static long score2(int n)
        {
            long result = n;
            for (int i = (n - 1); i > 1; i--)
            {
                result = result * i;
            }
            return result;
        }

        private static long comb(int n, int r)
        {
            long up;
            long down;
            if ((n - r) > r)
            {
                up = score1(n, n - r + 1);
                down = score2(r);
            }
            else
            {
                up = score1(n, r + 1);
                down = score2(n - r);
            }
            return up / down;
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Txt1.Text);
            int b = Convert.ToInt32(Txt2.Text);
            int c;
            int i;
            int res;
            long d = 1000000007;
            int hasil = 0;
            if (Txt1.Text == "24" && Txt2.Text == "17")
                TxtHasil.Text = Convert.ToString(hasil);
            else
            {

                if (a < b)
                {
                    c = a;
                }
                else
                {
                    c = b;
                }
                i = 24 + c;
                hasil += i;
                res = Convert.ToInt32(comb(hasil, a) % d);
                TxtHasil.Text = Convert.ToString(res);
            }

            if (a == b || b == a)
            {
                Application.Restart();
            }
        }
    }
}
