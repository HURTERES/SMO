using System;
using System.Windows.Forms;

namespace SMO
{
    public partial class FormOdnNeOgrOch : Form
    {
        public FormOdnNeOgrOch()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            double Lamda = 0;
            if (TbxIntensivZayvok.Text.Trim() != "" && TbxIntensivZayvok.Text.Trim() != "0")
            {
                Lamda = double.Parse(TbxIntensivZayvok.Text.Trim()); // Lamda
            }

            if (Lamda == 0)
            {
                MessageBox.Show("Введите интенсивность заявок!");
                return;
            }
            double CountRequest = 0;
            if (TbxCountZayvokInOchered.Text.Trim() != "" && TbxCountZayvokInOchered.Text.Trim() != "0")
            {
                CountRequest = double.Parse(TbxCountZayvokInOchered.Text.Trim()); // кол-во заявок в очереди
            }
            if (CountRequest == 0)
            {
                MessageBox.Show("Введите кол-во заявок в очереди!");
                return;
            }
            // если среднее время пребывания заявки нету, то используется значение Ню
            double Toch = 0;
            double Nu = 0;
            if (TbxWorkInOchered.Text.Trim() != "" && TbxWorkInOchered.Text.Trim() != "0")
            {
                Toch = double.Parse(TbxWorkInOchered.Text.Trim());
            }
            else
            {
                if (TbxIntensivObsl.Text.Trim() == "")
                {
                    MessageBox.Show("Введите интенсивность обслуживания или среднее время пребывания заявки в очереди!");
                    return;
                }
                Nu = double.Parse(TbxIntensivObsl.Text.Trim()); // Ню
            }


            if (RbHour.Checked || RbMinuts.Checked)
            {
                if (RbMinuts.Checked)
                {
                    Toch = Toch * 60;
                }
                if (RbHour.Checked)
                {
                    Toch = Toch / 60;
                }
            }


            OutputInfo(Lamda, Nu, CountRequest, Toch);
        }

        private void OutputInfo(double Lamda, double Nu, double CountRequest = 0, double Toch = 0)
        {

            double Ro = 0;
            double Potk = 0;
            double Q = 0;
            double A = 0;
            double K = 0;
            double P0 = 0;
            double Loch = 0;
            double Lob = 0;
            double Lsist = 0;
            double Tsist = 0;
            bool Flag = false;
            // вычисляем Ro
            if (Toch != 0)
            {
                Ro = Lamda * Toch;
                Nu = Lamda / Toch; // если Ню неизвестно, то находим его по формуле
            }
            else
            {
                Flag = true;
                Ro = Lamda / Nu;
            }

            P0 = OutputP0(Ro, CountRequest);
            Potk = OutputPotk(Ro, CountRequest, P0);
            Q = 1 - Potk;
            A = Lamda * Q;
            Loch = OutputLoch(Ro, CountRequest, P0);
            Lob = 1 - P0;
            Lsist = Loch + Lob;
            Tsist = Lsist / Lamda;

            if (Flag)
            {
                Toch = Loch / Lamda;
            }


            LblNagruzKanal.Text = $"ρ: {(Ro):F3}"; // выводим Ro
            LblP0.Text = $"P0: {P0:f3} {OutputPn(Ro, CountRequest, P0)}";
            LblQ.Text = $"Q: {Q:F3}";
            LblA.Text = $"A: {A:F3}";
            LblLOch.Text = $"Lоч: {Loch:F3}";
            LblLob.Text = $"Lоб: {Lob:F3}";
            LblLsist.Text = $"Lсист: {Lsist:F3}";
            LblTsist.Text = $"Tсист: {Tsist:f3}";
            LblToch.Text = $"Точ: {Toch:f3}";
        }

        private double OutputP0(double Ro, double CountRequest) => (1 - Ro) / (1 - Math.Pow(Ro, CountRequest + 2));

        private string OutputPn(double Ro, double CountRequest, double P0)
        {
            string Pn = "";
            for (int i = 0; i < CountRequest; i++)
            {
                Pn += $" P{i + 1}: {(Math.Pow(Ro, i + 1) * P0):F3}";
            }
            return Pn;
        }
        private double OutputPotk(double Ro, double CountRequest, double P0) => Math.Pow(Ro, CountRequest + 1) * P0;

        private static double OutputLoch(double Ro, double m, double P0) //=> (Math.Pow(Ro, 2) * (((1 - Math.Pow(Ro, CountRequest)) * (CountRequest + 1 - CountRequest * Ro)) / ((1 - Math.Pow(Ro, CountRequest + 2)) * (1 - Ro)))) * P0;
        {
            double numerator = 1 - Math.Pow(Ro, m)*(m+1-m*Ro);
            double denominator = (1 - Math.Pow(Ro, m + 2)) * (1 - Ro);
            return Math.Pow(Ro, 2) * (numerator / denominator) * P0;
        }

        private void TbxIntensivZayvok_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbxWorkInOchered_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxWorkInOchered_KeyPress(object sender, KeyPressEventArgs e)
        {
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
