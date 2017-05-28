namespace muhasebe
{
    partial class Form1
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
            System.Windows.Forms.Label isimLabel;
            System.Windows.Forms.Label soyisimLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label cepTelLabel;
            System.Windows.Forms.Label tCNoLabel;
            System.Windows.Forms.Label mNoLabel;
            System.Windows.Forms.Label aktifLabel;
            System.Windows.Forms.Label parolaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.musterilerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._MyDatabase_1DataSet = new muhasebe._MyDatabase_1DataSet();
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
            this.musterilerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.musterilerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimTextBox = new System.Windows.Forms.TextBox();
            this.soyisimTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.cepTelTextBox = new System.Windows.Forms.TextBox();
            this.tCNoTextBox = new System.Windows.Forms.TextBox();
            this.mNoTextBox = new System.Windows.Forms.TextBox();
            this.aktifCheckBox = new System.Windows.Forms.CheckBox();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.musterilerTableAdapter = new muhasebe._MyDatabase_1DataSetTableAdapters.musterilerTableAdapter();
            this.tableAdapterManager = new muhasebe._MyDatabase_1DataSetTableAdapters.TableAdapterManager();
            isimLabel = new System.Windows.Forms.Label();
            soyisimLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            cepTelLabel = new System.Windows.Forms.Label();
            tCNoLabel = new System.Windows.Forms.Label();
            mNoLabel = new System.Windows.Forms.Label();
            aktifLabel = new System.Windows.Forms.Label();
            parolaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingNavigator)).BeginInit();
            this.musterilerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MyDatabase_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // isimLabel
            // 
            isimLabel.AutoSize = true;
            isimLabel.Location = new System.Drawing.Point(42, 22);
            isimLabel.Name = "isimLabel";
            isimLabel.Size = new System.Drawing.Size(28, 13);
            isimLabel.TabIndex = 2;
            isimLabel.Text = "Isim:";
            // 
            // soyisimLabel
            // 
            soyisimLabel.AutoSize = true;
            soyisimLabel.Location = new System.Drawing.Point(25, 48);
            soyisimLabel.Name = "soyisimLabel";
            soyisimLabel.Size = new System.Drawing.Size(45, 13);
            soyisimLabel.TabIndex = 4;
            soyisimLabel.Text = "Soyisim:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(24, 74);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 6;
            telefonLabel.Text = "Telefon:";
            // 
            // cepTelLabel
            // 
            cepTelLabel.AutoSize = true;
            cepTelLabel.Location = new System.Drawing.Point(23, 100);
            cepTelLabel.Name = "cepTelLabel";
            cepTelLabel.Size = new System.Drawing.Size(47, 13);
            cepTelLabel.TabIndex = 8;
            cepTelLabel.Text = "Cep Tel:";
            // 
            // tCNoLabel
            // 
            tCNoLabel.AutoSize = true;
            tCNoLabel.Location = new System.Drawing.Point(32, 126);
            tCNoLabel.Name = "tCNoLabel";
            tCNoLabel.Size = new System.Drawing.Size(38, 13);
            tCNoLabel.TabIndex = 10;
            tCNoLabel.Text = "TCNo:";
            // 
            // mNoLabel
            // 
            mNoLabel.AutoSize = true;
            mNoLabel.Location = new System.Drawing.Point(27, 22);
            mNoLabel.Name = "mNoLabel";
            mNoLabel.Size = new System.Drawing.Size(61, 13);
            mNoLabel.TabIndex = 12;
            mNoLabel.Text = "Müşteri No:";
            // 
            // aktifLabel
            // 
            aktifLabel.AutoSize = true;
            aktifLabel.Location = new System.Drawing.Point(24, 73);
            aktifLabel.Name = "aktifLabel";
            aktifLabel.Size = new System.Drawing.Size(63, 13);
            aktifLabel.TabIndex = 14;
            aktifLabel.Text = "Üyelik Aktif:";
            // 
            // parolaLabel
            // 
            parolaLabel.AutoSize = true;
            parolaLabel.Location = new System.Drawing.Point(47, 48);
            parolaLabel.Name = "parolaLabel";
            parolaLabel.Size = new System.Drawing.Size(40, 13);
            parolaLabel.TabIndex = 16;
            parolaLabel.Text = "Parola:";
            // 
            // musterilerBindingNavigator
            // 
            this.musterilerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.musterilerBindingNavigator.BindingSource = this.musterilerBindingSource;
            this.musterilerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.musterilerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.musterilerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.musterilerBindingNavigatorSaveItem});
            this.musterilerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.musterilerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.musterilerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.musterilerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.musterilerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.musterilerBindingNavigator.Name = "musterilerBindingNavigator";
            this.musterilerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.musterilerBindingNavigator.Size = new System.Drawing.Size(957, 25);
            this.musterilerBindingNavigator.TabIndex = 0;
            this.musterilerBindingNavigator.Text = "bindingNavigator1";
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
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataMember = "musteriler";
            this.musterilerBindingSource.DataSource = this._MyDatabase_1DataSet;
            // 
            // _MyDatabase_1DataSet
            // 
            this._MyDatabase_1DataSet.DataSetName = "_MyDatabase_1DataSet";
            this._MyDatabase_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // musterilerBindingNavigatorSaveItem
            // 
            this.musterilerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.musterilerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("musterilerBindingNavigatorSaveItem.Image")));
            this.musterilerBindingNavigatorSaveItem.Name = "musterilerBindingNavigatorSaveItem";
            this.musterilerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.musterilerBindingNavigatorSaveItem.Text = "Save Data";
            this.musterilerBindingNavigatorSaveItem.Click += new System.EventHandler(this.musterilerBindingNavigatorSaveItem_Click);
            // 
            // musterilerDataGridView
            // 
            this.musterilerDataGridView.AutoGenerateColumns = false;
            this.musterilerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musterilerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn8});
            this.musterilerDataGridView.DataSource = this.musterilerBindingSource;
            this.musterilerDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.musterilerDataGridView.Location = new System.Drawing.Point(0, 275);
            this.musterilerDataGridView.Name = "musterilerDataGridView";
            this.musterilerDataGridView.Size = new System.Drawing.Size(957, 298);
            this.musterilerDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Isim";
            this.dataGridViewTextBoxColumn2.HeaderText = "Isim";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Soyisim";
            this.dataGridViewTextBoxColumn3.HeaderText = "Soyisim";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CepTel";
            this.dataGridViewTextBoxColumn5.HeaderText = "CepTel";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TCNo";
            this.dataGridViewTextBoxColumn6.HeaderText = "TCNo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MNo";
            this.dataGridViewTextBoxColumn7.HeaderText = "MNo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Aktif";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Aktif";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Parola";
            this.dataGridViewTextBoxColumn8.HeaderText = "Parola";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // isimTextBox
            // 
            this.isimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "Isim", true));
            this.isimTextBox.Location = new System.Drawing.Point(76, 19);
            this.isimTextBox.Name = "isimTextBox";
            this.isimTextBox.Size = new System.Drawing.Size(151, 20);
            this.isimTextBox.TabIndex = 3;
            // 
            // soyisimTextBox
            // 
            this.soyisimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "Soyisim", true));
            this.soyisimTextBox.Location = new System.Drawing.Point(76, 45);
            this.soyisimTextBox.Name = "soyisimTextBox";
            this.soyisimTextBox.Size = new System.Drawing.Size(151, 20);
            this.soyisimTextBox.TabIndex = 5;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(76, 71);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(151, 20);
            this.telefonTextBox.TabIndex = 7;
            // 
            // cepTelTextBox
            // 
            this.cepTelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "CepTel", true));
            this.cepTelTextBox.Location = new System.Drawing.Point(76, 97);
            this.cepTelTextBox.Name = "cepTelTextBox";
            this.cepTelTextBox.Size = new System.Drawing.Size(151, 20);
            this.cepTelTextBox.TabIndex = 9;
            // 
            // tCNoTextBox
            // 
            this.tCNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "TCNo", true));
            this.tCNoTextBox.Location = new System.Drawing.Point(76, 123);
            this.tCNoTextBox.Name = "tCNoTextBox";
            this.tCNoTextBox.Size = new System.Drawing.Size(151, 20);
            this.tCNoTextBox.TabIndex = 11;
            // 
            // mNoTextBox
            // 
            this.mNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "MNo", true));
            this.mNoTextBox.Location = new System.Drawing.Point(90, 19);
            this.mNoTextBox.Name = "mNoTextBox";
            this.mNoTextBox.Size = new System.Drawing.Size(151, 20);
            this.mNoTextBox.TabIndex = 13;
            // 
            // aktifCheckBox
            // 
            this.aktifCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.musterilerBindingSource, "Aktif", true));
            this.aktifCheckBox.Location = new System.Drawing.Point(90, 68);
            this.aktifCheckBox.Name = "aktifCheckBox";
            this.aktifCheckBox.Size = new System.Drawing.Size(155, 24);
            this.aktifCheckBox.TabIndex = 15;
            this.aktifCheckBox.UseVisualStyleBackColor = true;
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "Parola", true));
            this.parolaTextBox.Location = new System.Drawing.Point(90, 45);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.PasswordChar = 'X';
            this.parolaTextBox.Size = new System.Drawing.Size(151, 20);
            this.parolaTextBox.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isimTextBox);
            this.groupBox1.Controls.Add(isimLabel);
            this.groupBox1.Controls.Add(this.soyisimTextBox);
            this.groupBox1.Controls.Add(soyisimLabel);
            this.groupBox1.Controls.Add(this.telefonTextBox);
            this.groupBox1.Controls.Add(telefonLabel);
            this.groupBox1.Controls.Add(this.cepTelTextBox);
            this.groupBox1.Controls.Add(tCNoLabel);
            this.groupBox1.Controls.Add(cepTelLabel);
            this.groupBox1.Controls.Add(this.tCNoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 159);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 240);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mNoTextBox);
            this.groupBox3.Controls.Add(parolaLabel);
            this.groupBox3.Controls.Add(mNoLabel);
            this.groupBox3.Controls.Add(this.parolaTextBox);
            this.groupBox3.Controls.Add(this.aktifCheckBox);
            this.groupBox3.Controls.Add(aktifLabel);
            this.groupBox3.Location = new System.Drawing.Point(284, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 101);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.musterilerTableAdapter = this.musterilerTableAdapter;
            this.tableAdapterManager.satislarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = muhasebe._MyDatabase_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.urunlerTableAdapter = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 573);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.musterilerDataGridView);
            this.Controls.Add(this.musterilerBindingNavigator);
            this.Name = "Form1";
            this.Text = "Müşteriler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingNavigator)).EndInit();
            this.musterilerBindingNavigator.ResumeLayout(false);
            this.musterilerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MyDatabase_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _MyDatabase_1DataSet _MyDatabase_1DataSet;
        private _MyDatabase_1DataSetTableAdapters.musterilerTableAdapter musterilerTableAdapter;
        private _MyDatabase_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator musterilerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton musterilerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView musterilerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox isimTextBox;
        private System.Windows.Forms.TextBox soyisimTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox cepTelTextBox;
        private System.Windows.Forms.TextBox tCNoTextBox;
        private System.Windows.Forms.TextBox mNoTextBox;
        private System.Windows.Forms.CheckBox aktifCheckBox;
        private System.Windows.Forms.TextBox parolaTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.BindingSource musterilerBindingSource;
    }
}

