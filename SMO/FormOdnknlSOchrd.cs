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
    public partial class FormOdnknlSOchrd : Form
    {
        public FormOdnknlSOchrd()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (TbxIntensivObsl.Text.Trim() == "0" || TbxIntensivZayvok.Text.Trim() == "0" || TbxIntensivZayvok.Text.Trim() == "0" || TbxCountZayvokInOchered.Text.Trim() == "0")
            {
                MessageBox.Show("Введите значения больше 0");
                return;
            }
            if (TbxIntensivObsl.Text.Trim() == "" || TbxIntensivZayvok.Text.Trim() == "" || TbxIntensivZayvok.Text.Trim() == "" || TbxCountZayvokInOchered.Text.Trim() == "")
            {
                MessageBox.Show("Заполните поля для ввода!");
                return;
            }
            double IntensZayvok = double.Parse(TbxIntensivZayvok.Text.Replace('.', ',').Trim());
            double IntensObsl = 0;
            if (TbxIntensivObsl.Text.Trim() != "")
            {
                IntensObsl = double.Parse(TbxIntensivObsl.Text.Replace('.', ',').Trim());
            }
            int CountZayvok = int.Parse(TbxCountZayvokInOchered.Text.Trim());
            double TimeWorkInOchered = 0;
            if (TbxWorkInOchered.Text.Trim() != "")
            {
                TimeWorkInOchered = double.Parse(TbxWorkInOchered.Text.Trim());
            }

            if (RbHour.Checked || RbMinuts.Checked)
            {
                if (RbMinuts.Checked)
                {
                    TimeWorkInOchered = TimeWorkInOchered * 60;
                }
                if (RbHour.Checked)
                {
                    TimeWorkInOchered = TimeWorkInOchered / 60;
                }
            }

            OutputInfo(IntensZayvok, IntensObsl, CountZayvok, TimeWorkInOchered);

        }

        private void OutputInfo(double a, double b, int k, double time = 0)
        {
            double NagrKanal = 0;

            if (TbxWorkInOchered.Text.Trim() != "" && TbxWorkInOchered.Text.Trim() != "0")
            {
                NagrKanal = a * time;
                b = a / time;
            }
            else
            {
                NagrKanal = a / b;
            }

            LblNagruzKanal.Text = $"ρ: {NagrKanal:f3}";
            double P0 = 1 - NagrKanal;
            LblP0.Text = $"P0: {P0:f3}";
            for (int i = 0; i < k + 1; i++)
            {
                LblP0.Text += $" P{i + 1}: {Math.Pow(NagrKanal, i + 1) * (1 - NagrKanal)}";
            }
            LblQ.Text = $"Q: {(b / (a + b)):f3}";
            // Ротк - вероятность отказа, т.е. того, что заявка покинет СМО необслуженной;
            LblPotk.Text = $"Ротк: {(a / (a + b)):F3}";
            double A = (a * b) / (a + b);
            LblA.Text = $"A: {A:F3}";
            double Lsist = NagrKanal / (1 - NagrKanal);
            LblLsist.Text = $"Lсист: {Lsist:f3}";
            double Lob = 1 - P0;
            double Loch = (Math.Pow(NagrKanal, 2) / (1 - NagrKanal));
            LblLOch.Text = $"Lоч: {Loch:F3}";
            LblLob.Text = $"Lоб: {Lob:F3}";
            LblTsist.Text = $"Tсист: {((1 / a) * Lsist):f3}";
            LblToch.Text = $"Tоч: {((1 / a) * Loch):f3}";
        }

        private static double CalculatePO(double p, int k)
        {
            double P0 = 1;
            for (int i = 0; i < k; i++)
            {
                P0 += Math.Pow(p, i + 1);
            }
            return Math.Pow(P0, -1);
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

        private void TbxIntensivObsl_TextChanged(object sender, EventArgs e)
        {

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

        private void TbxCountZayvokInOchered_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем ввод только цифр, запятых (для вещественных чисел) и клавиш Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Разрешаем ввод запятой только один раз
            if ((e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void TbxWorkInOchered_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TbxCountZayvokInOchered_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxWorkInOchered_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
