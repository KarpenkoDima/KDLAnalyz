using KDLAnalize.MainWinForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDLAnalize.MainWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            int id = int.Parse(listBoxTypeAnalize.SelectedIndex.ToString());
            ListLogsForm logAnalize = new ListLogsForm(id);
            logAnalize.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно желаете закрыть программу?", "Закрыть программу", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
