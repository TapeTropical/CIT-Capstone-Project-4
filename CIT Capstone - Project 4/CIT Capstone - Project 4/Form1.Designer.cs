namespace CIT_Capstone___Project_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            yesDeBtn = new RadioButton();
            noDeBtn = new RadioButton();
            confirmBtn = new Button();
            enrollmentGB = new GroupBox();
            inStateBtn = new RadioButton();
            outStateBtn = new RadioButton();
            eRateBtn = new RadioButton();
            courseGroupBox = new GroupBox();
            courseListBox = new ListBox();
            receiptButton = new Button();
            deleteCourseBtn = new Button();
            addCourseBtn = new Button();
            label4 = new Label();
            creditHrsBox = new NumericUpDown();
            noNurseBtn = new RadioButton();
            yesNurseBtn = new RadioButton();
            label5 = new Label();
            eCampusBtn = new RadioButton();
            nsccBtn = new RadioButton();
            label6 = new Label();
            courseNameTxt = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            enrollmentGB.SuspendLayout();
            courseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)creditHrsBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(65, 57);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter your name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(219, 55);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(164, 27);
            nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(44, 118);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 2;
            label2.Text = "Type of Enrollment:";
            // 
            // label3
            // 
            label3.Location = new Point(24, 226);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 6;
            label3.Text = "Are you dual-enrolled?";
            // 
            // yesDeBtn
            // 
            yesDeBtn.AutoSize = true;
            yesDeBtn.Location = new Point(239, 226);
            yesDeBtn.Name = "yesDeBtn";
            yesDeBtn.Size = new Size(48, 24);
            yesDeBtn.TabIndex = 7;
            yesDeBtn.TabStop = true;
            yesDeBtn.Text = "Yes";
            yesDeBtn.UseVisualStyleBackColor = true;
            // 
            // noDeBtn
            // 
            noDeBtn.AutoSize = true;
            noDeBtn.Location = new Point(293, 227);
            noDeBtn.Name = "noDeBtn";
            noDeBtn.Size = new Size(47, 24);
            noDeBtn.TabIndex = 8;
            noDeBtn.TabStop = true;
            noDeBtn.Text = "No";
            noDeBtn.UseVisualStyleBackColor = true;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(24, 307);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(387, 56);
            confirmBtn.TabIndex = 9;
            confirmBtn.Text = "Confirm Information";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // enrollmentGB
            // 
            enrollmentGB.Controls.Add(inStateBtn);
            enrollmentGB.Controls.Add(outStateBtn);
            enrollmentGB.Controls.Add(eRateBtn);
            enrollmentGB.Location = new Point(219, 88);
            enrollmentGB.Name = "enrollmentGB";
            enrollmentGB.Size = new Size(164, 130);
            enrollmentGB.TabIndex = 21;
            enrollmentGB.TabStop = false;
            // 
            // inStateBtn
            // 
            inStateBtn.Location = new Point(20, 26);
            inStateBtn.Name = "inStateBtn";
            inStateBtn.Size = new Size(146, 30);
            inStateBtn.TabIndex = 13;
            inStateBtn.TabStop = true;
            inStateBtn.Text = "In-State";
            inStateBtn.UseVisualStyleBackColor = true;
            // 
            // outStateBtn
            // 
            outStateBtn.Location = new Point(20, 57);
            outStateBtn.Name = "outStateBtn";
            outStateBtn.Size = new Size(117, 24);
            outStateBtn.TabIndex = 14;
            outStateBtn.TabStop = true;
            outStateBtn.Text = "Out-of-State";
            outStateBtn.UseVisualStyleBackColor = true;
            // 
            // eRateBtn
            // 
            eRateBtn.Location = new Point(20, 87);
            eRateBtn.Name = "eRateBtn";
            eRateBtn.Size = new Size(117, 24);
            eRateBtn.TabIndex = 15;
            eRateBtn.TabStop = true;
            eRateBtn.Text = "eRate Out-of-State";
            eRateBtn.UseVisualStyleBackColor = true;
            // 
            // courseGroupBox
            // 
            courseGroupBox.Controls.Add(courseListBox);
            courseGroupBox.Location = new Point(413, 26);
            courseGroupBox.Name = "courseGroupBox";
            courseGroupBox.Size = new Size(178, 233);
            courseGroupBox.TabIndex = 36;
            courseGroupBox.TabStop = false;
            courseGroupBox.Text = "Enrolled Courses";
            // 
            // courseListBox
            // 
            courseListBox.FormattingEnabled = true;
            courseListBox.ItemHeight = 20;
            courseListBox.Location = new Point(17, 19);
            courseListBox.Name = "courseListBox";
            courseListBox.Size = new Size(150, 204);
            courseListBox.TabIndex = 14;
            // 
            // receiptButton
            // 
            receiptButton.Location = new Point(430, 306);
            receiptButton.Name = "receiptButton";
            receiptButton.Size = new Size(150, 56);
            receiptButton.TabIndex = 35;
            receiptButton.Text = "Print Receipt";
            receiptButton.UseVisualStyleBackColor = true;
            receiptButton.Click += receiptButton_Click;
            // 
            // deleteCourseBtn
            // 
            deleteCourseBtn.Location = new Point(235, 306);
            deleteCourseBtn.Name = "deleteCourseBtn";
            deleteCourseBtn.Size = new Size(169, 56);
            deleteCourseBtn.TabIndex = 34;
            deleteCourseBtn.Text = "Delete Course";
            deleteCourseBtn.UseVisualStyleBackColor = true;
            deleteCourseBtn.Click += deleteCourseBtn_Click;
            // 
            // addCourseBtn
            // 
            addCourseBtn.Location = new Point(28, 307);
            addCourseBtn.Name = "addCourseBtn";
            addCourseBtn.Size = new Size(182, 56);
            addCourseBtn.TabIndex = 32;
            addCourseBtn.Text = "Add Course";
            addCourseBtn.UseVisualStyleBackColor = true;
            addCourseBtn.Click += addCourseBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 204);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 31;
            label4.Text = "Credits:";
            label4.Click += label4_Click;
            // 
            // creditHrsBox
            // 
            creditHrsBox.Location = new Point(321, 227);
            creditHrsBox.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            creditHrsBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            creditHrsBox.Name = "creditHrsBox";
            creditHrsBox.Size = new Size(83, 27);
            creditHrsBox.TabIndex = 30;
            creditHrsBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // noNurseBtn
            // 
            noNurseBtn.AutoSize = true;
            noNurseBtn.Location = new Point(225, 21);
            noNurseBtn.Name = "noNurseBtn";
            noNurseBtn.Size = new Size(47, 24);
            noNurseBtn.TabIndex = 29;
            noNurseBtn.TabStop = true;
            noNurseBtn.Text = "No";
            noNurseBtn.UseVisualStyleBackColor = true;
            noNurseBtn.CheckedChanged += noNurseBtn_CheckedChanged;
            // 
            // yesNurseBtn
            // 
            yesNurseBtn.AutoSize = true;
            yesNurseBtn.Location = new Point(155, 21);
            yesNurseBtn.Name = "yesNurseBtn";
            yesNurseBtn.Size = new Size(48, 24);
            yesNurseBtn.TabIndex = 28;
            yesNurseBtn.TabStop = true;
            yesNurseBtn.Text = "Yes";
            yesNurseBtn.UseVisualStyleBackColor = true;
            yesNurseBtn.CheckedChanged += yesNurseBtn_CheckedChanged;
            // 
            // label5
            // 
            label5.Location = new Point(18, 21);
            label5.Name = "label5";
            label5.Size = new Size(132, 36);
            label5.TabIndex = 27;
            label5.Text = "Nursing Course:";
            // 
            // eCampusBtn
            // 
            eCampusBtn.AutoSize = true;
            eCampusBtn.Location = new Point(225, 36);
            eCampusBtn.Name = "eCampusBtn";
            eCampusBtn.Size = new Size(111, 24);
            eCampusBtn.TabIndex = 26;
            eCampusBtn.TabStop = true;
            eCampusBtn.Text = "TN eCampus";
            eCampusBtn.UseVisualStyleBackColor = true;
            eCampusBtn.CheckedChanged += eCampusBtn_CheckedChanged;
            // 
            // nsccBtn
            // 
            nsccBtn.AutoSize = true;
            nsccBtn.Location = new Point(155, 36);
            nsccBtn.Name = "nsccBtn";
            nsccBtn.Size = new Size(64, 24);
            nsccBtn.TabIndex = 25;
            nsccBtn.TabStop = true;
            nsccBtn.Text = "NSCC";
            nsccBtn.UseVisualStyleBackColor = true;
            nsccBtn.CheckedChanged += inPersonBtn_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 37);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 24;
            label6.Text = "Select Course Type:";
            // 
            // courseNameTxt
            // 
            courseNameTxt.Location = new Point(220, 75);
            courseNameTxt.Name = "courseNameTxt";
            courseNameTxt.Size = new Size(184, 27);
            courseNameTxt.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 75);
            label7.Name = "label7";
            label7.Size = new Size(164, 20);
            label7.TabIndex = 22;
            label7.Text = "Enter the Course Name:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(nsccBtn);
            groupBox1.Controls.Add(eCampusBtn);
            groupBox1.Location = new Point(21, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 81);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(yesNurseBtn);
            groupBox2.Controls.Add(noNurseBtn);
            groupBox2.Location = new Point(21, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 64);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(nameTextBox);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(yesDeBtn);
            groupBox3.Controls.Add(noDeBtn);
            groupBox3.Controls.Add(confirmBtn);
            groupBox3.Controls.Add(enrollmentGB);
            groupBox3.Location = new Point(21, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(436, 389);
            groupBox3.TabIndex = 39;
            groupBox3.TabStop = false;
            groupBox3.Text = "Student Information";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(courseNameTxt);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Controls.Add(creditHrsBox);
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(courseGroupBox);
            groupBox4.Controls.Add(addCourseBtn);
            groupBox4.Controls.Add(receiptButton);
            groupBox4.Controls.Add(deleteCourseBtn);
            groupBox4.Location = new Point(473, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(605, 389);
            groupBox4.TabIndex = 40;
            groupBox4.TabStop = false;
            groupBox4.Text = "Course Information";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 425);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Name = "Form1";
            Text = "Student Tuition Estimator";
            Load += Form1_Load;
            enrollmentGB.ResumeLayout(false);
            courseGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)creditHrsBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private Label label3;
        private RadioButton yesDeBtn;
        private RadioButton noDeBtn;
        private Button confirmBtn;
        private GroupBox enrollmentGB;
        private RadioButton inStateBtn;
        private RadioButton outStateBtn;
        private RadioButton eRateBtn;
        private GroupBox courseGroupBox;
        private ListBox courseListBox;
        private Button receiptButton;
        private Button deleteCourseBtn;
        private Button addCourseBtn;
        private Label label4;
        private NumericUpDown creditHrsBox;
        private RadioButton noNurseBtn;
        private RadioButton yesNurseBtn;
        private Label label5;
        private RadioButton eCampusBtn;
        private RadioButton nsccBtn;
        private Label label6;
        private TextBox courseNameTxt;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}