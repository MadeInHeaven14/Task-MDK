using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_MDK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Value1.Text) && !string.IsNullOrEmpty(tb_Value2.Text) && !string.IsNullOrEmpty(tb_Value3.Text)
                && !string.IsNullOrEmpty(tb_Name1.Text) && !string.IsNullOrEmpty(tb_Name2.Text) && !string.IsNullOrEmpty(tb_Name3.Text))
            {
                int value1, value2, value3;
                value1 = int.Parse(tb_Value1.Text);
                value2 = int.Parse(tb_Value2.Text);
                value3 = int.Parse(tb_Value3.Text);
                int max = Max(value1, value2, value3);
                tb_Message.Text = max.ToString();
            }
        }

        private int Sum(int x1, int x2, int x3)
        {
            int sum = 0;

            sum = sum + x1;
            sum = sum + x2;
            sum = sum + x3;

            return sum;
        }

        private int Max(int x1, int x2, int x3)
        {
            int max = int.MinValue;

            if (x1 > max) max = x1;
            if (x2 > max) max = x2;
            if (x3 > max) max = x3;

            return max;
        }

        private void MaxAndName(int x1, int x2, int x3,
            string name1, string name2, string name3,
            List<string> names, out int max, out string name_max)
        {
            max = int.MinValue; //вводим переменную для максимума с начальным значением MinValue
            name_max = "";
            if (x1 > max)
            {
                max = x1; name_max = name1; //максимум из одного значения и имя 
            }
            if (x2 > max)
            {
                max = x2; name_max = name2; //максимум из двух значений и имя 
            }
            if (x3 > max)
            {
                max = x3; name_max = name3; //максимум из трех значений и имя 
            }

            names.Add(name_max);

            if (max == x1 && name_max != name1)
                names.Add(name1);
            if (max == x2 && name_max != name2)
                names.Add(name2);
            if (max == x3 && name_max != name3)
                names.Add(name3);
        }

        private void btn_Sum_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Value1.Text) && !string.IsNullOrEmpty(tb_Value2.Text) && !string.IsNullOrEmpty(tb_Value3.Text)
                && !string.IsNullOrEmpty(tb_Name1.Text) && !string.IsNullOrEmpty(tb_Name2.Text) && !string.IsNullOrEmpty(tb_Name3.Text))
            {
                int value1, value2, value3;
                value1 = int.Parse(tb_Value1.Text);
                value2 = int.Parse(tb_Value2.Text);
                value3 = int.Parse(tb_Value3.Text);
                int sum = Sum(value1, value2, value3);
                tb_Message.Text = sum.ToString();
            }
        }

        private void btn_MaxName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Value1.Text) && !string.IsNullOrEmpty(tb_Value2.Text) && !string.IsNullOrEmpty(tb_Value3.Text) &&
                !string.IsNullOrEmpty(tb_Name1.Text) && !string.IsNullOrEmpty(tb_Name2.Text) && !string.IsNullOrEmpty(tb_Name3.Text))
            {
                //входные данные. Ввод значений
                int value1, value2, value3;
                string name1, name2, name3;
                value1 = int.Parse(tb_Value1.Text);
                value2 = int.Parse(tb_Value2.Text);
                value3 = int.Parse(tb_Value3.Text);
                name1 = tb_Name1.Text;
                name2 = tb_Name2.Text;
                name3 = tb_Name3.Text;

                //результаты
                int max_value;
                string max_name;
                List<string> names = new List<string>();

                //вычисления
                MaxAndName(value1, value2, value3,
                    name1, name2, name3, names,
                    out max_value, out max_name);

                //вывод результатов
                if (names.Count == 1)
                    tb_Message.Text = max_name + " собрал(а) грибов " +
                    max_value + ". Больше всех!";
                if (names.Count == 2)
                    tb_Message.Text = names[0] + " и " + names[1] +" собрали грибов " +
                    max_value + ". Больше всех!";
                if (names.Count == 3)
                    tb_Message.Text = names[0] + ", " + names[1] + " и " + names[2] + 
                        " собрали грибов " + max_value + ". Поровну!";
            }
        }

        private void tb_Name1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void tb_Name2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void tb_Name3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void tb_Value1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void tb_Value2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void tb_Value3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
