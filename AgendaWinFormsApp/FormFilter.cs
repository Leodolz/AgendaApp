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
    public partial class FormFilter : Form
    {
        public string returningFilterString = string.Empty;
        public FormFilter(string label)
        {
            InitializeComponent();
            labelFilter.Text = label;
            if (label.StartsWith("Date"))
                dateTimePickerIfDate.Visible = true;
            else if (label.StartsWith("Text"))
                textBoxIfText.Visible = true;
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (dateTimePickerIfDate.Visible)
                returningFilterString = dateTimePickerIfDate.Value.ToShortDateString();
            else if (textBoxIfText.Visible)
                returningFilterString = textBoxIfText.Text;
            Close();
        }
    }
}
