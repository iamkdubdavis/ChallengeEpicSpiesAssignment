using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //DateTime prevAssignDate = firstCalendar.SelectedDate = DateTime.Parse("9/2/2015");
                //DateTime newAssignStartDate = secondCalendar.SelectedDate = DateTime.Parse("9/16/2015");
                //DateTime newAssignEndDate = thirdCalendar.SelectedDate = DateTime.Parse("9/23/2015");
                firstCalendar.SelectedDate = DateTime.Now.Date;
                secondCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                thirdCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = " ";
            int totalDays = 0;

            DateTime prevAssignDay = firstCalendar.SelectedDate;
            int dayOne = prevAssignDay.DayOfYear;
            DateTime newAssignStartDay = secondCalendar.SelectedDate;
            int dayTwo = newAssignStartDay.DayOfYear;
            DateTime newAssignEndDay = thirdCalendar.SelectedDate;
            int dayThree = newAssignEndDay.DayOfYear;

            if (dayTwo - dayOne < 14)
            {
                resultLabel.Text = "Error: Must allow at least two weeks between previouse assignment and new assignment.";
                
            }
            else
            {
                totalDays = dayThree - dayTwo;
                int totalBudget = totalDays * 500;
                if (dayThree - dayTwo > 21)
                {
                    totalBudget += 1000;
                }
                resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget Total: {2:C}",
                    spyTextBox.Text,
                    assignmentTextBox.Text,
                    totalBudget);
            }
        }
    }
}