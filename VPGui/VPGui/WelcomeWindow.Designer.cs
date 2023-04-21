namespace VPGui
{
    partial class VPGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VPGui));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SignInLabel = new System.Windows.Forms.Label();
            this.CreateNewUserButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UserAndPassEnterButton = new System.Windows.Forms.Button();
            this.WkLabel1 = new System.Windows.Forms.Label();
            this.WkLabel2 = new System.Windows.Forms.Label();
            this.WkLogout = new System.Windows.Forms.Button();
            this.Wkbutton1 = new System.Windows.Forms.Button();
            this.GrpButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(42, 37);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(265, 19);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to The Visual Workout Manager";
            this.WelcomeLabel.Click += new System.EventHandler(this.WelcomeLabel_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(72, 127);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(60, 15);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(72, 159);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(59, 15);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLabel.ForeColor = System.Drawing.Color.White;
            this.SignInLabel.Location = new System.Drawing.Point(72, 83);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(49, 17);
            this.SignInLabel.TabIndex = 3;
            this.SignInLabel.Text = "Sign In";
            this.SignInLabel.Click += new System.EventHandler(this.SignInLabel_Click);
            // 
            // CreateNewUserButton
            // 
            this.CreateNewUserButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewUserButton.ForeColor = System.Drawing.Color.Black;
            this.CreateNewUserButton.Location = new System.Drawing.Point(26, 231);
            this.CreateNewUserButton.Name = "CreateNewUserButton";
            this.CreateNewUserButton.Size = new System.Drawing.Size(113, 22);
            this.CreateNewUserButton.TabIndex = 4;
            this.CreateNewUserButton.Text = "Create New User";
            this.CreateNewUserButton.UseVisualStyleBackColor = true;
            this.CreateNewUserButton.Click += new System.EventHandler(this.CreateNewUserButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(391, 242);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(113, 22);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameInput.Location = new System.Drawing.Point(190, 124);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(197, 22);
            this.UsernameInput.TabIndex = 6;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(190, 157);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(197, 20);
            this.PasswordInput.TabIndex = 7;
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // UserAndPassEnterButton
            // 
            this.UserAndPassEnterButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAndPassEnterButton.ForeColor = System.Drawing.Color.Black;
            this.UserAndPassEnterButton.Location = new System.Drawing.Point(420, 157);
            this.UserAndPassEnterButton.Name = "UserAndPassEnterButton";
            this.UserAndPassEnterButton.Size = new System.Drawing.Size(75, 23);
            this.UserAndPassEnterButton.TabIndex = 8;
            this.UserAndPassEnterButton.Text = "Enter";
            this.UserAndPassEnterButton.UseVisualStyleBackColor = true;
            this.UserAndPassEnterButton.Click += new System.EventHandler(this.UserAndPassEnterButton_Click);
            // 
            // WkLabel1
            // 
            this.WkLabel1.AutoSize = true;
            this.WkLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WkLabel1.ForeColor = System.Drawing.Color.White;
            this.WkLabel1.Location = new System.Drawing.Point(22, 18);
            this.WkLabel1.Name = "WkLabel1";
            this.WkLabel1.Size = new System.Drawing.Size(103, 19);
            this.WkLabel1.TabIndex = 9;
            this.WkLabel1.Text = "WelcomeBack!";
            this.WkLabel1.Click += new System.EventHandler(this.WkLabel1_Click);
            // 
            // WkLabel2
            // 
            this.WkLabel2.AutoSize = true;
            this.WkLabel2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.WkLabel2.ForeColor = System.Drawing.Color.White;
            this.WkLabel2.Location = new System.Drawing.Point(27, 70);
            this.WkLabel2.Name = "WkLabel2";
            this.WkLabel2.Size = new System.Drawing.Size(148, 17);
            this.WkLabel2.TabIndex = 10;
            this.WkLabel2.Text = "Please Select an Option";
            this.WkLabel2.Click += new System.EventHandler(this.WkLabel2_Click);
            // 
            // WkLogout
            // 
            this.WkLogout.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WkLogout.ForeColor = System.Drawing.Color.Black;
            this.WkLogout.Location = new System.Drawing.Point(391, 214);
            this.WkLogout.Name = "WkLogout";
            this.WkLogout.Size = new System.Drawing.Size(113, 22);
            this.WkLogout.TabIndex = 11;
            this.WkLogout.Text = "Logout";
            this.WkLogout.UseVisualStyleBackColor = true;
            this.WkLogout.Click += new System.EventHandler(this.WkLogout_Click);
            // 
            // Wkbutton1
            // 
            this.Wkbutton1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wkbutton1.ForeColor = System.Drawing.Color.Black;
            this.Wkbutton1.Location = new System.Drawing.Point(27, 115);
            this.Wkbutton1.Name = "Wkbutton1";
            this.Wkbutton1.Size = new System.Drawing.Size(105, 23);
            this.Wkbutton1.TabIndex = 14;
            this.Wkbutton1.Text = "Workout";
            this.Wkbutton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Wkbutton1.UseVisualStyleBackColor = true;
            this.Wkbutton1.Click += new System.EventHandler(this.Wkbutton1_Click);
            // 
            // GrpButton
            // 
            this.GrpButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpButton.ForeColor = System.Drawing.Color.Black;
            this.GrpButton.Location = new System.Drawing.Point(27, 160);
            this.GrpButton.Margin = new System.Windows.Forms.Padding(2);
            this.GrpButton.Name = "GrpButton";
            this.GrpButton.Size = new System.Drawing.Size(104, 22);
            this.GrpButton.TabIndex = 15;
            this.GrpButton.Text = "Your Schedule";
            this.GrpButton.UseVisualStyleBackColor = true;
            this.GrpButton.Click += new System.EventHandler(this.GrpButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(57)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GrpButton);
            this.panel1.Controls.Add(this.Wkbutton1);
            this.panel1.Controls.Add(this.WkLabel2);
            this.panel1.Controls.Add(this.WkLabel1);
            this.panel1.Controls.Add(this.UserAndPassEnterButton);
            this.panel1.Controls.Add(this.PasswordInput);
            this.panel1.Controls.Add(this.UsernameInput);
            this.panel1.Controls.Add(this.CreateNewUserButton);
            this.panel1.Controls.Add(this.SignInLabel);
            this.panel1.Controls.Add(this.PasswordLabel);
            this.panel1.Controls.Add(this.UsernameLabel);
            this.panel1.Controls.Add(this.WelcomeLabel);
            this.panel1.Controls.Add(this.WkLogout);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Location = new System.Drawing.Point(30, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 287);
            this.panel1.TabIndex = 16;
            // 
            // VPGui
            // 
            this.AcceptButton = this.UserAndPassEnterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(605, 343);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VPGui";
            this.Text = "Visual Workout Manager";
            this.Load += new System.EventHandler(this.VPGui_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.Button CreateNewUserButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Button UserAndPassEnterButton;
        private System.Windows.Forms.Label WkLabel1;
        private System.Windows.Forms.Label WkLabel2;
        private System.Windows.Forms.Button WkLogout;
        private System.Windows.Forms.Button Wkbutton1;
        private System.Windows.Forms.Button GrpButton;
        private System.Windows.Forms.Panel panel1;
    }
}

