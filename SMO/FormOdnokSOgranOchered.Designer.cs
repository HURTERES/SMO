﻿namespace SMO
{
    partial class FormOdnNeOgrOch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbxIntensivObsl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxIntensivZayvok = new System.Windows.Forms.TextBox();
            this.LblNagruzKanal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblPotk = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblQ = new System.Windows.Forms.Label();
            this.LblP0 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblToch = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LblTsist = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LblLob = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LblLOch = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LblLsist = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TbxWorkInOchered = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbxCountZayvokInOchered = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RbMinuts = new System.Windows.Forms.RadioButton();
            this.RbHour = new System.Windows.Forms.RadioButton();
            this.GbConvert = new System.Windows.Forms.GroupBox();
            this.GbConvert.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbxIntensivObsl
            // 
            this.TbxIntensivObsl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TbxIntensivObsl.Location = new System.Drawing.Point(357, 64);
            this.TbxIntensivObsl.Name = "TbxIntensivObsl";
            this.TbxIntensivObsl.Size = new System.Drawing.Size(114, 26);
            this.TbxIntensivObsl.TabIndex = 36;
            this.TbxIntensivObsl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxIntensivObsl_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Введите интенсивность обслуживания μ: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Введите интенсивность потока заявок λ:";
            // 
            // TbxIntensivZayvok
            // 
            this.TbxIntensivZayvok.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TbxIntensivZayvok.Location = new System.Drawing.Point(357, 13);
            this.TbxIntensivZayvok.Name = "TbxIntensivZayvok";
            this.TbxIntensivZayvok.Size = new System.Drawing.Size(114, 26);
            this.TbxIntensivZayvok.TabIndex = 33;
            this.TbxIntensivZayvok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxIntensivZayvok_KeyPress);
            // 
            // LblNagruzKanal
            // 
            this.LblNagruzKanal.AutoSize = true;
            this.LblNagruzKanal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblNagruzKanal.Location = new System.Drawing.Point(17, 215);
            this.LblNagruzKanal.Name = "LblNagruzKanal";
            this.LblNagruzKanal.Size = new System.Drawing.Size(25, 19);
            this.LblNagruzKanal.TabIndex = 54;
            this.LblNagruzKanal.Text = "ρ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(17, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 19);
            this.label7.TabIndex = 53;
            this.label7.Text = "Интенсивность нагрузки канала:";
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblA.Location = new System.Drawing.Point(17, 470);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(26, 19);
            this.LblA.TabIndex = 52;
            this.LblA.Text = "А:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(17, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(363, 19);
            this.label6.TabIndex = 51;
            this.label6.Text = "Абсолютная пропускная способность СМО:";
            // 
            // LblPotk
            // 
            this.LblPotk.AutoSize = true;
            this.LblPotk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblPotk.Location = new System.Drawing.Point(17, 411);
            this.LblPotk.Name = "LblPotk";
            this.LblPotk.Size = new System.Drawing.Size(52, 19);
            this.LblPotk.TabIndex = 50;
            this.LblPotk.Text = "Ротк:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "Вероятность отказа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(17, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "Относительная пропускная способность:";
            // 
            // LblQ
            // 
            this.LblQ.AutoSize = true;
            this.LblQ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblQ.Location = new System.Drawing.Point(17, 350);
            this.LblQ.Name = "LblQ";
            this.LblQ.Size = new System.Drawing.Size(27, 19);
            this.LblQ.TabIndex = 47;
            this.LblQ.Text = "Q:";
            // 
            // LblP0
            // 
            this.LblP0.AutoSize = true;
            this.LblP0.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblP0.Location = new System.Drawing.Point(17, 287);
            this.LblP0.Name = "LblP0";
            this.LblP0.Size = new System.Drawing.Size(35, 19);
            this.LblP0.TabIndex = 46;
            this.LblP0.Text = "P0:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "Предельные вероятности состояний: ";
            // 
            // LblToch
            // 
            this.LblToch.AutoSize = true;
            this.LblToch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblToch.Location = new System.Drawing.Point(17, 761);
            this.LblToch.Name = "LblToch";
            this.LblToch.Size = new System.Drawing.Size(43, 19);
            this.LblToch.TabIndex = 67;
            this.LblToch.Text = "Точ:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(17, 731);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(385, 19);
            this.label15.TabIndex = 66;
            this.label15.Text = "Среднее время пребывания заявки в очереди:";
            // 
            // LblTsist
            // 
            this.LblTsist.AutoSize = true;
            this.LblTsist.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblTsist.Location = new System.Drawing.Point(17, 703);
            this.LblTsist.Name = "LblTsist";
            this.LblTsist.Size = new System.Drawing.Size(61, 19);
            this.LblTsist.TabIndex = 65;
            this.LblTsist.Text = "Tсист:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(17, 673);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 19);
            this.label13.TabIndex = 64;
            this.label13.Text = "Среднее время пребывания заявки:";
            // 
            // LblLob
            // 
            this.LblLob.AutoSize = true;
            this.LblLob.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblLob.Location = new System.Drawing.Point(17, 645);
            this.LblLob.Name = "LblLob";
            this.LblLob.Size = new System.Drawing.Size(45, 19);
            this.LblLob.TabIndex = 63;
            this.LblLob.Text = "Lоб:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(17, 615);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(361, 19);
            this.label14.TabIndex = 62;
            this.label14.Text = "Среднее число заявок под обслуживанием:";
            // 
            // LblLOch
            // 
            this.LblLOch.AutoSize = true;
            this.LblLOch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblLOch.Location = new System.Drawing.Point(17, 587);
            this.LblLOch.Name = "LblLOch";
            this.LblLOch.Size = new System.Drawing.Size(44, 19);
            this.LblLOch.TabIndex = 61;
            this.LblLOch.Text = "Lоч:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(17, 557);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(279, 19);
            this.label12.TabIndex = 60;
            this.label12.Text = "Среднее число заявок в очереди:";
            // 
            // LblLsist
            // 
            this.LblLsist.AutoSize = true;
            this.LblLsist.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblLsist.Location = new System.Drawing.Point(17, 524);
            this.LblLsist.Name = "LblLsist";
            this.LblLsist.Size = new System.Drawing.Size(61, 19);
            this.LblLsist.TabIndex = 59;
            this.LblLsist.Text = "Lсист:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(17, 494);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 19);
            this.label10.TabIndex = 58;
            this.label10.Text = "Среднее число заявок в системе:";
            // 
            // TbxWorkInOchered
            // 
            this.TbxWorkInOchered.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TbxWorkInOchered.Location = new System.Drawing.Point(474, 147);
            this.TbxWorkInOchered.Name = "TbxWorkInOchered";
            this.TbxWorkInOchered.Size = new System.Drawing.Size(138, 26);
            this.TbxWorkInOchered.TabIndex = 71;
            this.TbxWorkInOchered.TextChanged += new System.EventHandler(this.TbxWorkInOchered_TextChanged);
            this.TbxWorkInOchered.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxWorkInOchered_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(17, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(454, 19);
            this.label9.TabIndex = 70;
            this.label9.Text = "Введите среднее время пребывания заявки в очереди:";
            // 
            // TbxCountZayvokInOchered
            // 
            this.TbxCountZayvokInOchered.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TbxCountZayvokInOchered.Location = new System.Drawing.Point(357, 108);
            this.TbxCountZayvokInOchered.Name = "TbxCountZayvokInOchered";
            this.TbxCountZayvokInOchered.Size = new System.Drawing.Size(114, 26);
            this.TbxCountZayvokInOchered.TabIndex = 69;
            this.TbxCountZayvokInOchered.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxCountZayvokInOchered_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(58, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 19);
            this.label8.TabIndex = 68;
            this.label8.Text = "Введите кол-во заявлок в очереди:";
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnStart.Location = new System.Drawing.Point(249, 801);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(114, 27);
            this.BtnStart.TabIndex = 72;
            this.BtnStart.Text = "Решить";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // RbMinuts
            // 
            this.RbMinuts.AutoSize = true;
            this.RbMinuts.Location = new System.Drawing.Point(12, 30);
            this.RbMinuts.Name = "RbMinuts";
            this.RbMinuts.Size = new System.Drawing.Size(110, 20);
            this.RbMinuts.TabIndex = 73;
            this.RbMinuts.TabStop = true;
            this.RbMinuts.Text = "Кон. в минуты";
            this.RbMinuts.UseVisualStyleBackColor = true;
            // 
            // RbHour
            // 
            this.RbHour.AutoSize = true;
            this.RbHour.Location = new System.Drawing.Point(12, 56);
            this.RbHour.Name = "RbHour";
            this.RbHour.Size = new System.Drawing.Size(96, 20);
            this.RbHour.TabIndex = 74;
            this.RbHour.TabStop = true;
            this.RbHour.Text = "Кон. в часы";
            this.RbHour.UseVisualStyleBackColor = true;
            // 
            // GbConvert
            // 
            this.GbConvert.Controls.Add(this.RbHour);
            this.GbConvert.Controls.Add(this.RbMinuts);
            this.GbConvert.Location = new System.Drawing.Point(474, 179);
            this.GbConvert.Name = "GbConvert";
            this.GbConvert.Size = new System.Drawing.Size(138, 93);
            this.GbConvert.TabIndex = 75;
            this.GbConvert.TabStop = false;
            this.GbConvert.Text = "Конвертирование";
            // 
            // FormOdnNeOgrOch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 840);
            this.Controls.Add(this.GbConvert);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TbxWorkInOchered);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TbxCountZayvokInOchered);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblToch);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.LblTsist);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LblLob);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.LblLOch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LblLsist);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblNagruzKanal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblPotk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblQ);
            this.Controls.Add(this.LblP0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxIntensivObsl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxIntensivZayvok);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOdnNeOgrOch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Одноканальная СМО с ограниченной длиной очереди";
            this.GbConvert.ResumeLayout(false);
            this.GbConvert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxIntensivObsl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxIntensivZayvok;
        private System.Windows.Forms.Label LblNagruzKanal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblPotk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblQ;
        private System.Windows.Forms.Label LblP0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblToch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label LblTsist;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LblLob;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LblLOch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblLsist;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbxWorkInOchered;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbxCountZayvokInOchered;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton RbMinuts;
        private System.Windows.Forms.RadioButton RbHour;
        private System.Windows.Forms.GroupBox GbConvert;
    }
}