using KDLAnalize.MainWinForms.BAL;
using KDLAnalize.MainWinForms.DAL;
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
        BindingSource bs;
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            bs = new BindingSource();
            DB db = new DB();
            TypeAnalizeReposetory repo = new TypeAnalizeReposetory(db);
            bs.DataSource = repo.GetAll();

            listBoxTypeAnalize.Items.Clear();
            listBoxTypeAnalize.DataSource = bs;
            listBoxTypeAnalize.DisplayMember = "Name";
            listBoxTypeAnalize.ValueMember = "TypeAnalizeID";

            

        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            int id = (int)(listBoxTypeAnalize.SelectedValue);
            ListLogsForm logAnalize = new ListLogsForm(id, listBoxTypeAnalize.Text);
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
