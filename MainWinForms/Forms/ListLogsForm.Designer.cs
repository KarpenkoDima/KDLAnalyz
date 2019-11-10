namespace KDLAnalize.MainWinForms.Forms
{
    partial class ListLogsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListLogsForm));
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.bsLogs = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonNewLog = new System.Windows.Forms.Button();
            this.groupBoxLogs = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLogs)).BeginInit();
            this.groupBoxLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.AllowUserToAddRows = false;
            this.dataGridViewLogs.AllowUserToDeleteRows = false;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLogs.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewLogs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridViewLogs.MultiSelect = false;
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.ReadOnly = true;
            this.dataGridViewLogs.Size = new System.Drawing.Size(665, 526);
            this.dataGridViewLogs.TabIndex = 0;
            this.dataGridViewLogs.DoubleClick += new System.EventHandler(this.dataGridViewLogs_DoubleClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(595, 606);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 28);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Выйти";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            this.buttonOpen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOpen.Location = new System.Drawing.Point(19, 606);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(87, 28);
            this.buttonOpen.TabIndex = 8;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonNewLog
            // 
            this.buttonNewLog.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewLog.Image")));
            this.buttonNewLog.Location = new System.Drawing.Point(723, 70);
            this.buttonNewLog.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonNewLog.Name = "buttonNewLog";
            this.buttonNewLog.Size = new System.Drawing.Size(146, 162);
            this.buttonNewLog.TabIndex = 7;
            this.buttonNewLog.Text = "Создать новый";
            this.buttonNewLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNewLog.UseVisualStyleBackColor = true;
            // 
            // groupBoxLogs
            // 
            this.groupBoxLogs.Controls.Add(this.dataGridViewLogs);
            this.groupBoxLogs.Location = new System.Drawing.Point(15, 47);
            this.groupBoxLogs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBoxLogs.Name = "groupBoxLogs";
            this.groupBoxLogs.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBoxLogs.Size = new System.Drawing.Size(671, 550);
            this.groupBoxLogs.TabIndex = 6;
            this.groupBoxLogs.TabStop = false;
            this.groupBoxLogs.Text = "Существующие журналы";
            // 
            // ListLogsForm
            // 
            this.AcceptButton = this.buttonOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(885, 682);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonNewLog);
            this.Controls.Add(this.groupBoxLogs);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListLogsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список журналов анализов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLogs)).EndInit();
            this.groupBoxLogs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.BindingSource bsLogs;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonNewLog;
        private System.Windows.Forms.GroupBox groupBoxLogs;
    }
}