using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bijslag
{
    public partial class Form1 : Form
    {
        private List<Child> children = new List<Child>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            Child newStudent = new Child(this.StudentNameBox.Text, this.StudentBirthdayPicker.Value.Date);
            this.children.Add(newStudent);

            this.StudentList.Rows.Add(newStudent.name, newStudent.birthday.Date.ToString("yyyy-MM-dd"));
        }

        private void RemoveStudentButton_Click(object sender, EventArgs e)
        {
            if (this.children.Count > 0)
            {
                int index = this.StudentList.CurrentCell.RowIndex;

                this.children.RemoveAt(index);
                this.StudentList.Rows.RemoveAt(index);
            }
        }

        private void StartCalcButton_Click(object sender, EventArgs e)
        {
            this.InfoGridView.Rows.Clear();

            double benefits = 0;

            int olderThanTwelveCount = 0;
            double olderThanTwelveBenefit = 0;

            int youngerThanTwelveCount = 0;
            double youngerThanTwelveBenefit = 0;

            foreach (Child child in this.children)
            {
                DateTime now = DateTime.Now;
                TimeSpan twelveYears = now.AddYears(12) - now;
                TimeSpan eighteenYears = now.AddYears(18) - now;

                if (
                    (this.RefDatePicker.Value.Date - child.birthday) >= twelveYears &&
                    (this.RefDatePicker.Value.Date - child.birthday) < eighteenYears
                )
                {
                    olderThanTwelveCount++;
                }
                else
                {
                    youngerThanTwelveCount++;
                }
            }

            if (olderThanTwelveCount > 0)
            {
                olderThanTwelveBenefit = olderThanTwelveCount * 235;
                this.InfoGridView.Rows.Add(">12 child benefits", "\u20AC" + string.Format("{0:f2}", Math.Round(olderThanTwelveBenefit, 2)));
            }
            if (youngerThanTwelveCount > 0)
            {
                youngerThanTwelveBenefit = youngerThanTwelveCount * 150;
                this.InfoGridView.Rows.Add("<12 child benefits", "\u20AC" + string.Format("{0:f2}", Math.Round(youngerThanTwelveBenefit, 2)));
            }

            benefits += olderThanTwelveBenefit + youngerThanTwelveBenefit;
            this.InfoGridView.Rows.Add("Benefits without storage percentage", "\u20AC" + string.Format("{0:f2}", Math.Round(benefits, 2)));
            double storagePercentageModifier = 1;
            switch (olderThanTwelveCount + youngerThanTwelveCount)
            {
                case 1:
                case 2:
                    storagePercentageModifier = 1;
                    break;
                case 3:
                case 4:
                    storagePercentageModifier = 1.02;
                    break;
                case 5:
                    storagePercentageModifier = 1.03;
                    break;
                default:
                    storagePercentageModifier = 1.035;
                    break;
            }

            this.InfoGridView.Rows.Add("Total benefits", "\u20AC" + string.Format("{0:f2}", Math.Round(benefits * storagePercentageModifier, 2)));
        }
    }

    public class Child
    {
        public string name;
        public DateTime birthday;

        public Child(string name, DateTime birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }
    }
}
