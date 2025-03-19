namespace CIT_Capstone___Project_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Course> courseList = new List<Course>();
        int costRate;
        bool dualEnrollment;
        string courseName;
        bool eCampus;
        bool nursing;
        int creditHours;
        int techAccessFee = 10;
        int registrationFee = 31;
        int totalCost;
        int semesterFees = 21;
        int onlineAccessFee = 70;

        private void Form1_Load(object sender, EventArgs e)
        {
            courseNameTxt.Enabled = false;
            nsccBtn.Enabled = false;
            eCampusBtn.Enabled = false;
            yesNurseBtn.Enabled = false;
            noNurseBtn.Enabled = false;
            creditHrsBox.Enabled = false;
            addCourseBtn.Enabled = false;
            deleteCourseBtn.Enabled = false;
            receiptButton.Enabled = false;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != string.Empty && (inStateBtn.Checked || outStateBtn.Checked || eRateBtn.Checked) && (yesDeBtn.Checked || noDeBtn.Checked))
            {
                nameTextBox.Enabled = false;
                inStateBtn.Enabled = false;
                outStateBtn.Enabled = false;
                eRateBtn.Enabled = false;
                yesDeBtn.Enabled = false;
                noDeBtn.Enabled = false;
                confirmBtn.Enabled = false;

                courseNameTxt.Enabled = true;
                nsccBtn.Enabled = true;
                eCampusBtn.Enabled = true;
                yesNurseBtn.Enabled = true;
                noNurseBtn.Enabled = true;
                creditHrsBox.Enabled = true;
                addCourseBtn.Enabled = true;
                deleteCourseBtn.Enabled = true;
                receiptButton.Enabled = true;

                if (eRateBtn.Checked)
                {
                    nsccBtn.Enabled = false;
                    yesNurseBtn.Enabled = false;

                    eCampusBtn.Checked = true;
                    noNurseBtn.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Error! Missing Input.");
            }
        }

        private void eCampusBtn_CheckedChanged(object sender, EventArgs e)
        {
            yesNurseBtn.Enabled = false;
            noNurseBtn.Checked = true;
        }

        private void yesNurseBtn_CheckedChanged(object sender, EventArgs e)
        {
            nsccBtn.Checked = true;
            eCampusBtn.Enabled = false;
        }

        private void inPersonBtn_CheckedChanged(object sender, EventArgs e)
        {
            yesNurseBtn.Enabled = true;
        }

        private void noNurseBtn_CheckedChanged(object sender, EventArgs e)
        {
            eCampusBtn.Enabled = true;
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            if (courseNameTxt.Text != string.Empty && (nsccBtn.Checked || eCampusBtn.Checked) && (yesNurseBtn.Checked || noNurseBtn.Checked))
            {
                courseName = courseNameTxt.Text;
                if (nsccBtn.Checked)
                {
                    eCampus = false;
                }
                else
                {
                    eCampus = true;
                }
                if (yesNurseBtn.Checked)
                {
                    nursing = true;
                }
                else
                {
                    nursing = false;
                }
                creditHours = (int)creditHrsBox.Value;

                Course newCourse = new Course(courseName, eCampus, nursing, creditHours);

                courseListBox.Items.Add(newCourse.CourseName);
                courseList.Add(newCourse);

                courseNameTxt.Text = string.Empty;
                nsccBtn.Checked = false;
                eCampusBtn.Checked = false;
                yesNurseBtn.Checked = false;
                noNurseBtn.Checked = false;
                creditHrsBox.Value = 1;

                if (eRateBtn.Checked)
                {
                    eCampusBtn.Checked = true;
                    noNurseBtn.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Error: Missing Input.");
            }
        }

        private void deleteCourseBtn_Click(object sender, EventArgs e)
        {
            var p = courseListBox.SelectedIndex;
            var i = courseListBox.Text;
            courseList.RemoveAt(p);
            courseListBox.Items.Remove(i);

            courseListBox.Items.Clear();
            foreach (Course elements in courseList)
            {
                courseListBox.Items.Add(elements.CourseName);
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            int totalCreditHours = 0;
            int totalNurseHours = 0;

            foreach (Course elements in courseList)
            {
                if (elements.Nursing == true)
                {
                    totalNurseHours += elements.CreditHours;
                }

                totalCreditHours += elements.CreditHours;
            }

            if (inStateBtn.Checked)
            {

                int nurseTotal = totalNurseHours * 25;

                costRate = 176;
                techAccessFee *= totalCreditHours;
                registrationFee *= totalCreditHours;
                totalCost = costRate * totalCreditHours;
                totalCost += techAccessFee;
                totalCost += nurseTotal;
                totalCost += registrationFee;
                if (totalCreditHours >= 12)
                {
                    totalCost = costRate * 12;
                    techAccessFee = 116;
                    registrationFee = 137;
                    int creditDiff = totalCreditHours - 12;
                    creditDiff *= 38;
                    totalCost += creditDiff;
                    totalCost += techAccessFee;
                    totalCost += nurseTotal;
                }


            }
            if (outStateBtn.Checked)
            {

                int nurseTotal = totalNurseHours * 25;

                costRate = 726;
                techAccessFee *= totalCreditHours;
                registrationFee *= totalCreditHours;
                totalCost = costRate * totalCreditHours;
                totalCost += techAccessFee;
                totalCost += registrationFee;
                totalCost += nurseTotal;
                if (totalCreditHours >= 12)
                {
                    totalCost = costRate * 12;
                    techAccessFee = 116;
                    registrationFee = 137;
                    int creditDiff = totalCreditHours - 12;
                    creditDiff *= 148;
                    totalCost += creditDiff;
                    totalCost += techAccessFee;
                    totalCost += registrationFee;
                    totalCost += nurseTotal;
                }
            }
            if (eRateBtn.Checked)
            {



                costRate = 264;
                onlineAccessFee *= totalCreditHours;
                totalCost = costRate * totalCreditHours;
                totalCost += onlineAccessFee;

            }
            if (noDeBtn.Checked)
            {
                dualEnrollment = false;
                totalCost += semesterFees;
            }
            MessageBox.Show("Name: " + nameTextBox.Text + 
                "\r\nDual Enrolled: " + dualEnrollment +
                "\r\nTechnology Aceess Fee: " + techAccessFee +
                "\r\nRegistration Fees: " + registrationFee +
                "\r\nSemester Fees: " + semesterFees +
                "\r\nTotal Cost including fees: " + totalCost.ToString("C"), "Receipt");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}