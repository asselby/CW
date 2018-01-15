namespace Registration
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.secondClosebtn = new System.Windows.Forms.Button();
            this.registrationBtn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.secondClosebtn);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 40);
            this.panel1.TabIndex = 0;
            // 
            // secondClosebtn
            // 
            this.secondClosebtn.BackColor = System.Drawing.Color.White;
            this.secondClosebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("secondClosebtn.BackgroundImage")));
            this.secondClosebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.secondClosebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.secondClosebtn.Location = new System.Drawing.Point(282, 0);
            this.secondClosebtn.Name = "secondClosebtn";
            this.secondClosebtn.Size = new System.Drawing.Size(51, 40);
            this.secondClosebtn.TabIndex = 1;
            this.secondClosebtn.UseVisualStyleBackColor = false;
            // 
            // registrationBtn
            // 
            this.registrationBtn.AutoSize = true;
            this.registrationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationBtn.Location = new System.Drawing.Point(32, 150);
            this.registrationBtn.Name = "registrationBtn";
            this.registrationBtn.Size = new System.Drawing.Size(275, 25);
            this.registrationBtn.TabIndex = 1;
            this.registrationBtn.Text = "Нажмите для регистрации";
            this.registrationBtn.Click += new System.EventHandler(this.registrationBtn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 348);
            this.Controls.Add(this.registrationBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button secondClosebtn;
        private System.Windows.Forms.Label registrationBtn;
    }
}