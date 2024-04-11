using System;
using System.Windows.Forms;

namespace SMO
{
    public partial class FormMnogokanalSOgrOch : Form
    {
        public FormMnogokanalSOgrOch()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // ввод Лямды (обяз)
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
            // ввод кол-во заявок (обяз)
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
            // ввод кол-ва (обяз)
            int CountCanal = 0;

            if (TbxCountCalans.Text.Trim() == "0" || TbxCountCalans.Text.Trim() == "1")
            {
                MessageBox.Show("Кол-во каналов должно быть больше 1!");
                return;
            }

            if (TbxCountCalans.Text.Trim() != "" && TbxCountCalans.Text.Trim() != "0")
            {
                CountCanal = int.Parse(TbxCountCalans.Text.Trim()); // кол-во заявок в очереди
            }
            if (CountCanal == 0)
            {
                MessageBox.Show("Введите кол-во каналов!");
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


            OutputInfo(Lamda, Nu, CountCanal, CountRequest, Toch);
        }

        private void OutputInfo(double Lamda, double Nu, int CountCalan, double CountRequest = 0, double Toch = 0)
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

            // нахождение значений
            P0 = OutputP0(Ro, CountCalan, CountRequest);
            Potk = OutputPotk(Ro, CountRequest, P0, CountCalan);
            Q = 1 - Potk;
            A = Lamda * Q;
            Loch = OutputLoch(Ro, CountCalan, CountRequest, P0);
            Lob = OutputLob(Ro, CountCalan, CountRequest, P0);
            Lsist = Loch + Lob;
            Tsist = (1 / Lamda) * Lsist;

            if (Flag)
            {
                Toch = Loch / Lamda;
            }


            // Вывод значений
            LblNagruzKanal.Text = $"ρ: {(Ro):F3}"; // выводим Ro
            LblP0.Text = $"P0: {P0:f3} {OutputPn(Ro, CountCalan, P0)}";
            LblPnm.Text = $"{OutputPnAndm(Ro, CountCalan, P0, CountRequest)}";
            LblPotk.Text = $"Pотк: {Potk:f3}";
            LblQ.Text = $"Q: {Q:F3}";
            LblA.Text = $"A: {A:F3}";
            LblLOch.Text = $"Lоч: {Loch:F3}";
            LblLob.Text = $"Lоб(K): {Lob:F3}";
            LblLsist.Text = $"Lсист: {Lsist:F3}";
            LblTsist.Text = $"Tсист: {Tsist:f3}";
            LblToch.Text = $"Точ: {Toch:f3}";
        }

        private static double OutputLob(double Ro, int n, double m, double P0) => Ro * (1 - ((Math.Pow(Ro, n + m)) / (Math.Pow(n, m) * Factorial(n)))*P0);
        private double OutputP0(double Ro, int n, double m)
        {
            double Sum = 1;
            for (int i = 0; i < n; i++)
            {
                Sum += Math.Pow(Ro, i + 1) / Factorial(i + 1);
            }
            Sum += (Math.Pow(Ro, n + 1) * (1 - Math.Pow(Ro / n, m))) / (n * Factorial(n) * (1 - (Ro / n)));
            return Math.Pow(Sum, -1);
        }

        private string OutputPn(double Ro, int n, double P0)
        {
            string Pn = "";
            for (int i = 0; i < n; i++)
            {
                Pn += $" P{i + 1}: {((Math.Pow(Ro, i + 1) / Factorial(i + 1)) * P0):f3}";
            }
            return Pn;
        }

        private string OutputPnAndm(double Ro, int n, double P0, double m)
        {
            string Pnm = "";
            for (int i = 0; i < m; i++)
            {
                Pnm += $"P{n}+{i + 1}: {((Math.Pow(Ro, n + (i + 1)) / (Math.Pow(n, i + 1) * Factorial(n))) * P0):f3}; ";
            }
            return Pnm;
        }
        private double OutputPotk(double Ro, double m, double P0, int n) => ((Math.Pow(Ro, n + m)) / (Math.Pow(n, m) * Factorial(n))) * P0;

        private static double OutputLoch(double Ro, int n, double m, double P0)
        {
            double N = Ro / n;
            double a = (Math.Pow(Ro, n + 1)) / (n * Factorial(n));
            double b = (1 - (m + 1 - m*N) * Math.Pow(N, m)) / (Math.Pow(1 - N, 2));
            return (a * b) * P0;
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

        private void TbxCountZayvokInOchered_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxCountZayvokInOchered_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbxCountCalans_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
