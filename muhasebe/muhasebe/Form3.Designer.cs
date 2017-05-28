namespace muhasebe
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label urunAdiLabel;
            System.Windows.Forms.Label urunKoduLabel;
            System.Windows.Forms.Label barkodLabel;
            System.Windows.Forms.Label stokDurumuLabel;
            System.Windows.Forms.Label fiyatLabel;
            System.Windows.Forms.Label kDVLabel;
            System.Windows.Forms.Label ozelFiyatLabel;
            this._MyDatabase_1DataSet = new muhasebe._MyDatabase_1DataSet();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerTableAdapter = new muhasebe._MyDatabase_1DataSetTableAdapters.urunlerTableAdapter();
            this.tableAdapterManager = new muhasebe._MyDatabase_1DataSetTableAdapters.TableAdapterManager();
            this.urunlerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.urunlerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.urunlerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.urunAdiTextBox = new System.Windows.Forms.TextBox();
            this.urunKoduTextBox = new System.Windows.Forms.TextBox();
            this.barkodTextBox = new System.Windows.Forms.TextBox();
            this.stokDurumuCheckBox = new System.Windows.Forms.CheckBox();
            this.fiyatTextBox = new System.Windows.Forms.TextBox();
            this.kDVTextBox = new System.Windows.Forms.TextBox();
            this.ozelFiyatTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            urunAdiLabel = new System.Windows.Forms.Label();
            urunKoduLabel = new System.Windows.Forms.Label();
            barkodLabel = new System.Windows.Forms.Label();
            stokDurumuLabel = new System.Windows.Forms.Label();
            fiyatLabel = new System.Windows.Forms.Label();
            kDVLabel = new System.Windows.Forms.Label();
            ozelFiyatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._MyDatabase_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingNavigator)).BeginInit();
            this.urunlerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _MyDatabase_1DataSet
            // 
            this._MyDatabase_1DataSet.DataSetName = "_MyDatabase_1DataSet";
            this._MyDatabase_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "urunler";
            this.urunlerBindingSource.DataSource = this._MyDatabase_1DataSet;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.musterilerTableAdapter = null;
            this.tableAdapterManager.satislarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = muhasebe._MyDatabase_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.urunlerTableAdapter = this.urunlerTableAdapter;
            // 
            // urunlerBindingNavigator
            // 
            this.urunlerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.urunlerBindingNavigator.BindingSource = this.urunlerBindingSource;
            this.urunlerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.urunlerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.urunlerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.urunlerBindingNavigatorSaveItem});
            this.urunlerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.urunlerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.urunlerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.urunlerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.urunlerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.urunlerBindingNavigator.Name = "urunlerBindingNavigator";
            this.urunlerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.urunlerBindingNavigator.Size = new System.Drawing.Size(854, 25);
            this.urunlerBindingNavigator.TabIndex = 0;
            this.urunlerBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // urunlerBindingNavigatorSaveItem
            // 
            this.urunlerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.urunlerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("urunlerBindingNavigatorSaveItem.Image")));
            this.urunlerBindingNavigatorSaveItem.Name = "urunlerBindingNavigatorSaveItem";
            this.urunlerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.urunlerBindingNavigatorSaveItem.Text = "Save Data";
            this.urunlerBindingNavigatorSaveItem.Click += new System.EventHandler(this.urunlerBindingNavigatorSaveItem_Click);
            // 
            // urunlerDataGridView
            // 
            this.urunlerDataGridView.AutoGenerateColumns = false;
            this.urunlerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunlerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.urunlerDataGridView.DataSource = this.urunlerBindingSource;
            this.urunlerDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.urunlerDataGridView.Location = new System.Drawing.Point(0, 205);
            this.urunlerDataGridView.Name = "urunlerDataGridView";
            this.urunlerDataGridView.Size = new System.Drawing.Size(854, 279);
            this.urunlerDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UrunAdi";
            this.dataGridViewTextBoxColumn2.HeaderText = "UrunAdi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UrunKodu";
            this.dataGridViewTextBoxColumn3.HeaderText = "UrunKodu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Barkod";
            this.dataGridViewTextBoxColumn4.HeaderText = "Barkod";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "StokDurumu";
            this.dataGridViewCheckBoxColumn1.HeaderText = "StokDurumu";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fiyat";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fiyat";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "KDV";
            this.dataGridViewTextBoxColumn6.HeaderText = "KDV";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OzelFiyat";
            this.dataGridViewTextBoxColumn7.HeaderText = "OzelFiyat";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(ozelFiyatLabel);
            this.groupBox1.Controls.Add(this.ozelFiyatTextBox);
            this.groupBox1.Controls.Add(kDVLabel);
            this.groupBox1.Controls.Add(this.kDVTextBox);
            this.groupBox1.Controls.Add(fiyatLabel);
            this.groupBox1.Controls.Add(this.fiyatTextBox);
            this.groupBox1.Controls.Add(stokDurumuLabel);
            this.groupBox1.Controls.Add(this.stokDurumuCheckBox);
            this.groupBox1.Controls.Add(urunKoduLabel);
            this.groupBox1.Controls.Add(this.urunKoduTextBox);
            this.groupBox1.Controls.Add(urunAdiLabel);
            this.groupBox1.Controls.Add(this.urunAdiTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // urunAdiLabel
            // 
            urunAdiLabel.AutoSize = true;
            urunAdiLabel.Location = new System.Drawing.Point(39, 22);
            urunAdiLabel.Name = "urunAdiLabel";
            urunAdiLabel.Size = new System.Drawing.Size(51, 13);
            urunAdiLabel.TabIndex = 0;
            urunAdiLabel.Text = "Urun Adi:";
            // 
            // urunAdiTextBox
            // 
            this.urunAdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunlerBindingSource, "UrunAdi", true));
            this.urunAdiTextBox.Location = new System.Drawing.Point(96, 19);
            this.urunAdiTextBox.Name = "urunAdiTextBox";
            this.urunAdiTextBox.Size = new System.Drawing.Size(100, 20);
            this.urunAdiTextBox.TabIndex = 1;
            // 
            // urunKoduLabel
            // 
            urunKoduLabel.AutoSize = true;
            urunKoduLabel.Location = new System.Drawing.Point(29, 48);
            urunKoduLabel.Name = "urunKoduLabel";
            urunKoduLabel.Size = new System.Drawing.Size(61, 13);
            urunKoduLabel.TabIndex = 2;
            urunKoduLabel.Text = "Urun Kodu:";
            // 
            // urunKoduTextBox
            // 
            this.urunKoduTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunlerBindingSource, "UrunKodu", true));
            this.urunKoduTextBox.Location = new System.Drawing.Point(96, 45);
            this.urunKoduTextBox.Name = "urunKoduTextBox";
            this.urunKoduTextBox.Size = new System.Drawing.Size(100, 20);
            this.urunKoduTextBox.TabIndex = 3;
            // 
            // barkodLabel
            // 
            barkodLabel.AutoSize = true;
            barkodLabel.Location = new System.Drawing.Point(46, 22);
            barkodLabel.Name = "barkodLabel";
            barkodLabel.Size = new System.Drawing.Size(44, 13);
            barkodLabel.TabIndex = 4;
            barkodLabel.Text = "Barkod:";
            // 
            // barkodTextBox
            // 
            this.barkodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunlerBindingSource, "Barkod", true));
            this.barkodTextBox.Location = new System.Drawing.Point(96, 19);
            this.barkodTextBox.Name = "barkodTextBox";
            this.barkodTextBox.Size = new System.Drawing.Size(241, 20);
            this.barkodTextBox.TabIndex = 5;
            // 
            // stokDurumuLabel
            // 
            stokDurumuLabel.AutoSize = true;
            stokDurumuLabel.Location = new System.Drawing.Point(18, 76);
            stokDurumuLabel.Name = "stokDurumuLabel";
            stokDurumuLabel.Size = new System.Drawing.Size(72, 13);
            stokDurumuLabel.TabIndex = 6;
            stokDurumuLabel.Text = "Stok Durumu:";
            // 
            // stokDurumuCheckBox
            // 
            this.stokDurumuCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.urunlerBindingSource, "StokDurumu", true));
            this.stokDurumuCheckBox.Location = new System.Drawing.Point(96, 71);
            this.stokDurumuCheckBox.Name = "stokDurumuCheckBox";
            this.stokDurumuCheckBox.Size = new System.Drawing.Size(104, 24);
            this.stokDurumuCheckBox.TabIndex = 7;
            this.stokDurumuCheckBox.UseVisualStyleBackColor = true;
            // 
            // fiyatLabel
            // 
            fiyatLabel.AutoSize = true;
            fiyatLabel.Location = new System.Drawing.Point(238, 22);
            fiyatLabel.Name = "fiyatLabel";
            fiyatLabel.Size = new System.Drawing.Size(32, 13);
            fiyatLabel.TabIndex = 8;
            fiyatLabel.Text = "Fiyat:";
            // 
            // fiyatTextBox
            // 
            this.fiyatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunlerBindingSource, "Fiyat", true));
            this.fiyatTextBox.Location = new System.Drawing.Point(276, 19);
            this.fiyatTextBox.Name = "fiyatTextBox";
            this.fiyatTextBox.Size = new System.Drawing.Size(100, 20);
            this.fiyatTextBox.TabIndex = 9;
            // 
            // kDVLabel
            // 
            kDVLabel.AutoSize = true;
            kDVLabel.Location = new System.Drawing.Point(238, 48);
            kDVLabel.Name = "kDVLabel";
            kDVLabel.Size = new System.Drawing.Size(32, 13);
            kDVLabel.TabIndex = 10;
            kDVLabel.Text = "KDV:";
            // 
            // kDVTextBox
            // 
            this.kDVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunlerBindingSource, "KDV", true));
            this.kDVTextBox.Location = new System.Drawing.Point(276, 45);
            this.kDVTextBox.Name = "kDVTextBox";
            this.kDVTextBox.Size = new System.Drawing.Size(100, 20);
            this.kDVTextBox.TabIndex = 11;
            // 
            // ozelFiyatLabel
            // 
            ozelFiyatLabel.AutoSize = true;
            ozelFiyatLabel.Location = new System.Drawing.Point(214, 76);
            ozelFiyatLabel.Name = "ozelFiyatLabel";
            ozelFiyatLabel.Size = new System.Drawing.Size(56, 13);
            ozelFiyatLabel.TabIndex = 12;
            ozelFiyatLabel.Text = "Ozel Fiyat:";
            // 
            // ozelFiyatTextBox
            // 
            this.ozelFiyatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunlerBindingSource, "OzelFiyat", true));
            this.ozelFiyatTextBox.Location = new System.Drawing.Point(276, 73);
            this.ozelFiyatTextBox.Name = "ozelFiyatTextBox";
            this.ozelFiyatTextBox.Size = new System.Drawing.Size(100, 20);
            this.ozelFiyatTextBox.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.barkodTextBox);
            this.groupBox2.Controls.Add(barkodLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 50);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.urunlerDataGridView);
            this.Controls.Add(this.urunlerBindingNavigator);
            this.Name = "Form3";
            this.Text = "Ürünler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this._MyDatabase_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingNavigator)).EndInit();
            this.urunlerBindingNavigator.ResumeLayout(false);
            this.urunlerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _MyDatabase_1DataSet _MyDatabase_1DataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private _MyDatabase_1DataSetTableAdapters.urunlerTableAdapter urunlerTableAdapter;
        private _MyDatabase_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator urunlerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton urunlerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView urunlerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fiyatTextBox;
        private System.Windows.Forms.CheckBox stokDurumuCheckBox;
        private System.Windows.Forms.TextBox barkodTextBox;
        private System.Windows.Forms.TextBox urunKoduTextBox;
        private System.Windows.Forms.TextBox urunAdiTextBox;
        private System.Windows.Forms.TextBox ozelFiyatTextBox;
        private System.Windows.Forms.TextBox kDVTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}