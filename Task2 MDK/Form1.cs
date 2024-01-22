using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_MDK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Time_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                double distance1 = 1500;
                double distance2 = 40;
                double distance3 = 10;

                double swim1 = Convert.ToDouble(tb_SwimValue1.Text);
                double cycle1 = Convert.ToDouble(tb_CycleValue1.Text);
                double run1 = Convert.ToDouble(tb_RunValue1.Text);

                double swim2 = Convert.ToDouble(tb_SwimValue2.Text);
                double cycle2 = Convert.ToDouble(tb_CycleValue2.Text);
                double run2 = Convert.ToDouble(tb_RunValue2.Text);

                double swim3 = Convert.ToDouble(tb_SwimValue3.Text);
                double cycle3 = Convert.ToDouble(tb_CycleValue3.Text);
                double run3 = Convert.ToDouble(tb_RunValue3.Text);

                double time1 = FindTime(swim1, distance1) + ConvertHourToMin(FindTime(cycle1, distance2)) +
                    ConvertHourToMin(FindTime(run1, distance3));
                double time2 = FindTime(swim2, distance1) + ConvertHourToMin(FindTime(cycle2, distance2)) +
                    ConvertHourToMin(FindTime(run2, distance3));
                double time3 = FindTime(swim3, distance1) + ConvertHourToMin(FindTime(cycle3, distance2)) +
                    ConvertHourToMin(FindTime(run3, distance3));

                tb_TotalTimeValue1.Text = time1.ToString();
                tb_TotalTimeValue2.Text = time2.ToString();
                tb_TotalTimeValue3.Text = time3.ToString();

                btn_Champion.Enabled = true;
            }
        }

        private void btn_Champion_Click(object sender, EventArgs e)
        {
            double value1 = Convert.ToDouble(tb_TotalTimeValue1.Text);
            double value2 = Convert.ToDouble(tb_TotalTimeValue2.Text);
            double value3 = Convert.ToDouble(tb_TotalTimeValue3.Text);

            List<string> champions= CheckChampion(value1, value2, value3);

            if (champions.Count == 1)
                tb_ChampionName.Text = champions[0];
            if(champions.Count == 2)
                tb_ChampionName.Text = champions[0] + ", " + champions[1];
            if (champions.Count == 3)
                tb_ChampionName.Text = champions[0] + ", " + champions[1] + ", " + champions[2];

            btn_Restart.Enabled = true;
        }

        private double FindTime(double value, double distance)
        {
            double time = distance / value;
            return time;
        }

        private double ConvertHourToMin(double value)
        {
            value = value * 60;
            return value;
        }

        private List<string> CheckChampion(double value1, double value2, double value3)
        {
            List<string> champions = new List<string>();

            double minValue = Math.Min(Math.Min(value1, value2), value3);

            if (value1 == minValue)
            {
                champions.Add("Андрей");
            }

            if (value2 == minValue)
            {
                champions.Add("Егор");
            }

            if (value3 == minValue)
            {
                champions.Add("Михаил");
            }

            return champions;
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(tb_SwimValue1.Text) || string.IsNullOrEmpty(tb_SwimValue2.Text) 
                || string.IsNullOrEmpty(tb_SwimValue3.Text) || string.IsNullOrEmpty(tb_CycleValue1.Text)
                || string.IsNullOrEmpty(tb_CycleValue2.Text) || string.IsNullOrEmpty(tb_CycleValue3.Text)
                || string.IsNullOrEmpty(tb_RunValue1.Text) || string.IsNullOrEmpty(tb_RunValue3.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void tb_SwimValue1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_SwimValue1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            string text = textBox.Text;

            if (text.StartsWith(","))
                textBox.Text = text.Substring(1);
        }
    }
}
