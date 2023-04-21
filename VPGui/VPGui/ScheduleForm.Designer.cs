namespace VPGui
{
    partial class ScheduleForm
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
            this.WkClose = new System.Windows.Forms.Button();
            this.WkLabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mondayGbx = new System.Windows.Forms.GroupBox();
            this.tuesdayGbx = new System.Windows.Forms.GroupBox();
            this.wednesdayGbx = new System.Windows.Forms.GroupBox();
            this.thursdayGbx = new System.Windows.Forms.GroupBox();
            this.fridayGbx = new System.Windows.Forms.GroupBox();
            this.saturdayGbx = new System.Windows.Forms.GroupBox();
            this.sundayGbx = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WkClose
            // 
            this.WkClose.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WkClose.Location = new System.Drawing.Point(445, 407);
            this.WkClose.Name = "WkClose";
            this.WkClose.Size = new System.Drawing.Size(87, 22);
            this.WkClose.TabIndex = 15;
            this.WkClose.Text = "Close";
            this.WkClose.UseVisualStyleBackColor = true;
            this.WkClose.Click += new System.EventHandler(this.WkClose_Click);
            // 
            // WkLabel1
            // 
            this.WkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WkLabel1.AutoSize = true;
            this.WkLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.WkLabel1.ForeColor = System.Drawing.Color.White;
            this.WkLabel1.Location = new System.Drawing.Point(22, 17);
            this.WkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WkLabel1.Name = "WkLabel1";
            this.WkLabel1.Size = new System.Drawing.Size(114, 19);
            this.WkLabel1.TabIndex = 22;
            this.WkLabel1.Text = "Weekly Schedule";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(57)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.WkLabel1);
            this.panel1.Controls.Add(this.WkClose);
            this.panel1.Location = new System.Drawing.Point(41, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 443);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(102, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "You have not made a schedule yet";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.mondayGbx);
            this.flowLayoutPanel1.Controls.Add(this.tuesdayGbx);
            this.flowLayoutPanel1.Controls.Add(this.wednesdayGbx);
            this.flowLayoutPanel1.Controls.Add(this.thursdayGbx);
            this.flowLayoutPanel1.Controls.Add(this.fridayGbx);
            this.flowLayoutPanel1.Controls.Add(this.saturdayGbx);
            this.flowLayoutPanel1.Controls.Add(this.sundayGbx);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(506, 362);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // mondayGbx
            // 
            this.mondayGbx.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mondayGbx.ForeColor = System.Drawing.SystemColors.Control;
            this.mondayGbx.Location = new System.Drawing.Point(3, 3);
            this.mondayGbx.Name = "mondayGbx";
            this.mondayGbx.Size = new System.Drawing.Size(483, 221);
            this.mondayGbx.TabIndex = 0;
            this.mondayGbx.TabStop = false;
            this.mondayGbx.Text = "Monday";
            this.mondayGbx.Visible = false;
            // 
            // tuesdayGbx
            // 
            this.tuesdayGbx.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesdayGbx.ForeColor = System.Drawing.SystemColors.Control;
            this.tuesdayGbx.Location = new System.Drawing.Point(3, 230);
            this.tuesdayGbx.Name = "tuesdayGbx";
            this.tuesdayGbx.Size = new System.Drawing.Size(483, 221);
            this.tuesdayGbx.TabIndex = 1;
            this.tuesdayGbx.TabStop = false;
            this.tuesdayGbx.Text = "Tuesday";
            this.tuesdayGbx.Visible = false;
            // 
            // wednesdayGbx
            // 
            this.wednesdayGbx.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesdayGbx.ForeColor = System.Drawing.SystemColors.Control;
            this.wednesdayGbx.Location = new System.Drawing.Point(3, 457);
            this.wednesdayGbx.Name = "wednesdayGbx";
            this.wednesdayGbx.Size = new System.Drawing.Size(483, 221);
            this.wednesdayGbx.TabIndex = 2;
            this.wednesdayGbx.TabStop = false;
            this.wednesdayGbx.Text = "Wednesday";
            this.wednesdayGbx.Visible = false;
            // 
            // thursdayGbx
            // 
            this.thursdayGbx.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursdayGbx.ForeColor = System.Drawing.SystemColors.Control;
            this.thursdayGbx.Location = new System.Drawing.Point(3, 684);
            this.thursdayGbx.Name = "thursdayGbx";
            this.thursdayGbx.Size = new System.Drawing.Size(483, 221);
            this.thursdayGbx.TabIndex = 3;
            this.thursdayGbx.TabStop = false;
            this.thursdayGbx.Text = "Thursday";
            this.thursdayGbx.Visible = false;
            // 
            // fridayGbx
            // 
            this.fridayGbx.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fridayGbx.ForeColor = System.Drawing.SystemColors.Control;
            this.fridayGbx.Location = new System.Drawing.Point(3, 911);
            this.fridayGbx.Name = "fridayGbx";
            this.fridayGbx.Size = new System.Drawing.Size(483, 221);
            this.fridayGbx.TabIndex = 4;
            this.fridayGbx.TabStop = false;
            this.fridayGbx.Text = "Friday";
            this.fridayGbx.Visible = false;
            // 
            // saturdayGbx
            // 
            this.saturdayGbx.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturdayGbx.ForeColor = System.Drawing.SystemColors.Control;
            this.saturdayGbx.Location = new System.Drawing.Point(3, 1138);
            this.saturdayGbx.Name = "saturdayGbx";
            this.saturdayGbx.Size = new System.Drawing.Size(483, 221);
            this.saturdayGbx.TabIndex = 5;
            this.saturdayGbx.TabStop = false;
            this.saturdayGbx.Text = "Saturday";
            this.saturdayGbx.Visible = false;
            // 
            // sundayGbx
            // 
            this.sundayGbx.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sundayGbx.ForeColor = System.Drawing.SystemColors.Control;
            this.sundayGbx.Location = new System.Drawing.Point(3, 1365);
            this.sundayGbx.Name = "sundayGbx";
            this.sundayGbx.Size = new System.Drawing.Size(483, 221);
            this.sundayGbx.TabIndex = 6;
            this.sundayGbx.TabStop = false;
            this.sundayGbx.Text = "Sunday";
            this.sundayGbx.Visible = false;
            this.sundayGbx.Enter += new System.EventHandler(this.sundayGbx_Enter);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(644, 493);
            this.Controls.Add(this.panel1);
            this.Name = "ScheduleForm";
            this.Text = "Your Schedule";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WkClose;
        private System.Windows.Forms.Label WkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox mondayGbx;
        private System.Windows.Forms.GroupBox tuesdayGbx;
        private System.Windows.Forms.GroupBox wednesdayGbx;
        private System.Windows.Forms.GroupBox thursdayGbx;
        private System.Windows.Forms.GroupBox fridayGbx;
        private System.Windows.Forms.GroupBox saturdayGbx;
        private System.Windows.Forms.GroupBox sundayGbx;
        private System.Windows.Forms.Label label1;
    }
}