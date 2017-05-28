namespace muhasebe
{
    partial class Form2
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
            System.Windows.Forms.Label satisKoduLabel;
            System.Windows.Forms.Label urunKoduLabel;
            System.Windows.Forms.Label mnoLabel;
            System.Windows.Forms.Label tutarLabel;
            System.Windows.Forms.Label kDVLabel;
            System.Windows.Forms.Label kasiyerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.satislarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satislarTableAdapter = new muhasebe._MyDatabase_1DataSetTableAdapters.satislarTableAdapter();
            this.tableAdapterManager = new muhasebe._MyDatabase_1DataSetTableAdapters.TableAdapterManager();
            this.satislarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.satislarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.satislarDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kasiyerTextBox = new System.Windows.Forms.TextBox();
            this.kDVTextBox = new System.Windows.Forms.TextBox();
            this.tutarTextBox = new System.Windows.Forms.TextBox();
            this.mnoTextBox = new System.Windows.Forms.TextBox();
            this.urunKoduTextBox = new System.Windows.Forms.TextBox();
            this.satisKoduTextBox = new System.Windows.Forms.TextBox();
            this._MyDatabase_1DataSet1 = new muhasebe._MyDatabase_1DataSet1();
            this._MyDatabase_1DataSet = new muhasebe._MyDatabase_1DataSet();
            satisKoduLabel = new System.Windows.Forms.Label();
            urunKoduLabel = new System.Windows.Forms.Label();
            mnoLabel = new System.Windows.Forms.Label();
            tutarLabel = new System.Windows.Forms.Label();
            kDVLabel = new System.Windows.Forms.Label();
            kasiyerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingNavigator)).BeginInit();
            this.satislarBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satislarDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._MyDatabase_1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MyDatabase_1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // satisKoduLabel
            // 
            satisKoduLabel.AutoSize = true;
            satisKoduLabel.Location = new System.Drawing.Point(20, 22);
            satisKoduLabel.Name = "satisKoduLabel";
            satisKoduLabel.Size = new System.Drawing.Size(61, 13);
            satisKoduLabel.TabIndex = 0;
            satisKoduLabel.Text = "Satis Kodu:";
            // 
            // urunKoduLabel
            // 
            urunKoduLabel.AutoSize = true;
            urunKoduLabel.Location = new System.Drawing.Point(20, 48);
            urunKoduLabel.Name = "urunKoduLabel";
            urunKoduLabel.Size = new System.Drawing.Size(61, 13);
            urunKoduLabel.TabIndex = 2;
            urunKoduLabel.Text = "Urun Kodu:";
            // 
            // mnoLabel
            // 
            mnoLabel.AutoSize = true;
            mnoLabel.Location = new System.Drawing.Point(50, 74);
            mnoLabel.Name = "mnoLabel";
            mnoLabel.Size = new System.Drawing.Size(31, 13);
            mnoLabel.TabIndex = 4;
            mnoLabel.Text = "Mno:";
            // 
            // tutarLabel
            // 
            tutarLabel.AutoSize = true;
            tutarLabel.Location = new System.Drawing.Point(265, 22);
            tutarLabel.Name = "tutarLabel";
            tutarLabel.Size = new System.Drawing.Size(35, 13);
            tutarLabel.TabIndex = 6;
            tutarLabel.Text = "Tutar:";
            // 
            // kDVLabel
            // 
            kDVLabel.AutoSize = true;
            kDVLabel.Location = new System.Drawing.Point(268, 48);
            kDVLabel.Name = "kDVLabel";
            kDVLabel.Size = new System.Drawing.Size(32, 13);
            kDVLabel.TabIndex = 8;
            kDVLabel.Text = "KDV:";
            // 
            // kasiyerLabel
            // 
            kasiyerLabel.AutoSize = true;
            kasiyerLabel.Location = new System.Drawing.Point(446, 22);
            kasiyerLabel.Name = "kasiyerLabel";
            kasiyerLabel.Size = new System.Drawing.Size(44, 13);
            kasiyerLabel.TabIndex = 10;
            kasiyerLabel.Text = "Kasiyer:";
            // 
            // satislarTableAdapter
            // 
            this.satislarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.musterilerTableAdapter = null;
            this.tableAdapterManager.satislarTableAdapter = this.satislarTableAdapter;
            this.tableAdapterManager.UpdateOrder = muhasebe._MyDatabase_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.urunlerTableAdapter = null;
            // 
            // satislarBindingNavigator
            // 
            this.satislarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.satislarBindingNavigator.BindingSource = this.satislarBindingSource;
            this.satislarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.satislarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.satislarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.satislarBindingNavigatorSaveItem});
            this.satislarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.satislarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.satislarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.satislarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.satislarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.satislarBindingNavigator.Name = "satislarBindingNavigator";
            this.satislarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.satislarBindingNavigator.Size = new System.Drawing.Size(885, 25);
            this.satislarBindingNavigator.TabIndex = 0;
            this.satislarBindingNavigator.Text = "bindingNavigator1";
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
            // satislarBindingNavigatorSaveItem
            // 
            this.satislarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.satislarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("satislarBindingNavigatorSaveItem.Image")));
            this.satislarBindingNavigatorSaveItem.Name = "satislarBindingNavigatorSaveItem";
            this.satislarBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.satislarBindingNavigatorSaveItem.Text = "Save Data";
            this.satislarBindingNavigatorSaveItem.Click += new System.EventHandler(this.satislarBindingNavigatorSaveItem_Click);
            // 
            // satislarDataGridView
            // 
            this.satislarDataGridView.AutoGenerateColumns = false;
            this.satislarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.satislarDataGridView.DataSource = this.satislarBindingSource;
            this.satislarDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.satislarDataGridView.Location = new System.Drawing.Point(0, 204);
            this.satislarDataGridView.Name = "satislarDataGridView";
            this.satislarDataGridView.Size = new System.Drawing.Size(885, 279);
            this.satislarDataGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(kasiyerLabel);
            this.groupBox1.Controls.Add(this.kasiyerTextBox);
            this.groupBox1.Controls.Add(kDVLabel);
            this.groupBox1.Controls.Add(this.kDVTextBox);
            this.groupBox1.Controls.Add(tutarLabel);
            this.groupBox1.Controls.Add(this.tutarTextBox);
            this.groupBox1.Controls.Add(mnoLabel);
            this.groupBox1.Controls.Add(this.mnoTextBox);
            this.groupBox1.Controls.Add(urunKoduLabel);
            this.groupBox1.Controls.Add(this.urunKoduTextBox);
            this.groupBox1.Controls.Add(satisKoduLabel);
            this.groupBox1.Controls.Add(this.satisKoduTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // kasiyerTextBox
            // 
            this.kasiyerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satislarBindingSource, "Kasiyer", true));
            this.kasiyerTextBox.Location = new System.Drawing.Point(496, 19);
            this.kasiyerTextBox.Name = "kasiyerTextBox";
            this.kasiyerTextBox.Size = new System.Drawing.Size(100, 20);
            this.kasiyerTextBox.TabIndex = 11;
            // 
            // kDVTextBox
            // 
            this.kDVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satislarBindingSource, "KDV", true));
            this.kDVTextBox.Location = new System.Drawing.Point(306, 45);
            this.kDVTextBox.Name = "kDVTextBox";
            this.kDVTextBox.Size = new System.Drawing.Size(100, 20);
            this.kDVTextBox.TabIndex = 9;
            // 
            // tutarTextBox
            // 
            this.tutarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satislarBindingSource, "Tutar", true));
            this.tutarTextBox.Location = new System.Drawing.Point(306, 19);
            this.tutarTextBox.Name = "tutarTextBox";
            this.tutarTextBox.Size = new System.Drawing.Size(100, 20);
            this.tutarTextBox.TabIndex = 7;
            // 
            // mnoTextBox
            // 
            this.mnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satislarBindingSource, "Mno", true));
            this.mnoTextBox.Location = new System.Drawing.Point(87, 71);
            this.mnoTextBox.Name = "mnoTextBox";
            this.mnoTextBox.Size = new System.Drawing.Size(100, 20);
            this.mnoTextBox.TabIndex = 5;
            // 
            // urunKoduTextBox
            // 
            this.urunKoduTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satislarBindingSource, "UrunKodu", true));
            this.urunKoduTextBox.Location = new System.Drawing.Point(87, 45);
            this.urunKoduTextBox.Name = "urunKoduTextBox";
            this.urunKoduTextBox.Size = new System.Drawing.Size(100, 20);
            this.urunKoduTextBox.TabIndex = 3;
            // 
            // satisKoduTextBox
            // 
            this.satisKoduTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.satislarBindingSource, "SatisKodu", true));
            this.satisKoduTextBox.Location = new System.Drawing.Point(87, 19);
            this.satisKoduTextBox.Name = "satisKoduTextBox";
            this.satisKoduTextBox.Size = new System.Drawing.Size(100, 20);
            this.satisKoduTextBox.TabIndex = 1;
            // 
            // _MyDatabase_1DataSet1
            // 
            this._MyDatabase_1DataSet1.DataSetName = "_MyDatabase_1DataSet1";
            this._MyDatabase_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _MyDatabase_1DataSet
            // 
            this._MyDatabase_1DataSet.DataSetName = "_MyDatabase_1DataSet";
            this._MyDatabase_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.satislarDataGridView);
            this.Controls.Add(this.satislarBindingNavigator);
            this.Name = "Form2";
            this.Text = "Satışlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingNavigator)).EndInit();
            this.satislarBindingNavigator.ResumeLayout(false);
            this.satislarBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satislarDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._MyDatabase_1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MyDatabase_1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource satislarBindingSource;
        private _MyDatabase_1DataSetTableAdapters.satislarTableAdapter satislarTableAdapter;
        private _MyDatabase_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator satislarBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton satislarBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView satislarDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox kasiyerTextBox;
        private System.Windows.Forms.TextBox kDVTextBox;
        private System.Windows.Forms.TextBox tutarTextBox;
        private System.Windows.Forms.TextBox mnoTextBox;
        private System.Windows.Forms.TextBox urunKoduTextBox;
        private System.Windows.Forms.TextBox satisKoduTextBox;
        private _MyDatabase_1DataSet1 _MyDatabase_1DataSet1;
        private _MyDatabase_1DataSet _MyDatabase_1DataSet;
    }
}