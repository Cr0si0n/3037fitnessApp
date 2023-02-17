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
            this.ExitUserCreation = new System.Windows.Forms.Button();
            this.UserMakeLabel = new System.Windows.Forms.Label();
            this.PassMakeLabel = new System.Windows.Forms.Label();
            this.UserMakeInput = new System.Windows.Forms.TextBox();
            this.PassMakeInput = new System.Windows.Forms.TextBox();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.NewUserAndPassEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitUserCreation
            // 
            this.ExitUserCreation.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.ExitUserCreation.Location = new System.Drawing.Point(284, 204);
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
            this.UserMakeLabel.Location = new System.Drawing.Point(34, 100);
            this.UserMakeLabel.Name = "UserMakeLabel";
            this.UserMakeLabel.Size = new System.Drawing.Size(94, 16);
            this.UserMakeLabel.TabIndex = 1;
            this.UserMakeLabel.Text = "New Username";
            // 
            // PassMakeLabel
            // 
            this.PassMakeLabel.AutoSize = true;
            this.PassMakeLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.PassMakeLabel.Location = new System.Drawing.Point(34, 140);
            this.PassMakeLabel.Name = "PassMakeLabel";
            this.PassMakeLabel.Size = new System.Drawing.Size(94, 16);
            this.PassMakeLabel.TabIndex = 2;
            this.PassMakeLabel.Text = "New Password";
            // 
            // UserMakeInput
            // 
            this.UserMakeInput.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.UserMakeInput.Location = new System.Drawing.Point(134, 97);
            this.UserMakeInput.Name = "UserMakeInput";
            this.UserMakeInput.Size = new System.Drawing.Size(162, 23);
            this.UserMakeInput.TabIndex = 3;
            this.UserMakeInput.TextChanged += new System.EventHandler(this.UserMakeInput_TextChanged);
            // 
            // PassMakeInput
            // 
            this.PassMakeInput.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.PassMakeInput.Location = new System.Drawing.Point(134, 137);
            this.PassMakeInput.Name = "PassMakeInput";
            this.PassMakeInput.Size = new System.Drawing.Size(162, 23);
            this.PassMakeInput.TabIndex = 4;
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.Location = new System.Drawing.Point(33, 40);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(247, 19);
            this.InstructionsLabel.TabIndex = 5;
            this.InstructionsLabel.Text = "Enter Desired Username and Password";
            // 
            // NewUserAndPassEnter
            // 
            this.NewUserAndPassEnter.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.NewUserAndPassEnter.Location = new System.Drawing.Point(309, 133);
            this.NewUserAndPassEnter.Name = "NewUserAndPassEnter";
            this.NewUserAndPassEnter.Size = new System.Drawing.Size(76, 23);
            this.NewUserAndPassEnter.TabIndex = 6;
            this.NewUserAndPassEnter.Text = "Enter";
            this.NewUserAndPassEnter.UseVisualStyleBackColor = true;
            this.NewUserAndPassEnter.Click += new System.EventHandler(this.NewUserAndPassEnter_Click);
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 268);
            this.Controls.Add(this.NewUserAndPassEnter);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.PassMakeInput);
            this.Controls.Add(this.UserMakeInput);
            this.Controls.Add(this.PassMakeLabel);
            this.Controls.Add(this.UserMakeLabel);
            this.Controls.Add(this.ExitUserCreation);
            this.Name = "NewUserForm";
            this.Text = "New User Creation";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitUserCreation;
        private System.Windows.Forms.Label UserMakeLabel;
        private System.Windows.Forms.Label PassMakeLabel;
        private System.Windows.Forms.TextBox UserMakeInput;
        private System.Windows.Forms.TextBox PassMakeInput;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Button NewUserAndPassEnter;
    }
}