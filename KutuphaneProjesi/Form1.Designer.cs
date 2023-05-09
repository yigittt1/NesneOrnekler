
namespace KutuphaneProjesi
{
    partial class FormAnaSayfa
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
            this.btnKitap = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnTur = new System.Windows.Forms.Button();
            this.btnOdunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKitap
            // 
            this.btnKitap.Location = new System.Drawing.Point(34, 45);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(170, 75);
            this.btnKitap.TabIndex = 0;
            this.btnKitap.Text = "button1";
            this.btnKitap.UseVisualStyleBackColor = true;
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Location = new System.Drawing.Point(228, 45);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(170, 75);
            this.btnOgrenci.TabIndex = 1;
            this.btnOgrenci.Text = "button2";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            // 
            // btnTur
            // 
            this.btnTur.Location = new System.Drawing.Point(34, 136);
            this.btnTur.Name = "btnTur";
            this.btnTur.Size = new System.Drawing.Size(170, 75);
            this.btnTur.TabIndex = 2;
            this.btnTur.Text = "button3";
            this.btnTur.UseVisualStyleBackColor = true;
            // 
            // btnOdunc
            // 
            this.btnOdunc.Location = new System.Drawing.Point(228, 136);
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.Size = new System.Drawing.Size(170, 75);
            this.btnOdunc.TabIndex = 3;
            this.btnOdunc.Text = "button4";
            this.btnOdunc.UseVisualStyleBackColor = true;
            // 
            // FormAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btnOdunc);
            this.Controls.Add(this.btnTur);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnKitap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Projesi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKitap;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnTur;
        private System.Windows.Forms.Button btnOdunc;
    }
}

