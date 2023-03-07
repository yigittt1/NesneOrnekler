
namespace U5_Uyg1
{
    partial class FormA
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
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnControlBox = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Location = new System.Drawing.Point(12, 157);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(134, 23);
            this.btnShowDialog.TabIndex = 11;
            this.btnShowDialog.Text = "ShowDialog";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialog_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 128);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(134, 23);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.Location = new System.Drawing.Point(12, 99);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(134, 23);
            this.btnCenter.TabIndex = 9;
            this.btnCenter.Text = "CenterToScreen";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnControlBox
            // 
            this.btnControlBox.Location = new System.Drawing.Point(12, 70);
            this.btnControlBox.Name = "btnControlBox";
            this.btnControlBox.Size = new System.Drawing.Size(134, 23);
            this.btnControlBox.TabIndex = 8;
            this.btnControlBox.Text = "ControlBox";
            this.btnControlBox.UseVisualStyleBackColor = true;
            this.btnControlBox.Click += new System.EventHandler(this.btnControlBox_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(12, 12);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(134, 23);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 195);
            this.Controls.Add(this.btnShowDialog);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.btnControlBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Name = "Form1";
            this.Text = "FormA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowDialog;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnControlBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
    }
}

