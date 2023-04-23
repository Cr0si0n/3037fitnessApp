namespace VPGui
{
    partial class Goals
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.WeightTxt = new System.Windows.Forms.TextBox();
            this.RepsTxt = new System.Windows.Forms.TextBox();
            this.SetsTxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mondayGbx = new System.Windows.Forms.GroupBox();
            this.WkLabel1 = new System.Windows.Forms.Label();
            this.WkClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(57)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.WeightTxt);
            this.panel1.Controls.Add(this.RepsTxt);
            this.panel1.Controls.Add(this.SetsTxt);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.WkLabel1);
            this.panel1.Controls.Add(this.WkClose);
            this.panel1.Location = new System.Drawing.Point(29, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 443);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(27, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 23);
            this.comboBox2.TabIndex = 67;
            this.comboBox2.Text = "Choose an Exercise";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(27, 239);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(146, 22);
            this.deleteBtn.TabIndex = 66;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(27, 211);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(146, 22);
            this.saveBtn.TabIndex = 65;
            this.saveBtn.Text = "Add";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 19);
            this.label5.TabIndex = 64;
            this.label5.Text = "Sets    Reps   Weight (lbs)";
            // 
            // WeightTxt
            // 
            this.WeightTxt.Location = new System.Drawing.Point(123, 140);
            this.WeightTxt.Name = "WeightTxt";
            this.WeightTxt.Size = new System.Drawing.Size(52, 20);
            this.WeightTxt.TabIndex = 63;
            this.WeightTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RepsTxt
            // 
            this.RepsTxt.Location = new System.Drawing.Point(72, 140);
            this.RepsTxt.Name = "RepsTxt";
            this.RepsTxt.Size = new System.Drawing.Size(26, 20);
            this.RepsTxt.TabIndex = 62;
            this.RepsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SetsTxt
            // 
            this.SetsTxt.Location = new System.Drawing.Point(29, 140);
            this.SetsTxt.Name = "SetsTxt";
            this.SetsTxt.Size = new System.Drawing.Size(26, 20);
            this.SetsTxt.TabIndex = 61;
            this.SetsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 23);
            this.comboBox1.TabIndex = 60;
            this.comboBox1.Text = "Choose a Muscle Group";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(250, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "You have no goals yet";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.mondayGbx);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(208, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(308, 373);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // mondayGbx
            // 
            this.mondayGbx.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mondayGbx.ForeColor = System.Drawing.SystemColors.Control;
            this.mondayGbx.Location = new System.Drawing.Point(3, 3);
            this.mondayGbx.Name = "mondayGbx";
            this.mondayGbx.Size = new System.Drawing.Size(280, 130);
            this.mondayGbx.TabIndex = 0;
            this.mondayGbx.TabStop = false;
            this.mondayGbx.Text = "Example";
            this.mondayGbx.Visible = false;
            // 
            // WkLabel1
            // 
            this.WkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WkLabel1.AutoSize = true;
            this.WkLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.WkLabel1.ForeColor = System.Drawing.Color.White;
            this.WkLabel1.Location = new System.Drawing.Point(12, 10);
            this.WkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WkLabel1.Name = "WkLabel1";
            this.WkLabel1.Size = new System.Drawing.Size(44, 19);
            this.WkLabel1.TabIndex = 22;
            this.WkLabel1.Text = "Goals";
            // 
            // WkClose
            // 
            this.WkClose.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WkClose.Location = new System.Drawing.Point(27, 385);
            this.WkClose.Name = "WkClose";
            this.WkClose.Size = new System.Drawing.Size(146, 22);
            this.WkClose.TabIndex = 15;
            this.WkClose.Text = "Close";
            this.WkClose.UseVisualStyleBackColor = true;
            this.WkClose.Click += new System.EventHandler(this.WkClose_Click);
            // 
            // Goals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(597, 499);
            this.Controls.Add(this.panel1);
            this.Name = "Goals";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox mondayGbx;
        private System.Windows.Forms.Label WkLabel1;
        private System.Windows.Forms.Button WkClose;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox SetsTxt;
        private System.Windows.Forms.TextBox RepsTxt;
        private System.Windows.Forms.TextBox WeightTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}