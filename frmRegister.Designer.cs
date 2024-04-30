
namespace Farm
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.registerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cnfPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.regLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cnfHide = new Guna.UI2.WinForms.Guna2Button();
            this.passHide = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passShow = new Guna.UI2.WinForms.Guna2Button();
            this.cnfShow = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.BorderRadius = 10;
            this.registerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerBtn.FillColor = System.Drawing.Color.DarkGreen;
            this.registerBtn.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(511, 318);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(180, 45);
            this.registerBtn.TabIndex = 27;
            this.registerBtn.Text = "REGISTER";
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // cnfPass
            // 
            this.cnfPass.BorderColor = System.Drawing.Color.DarkGreen;
            this.cnfPass.BorderRadius = 10;
            this.cnfPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cnfPass.DefaultText = "";
            this.cnfPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cnfPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cnfPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cnfPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cnfPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cnfPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cnfPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cnfPass.Location = new System.Drawing.Point(479, 240);
            this.cnfPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cnfPass.Name = "cnfPass";
            this.cnfPass.PasswordChar = '●';
            this.cnfPass.PlaceholderText = "";
            this.cnfPass.SelectedText = "";
            this.cnfPass.ShadowDecoration.BorderRadius = 10;
            this.cnfPass.Size = new System.Drawing.Size(199, 31);
            this.cnfPass.TabIndex = 26;
            this.cnfPass.UseSystemPasswordChar = true;
            this.cnfPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cnfPass_KeyDown);
            // 
            // txtUser
            // 
            this.txtUser.BorderColor = System.Drawing.Color.DarkGreen;
            this.txtUser.BorderRadius = 10;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Location = new System.Drawing.Point(479, 116);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderText = "";
            this.txtUser.SelectedText = "";
            this.txtUser.ShadowDecoration.BorderRadius = 10;
            this.txtUser.Size = new System.Drawing.Size(235, 31);
            this.txtUser.TabIndex = 25;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPass.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass.ForeColor = System.Drawing.Color.DarkGreen;
            this.showPass.Location = new System.Drawing.Point(585, 278);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(129, 23);
            this.showPass.TabIndex = 24;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.regLabel.Location = new System.Drawing.Point(567, 412);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(61, 23);
            this.regLabel.TabIndex = 23;
            this.regLabel.Text = "LOGIN";
            this.regLabel.Click += new System.EventHandler(this.regLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(507, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Already Have an Account?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(475, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(475, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(518, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 41);
            this.label1.TabIndex = 19;
            this.label1.Text = "Get Started";
            // 
            // txtPass
            // 
            this.txtPass.BorderColor = System.Drawing.Color.DarkGreen;
            this.txtPass.BorderRadius = 10;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.Location = new System.Drawing.Point(479, 178);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.ShadowDecoration.BorderRadius = 10;
            this.txtPass.Size = new System.Drawing.Size(199, 31);
            this.txtPass.TabIndex = 29;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(475, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Password";
            // 
            // cnfHide
            // 
            this.cnfHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cnfHide.BackgroundImage")));
            this.cnfHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cnfHide.BorderColor = System.Drawing.Color.DarkGreen;
            this.cnfHide.BorderRadius = 10;
            this.cnfHide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cnfHide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cnfHide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cnfHide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cnfHide.FillColor = System.Drawing.Color.Transparent;
            this.cnfHide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cnfHide.ForeColor = System.Drawing.Color.Transparent;
            this.cnfHide.Location = new System.Drawing.Point(684, 239);
            this.cnfHide.Name = "cnfHide";
            this.cnfHide.PressedColor = System.Drawing.Color.Transparent;
            this.cnfHide.Size = new System.Drawing.Size(30, 32);
            this.cnfHide.TabIndex = 32;
            this.cnfHide.Click += new System.EventHandler(this.cnfHide_Click);
            // 
            // passHide
            // 
            this.passHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passHide.BackgroundImage")));
            this.passHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passHide.BorderColor = System.Drawing.Color.DarkGreen;
            this.passHide.BorderRadius = 10;
            this.passHide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.passHide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.passHide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.passHide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.passHide.FillColor = System.Drawing.Color.Transparent;
            this.passHide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passHide.ForeColor = System.Drawing.Color.Transparent;
            this.passHide.Location = new System.Drawing.Point(684, 178);
            this.passHide.Name = "passHide";
            this.passHide.PressedColor = System.Drawing.Color.Transparent;
            this.passHide.Size = new System.Drawing.Size(30, 32);
            this.passHide.TabIndex = 31;
            this.passHide.Click += new System.EventHandler(this.passHide_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Farm.Properties.Resources.farmLogin2;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // passShow
            // 
            this.passShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passShow.BackgroundImage")));
            this.passShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passShow.BorderColor = System.Drawing.Color.DarkGreen;
            this.passShow.BorderRadius = 10;
            this.passShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.passShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.passShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.passShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.passShow.FillColor = System.Drawing.Color.Transparent;
            this.passShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passShow.ForeColor = System.Drawing.Color.Transparent;
            this.passShow.Location = new System.Drawing.Point(684, 177);
            this.passShow.Name = "passShow";
            this.passShow.PressedColor = System.Drawing.Color.Transparent;
            this.passShow.Size = new System.Drawing.Size(30, 32);
            this.passShow.TabIndex = 34;
            this.passShow.Click += new System.EventHandler(this.passShow_Click);
            // 
            // cnfShow
            // 
            this.cnfShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cnfShow.BackgroundImage")));
            this.cnfShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cnfShow.BorderColor = System.Drawing.Color.DarkGreen;
            this.cnfShow.BorderRadius = 10;
            this.cnfShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cnfShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cnfShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cnfShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cnfShow.FillColor = System.Drawing.Color.Transparent;
            this.cnfShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cnfShow.ForeColor = System.Drawing.Color.Transparent;
            this.cnfShow.Location = new System.Drawing.Point(684, 240);
            this.cnfShow.Name = "cnfShow";
            this.cnfShow.PressedColor = System.Drawing.Color.Transparent;
            this.cnfShow.Size = new System.Drawing.Size(30, 32);
            this.cnfShow.TabIndex = 33;
            this.cnfShow.Click += new System.EventHandler(this.cnfShow_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.cnfHide);
            this.Controls.Add(this.passHide);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.cnfPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passShow);
            this.Controls.Add(this.cnfShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button registerBtn;
        private Guna.UI2.WinForms.Guna2TextBox cnfPass;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button passHide;
        private Guna.UI2.WinForms.Guna2Button cnfHide;
        private Guna.UI2.WinForms.Guna2Button cnfShow;
        private Guna.UI2.WinForms.Guna2Button passShow;
    }
}