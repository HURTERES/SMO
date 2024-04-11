namespace SMO
{
    partial class FormOdnokanalSOtkazamy
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
            this.TbxIntensivZayvok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxIntensivObsl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblP0 = new System.Windows.Forms.Label();
            this.LblP1 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblQ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblPotk = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbxIntensivZayvok
            // 
            this.TbxIntensivZayvok.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TbxIntensivZayvok.Location = new System.Drawing.Point(357, 15);
            this.TbxIntensivZayvok.Name = "TbxIntensivZayvok";
            this.TbxIntensivZayvok.Size = new System.Drawing.Size(114, 26);
            this.TbxIntensivZayvok.TabIndex = 0;
            this.TbxIntensivZayvok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxIntensivZayvok_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите интенсивность потока заявок λ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите интенсивность обслуживания μ: ";
            // 
            // TbxIntensivObsl
            // 
            this.TbxIntensivObsl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TbxIntensivObsl.Location = new System.Drawing.Point(357, 66);
            this.TbxIntensivObsl.Name = "TbxIntensivObsl";
            this.TbxIntensivObsl.Size = new System.Drawing.Size(114, 26);
            this.TbxIntensivObsl.TabIndex = 4;
            this.TbxIntensivObsl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxIntensivObsl_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Предельные вероятности состояний: ";
            // 
            // LblP0
            // 
            this.LblP0.AutoSize = true;
            this.LblP0.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblP0.Location = new System.Drawing.Point(12, 150);
            this.LblP0.Name = "LblP0";
            this.LblP0.Size = new System.Drawing.Size(35, 19);
            this.LblP0.TabIndex = 6;
            this.LblP0.Text = "P0:";
            // 
            // LblP1
            // 
            this.LblP1.AutoSize = true;
            this.LblP1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblP1.Location = new System.Drawing.Point(12, 190);
            this.LblP1.Name = "LblP1";
            this.LblP1.Size = new System.Drawing.Size(35, 19);
            this.LblP1.TabIndex = 7;
            this.LblP1.Text = "P1:";
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnStart.Location = new System.Drawing.Point(175, 421);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(114, 27);
            this.BtnStart.TabIndex = 8;
            this.BtnStart.Text = "Решить";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblQ
            // 
            this.LblQ.AutoSize = true;
            this.LblQ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblQ.Location = new System.Drawing.Point(12, 251);
            this.LblQ.Name = "LblQ";
            this.LblQ.Size = new System.Drawing.Size(27, 19);
            this.LblQ.TabIndex = 9;
            this.LblQ.Text = "Q:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Относительная пропускная способность:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Вероятность отказа:";
            // 
            // LblPotk
            // 
            this.LblPotk.AutoSize = true;
            this.LblPotk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblPotk.Location = new System.Drawing.Point(12, 312);
            this.LblPotk.Name = "LblPotk";
            this.LblPotk.Size = new System.Drawing.Size(52, 19);
            this.LblPotk.TabIndex = 12;
            this.LblPotk.Text = "Ротк:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(363, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Абсолютная пропускная способность СМО:";
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblA.Location = new System.Drawing.Point(12, 371);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(26, 19);
            this.LblA.TabIndex = 14;
            this.LblA.Text = "А:";
            // 
            // FormOdnokanalSOtkazamy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 460);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblPotk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblQ);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblP1);
            this.Controls.Add(this.LblP0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxIntensivObsl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxIntensivZayvok);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOdnokanalSOtkazamy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Одноканальная СМО с отказами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxIntensivZayvok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxIntensivObsl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblP0;
        private System.Windows.Forms.Label LblP1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblPotk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblA;
    }
}