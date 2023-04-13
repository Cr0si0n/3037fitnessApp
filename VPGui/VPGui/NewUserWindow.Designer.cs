namespace VPGui
{
    partial class NewUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserForm));
            this.ExitUserCreation = new System.Windows.Forms.Button();
            this.UserMakeLabel = new System.Windows.Forms.Label();
            this.PassMakeLabel = new System.Windows.Forms.Label();
            this.UserMakeInput = new System.Windows.Forms.TextBox();
            this.PassMakeInput = new System.Windows.Forms.TextBox();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.NewUserAndPassEnter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitUserCreation
            // 
            this.ExitUserCreation.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.ExitUserCreation.Location = new System.Drawing.Point(269, 188);
            this.ExitUserCreation.Name = "ExitUserCreation";
            this.ExitUserCreation.Size = new System.Drawing.Size(101, 29);
            this.ExitUserCreation.TabIndex = 0;
            this.ExitUserCreation.Text = "Exit/Back";
            this.ExitUserCreation.UseVisualStyleBackColor = true;
            this.ExitUserCreation.Click += new System.EventHandler(this.ExitUserCreation_Click);
            // 
            // UserMakeLabel
            // 
            this.UserMakeLabel.AutoSize = true;
            this.UserMakeLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.UserMakeLabel.ForeColor = System.Drawing.Color.White;
            this.UserMakeLabel.Location = new System.Drawing.Point(19, 84);
            this.UserMakeLabel.Name = "UserMakeLabel";
            this.UserMakeLabel.Size = new System.Drawing.Size(94, 16);
            this.UserMakeLabel.TabIndex = 1;
            this.UserMakeLabel.Text = "New Username";
            // 
            // PassMakeLabel
            // 
            this.PassMakeLabel.AutoSize = true;
            this.PassMakeLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.PassMakeLabel.ForeColor = System.Drawing.Color.White;
            this.PassMakeLabel.Location = new System.Drawing.Point(19, 124);
            this.PassMakeLabel.Name = "PassMakeLabel";
            this.PassMakeLabel.Size = new System.Drawing.Size(94, 16);
            this.PassMakeLabel.TabIndex = 2;
            this.PassMakeLabel.Text = "New Password";
            // 
            // UserMakeInput
            // 
            this.UserMakeInput.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.UserMakeInput.Location = new System.Drawing.Point(119, 81);
            this.UserMakeInput.Name = "UserMakeInput";
            this.UserMakeInput.Size = new System.Drawing.Size(162, 23);
            this.UserMakeInput.TabIndex = 3;
            this.UserMakeInput.TextChanged += new System.EventHandler(this.UserMakeInput_TextChanged);
            // 
            // PassMakeInput
            // 
            this.PassMakeInput.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.PassMakeInput.Location = new System.Drawing.Point(119, 121);
            this.PassMakeInput.Name = "PassMakeInput";
            this.PassMakeInput.Size = new System.Drawing.Size(162, 23);
            this.PassMakeInput.TabIndex = 4;
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.ForeColor = System.Drawing.Color.White;
            this.InstructionsLabel.Location = new System.Drawing.Point(18, 24);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(247, 19);
            this.InstructionsLabel.TabIndex = 5;
            this.InstructionsLabel.Text = "Enter Desired Username and Password";
            // 
            // NewUserAndPassEnter
            // 
            this.NewUserAndPassEnter.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.NewUserAndPassEnter.Location = new System.Drawing.Point(294, 117);
            this.NewUserAndPassEnter.Name = "NewUserAndPassEnter";
            this.NewUserAndPassEnter.Size = new System.Drawing.Size(76, 23);
            this.NewUserAndPassEnter.TabIndex = 6;
            this.NewUserAndPassEnter.Text = "Enter";
            this.NewUserAndPassEnter.UseVisualStyleBackColor = true;
            this.NewUserAndPassEnter.Click += new System.EventHandler(this.NewUserAndPassEnter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(57)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NewUserAndPassEnter);
            this.panel1.Controls.Add(this.InstructionsLabel);
            this.panel1.Controls.Add(this.PassMakeInput);
            this.panel1.Controls.Add(this.UserMakeInput);
            this.panel1.Controls.Add(this.PassMakeLabel);
            this.panel1.Controls.Add(this.UserMakeLabel);
            this.panel1.Controls.Add(this.ExitUserCreation);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 236);
            this.panel1.TabIndex = 7;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(431, 268);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewUserForm";
            this.Text = "New User Creation";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitUserCreation;
        private System.Windows.Forms.Label UserMakeLabel;
        private System.Windows.Forms.Label PassMakeLabel;
        private System.Windows.Forms.TextBox UserMakeInput;
        private System.Windows.Forms.TextBox PassMakeInput;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Button NewUserAndPassEnter;
        private System.Windows.Forms.Panel panel1;
    }
}