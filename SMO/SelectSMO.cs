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

namespace SMO
{
    public partial class SelectSMO : Form
    {
        public SelectSMO()
        {
            InitializeComponent();
        }

        private void BtnOneKanalSOtkazamy_Click(object sender, EventArgs e)
        {
            FormOdnokanalSOtkazamy FrmOdnOtk = new FormOdnokanalSOtkazamy();
            this.Hide();
            FrmOdnOtk.ShowDialog();
            this.Show();
        }

        private void BtnMnogokanalSOtkazamy_Click(object sender, EventArgs e)
        {
            FormMnogokanalSOtkazamy FrmMnogSOtk = new FormMnogokanalSOtkazamy();
            this.Hide();
            FrmMnogSOtk.ShowDialog();
            this.Show();
        }

        private void BtnOdnokanalSOcherediy_Click(object sender, EventArgs e)
        {
            FormOdnknlSOchrd FrmOdnkSOcherd = new FormOdnknlSOchrd();
            this.Hide();
            FrmOdnkSOcherd.ShowDialog();
            this.Show();
        }

        private void BtnMnogokanalSOcherediy_Click(object sender, EventArgs e)
        {
            FormMnogokanalSNeogrOchered FrmNew = new FormMnogokanalSNeogrOchered();
            this.Hide();
            FrmNew.ShowDialog();
            this.Show();
        }

        private void BtnOdnokanalSOgranichOchered_Click(object sender, EventArgs e)
        {
            FormOdnNeOgrOch FrmNeOgrOch = new FormOdnNeOgrOch();
            this.Hide();
            FrmNeOgrOch.ShowDialog();
            this.Show();
        }

        private void BtnMnogokanalSOgranOchered_Click(object sender, EventArgs e)
        {
            FormMnogokanalSOgrOch Frm = new FormMnogokanalSOgrOch();
            this.Hide();
            Frm.ShowDialog();
            this.Show();
        }
    }
}
