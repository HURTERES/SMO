using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMO
{
    public partial class FormMnogokanalSOtkazamy : Form
    {
        public FormMnogokanalSOtkazamy()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

            if (TbxIntensivObsl.Text.Trim() == "" || TbxIntensivZayvok.Text.Trim() == "" || TbxCountCanal.Text.Trim() == "")
            {
                MessageBox.Show("Заполните поля для ввода!");
                return;
            }

            if (TbxIntensivObsl.Text.Trim() == "0" || TbxIntensivZayvok.Text.Trim() == "0")
            {
                MessageBox.Show("Введите значения больше 0");
                return;
            }
            
            if (int.Parse(TbxCountCanal.Text.Trim()) <= 1)
            {
                MessageBox.Show("Кол-во каналов не должно быть меньше 1");
                return;
            }

            double IntensZayvok = double.Parse(TbxIntensivZayvok.Text.Replace('.', ',').Trim());
            double IntensObsl = double.Parse(TbxIntensivObsl.Text.Replace('.', ',').Trim());
            int CountKanal = int.Parse(TbxCountCanal.Text.Trim());

            OutputInfo(IntensZayvok, IntensObsl, CountKanal);
        }

        // Функция для вычисления предельной вероятности P0 по формуле Эрланга-В
        public static double ErlangBProbability(int CountKan, double IntensZayvok, double IntensObsl)
        {
            double sum = 0;
            for (int n = 0; n <= CountKan; n++)
            {
                sum += Math.Pow((IntensZayvok / IntensObsl), n) / Factorial(n);
            }
            return Math.Pow((IntensZayvok / IntensObsl), CountKan) / (Factorial(CountKan) * sum);
        }

        // Функция для вычисления вероятности Pn
        public static double PnProbability(double P0, int CountKan, double IntensZayvok, double IntensObsl)
        {
            return (Math.Pow(IntensZayvok / IntensObsl, CountKan) / Factorial(CountKan)) * P0;
        }

        private static double Factorial(int n)
        {
            if (n == 0)
                return 1;
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        private void OutputInfo(double a, double b, int n)
        {
            double NagrKanal = a / b;
            LblNagruzKanal.Text = $"ρ: {NagrKanal:f3}";
            double P0 = ErlangBProbability(n, a, b);
            LblP0.Text = $"P0: {P0:F3}";
            for (int i = 0; i < n; i++)
            {
                int Count = i + 1;
                LblP0.Text += $" P{Count}: {PnProbability(P0, i+1, a, b):f3}";
            }
            double Potk = ((Math.Pow(NagrKanal, n) / Factorial(n)) * P0);
            LblPotk.Text = $"Ротк: {Potk:f3}";
            double Q = (1 - Potk);
            LblQ.Text = $"Q: {Q:f3}";
            double A = a * Q;
            LblA.Text = $"A: {A:f3}";
            double K = A / b;
            LblK.Text = $"K: {K:F3}";
        }

        private void TbxIntensivZayvok_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем ввод только цифр, запятых (для вещественных чисел) и клавиш Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Разрешаем ввод запятой только один раз
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void TbxIntensivObsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем ввод только цифр, запятых (для вещественных чисел) и клавиш Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Разрешаем ввод запятой только один раз
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void TbxCountCanal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем ввод только цифр, запятых (для вещественных чисел) и клавиш Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
