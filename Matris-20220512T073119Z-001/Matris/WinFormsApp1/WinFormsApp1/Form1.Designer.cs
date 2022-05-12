
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSatir = new System.Windows.Forms.Label();
            this.lblSutun = new System.Windows.Forms.Label();
            this.lblSonucMat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSatir = new System.Windows.Forms.TextBox();
            this.tbSutun = new System.Windows.Forms.TextBox();
            this.tbMatrisToplami = new System.Windows.Forms.TextBox();
            this.tbMatris2 = new System.Windows.Forms.TextBox();
            this.tbMatris1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMatrisCarpimi = new System.Windows.Forms.TextBox();
            this.tbMatrisCikarimi = new System.Windows.Forms.TextBox();
            this.tbMatrisModu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSatir
            // 
            this.lblSatir.AutoSize = true;
            this.lblSatir.Location = new System.Drawing.Point(1, 28);
            this.lblSatir.Name = "lblSatir";
            this.lblSatir.Size = new System.Drawing.Size(47, 20);
            this.lblSatir.TabIndex = 0;
            this.lblSatir.Text = "SATIR";
            // 
            // lblSutun
            // 
            this.lblSutun.AutoSize = true;
            this.lblSutun.Location = new System.Drawing.Point(1, 125);
            this.lblSutun.Name = "lblSutun";
            this.lblSutun.Size = new System.Drawing.Size(56, 20);
            this.lblSutun.TabIndex = 1;
            this.lblSutun.Text = "SÜTUN";
            // 
            // lblSonucMat
            // 
            this.lblSonucMat.AutoSize = true;
            this.lblSonucMat.Location = new System.Drawing.Point(76, 448);
            this.lblSonucMat.Name = "lblSonucMat";
            this.lblSonucMat.Size = new System.Drawing.Size(124, 20);
            this.lblSonucMat.TabIndex = 2;
            this.lblSonucMat.Text = "MATRİS TOPLAMI";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSatir
            // 
            this.tbSatir.Location = new System.Drawing.Point(85, 28);
            this.tbSatir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSatir.Name = "tbSatir";
            this.tbSatir.Size = new System.Drawing.Size(114, 27);
            this.tbSatir.TabIndex = 4;
            // 
            // tbSutun
            // 
            this.tbSutun.Location = new System.Drawing.Point(85, 118);
            this.tbSutun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSutun.Name = "tbSutun";
            this.tbSutun.Size = new System.Drawing.Size(114, 27);
            this.tbSutun.TabIndex = 5;
            // 
            // tbMatrisToplami
            // 
            this.tbMatrisToplami.Location = new System.Drawing.Point(12, 481);
            this.tbMatrisToplami.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMatrisToplami.Multiline = true;
            this.tbMatrisToplami.Name = "tbMatrisToplami";
            this.tbMatrisToplami.Size = new System.Drawing.Size(285, 325);
            this.tbMatrisToplami.TabIndex = 6;
            // 
            // tbMatris2
            // 
            this.tbMatris2.Location = new System.Drawing.Point(807, 59);
            this.tbMatris2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMatris2.Multiline = true;
            this.tbMatris2.Name = "tbMatris2";
            this.tbMatris2.Size = new System.Drawing.Size(242, 325);
            this.tbMatris2.TabIndex = 7;
            // 
            // tbMatris1
            // 
            this.tbMatris1.Location = new System.Drawing.Point(492, 59);
            this.tbMatris1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMatris1.Multiline = true;
            this.tbMatris1.Name = "tbMatris1";
            this.tbMatris1.Size = new System.Drawing.Size(242, 325);
            this.tbMatris1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "1. MATRİS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(895, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "2. MATRİS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "MATRİS ÇARPIMI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(673, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "MATRİS ÇIKARIMI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(982, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "MATRİS MODU";
            // 
            // tbMatrisCarpimi
            // 
            this.tbMatrisCarpimi.Location = new System.Drawing.Point(303, 481);
            this.tbMatrisCarpimi.Multiline = true;
            this.tbMatrisCarpimi.Name = "tbMatrisCarpimi";
            this.tbMatrisCarpimi.Size = new System.Drawing.Size(285, 325);
            this.tbMatrisCarpimi.TabIndex = 14;
            // 
            // tbMatrisCikarimi
            // 
            this.tbMatrisCikarimi.Location = new System.Drawing.Point(594, 481);
            this.tbMatrisCikarimi.Multiline = true;
            this.tbMatrisCikarimi.Name = "tbMatrisCikarimi";
            this.tbMatrisCikarimi.Size = new System.Drawing.Size(285, 325);
            this.tbMatrisCikarimi.TabIndex = 15;
            // 
            // tbMatrisModu
            // 
            this.tbMatrisModu.Location = new System.Drawing.Point(885, 481);
            this.tbMatrisModu.Multiline = true;
            this.tbMatrisModu.Name = "tbMatrisModu";
            this.tbMatrisModu.Size = new System.Drawing.Size(285, 325);
            this.tbMatrisModu.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 819);
            this.Controls.Add(this.tbMatrisModu);
            this.Controls.Add(this.tbMatrisCikarimi);
            this.Controls.Add(this.tbMatrisCarpimi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMatris1);
            this.Controls.Add(this.tbMatris2);
            this.Controls.Add(this.tbMatrisToplami);
            this.Controls.Add(this.tbSutun);
            this.Controls.Add(this.tbSatir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSonucMat);
            this.Controls.Add(this.lblSutun);
            this.Controls.Add(this.lblSatir);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSatir;
        private System.Windows.Forms.Label lblSutun;
        private System.Windows.Forms.Label lblSonucMat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSatir;
        private System.Windows.Forms.TextBox tbSutun;
        private System.Windows.Forms.TextBox tbMatrisToplami;
        private System.Windows.Forms.TextBox tbMatris2;
        private System.Windows.Forms.TextBox tbMatris1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMatrisCarpimi;
        private System.Windows.Forms.TextBox tbMatrisCikarimi;
        private System.Windows.Forms.TextBox tbMatrisModu;
    }
}

