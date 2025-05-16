using System;
using System.Windows.Forms;

namespace EMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTimePickerEMI.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 10);
            DateTimePickerEMI.Enabled = false;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                var interestRateYearlyFirstDate = DateTimePickerInterestRateFirst.Value;
                var interestRateYearlySecondDate = DateTimePickerInterestRateSecond.Value;
                var interestRateYearlyThirdDate = DateTimePickerInterestRateThird.Value;


                var emi = decimal.Parse(textEMI.Text);

                var principalAmount = decimal.Parse(textBoxOpeningBalance.Text);
                var emiDate = DateTimePickerEMI.Value;
                var todayDay = DateTime.Today.Day;
                var lastEmiDate = todayDay > 10 ? emiDate : DateTimePickerEMI.Value.AddMonths(-1);
                //var comingEmiDate= todayDay == (DateTimePickerEMI.Value.AddMonths(+1)) ? emiDate : DateTimePickerEMI.Value.AddMonths(+1);
                var totalDaysPreviousDate = (interestRateYearlyFirstDate - lastEmiDate).Days;
                var interestRateYearlyPrevious = decimal.Parse(textBoxPreviousInterest.Text);
                var interestRatePerDayPrevious = Math.Round(interestRateYearlyPrevious / 365, 9);
                var interestPerDayPrevious = Math.Round(interestRatePerDayPrevious / 100, 9);
                var finalInterestPrevious =
                    Math.Round(totalDaysPreviousDate * interestPerDayPrevious * principalAmount, 2);


                decimal finalInterestFirst = 0;
                decimal finalInterestSecond = 0;
                decimal finalInterestThird = 0;

                if (!string.IsNullOrEmpty(textBoxInterestRateFirst.Text))
                {
                    var interestRateYearlyFirst = decimal.Parse(textBoxInterestRateFirst.Text);
                    var totalDaysFirstDate = (interestRateYearlySecondDate - interestRateYearlyFirstDate).Days;
                    var interestRatePerDayFirst = Math.Round(interestRateYearlyFirst / 365, 9);
                    var interestPerDayFirst = Math.Round(interestRatePerDayFirst / 100, 9);
                    finalInterestFirst = Math.Round(interestPerDayFirst * totalDaysFirstDate * principalAmount, 2);

                    if (!string.IsNullOrEmpty(textBoxInterestRateSecond.Text))
                    {
                        var totalDaysSecondDate = (interestRateYearlyThirdDate - interestRateYearlySecondDate).Days;
                        var interestRateYearlySecond = decimal.Parse(textBoxInterestRateSecond.Text);
                        var interestRatePerDaySecond = Math.Round(interestRateYearlySecond / 365, 9);
                        var interestPerDaySecond = Math.Round(interestRatePerDaySecond / 100, 9);
                        finalInterestSecond =
                            Math.Round(interestPerDaySecond * totalDaysSecondDate * principalAmount, 2);

                        if (!string.IsNullOrEmpty(textBoxInterestRateThird.Text))
                        {
                            var totalDaysThirdDate = (DateTime.Today - interestRateYearlyThirdDate).Days;
                            var interestRateYearlyThird = decimal.Parse(textBoxInterestRateThird.Text);
                            var interestRatePerDayThird = Math.Round(interestRateYearlyThird / 365, 9);
                            var interestPerDayThird = Math.Round(interestRatePerDayThird / 100, 9);
                            finalInterestThird = Math.Round(interestPerDayThird * totalDaysThirdDate * principalAmount,
                                2);
                        }
                    }
                }


                var finalInterest = finalInterestPrevious + finalInterestFirst + finalInterestSecond +
                                    finalInterestThird;
                var amount = emi - finalInterest;
                MessageBox.Show(@"Total interest: " + finalInterest + @", principal: " + amount, @"EMI Calculator",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Please input valid parameters", @"EMI Calculator", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}