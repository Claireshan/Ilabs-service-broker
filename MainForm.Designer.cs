namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.Schedule = new System.Windows.Forms.Label();
            this.ilabsb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stdName = new System.Windows.Forms.TextBox();
            this.studentnum = new System.Windows.Forms.TextBox();
            this.scheduledtimeTextbox = new System.Windows.Forms.DateTimePicker();
            this.year = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labs = new System.Windows.Forms.ComboBox();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.course = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Schedule
            // 
            this.Schedule.AutoSize = true;
            this.Schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schedule.Location = new System.Drawing.Point(28, 67);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(217, 20);
            this.Schedule.TabIndex = 0;
            this.Schedule.Text = "Schedule for the lab to do";
            // 
            // ilabsb
            // 
            this.ilabsb.AutoSize = true;
            this.ilabsb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilabsb.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ilabsb.Location = new System.Drawing.Point(246, 13);
            this.ilabsb.Name = "ilabsb";
            this.ilabsb.Size = new System.Drawing.Size(268, 25);
            this.ilabsb.TabIndex = 1;
            this.ilabsb.Text = "ILABS SERVICE BROKER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Schedule time";
            // 
            // stdName
            // 
            this.stdName.Location = new System.Drawing.Point(204, 115);
            this.stdName.Name = "stdName";
            this.stdName.Size = new System.Drawing.Size(241, 20);
            this.stdName.TabIndex = 7;
            // 
            // studentnum
            // 
            this.studentnum.Location = new System.Drawing.Point(204, 157);
            this.studentnum.Name = "studentnum";
            this.studentnum.Size = new System.Drawing.Size(241, 20);
            this.studentnum.TabIndex = 8;
            // 
            // scheduledtimeTextbox
            // 
            this.scheduledtimeTextbox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.scheduledtimeTextbox.Location = new System.Drawing.Point(204, 325);
            this.scheduledtimeTextbox.MaxDate = new System.DateTime(3000, 1, 12, 0, 0, 0, 0);
            this.scheduledtimeTextbox.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.scheduledtimeTextbox.Name = "scheduledtimeTextbox";
            this.scheduledtimeTextbox.Size = new System.Drawing.Size(241, 20);
            this.scheduledtimeTextbox.TabIndex = 10;
            // 
            // year
            // 
            this.year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year.FormattingEnabled = true;
            this.year.Items.AddRange(new object[] {
            "First ",
            "Second ",
            "Third ",
            "Forth "});
            this.year.Location = new System.Drawing.Point(204, 233);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(241, 21);
            this.year.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lab Experiment";
            // 
            // labs
            // 
            this.labs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.labs.FormattingEnabled = true;
            this.labs.Items.AddRange(new object[] {
            "Half wave rectification Lab",
            "Opamp Lab",
            "Full wave rectification Lab",
            "Digital logic Lab",
            "FM and AM Lab"});
            this.labs.Location = new System.Drawing.Point(204, 281);
            this.labs.Name = "labs";
            this.labs.Size = new System.Drawing.Size(241, 21);
            this.labs.TabIndex = 14;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DownloadButton.Location = new System.Drawing.Point(578, 406);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(201, 32);
            this.DownloadButton.TabIndex = 15;
            this.DownloadButton.Text = "Download lab file";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // scheduleButton
            // 
            this.scheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.scheduleButton.Location = new System.Drawing.Point(441, 406);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(101, 31);
            this.scheduleButton.TabIndex = 16;
            this.scheduleButton.Text = "Schedule";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // course
            // 
            this.course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course.FormattingEnabled = true;
            this.course.Items.AddRange(new object[] {
            "Computer Engineering",
            "Electrical Engineering",
            "Telecommunication Engineering"});
            this.course.Location = new System.Drawing.Point(204, 195);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(241, 21);
            this.course.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.course);
            this.Controls.Add(this.scheduleButton);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.labs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.year);
            this.Controls.Add(this.scheduledtimeTextbox);
            this.Controls.Add(this.studentnum);
            this.Controls.Add(this.stdName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ilabsb);
            this.Controls.Add(this.Schedule);
            this.Name = "MainForm";
            this.Text = "Service Broker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Schedule;
        private System.Windows.Forms.Label ilabsb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stdName;
        private System.Windows.Forms.TextBox studentnum;
        private System.Windows.Forms.DateTimePicker scheduledtimeTextbox;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox labs;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.ComboBox course;
    }
}

