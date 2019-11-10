namespace KDLAnalize.MainWinForms
{
    partial class MainForm
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
            this.listBoxTypeAnalize = new System.Windows.Forms.ListBox();
            this.groupBoxTypeAnalize = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxTypeAnalize.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTypeAnalize
            // 
            this.listBoxTypeAnalize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTypeAnalize.FormattingEnabled = true;
            this.listBoxTypeAnalize.ItemHeight = 16;
            this.listBoxTypeAnalize.Items.AddRange(new object[] {
            "Клинический анализ крови",
            "Клинический анализ мочи"});
            this.listBoxTypeAnalize.Location = new System.Drawing.Point(28, 37);
            this.listBoxTypeAnalize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxTypeAnalize.Name = "listBoxTypeAnalize";
            this.listBoxTypeAnalize.Size = new System.Drawing.Size(430, 276);
            this.listBoxTypeAnalize.TabIndex = 2;
            // 
            // groupBoxTypeAnalize
            // 
            this.groupBoxTypeAnalize.Controls.Add(this.listBoxTypeAnalize);
            this.groupBoxTypeAnalize.Controls.Add(this.buttonCancel);
            this.groupBoxTypeAnalize.Controls.Add(this.buttonOk);
            this.groupBoxTypeAnalize.Location = new System.Drawing.Point(16, 18);
            this.groupBoxTypeAnalize.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBoxTypeAnalize.Name = "groupBoxTypeAnalize";
            this.groupBoxTypeAnalize.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBoxTypeAnalize.Size = new System.Drawing.Size(490, 416);
            this.groupBoxTypeAnalize.TabIndex = 1;
            this.groupBoxTypeAnalize.TabStop = false;
            this.groupBoxTypeAnalize.Text = "Выберите тип анализа";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(369, 352);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 34);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Выйти";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(28, 352);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(101, 34);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(523, 453);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxTypeAnalize);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор типа анализа";
            this.groupBoxTypeAnalize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTypeAnalize;
        private System.Windows.Forms.GroupBox groupBoxTypeAnalize;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}

