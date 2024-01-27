using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_MDK
{
    public partial class Form1 : Form
    {
        /*int[] array = { 1, 2, 3, 4};*/
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Sum_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Array.Text))
            {
                tb_Product.Text = null;
                tb_Max.Text = null;
                tb_Min.Text = null;

                try
                {
                    string[] numbers = tb_Array.Text.Split(' ');
                    double[] array = Array.ConvertAll(numbers, double.Parse);

                    tb_Sum.Text = Sum(array).ToString();
                }
                catch
                {
                    MessageBox.Show("Неправильный формат введенного массива!");
                }
            }
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Array.Text))
            {
                tb_Sum.Text = null;
                tb_Max.Text = null;
                tb_Min.Text = null;

                try
                {
                    string[] numbers = tb_Array.Text.Split(' ');
                    double[] array = Array.ConvertAll(numbers, double.Parse);

                    tb_Product.Text = Product(array).ToString();
                }
                catch
                {
                    MessageBox.Show("Неправильный формат введенного массива!");
                }
            }
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Array.Text))
            {
                tb_Product.Text = null;
                tb_Sum.Text = null;
                tb_Min.Text = null;

                try
                {
                    string[] numbers = tb_Array.Text.Split(' ');
                    double[] array = Array.ConvertAll(numbers, double.Parse);

                    tb_Max.Text = Max(array).ToString();
                }
                catch
                {
                    MessageBox.Show("Неправильный формат введенного массива!");
                }
            }
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Array.Text))
            {
                tb_Product.Text = null;
                tb_Max.Text = null;
                tb_Sum.Text = null;

                try
                {
                    string[] numbers = tb_Array.Text.Split(' ');
                    double[] array = Array.ConvertAll(numbers, double.Parse);

                    tb_Min.Text = Min(array).ToString();
                }
                catch
                {
                    MessageBox.Show("Неправильный формат введенного массива!");
                }
            }
        }

        private double Sum(double[] arr)
        {
            int n = arr.Length;
            double sum = 0;
            for (int i = 0; i < n; i++)
                sum += arr[i];
            return sum;
        }

        private double Product(double[] arr)
        {
            int n = arr.Length;
            double prod = 1;
            for (int i = 0; i < n; i++)
                prod *= arr[i];
            return prod;

        }

        private double Max(double[] arr)
        {
            int n = arr.Length;
            double max = int.MinValue;
            for (int i = 0; i < n; i++)
                if (arr[i] > max) max = arr[i];
            return max;
        }

        private double Min(double[] arr)
        {
            int n = arr.Length;
            double min = int.MaxValue;
            for (int i = 0; i < n; i++)
                if (arr[i] < min) min = arr[i];
            return min;
        }

        private void tb_Array_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)&&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void tb_Array_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            string text = textBox.Text;

            if (text.StartsWith(",") || text.StartsWith(" "))
                textBox.Text = text.Substring(1);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Array.Text = null;
            tb_Sum.Text = null;
            tb_Product.Text = null;
            tb_Max.Text = null;
            tb_Min.Text = null;
        }
    }
}
