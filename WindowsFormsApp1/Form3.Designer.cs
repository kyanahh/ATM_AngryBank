
namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.lblAvail = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEnter
            // 
            this.txtEnter.BackColor = System.Drawing.Color.White;
            this.txtEnter.Enabled = false;
            this.txtEnter.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnter.ForeColor = System.Drawing.Color.Black;
            this.txtEnter.Location = new System.Drawing.Point(278, 254);
            this.txtEnter.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnter.MaxLength = 15;
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.ReadOnly = true;
            this.txtEnter.Size = new System.Drawing.Size(220, 31);
            this.txtEnter.TabIndex = 1;
            this.txtEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAvail
            // 
            this.lblAvail.AutoSize = true;
            this.lblAvail.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvail.ForeColor = System.Drawing.Color.White;
            this.lblAvail.Location = new System.Drawing.Point(305, 215);
            this.lblAvail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvail.Name = "lblAvail";
            this.lblAvail.Size = new System.Drawing.Size(175, 23);
            this.lblAvail.TabIndex = 2;
            this.lblAvail.Text = "Available Balance: ";
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.btnContinue.Location = new System.Drawing.Point(617, 381);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(2);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(139, 37);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "CONTINUE";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.ForeColor = System.Drawing.Color.White;
            this.lblReview.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblReview.Location = new System.Drawing.Point(203, 122);
            this.lblReview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(381, 46);
            this.lblReview.TabIndex = 5;
            this.lblReview.Text = "Review your balance information, \r\nthen select CONTINUE when you are done.";
            this.lblReview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(24, 22);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(240, 28);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "BALANCE INQURY";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(794, 462);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblAvail);
            this.Controls.Add(this.txtEnter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "AngryBank";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Label lblAvail;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblBalance;
    }
}