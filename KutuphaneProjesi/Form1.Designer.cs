﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaSayfa));
            this.btnKitap = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnTur = new System.Windows.Forms.Button();
            this.btnOdunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKitap
            // 
            this.btnKitap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKitap.Image = ((System.Drawing.Image)(resources.GetObject("btnKitap.Image")));
            this.btnKitap.Location = new System.Drawing.Point(34, 45);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(170, 75);
            this.btnKitap.TabIndex = 0;
            this.btnKitap.Text = "Kitap İşlemleri";
            this.btnKitap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKitap.UseVisualStyleBackColor = false;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOgrenci.Image = ((System.Drawing.Image)(resources.GetObject("btnOgrenci.Image")));
            this.btnOgrenci.Location = new System.Drawing.Point(228, 45);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(170, 75);
            this.btnOgrenci.TabIndex = 1;
            this.btnOgrenci.Text = "Öğrenci İşlemleri";
            this.btnOgrenci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOgrenci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOgrenci.UseVisualStyleBackColor = false;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnTur
            // 
            this.btnTur.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTur.Image = ((System.Drawing.Image)(resources.GetObject("btnTur.Image")));
            this.btnTur.Location = new System.Drawing.Point(34, 136);
            this.btnTur.Name = "btnTur";
            this.btnTur.Size = new System.Drawing.Size(170, 75);
            this.btnTur.TabIndex = 2;
            this.btnTur.Text = "Tür İşlemleri";
            this.btnTur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTur.UseVisualStyleBackColor = false;
            this.btnTur.Click += new System.EventHandler(this.btnTur_Click);
            // 
            // btnOdunc
            // 
            this.btnOdunc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdunc.Image = ((System.Drawing.Image)(resources.GetObject("btnOdunc.Image")));
            this.btnOdunc.Location = new System.Drawing.Point(228, 136);
            this.btnOdunc.Name = "btnOdunc";
            this.btnOdunc.Size = new System.Drawing.Size(170, 75);
            this.btnOdunc.TabIndex = 3;
            this.btnOdunc.Text = "Ödünç Kitap İşlemleri";
            this.btnOdunc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOdunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOdunc.UseVisualStyleBackColor = false;
            this.btnOdunc.Click += new System.EventHandler(this.btnOdunc_Click);
            // 
            // FormAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btnOdunc);
            this.Controls.Add(this.btnTur);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnKitap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

