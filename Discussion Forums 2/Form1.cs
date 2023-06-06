using System.Windows.Forms;

namespace Discussion_Forums_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int days = (int)numericUpDown.Value;
            DateTime fromDate = fromDateTimePicker.Value;
            DateTime toDate = toDateTimePicker.Value;

            if (days > 0)
            {
                toDate = fromDate.AddDays(days);
            }
            else if (days < 0)
            {
                fromDate = toDate.AddDays(days);
            }

            fromDateTimePicker.Value = fromDate;
            toDateTimePicker.Value = toDate;
            CountUpdate();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CountUpdate();
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = (int)numericUpDown.Value;
            DateTime fromDate = fromDateTimePicker.Value;
            DateTime toDate = toDateTimePicker.Value;

            count++;
            toDate = fromDate.AddDays(count);

            numericUpDown.Value = count;
            toDateTimePicker.Value = toDate;
        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = (int)numericUpDown.Value;
            DateTime fromDate = fromDateTimePicker.Value;
            DateTime toDate = toDateTimePicker.Value;

            if (count > 0)
            {
                count--; 
                toDate = fromDate.AddDays(count);

                numericUpDown.Value = count; 
                toDateTimePicker.Value = toDate;
            }
        }

        private void CountUpdate()
        {
            TimeSpan duration = toDateTimePicker.Value - fromDateTimePicker.Value;
            int days = (int)duration.TotalDays;
        }

    }
}