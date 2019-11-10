namespace KDLAnalize.MainWinForms.Forms
{
    partial class LogAnalisis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogAnalisis));
            this.tableLayoutPanelAnalize = new System.Windows.Forms.TableLayoutPanel();
            this.bindingNavigatorAnalize = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.словриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTypeAnalize = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewLog = new System.Windows.Forms.DataGridView();
            this.splitContainerLog = new System.Windows.Forms.SplitContainer();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPatient = new System.Windows.Forms.BindingNavigator(this.components);
            this.tableLayoutPanelPatient = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxBlock = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxMedCard = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBoxDateAnalize = new System.Windows.Forms.MaskedTextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelAnalize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAnalize)).BeginInit();
            this.bindingNavigatorAnalize.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLog)).BeginInit();
            this.splitContainerLog.Panel1.SuspendLayout();
            this.splitContainerLog.Panel2.SuspendLayout();
            this.splitContainerLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPatient)).BeginInit();
            this.bindingNavigatorPatient.SuspendLayout();
            this.tableLayoutPanelPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelAnalize
            // 
            this.tableLayoutPanelAnalize.ColumnCount = 1;
            this.tableLayoutPanelAnalize.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAnalize.Controls.Add(this.tableLayoutPanelPatient, 0, 0);
            this.tableLayoutPanelAnalize.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanelAnalize.Name = "tableLayoutPanelAnalize";
            this.tableLayoutPanelAnalize.RowCount = 2;
            this.tableLayoutPanelAnalize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.40035F));
            this.tableLayoutPanelAnalize.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.59965F));
            this.tableLayoutPanelAnalize.Size = new System.Drawing.Size(479, 567);
            this.tableLayoutPanelAnalize.TabIndex = 3;
            // 
            // bindingNavigatorAnalize
            // 
            this.bindingNavigatorAnalize.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigatorAnalize.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigatorAnalize.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigatorAnalize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorAnalize.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigatorAnalize.Location = new System.Drawing.Point(0, 580);
            this.bindingNavigatorAnalize.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigatorAnalize.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigatorAnalize.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigatorAnalize.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigatorAnalize.Name = "bindingNavigatorAnalize";
            this.bindingNavigatorAnalize.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigatorAnalize.Size = new System.Drawing.Size(479, 25);
            this.bindingNavigatorAnalize.TabIndex = 0;
            this.bindingNavigatorAnalize.Text = "bindingNavigator2";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.словриToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // словриToolStripMenuItem
            // 
            this.словриToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTypeAnalize});
            this.словриToolStripMenuItem.Name = "словриToolStripMenuItem";
            this.словриToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.словриToolStripMenuItem.Text = "Словри";
            // 
            // ToolStripMenuItemTypeAnalize
            // 
            this.ToolStripMenuItemTypeAnalize.Name = "ToolStripMenuItemTypeAnalize";
            this.ToolStripMenuItemTypeAnalize.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemTypeAnalize.Text = "Тип анализа";
            // 
            // dataGridViewLog
            // 
            this.dataGridViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLog.Location = new System.Drawing.Point(0, 49);
            this.dataGridViewLog.Name = "dataGridViewLog";
            this.dataGridViewLog.Size = new System.Drawing.Size(317, 556);
            this.dataGridViewLog.TabIndex = 1;
            // 
            // splitContainerLog
            // 
            this.splitContainerLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLog.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLog.Name = "splitContainerLog";
            // 
            // splitContainerLog.Panel1
            // 
            this.splitContainerLog.Panel1.Controls.Add(this.dataGridViewLog);
            this.splitContainerLog.Panel1.Controls.Add(this.bindingNavigatorPatient);
            this.splitContainerLog.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainerLog.Panel2
            // 
            this.splitContainerLog.Panel2.Controls.Add(this.bindingNavigatorAnalize);
            this.splitContainerLog.Panel2.Controls.Add(this.tableLayoutPanelAnalize);
            this.splitContainerLog.Size = new System.Drawing.Size(800, 605);
            this.splitContainerLog.SplitterDistance = 317;
            this.splitContainerLog.TabIndex = 4;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorPatient
            // 
            this.bindingNavigatorPatient.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorPatient.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorPatient.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorPatient.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigatorPatient.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorPatient.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorPatient.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorPatient.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorPatient.Name = "bindingNavigatorPatient";
            this.bindingNavigatorPatient.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorPatient.Size = new System.Drawing.Size(317, 25);
            this.bindingNavigatorPatient.TabIndex = 0;
            this.bindingNavigatorPatient.Text = "bindingNavigator1";
            // 
            // tableLayoutPanelPatient
            // 
            this.tableLayoutPanelPatient.ColumnCount = 4;
            this.tableLayoutPanelPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.84615F));
            this.tableLayoutPanelPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.15385F));
            this.tableLayoutPanelPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanelPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanelPatient.Controls.Add(this.textBoxBlock, 3, 2);
            this.tableLayoutPanelPatient.Controls.Add(this.textBoxMiddleName, 1, 2);
            this.tableLayoutPanelPatient.Controls.Add(this.textBoxMedCard, 3, 1);
            this.tableLayoutPanelPatient.Controls.Add(this.textBoxFirstName, 1, 1);
            this.tableLayoutPanelPatient.Controls.Add(this.textBoxBirthday, 3, 0);
            this.tableLayoutPanelPatient.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelPatient.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanelPatient.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanelPatient.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanelPatient.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanelPatient.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanelPatient.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanelPatient.Controls.Add(this.maskedTextBoxDateAnalize, 1, 3);
            this.tableLayoutPanelPatient.Controls.Add(this.textBoxLastName, 1, 0);
            this.tableLayoutPanelPatient.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelPatient.Name = "tableLayoutPanelPatient";
            this.tableLayoutPanelPatient.RowCount = 5;
            this.tableLayoutPanelPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPatient.Size = new System.Drawing.Size(473, 103);
            this.tableLayoutPanelPatient.TabIndex = 7;
            // 
            // textBoxBlock
            // 
            this.textBoxBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBlock.Location = new System.Drawing.Point(349, 55);
            this.textBoxBlock.Name = "textBoxBlock";
            this.textBoxBlock.Size = new System.Drawing.Size(121, 20);
            this.textBoxBlock.TabIndex = 21;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMiddleName.Location = new System.Drawing.Point(104, 55);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(153, 20);
            this.textBoxMiddleName.TabIndex = 20;
            // 
            // textBoxMedCard
            // 
            this.textBoxMedCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMedCard.Location = new System.Drawing.Point(349, 29);
            this.textBoxMedCard.Name = "textBoxMedCard";
            this.textBoxMedCard.Size = new System.Drawing.Size(121, 20);
            this.textBoxMedCard.TabIndex = 19;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFirstName.Location = new System.Drawing.Point(104, 29);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(153, 20);
            this.textBoxFirstName.TabIndex = 18;
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBirthday.Location = new System.Drawing.Point(349, 3);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.Size = new System.Drawing.Size(121, 20);
            this.textBoxBirthday.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Возраст";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Мед карта №";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Отделение";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Дата взятия";
            // 
            // maskedTextBoxDateAnalize
            // 
            this.maskedTextBoxDateAnalize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBoxDateAnalize.Location = new System.Drawing.Point(104, 81);
            this.maskedTextBoxDateAnalize.Mask = "00/00/0000";
            this.maskedTextBoxDateAnalize.Name = "maskedTextBoxDateAnalize";
            this.maskedTextBoxDateAnalize.Size = new System.Drawing.Size(153, 20);
            this.maskedTextBoxDateAnalize.TabIndex = 15;
            this.maskedTextBoxDateAnalize.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLastName.Location = new System.Drawing.Point(104, 3);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(153, 20);
            this.textBoxLastName.TabIndex = 16;
            // 
            // LogAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.splitContainerLog);
            this.Name = "LogAnalisis";
            this.Text = "LogAnalisis";
            this.tableLayoutPanelAnalize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAnalize)).EndInit();
            this.bindingNavigatorAnalize.ResumeLayout(false);
            this.bindingNavigatorAnalize.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).EndInit();
            this.splitContainerLog.Panel1.ResumeLayout(false);
            this.splitContainerLog.Panel1.PerformLayout();
            this.splitContainerLog.Panel2.ResumeLayout(false);
            this.splitContainerLog.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLog)).EndInit();
            this.splitContainerLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPatient)).EndInit();
            this.bindingNavigatorPatient.ResumeLayout(false);
            this.bindingNavigatorPatient.PerformLayout();
            this.tableLayoutPanelPatient.ResumeLayout(false);
            this.tableLayoutPanelPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAnalize;
        private System.Windows.Forms.BindingNavigator bindingNavigatorAnalize;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem словриToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTypeAnalize;
        private System.Windows.Forms.DataGridView dataGridViewLog;
        private System.Windows.Forms.SplitContainer splitContainerLog;
        private System.Windows.Forms.BindingNavigator bindingNavigatorPatient;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPatient;
        private System.Windows.Forms.TextBox textBoxBlock;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxMedCard;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDateAnalize;
        private System.Windows.Forms.TextBox textBoxLastName;
    }
}