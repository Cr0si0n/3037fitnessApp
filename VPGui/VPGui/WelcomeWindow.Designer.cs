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
            this.Wkbutton3 = new System.Windows.Forms.Button();
            this.Wkbutton2 = new System.Windows.Forms.Button();
            this.Wkbutton1 = new System.Windows.Forms.Button();
            this.GrpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(48, 47);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(265, 19);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to The Visual Workout Manager";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(78, 137);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(60, 15);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(78, 169);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(59, 15);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLabel.Location = new System.Drawing.Point(78, 93);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(49, 17);
            this.SignInLabel.TabIndex = 3;
            this.SignInLabel.Text = "Sign In";
            // 
            // CreateNewUserButton
            // 
            this.CreateNewUserButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewUserButton.Location = new System.Drawing.Point(82, 267);
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
            this.ExitButton.Location = new System.Drawing.Point(400, 267);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(87, 22);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameInput.Location = new System.Drawing.Point(196, 134);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(197, 22);
            this.UsernameInput.TabIndex = 6;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(196, 167);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(197, 20);
            this.PasswordInput.TabIndex = 7;
            // 
            // UserAndPassEnterButton
            // 
            this.UserAndPassEnterButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAndPassEnterButton.Location = new System.Drawing.Point(426, 167);
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
            this.WkLabel1.Location = new System.Drawing.Point(48, 38);
            this.WkLabel1.Name = "WkLabel1";
            this.WkLabel1.Size = new System.Drawing.Size(103, 19);
            this.WkLabel1.TabIndex = 9;
            this.WkLabel1.Text = "WelcomeBack!";
            // 
            // WkLabel2
            // 
            this.WkLabel2.AutoSize = true;
            this.WkLabel2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.WkLabel2.Location = new System.Drawing.Point(48, 71);
            this.WkLabel2.Name = "WkLabel2";
            this.WkLabel2.Size = new System.Drawing.Size(154, 17);
            this.WkLabel2.TabIndex = 10;
            this.WkLabel2.Text = "Please Select A Workout";
            // 
            // WkLogout
            // 
            this.WkLogout.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WkLogout.Location = new System.Drawing.Point(400, 267);
            this.WkLogout.Name = "WkLogout";
            this.WkLogout.Size = new System.Drawing.Size(87, 22);
            this.WkLogout.TabIndex = 11;
            this.WkLogout.Text = "Logout";
            this.WkLogout.UseVisualStyleBackColor = true;
            this.WkLogout.Click += new System.EventHandler(this.WkLogout_Click);
            // 
            // Wkbutton3
            // 
            this.Wkbutton3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wkbutton3.Location = new System.Drawing.Point(62, 200);
            this.Wkbutton3.Name = "Wkbutton3";
            this.Wkbutton3.Size = new System.Drawing.Size(105, 23);
            this.Wkbutton3.TabIndex = 12;
            this.Wkbutton3.Text = "Cardio";
            this.Wkbutton3.UseVisualStyleBackColor = true;
            // 
            // Wkbutton2
            // 
            this.Wkbutton2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wkbutton2.Location = new System.Drawing.Point(62, 155);
            this.Wkbutton2.Name = "Wkbutton2";
            this.Wkbutton2.Size = new System.Drawing.Size(105, 23);
            this.Wkbutton2.TabIndex = 13;
            this.Wkbutton2.Text = "HIT";
            this.Wkbutton2.UseVisualStyleBackColor = true;
            // 
            // Wkbutton1
            // 
            this.Wkbutton1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wkbutton1.Location = new System.Drawing.Point(62, 111);
            this.Wkbutton1.Name = "Wkbutton1";
            this.Wkbutton1.Size = new System.Drawing.Size(105, 23);
            this.Wkbutton1.TabIndex = 14;
            this.Wkbutton1.Text = "Bodybuilding";
            this.Wkbutton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Wkbutton1.UseVisualStyleBackColor = true;
            this.Wkbutton1.Click += new System.EventHandler(this.Wkbutton1_Click);
            // 
            // GrpButton
            // 
            this.GrpButton.Location = new System.Drawing.Point(256, 268);
            this.GrpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpButton.Name = "GrpButton";
            this.GrpButton.Size = new System.Drawing.Size(87, 22);
            this.GrpButton.TabIndex = 15;
            this.GrpButton.Text = "Weekly Stats";
            this.GrpButton.UseVisualStyleBackColor = true;
            this.GrpButton.Click += new System.EventHandler(this.GrpButton_Click);
            // 
            // VPGui
            // 
            this.AcceptButton = this.UserAndPassEnterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(605, 343);
            this.Controls.Add(this.GrpButton);
            this.Controls.Add(this.Wkbutton1);
            this.Controls.Add(this.Wkbutton2);
            this.Controls.Add(this.Wkbutton3);
            this.Controls.Add(this.WkLabel2);
            this.Controls.Add(this.WkLabel1);
            this.Controls.Add(this.UserAndPassEnterButton);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.CreateNewUserButton);
            this.Controls.Add(this.SignInLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.WkLogout);
            this.Controls.Add(this.ExitButton);
            this.Name = "VPGui";
            this.Text = "Visual Workout Manager";
            this.Load += new System.EventHandler(this.VPGui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button Wkbutton3;
        private System.Windows.Forms.Button Wkbutton2;
        private System.Windows.Forms.Button Wkbutton1;
        private System.Windows.Forms.Button GrpButton;
    }
}

