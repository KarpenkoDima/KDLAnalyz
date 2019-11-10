using KDLAnalize.MainWinForms.BAL;
using KDLAnalize.MainWinForms.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDLAnalize.MainWinForms.Forms
{
    public partial class ListLogsForm : Form
    {
        int _typeAnalizeId;
        BindingSource bs;
        public ListLogsForm(int typeAnalizeId, string Name)
        {
            InitializeComponent();
            this._typeAnalizeId = typeAnalizeId;
            this.Text += " " + Name;            
            Init();
        }

        private void Init()
        {
            bs = new BindingSource();
            DB db = new DB();
            LogAnalizeReposetory repo = new LogAnalizeReposetory(db, _typeAnalizeId);
            bs.DataSource = repo.GetAll();
            dataGridViewLogs.DataSource = bs;
            
        }
        private void dataGridViewLogs_DoubleClick(object sender, EventArgs e)
        {
            SelectRow();
        }

        private void SelectRow()
        {
            int id = int.Parse(dataGridViewLogs.SelectedRows[0].Cells[0].Value.ToString());
            LogAnalisis logAnalisis = new LogAnalisis();
            logAnalisis.ShowDialog();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (buttonOpen.DialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
                buttonOpen.DialogResult = DialogResult.OK;
            }
            
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            buttonOpen.DialogResult = DialogResult.OK;
            if (dataGridViewLogs.SelectedRows.Count > 0)
            {
                SelectRow();
            }
            else
            {
                MessageBox.Show("Выберите строку", "Не выбрано ни одной строки");
                buttonOpen.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
