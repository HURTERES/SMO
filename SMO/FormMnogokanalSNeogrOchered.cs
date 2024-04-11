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
    public partial class FormMnogokanalSNeogrOchered : Form
    {
        public FormMnogokanalSNeogrOchered()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

            if (TbxIntensivZayvok.Text.Trim() == "")
            {
                MessageBox.Show("Введите интенсивность поступления заявок!");
                return;
            }
            if (TbxIntensivZayvok.Text.Trim() == "0")
            {
                MessageBox.Show("Введите интенсивность поступления заявок!");
                return;
            }
            double Lamda = double.Parse(TbxIntensivZayvok.Text.Trim()); // лямда
            
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
                    MessageBox.Show("Введите среднее время пребывания заявки в очереди или интенсивность обслуживания");
                    return;
                }
                Nu = double.Parse(TbxIntensivObsl.Text.Trim()); // Ню
            }

            if (TbxCountCanal.Text.Trim() == "")
            {
                MessageBox.Show("Введите кол-во каналов в СМО!");
                return;
            }
            if (TbxCountCanal.Text.Trim() == "0" || TbxCountCanal.Text.Trim() == "1")
            {
                MessageBox.Show("Кол-во каналов должно быть больше 1!");
                return;
            }
            //  среднее время пребывания заявки в очереди
            int CountKanals = int.Parse(TbxCountCanal.Text.Trim()); // кол-во каналов в СМО

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

            OutputInfo(Lamda, CountKanals, Nu, Toch);
        }

        private void OutputInfo(double Lamda, int CountKanal, double Nu = 0, double Toch = 0)
        {
            double Ro = 0;
            double Potk = 0;
            double Q = 0;
            double A = 0;
            double K = 0;
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

            LblNagruzKanal.Text = $"ρ: {(Ro):F3}"; // выводим Ro
            double P0 = PredelVerP0(Ro, CountKanal);
            LblP0.Text = $"P0: {P0:F3} {PredelVerPn(Ro, CountKanal, P0)}";

            if (Ro < 1) // если Ro меньше 1
            {
                Potk = 0;
                Q = 1;
                A = Lamda;
            }
            else
            {
                Potk = (Math.Pow(Ro, CountKanal) / Factorial(CountKanal)) * P0;
                Q = 1 - Potk;
                A = Lamda * Q;
                K = Ro;
            }

            LblPotk.Text = $"Pотк: {Potk:f3}";
            LblQ.Text = $"Q: {Q:F3}";
            LblA.Text = $"A: {A:F3}";
            LblK.Text = $"k: {Ro:f3}";

            double Poch = (Math.Pow(Ro, CountKanal + 1)/(Factorial(CountKanal)*(CountKanal-Ro))) * P0;
            double Loch = (Math.Pow(Ro, CountKanal + 1) * P0) / (CountKanal * Factorial(CountKanal) * Math.Pow(1 - (Ro / CountKanal), 2));
            double Lsist = Loch + Ro;

            LblPoch.Text = $"Pоч: {Poch:f3}";
            LblLoch.Text = $"Lоч: {Loch:f3}";
            LblSist.Text = $"Lсист: {Lsist:f3}";

            double Lob = Lsist + Loch;
            double Tsist = (1 / Lamda) * Lsist;

            if (Flag == true)
            {
                Toch = (1 / Lamda) * Loch;
            }

            LblLob.Text = $"Lоб: {Lob:f3}";
            LblTsist.Text = $"Tсист: {Tsist:f3}";
            LblToch.Text = $"Tоч: {Toch:f3}";

        }

        private static double PredelVerP0(double Ro, int CountCanal) // расчитыает P0
        {
            double Sum = 1;
            for (int i = 0; i < CountCanal; i++)
            {
                Sum += Math.Pow(Ro, i + 1)/Factorial(i+1);
            }
            Sum += Math.Pow(Ro, CountCanal + 1) / (Factorial(CountCanal) * (CountCanal - Ro));
            return Math.Pow(Sum, -1);
        }
        
        private static string PredelVerPn(double Ro, int CountCanal, double P0) // расчитывает P1, P2,... Pn
        {
            string ReadyText = "";
            for (int i =0; i < CountCanal; i++)
            {
                ReadyText += $" P{i+1}: {((Math.Pow(Ro, i+1)/Factorial(i+1)) * P0):f3}";
            }
            return ReadyText;
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

        private void TbxCountCanal_KeyPress(object sender, KeyPressEventArgs e)
        {
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
    }
}
