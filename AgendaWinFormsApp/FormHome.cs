using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaManager;
using System.Windows.Forms;


namespace AgendaWinFormsApp
{
    public partial class FormHome : Form
    {
        public static IUserClient appTaskManager;
        public static string textEntryToAdd;
        public static Dictionary<int, AgendaEntry> AgendaToDisplay { get; set; }
        public FormHome()
        {
            InitializeComponent();
            appTaskManager = new UserClientDecorator(new AppTaskManager());
            PopulateFilterComboBox();
            AgendaToDisplay = appTaskManager.GetAgendaController().GetAgenda();
        }
        private void buttonAddEntry_Click(object sender, EventArgs e)
        {
            textEntryToAdd = textBoxUserEntry.Text.ToString();
            if (textEntryToAdd.Equals(""))
            {
                MessageBox.Show("Please type an entry for the agenda", "Add Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!checkBoxTextOnly.Checked)
            {
                FormAddEntry formAdd = new FormAddEntry();
                formAdd.ShowDialog();
            }
            else appTaskManager.ExecuteCommand("ADD",textEntryToAdd);
            FormHome_Load(sender, e);
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            dataGridViewAgenda.DataSource = AgendaTableGenerator.GetDataTableAgenda(AgendaToDisplay);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewAgenda.SelectedCells.Count < 1)
            {
                MessageBox.Show("There is no selection to remove", "Remove Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int selectedRowIndex = dataGridViewAgenda.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewAgenda.Rows[selectedRowIndex];
            appTaskManager.ExecuteCommand("REMOVE",selectedRow.Cells["ID"].Value.ToString());
            FormHome_Load(sender, e);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            FormFilter formFilter = new FormFilter(comboBoxFilterOptions.GetItemText(comboBoxFilterOptions.SelectedItem) + ":");
            formFilter.ShowDialog();
            if (formFilter.returningFilterString.Equals(string.Empty))
                return;
            ActionerOfFilter.FilteringCode = (int)comboBoxFilterOptions.SelectedValue;
            appTaskManager.ExecuteCommand("FILTER",formFilter.returningFilterString);
            FormHome_Load(sender, e);
            AgendaToDisplay = appTaskManager.GetAgendaController().GetAgenda();
        }
        private void PopulateFilterComboBox()
        {
            List<FilteringOption> dataSourceComboBoxFilter = new List<FilteringOption>()
            {
                new FilteringOption(){ OptionName = "Date",OptionValue=1},
                new FilteringOption(){ OptionName = "Text",OptionValue=2}
            };
            comboBoxFilterOptions.DataSource = dataSourceComboBoxFilter;
            comboBoxFilterOptions.DisplayMember = "OptionName";
            comboBoxFilterOptions.ValueMember = "OptionValue";
            comboBoxFilterOptions.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
