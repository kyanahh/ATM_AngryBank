
namespace WindowsFormsApp1
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblThanks = new System.Windows.Forms.Label();
            this.lblAngry = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.btnNo.Location = new System.Drawing.Point(432, 332);
            this.btnNo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(177, 63);
            this.btnNo.TabIndex = 20;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.btnYes.Location = new System.Drawing.Point(183, 332);
            this.btnYes.Margin = new System.Windows.Forms.Padding(2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(177, 63);
            this.btnYes.TabIndex = 19;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.ForeColor = System.Drawing.Color.White;
            this.lblThanks.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblThanks.Location = new System.Drawing.Point(39, 228);
            this.lblThanks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(696, 56);
            this.lblThanks.TabIndex = 18;
            this.lblThanks.Text = "Thank you for using AngryBank!\r\nWould you like to continue using the automated te" +
    "ller machine?\r\n";
            this.lblThanks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAngry
            // 
            this.lblAngry.AutoSize = true;
            this.lblAngry.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngry.ForeColor = System.Drawing.Color.White;
            this.lblAngry.Location = new System.Drawing.Point(24, 22);
            this.lblAngry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAngry.Name = "lblAngry";
            this.lblAngry.Size = new System.Drawing.Size(139, 28);
            this.lblAngry.TabIndex = 17;
            this.lblAngry.Text = "AngryBank";
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.ForeColor = System.Drawing.Color.White;
            this.lblNew.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblNew.Location = new System.Drawing.Point(313, 93);
            this.lblNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(159, 28);
            this.lblNew.TabIndex = 21;
            this.lblNew.Text = "New Balance:";
            this.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEnter
            // 
            this.txtEnter.BackColor = System.Drawing.Color.White;
            this.txtEnter.Enabled = false;
            this.txtEnter.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnter.ForeColor = System.Drawing.Color.Black;
            this.txtEnter.Location = new System.Drawing.Point(247, 137);
            this.txtEnter.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnter.MaxLength = 15;
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.ReadOnly = true;
            this.txtEnter.Size = new System.Drawing.Size(290, 37);
            this.txtEnter.TabIndex = 23;
            this.txtEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(794, 462);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.lblAngry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "AngryBank";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Label lblAngry;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.TextBox txtEnter;
    }
}