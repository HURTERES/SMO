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
    public partial class FormOdnokanalSOtkazamy : Form
    {
        public FormOdnokanalSOtkazamy()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

            if (TbxIntensivObsl.Text.Trim() == "" || TbxIntensivZayvok.Text.Trim() == "")
            {
                MessageBox.Show("Заполните поля для ввода!");
                return;
            }


            if (TbxIntensivObsl.Text.Trim() == "0" || TbxIntensivZayvok.Text.Trim() == "0")
            {
                MessageBox.Show("Введите значения больше 0");
                return;
            }

            

            double IntensZayvok = double.Parse(TbxIntensivZayvok.Text.Replace('.', ',').Trim());
            double IntensObsl = double.Parse(TbxIntensivObsl.Text.Replace('.', ',').Trim());

            PredelnVeroytnokstSostoyniy(IntensZayvok, IntensObsl);

        }

        private void PredelnVeroytnokstSostoyniy(double IntensZayvok, double IntensObsl)
        {
            double P0 = IntensObsl / (IntensZayvok + IntensObsl + 0.0);
            double P1 = IntensZayvok / (IntensZayvok + IntensObsl + 0.0);

            // Предельные вероятности состояний 
            LblP0.Text = $"P0: {P0:F3}";
            LblP1.Text = $"P0: {P1:F3}";
            // Q - относительную пропускную способность, т.е. среднюю долю пришедших заявок, обслуживаемых системой;
            LblQ.Text = $"Q: {P0:f3}";
            // Ротк - вероятность отказа, т.е. того, что заявка покинет СМО необслуженной;
            LblPotk.Text = $"Ротк: {P1:F3}";
            double A = (IntensZayvok * IntensObsl) / (IntensZayvok + IntensObsl);
            LblA.Text = $"A: {A:F3}";
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
    }
}
