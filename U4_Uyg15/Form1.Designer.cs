
namespace U4_Uyg15
{
    partial class Form1
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikart = new System.Windows.Forms.Button();
            this.listeStack = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(26, 37);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(182, 20);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(26, 82);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 30);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCikart
            // 
            this.btnCikart.Location = new System.Drawing.Point(115, 82);
            this.btnCikart.Name = "btnCikart";
            this.btnCikart.Size = new System.Drawing.Size(88, 31);
            this.btnCikart.TabIndex = 2;
            this.btnCikart.Text = "Çıkart";
            this.btnCikart.UseVisualStyleBackColor = true;
            // 
            // listeStack
            // 
            this.listeStack.FormattingEnabled = true;
            this.listeStack.Location = new System.Drawing.Point(246, 12);
            this.listeStack.Name = "listeStack";
            this.listeStack.Size = new System.Drawing.Size(134, 277);
            this.listeStack.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad Soyad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeStack);
            this.Controls.Add(this.btnCikart);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAdSoyad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikart;
        private System.Windows.Forms.ListBox listeStack;
        private System.Windows.Forms.Label label1;
    }
}

