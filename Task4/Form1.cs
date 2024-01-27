using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        int[] array = { 1, 2, 3, 4 };
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Sum_Click(object sender, EventArgs e)
        {
                tb_Product.Text = null;
                tb_Max.Text = null;
                tb_Min.Text = null;

                tb_Sum.Text = Sum(array).ToString();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
                tb_Sum.Text = null;
                tb_Max.Text = null;
                tb_Min.Text = null;


                tb_Product.Text = Product(array).ToString();
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
                tb_Product.Text = null;
                tb_Sum.Text = null;
                tb_Min.Text = null;

                tb_Max.Text = Max(array).ToString();
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
                tb_Product.Text = null;
                tb_Max.Text = null;
                tb_Sum.Text = null;

                tb_Min.Text = Min(array).ToString();
        }

        private int Sum(int[] arr)
        {
            int n = arr.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += arr[i];
            return sum;
        }

        private int Product(int[] arr)
        {
            int n = arr.Length;
            int prod = 1;
            for (int i = 0; i < n; i++)
                prod *= arr[i];
            return prod;

        }

        private int Max(int[] arr)
        {
            int n = arr.Length;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
                if (arr[i] > max) max = arr[i];
            return max;
        }

        private int Min(int[] arr)
        {
            int n = arr.Length;
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
                if (arr[i] < min) min = arr[i];
            return min;
        }
    }
}
