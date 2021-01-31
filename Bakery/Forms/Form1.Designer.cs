
namespace Bakery
{
    partial class FormWelcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAdminSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoş Geldiniz!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Alışverişe Başla!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdminSignIn
            // 
            this.buttonAdminSignIn.Location = new System.Drawing.Point(66, 207);
            this.buttonAdminSignIn.Name = "buttonAdminSignIn";
            this.buttonAdminSignIn.Size = new System.Drawing.Size(136, 45);
            this.buttonAdminSignIn.TabIndex = 3;
            this.buttonAdminSignIn.Text = "Admin Girişi";
            this.buttonAdminSignIn.UseVisualStyleBackColor = true;
            this.buttonAdminSignIn.Click += new System.EventHandler(this.buttonAdminSignIn_Click);
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 334);
            this.Controls.Add(this.buttonAdminSignIn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormWelcome";
            this.Text = "Hoş Geldiniz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAdminSignIn;
    }
}

