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
            this.SuspendLayout();
            // 
            // ExitUserCreation
            // 
            this.ExitUserCreation.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.ExitUserCreation.Location = new System.Drawing.Point(568, 392);
            this.ExitUserCreation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ExitUserCreation.Name = "ExitUserCreation";
            this.ExitUserCreation.Size = new System.Drawing.Size(202, 56);
            this.ExitUserCreation.TabIndex = 0;
            this.ExitUserCreation.Text = "Exit/Back";
            this.ExitUserCreation.UseVisualStyleBackColor = true;
            this.ExitUserCreation.Click += new System.EventHandler(this.ExitUserCreation_Click);
            // 
            // UserMakeLabel
            // 
            this.UserMakeLabel.AutoSize = true;
            this.UserMakeLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.UserMakeLabel.Location = new System.Drawing.Point(68, 192);
            this.UserMakeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserMakeLabel.Name = "UserMakeLabel";
            this.UserMakeLabel.Size = new System.Drawing.Size(179, 31);
            this.UserMakeLabel.TabIndex = 1;
            this.UserMakeLabel.Text = "New Username";
            // 
            // PassMakeLabel
            // 
            this.PassMakeLabel.AutoSize = true;
            this.PassMakeLabel.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.PassMakeLabel.Location = new System.Drawing.Point(68, 269);
            this.PassMakeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PassMakeLabel.Name = "PassMakeLabel";
            this.PassMakeLabel.Size = new System.Drawing.Size(174, 31);
            this.PassMakeLabel.TabIndex = 2;
            this.PassMakeLabel.Text = "New Password";
            // 
            // UserMakeInput
            // 
            this.UserMakeInput.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.UserMakeInput.Location = new System.Drawing.Point(268, 187);
            this.UserMakeInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UserMakeInput.Name = "UserMakeInput";
            this.UserMakeInput.Size = new System.Drawing.Size(320, 38);
            this.UserMakeInput.TabIndex = 3;
            this.UserMakeInput.TextChanged += new System.EventHandler(this.UserMakeInput_TextChanged);
            // 
            // PassMakeInput
            // 
            this.PassMakeInput.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.PassMakeInput.Location = new System.Drawing.Point(268, 263);
            this.PassMakeInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PassMakeInput.Name = "PassMakeInput";
            this.PassMakeInput.Size = new System.Drawing.Size(320, 38);
            this.PassMakeInput.TabIndex = 4;
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.Location = new System.Drawing.Point(66, 77);
            this.InstructionsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(503, 36);
            this.InstructionsLabel.TabIndex = 5;
            this.InstructionsLabel.Text = "Enter Desired Username and Password";
            // 
            // NewUserAndPassEnter
            // 
            this.NewUserAndPassEnter.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.NewUserAndPassEnter.Location = new System.Drawing.Point(618, 256);
            this.NewUserAndPassEnter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NewUserAndPassEnter.Name = "NewUserAndPassEnter";
            this.NewUserAndPassEnter.Size = new System.Drawing.Size(152, 44);
            this.NewUserAndPassEnter.TabIndex = 6;
            this.NewUserAndPassEnter.Text = "Enter";
            this.NewUserAndPassEnter.UseVisualStyleBackColor = true;
            this.NewUserAndPassEnter.Click += new System.EventHandler(this.NewUserAndPassEnter_Click);
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 515);
            this.Controls.Add(this.NewUserAndPassEnter);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.PassMakeInput);
            this.Controls.Add(this.UserMakeInput);
            this.Controls.Add(this.PassMakeLabel);
            this.Controls.Add(this.UserMakeLabel);
            this.Controls.Add(this.ExitUserCreation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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