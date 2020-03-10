using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaWinFormsApp
{
    public partial class FormAddEntry : Form
    {
        public FormAddEntry()
        {
            InitializeComponent();
        }
        private void checkBoxPutDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPutDate.Checked)
                dateTimePickerDate.Visible = true;
            else dateTimePickerDate.Visible = false;
        }

        private void checkBoxPutTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPutTime.Checked)
                dateTimePickerTime.Visible = true;
            else dateTimePickerTime.Visible = false;
        }

        private void buttonAddEntry_Click(object sender, EventArgs e)
        {
            string date, time;
            date = time = string.Empty;
            if (dateTimePickerDate.Visible)
                date = dateTimePickerDate.Value.ToShortDateString()+"|";
            if (dateTimePickerTime.Visible)
                time = getTimeFormat(dateTimePickerTime.Value.TimeOfDay)+"|";
            string commandEntry = date + time + FormHome.textEntryToAdd;
            FormHome.appTaskManager.ExecuteCommand("ADD",commandEntry);
            Close();

        }
        private string getTimeFormat(TimeSpan dateTime)
        {
            string formatedTime;
            formatedTime = dateTime.Hours.ToString() + ":"
                + dateTime.Minutes.ToString() + ":"
                + dateTime.Seconds.ToString();
            return formatedTime;
        }
    }
}
