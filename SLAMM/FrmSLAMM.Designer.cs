namespace SLAMM
{
    partial class FrmSLAMM
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
            System.Windows.Forms.Label arrivalTimeLabel;
            System.Windows.Forms.Label datePatternLabel;
            System.Windows.Forms.Label dateVariationLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label emailNotificationLabel;
            System.Windows.Forms.Label filePatternLabel;
            System.Windows.Forms.Label functionIdLabel;
            System.Windows.Forms.Label isActiveLabel;
            System.Windows.Forms.Label isRecursiveLabel;
            System.Windows.Forms.Label marketIdLabel;
            System.Windows.Forms.Label pathLabel;
            System.Windows.Forms.Label pathIdLabel;
            System.Windows.Forms.Label timeZoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSLAMM));
            this.tblFilesRecon_LocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFilesRecon_LocationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblFilesRecon_LocationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.arrivalTimeTextBox = new System.Windows.Forms.TextBox();
            this.dateVariationTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.emailNotificationTextBox = new System.Windows.Forms.TextBox();
            this.filePatternTextBox = new System.Windows.Forms.TextBox();
            this.tblFilesReconFunctionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.isRecursiveCheckBox = new System.Windows.Forms.CheckBox();
            this.tblFilesReconMarketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathIdTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.datePatternTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.marketIdListBox = new System.Windows.Forms.ListBox();
            this.functionIdListBox = new System.Windows.Forms.ListBox();
            this.timeZoneListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            arrivalTimeLabel = new System.Windows.Forms.Label();
            datePatternLabel = new System.Windows.Forms.Label();
            dateVariationLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            emailNotificationLabel = new System.Windows.Forms.Label();
            filePatternLabel = new System.Windows.Forms.Label();
            functionIdLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            isRecursiveLabel = new System.Windows.Forms.Label();
            marketIdLabel = new System.Windows.Forms.Label();
            pathLabel = new System.Windows.Forms.Label();
            pathIdLabel = new System.Windows.Forms.Label();
            timeZoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilesRecon_LocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilesRecon_LocationBindingNavigator)).BeginInit();
            this.tblFilesRecon_LocationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilesReconFunctionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilesReconMarketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // arrivalTimeLabel
            // 
            arrivalTimeLabel.AutoSize = true;
            arrivalTimeLabel.Location = new System.Drawing.Point(28, 23);
            arrivalTimeLabel.Name = "arrivalTimeLabel";
            arrivalTimeLabel.Size = new System.Drawing.Size(65, 13);
            arrivalTimeLabel.TabIndex = 1;
            arrivalTimeLabel.Text = "Arrival Time:";
            // 
            // datePatternLabel
            // 
            datePatternLabel.AutoSize = true;
            datePatternLabel.Location = new System.Drawing.Point(28, 49);
            datePatternLabel.Name = "datePatternLabel";
            datePatternLabel.Size = new System.Drawing.Size(70, 13);
            datePatternLabel.TabIndex = 3;
            datePatternLabel.Text = "Date Pattern:";
            // 
            // dateVariationLabel
            // 
            dateVariationLabel.AutoSize = true;
            dateVariationLabel.Location = new System.Drawing.Point(28, 76);
            dateVariationLabel.Name = "dateVariationLabel";
            dateVariationLabel.Size = new System.Drawing.Size(77, 13);
            dateVariationLabel.TabIndex = 5;
            dateVariationLabel.Text = "Date Variation:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(28, 102);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Description:";
            // 
            // emailNotificationLabel
            // 
            emailNotificationLabel.AutoSize = true;
            emailNotificationLabel.Location = new System.Drawing.Point(28, 128);
            emailNotificationLabel.Name = "emailNotificationLabel";
            emailNotificationLabel.Size = new System.Drawing.Size(91, 13);
            emailNotificationLabel.TabIndex = 9;
            emailNotificationLabel.Text = "Email Notification:";
            // 
            // filePatternLabel
            // 
            filePatternLabel.AutoSize = true;
            filePatternLabel.Location = new System.Drawing.Point(28, 154);
            filePatternLabel.Name = "filePatternLabel";
            filePatternLabel.Size = new System.Drawing.Size(63, 13);
            filePatternLabel.TabIndex = 11;
            filePatternLabel.Text = "File Pattern:";
            // 
            // functionIdLabel
            // 
            functionIdLabel.AutoSize = true;
            functionIdLabel.Location = new System.Drawing.Point(28, 180);
            functionIdLabel.Name = "functionIdLabel";
            functionIdLabel.Size = new System.Drawing.Size(63, 13);
            functionIdLabel.TabIndex = 13;
            functionIdLabel.Text = "Function Id:";
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(28, 318);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(51, 13);
            isActiveLabel.TabIndex = 15;
            isActiveLabel.Text = "Is Active:";
            // 
            // isRecursiveLabel
            // 
            isRecursiveLabel.AutoSize = true;
            isRecursiveLabel.Location = new System.Drawing.Point(347, 318);
            isRecursiveLabel.Name = "isRecursiveLabel";
            isRecursiveLabel.Size = new System.Drawing.Size(69, 13);
            isRecursiveLabel.TabIndex = 9;
            isRecursiveLabel.Text = "Is Recursive:";
            // 
            // marketIdLabel
            // 
            marketIdLabel.AutoSize = true;
            marketIdLabel.Location = new System.Drawing.Point(347, 183);
            marketIdLabel.Name = "marketIdLabel";
            marketIdLabel.Size = new System.Drawing.Size(55, 13);
            marketIdLabel.TabIndex = 19;
            marketIdLabel.Text = "Market Id:";
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new System.Drawing.Point(28, 348);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new System.Drawing.Size(32, 13);
            pathLabel.TabIndex = 21;
            pathLabel.Text = "Path:";
            // 
            // pathIdLabel
            // 
            pathIdLabel.AutoSize = true;
            pathIdLabel.Location = new System.Drawing.Point(28, 374);
            pathIdLabel.Name = "pathIdLabel";
            pathIdLabel.Size = new System.Drawing.Size(44, 13);
            pathIdLabel.TabIndex = 23;
            pathIdLabel.Text = "Path Id:";
            // 
            // timeZoneLabel
            // 
            timeZoneLabel.AutoSize = true;
            timeZoneLabel.Location = new System.Drawing.Point(28, 400);
            timeZoneLabel.Name = "timeZoneLabel";
            timeZoneLabel.Size = new System.Drawing.Size(61, 13);
            timeZoneLabel.TabIndex = 25;
            timeZoneLabel.Text = "Time Zone:";
            // 
            // tblFilesRecon_LocationBindingSource
            // 
            this.tblFilesRecon_LocationBindingSource.DataSource = typeof(SLAMM.tblFilesRecon_Location);
            // 
            // tblFilesRecon_LocationBindingNavigator
            // 
            this.tblFilesRecon_LocationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblFilesRecon_LocationBindingNavigator.BindingSource = this.tblFilesRecon_LocationBindingSource;
            this.tblFilesRecon_LocationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblFilesRecon_LocationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblFilesRecon_LocationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.tblFilesRecon_LocationBindingNavigatorSaveItem});
            this.tblFilesRecon_LocationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblFilesRecon_LocationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblFilesRecon_LocationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblFilesRecon_LocationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblFilesRecon_LocationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblFilesRecon_LocationBindingNavigator.Name = "tblFilesRecon_LocationBindingNavigator";
            this.tblFilesRecon_LocationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblFilesRecon_LocationBindingNavigator.Size = new System.Drawing.Size(1273, 25);
            this.tblFilesRecon_LocationBindingNavigator.TabIndex = 0;
            this.tblFilesRecon_LocationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // tblFilesRecon_LocationBindingNavigatorSaveItem
            // 
            this.tblFilesRecon_LocationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblFilesRecon_LocationBindingNavigatorSaveItem.Enabled = false;
            this.tblFilesRecon_LocationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblFilesRecon_LocationBindingNavigatorSaveItem.Image")));
            this.tblFilesRecon_LocationBindingNavigatorSaveItem.Name = "tblFilesRecon_LocationBindingNavigatorSaveItem";
            this.tblFilesRecon_LocationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblFilesRecon_LocationBindingNavigatorSaveItem.Text = "Save Data";
            this.tblFilesRecon_LocationBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblFilesRecon_LocationBindingNavigatorSaveItem_Click);
            // 
            // arrivalTimeTextBox
            // 
            this.arrivalTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFilesRecon_LocationBindingSource, "ArrivalTime", true));
            this.arrivalTimeTextBox.Location = new System.Drawing.Point(125, 20);
            this.arrivalTimeTextBox.Name = "arrivalTimeTextBox";
            this.arrivalTimeTextBox.Size = new System.Drawing.Size(521, 20);
            this.arrivalTimeTextBox.TabIndex = 0;
            this.arrivalTimeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.arrivalTimeTextBox_Validating);
            // 
            // dateVariationTextBox
            // 
            this.dateVariationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFilesRecon_LocationBindingSource, "DateVariation", true));
            this.dateVariationTextBox.Location = new System.Drawing.Point(125, 73);
            this.dateVariationTextBox.Name = "dateVariationTextBox";
            this.dateVariationTextBox.Size = new System.Drawing.Size(521, 20);
            this.dateVariationTextBox.TabIndex = 2;
            this.dateVariationTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dateVariationTextBox_Validating);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFilesRecon_LocationBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(125, 99);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(521, 20);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // emailNotificationTextBox
            // 
            this.emailNotificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFilesRecon_LocationBindingSource, "EmailNotification", true));
            this.emailNotificationTextBox.Location = new System.Drawing.Point(125, 125);
            this.emailNotificationTextBox.Name = "emailNotificationTextBox";
            this.emailNotificationTextBox.Size = new System.Drawing.Size(521, 20);
            this.emailNotificationTextBox.TabIndex = 4;
            this.emailNotificationTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailNotificationTextBox_Validating);
            // 
            // filePatternTextBox
            // 
            this.filePatternTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFilesRecon_LocationBindingSource, "FilePattern", true));
            this.filePatternTextBox.Location = new System.Drawing.Point(125, 151);
            this.filePatternTextBox.Name = "filePatternTextBox";
            this.filePatternTextBox.Size = new System.Drawing.Size(521, 20);
            this.filePatternTextBox.TabIndex = 5;
            this.filePatternTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.filePatternTextBox_Validating);
            // 
            // tblFilesReconFunctionBindingSource
            // 
            this.tblFilesReconFunctionBindingSource.DataSource = typeof(SLAMM.tblFilesRecon_Function);
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblFilesRecon_LocationBindingSource, "IsActive", true));
            this.isActiveCheckBox.Location = new System.Drawing.Point(125, 318);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(119, 21);
            this.isActiveCheckBox.TabIndex = 8;
            this.isActiveCheckBox.Text = "Active";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // isRecursiveCheckBox
            // 
            this.isRecursiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblFilesRecon_LocationBindingSource, "IsRecursive", true));
            this.isRecursiveCheckBox.Location = new System.Drawing.Point(444, 318);
            this.isRecursiveCheckBox.Name = "isRecursiveCheckBox";
            this.isRecursiveCheckBox.Size = new System.Drawing.Size(135, 21);
            this.isRecursiveCheckBox.TabIndex = 9;
            this.isRecursiveCheckBox.Text = "Recursive";
            this.isRecursiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // tblFilesReconMarketBindingSource
            // 
            this.tblFilesReconMarketBindingSource.DataSource = typeof(SLAMM.tblFilesRecon_Market);
            // 
            // pathTextBox
            // 
            this.pathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFilesRecon_LocationBindingSource, "Path", true));
            this.pathTextBox.Location = new System.Drawing.Point(125, 345);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(521, 20);
            this.pathTextBox.TabIndex = 10;
            this.pathTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.pathTextBox_Validating);
            // 
            // pathIdTextBox
            // 
            this.pathIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFilesRecon_LocationBindingSource, "PathId", true));
            this.pathIdTextBox.Enabled = false;
            this.pathIdTextBox.Location = new System.Drawing.Point(125, 371);
            this.pathIdTextBox.Name = "pathIdTextBox";
            this.pathIdTextBox.Size = new System.Drawing.Size(521, 20);
            this.pathIdTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.CausesValidation = false;
            this.button1.Location = new System.Drawing.Point(490, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(571, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datePatternTextBox
            // 
            this.datePatternTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFilesRecon_LocationBindingSource, "DatePattern", true));
            this.datePatternTextBox.Location = new System.Drawing.Point(125, 49);
            this.datePatternTextBox.Name = "datePatternTextBox";
            this.datePatternTextBox.Size = new System.Drawing.Size(521, 20);
            this.datePatternTextBox.TabIndex = 1;
            this.datePatternTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.datePatternTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // marketIdListBox
            // 
            this.marketIdListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblFilesRecon_LocationBindingSource, "MarketId", true));
            this.marketIdListBox.DataSource = this.tblFilesReconMarketBindingSource;
            this.marketIdListBox.DisplayMember = "Market";
            this.marketIdListBox.FormattingEnabled = true;
            this.marketIdListBox.Location = new System.Drawing.Point(444, 180);
            this.marketIdListBox.Name = "marketIdListBox";
            this.marketIdListBox.Size = new System.Drawing.Size(202, 121);
            this.marketIdListBox.TabIndex = 7;
            this.marketIdListBox.ValueMember = "MarketId";
            // 
            // functionIdListBox
            // 
            this.functionIdListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblFilesRecon_LocationBindingSource, "FunctionId", true));
            this.functionIdListBox.DataSource = this.tblFilesReconFunctionBindingSource;
            this.functionIdListBox.DisplayMember = "FunctionName";
            this.functionIdListBox.FormattingEnabled = true;
            this.functionIdListBox.Location = new System.Drawing.Point(125, 180);
            this.functionIdListBox.Name = "functionIdListBox";
            this.functionIdListBox.Size = new System.Drawing.Size(202, 121);
            this.functionIdListBox.TabIndex = 6;
            this.functionIdListBox.ValueMember = "FunctionId";
            // 
            // timeZoneListBox
            // 
            this.timeZoneListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblFilesRecon_LocationBindingSource, "TimeZone", true));
            this.timeZoneListBox.FormattingEnabled = true;
            this.timeZoneListBox.Location = new System.Drawing.Point(125, 400);
            this.timeZoneListBox.Name = "timeZoneListBox";
            this.timeZoneListBox.Size = new System.Drawing.Size(197, 56);
            this.timeZoneListBox.TabIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 642);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1273, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.arrivalTimeTextBox);
            this.panel1.Controls.Add(this.timeZoneListBox);
            this.panel1.Controls.Add(timeZoneLabel);
            this.panel1.Controls.Add(this.functionIdListBox);
            this.panel1.Controls.Add(this.pathIdTextBox);
            this.panel1.Controls.Add(this.marketIdListBox);
            this.panel1.Controls.Add(pathIdLabel);
            this.panel1.Controls.Add(this.datePatternTextBox);
            this.panel1.Controls.Add(this.pathTextBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(pathLabel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(marketIdLabel);
            this.panel1.Controls.Add(arrivalTimeLabel);
            this.panel1.Controls.Add(this.isRecursiveCheckBox);
            this.panel1.Controls.Add(isRecursiveLabel);
            this.panel1.Controls.Add(datePatternLabel);
            this.panel1.Controls.Add(this.isActiveCheckBox);
            this.panel1.Controls.Add(dateVariationLabel);
            this.panel1.Controls.Add(isActiveLabel);
            this.panel1.Controls.Add(this.dateVariationTextBox);
            this.panel1.Controls.Add(functionIdLabel);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.filePatternTextBox);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(filePatternLabel);
            this.panel1.Controls.Add(emailNotificationLabel);
            this.panel1.Controls.Add(this.emailNotificationTextBox);
            this.panel1.Location = new System.Drawing.Point(28, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 593);
            this.panel1.TabIndex = 27;
            // 
            // FrmSLAMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 664);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tblFilesRecon_LocationBindingNavigator);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmSLAMM";
            this.Text = "File Recon";
            this.Load += new System.EventHandler(this.FrmSLAMM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblFilesRecon_LocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilesRecon_LocationBindingNavigator)).EndInit();
            this.tblFilesRecon_LocationBindingNavigator.ResumeLayout(false);
            this.tblFilesRecon_LocationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilesReconFunctionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilesReconMarketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblFilesRecon_LocationBindingSource;
        private System.Windows.Forms.BindingNavigator tblFilesRecon_LocationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblFilesRecon_LocationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox arrivalTimeTextBox;
        private System.Windows.Forms.TextBox dateVariationTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox emailNotificationTextBox;
        private System.Windows.Forms.TextBox filePatternTextBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.CheckBox isRecursiveCheckBox;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.TextBox pathIdTextBox;
        private System.Windows.Forms.BindingSource tblFilesReconFunctionBindingSource;
        private System.Windows.Forms.BindingSource tblFilesReconMarketBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox datePatternTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox functionIdListBox;
        private System.Windows.Forms.ListBox marketIdListBox;
        private System.Windows.Forms.ListBox timeZoneListBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}