namespace muhasebe
{
    partial class Kasiyer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasiyer));
            System.Windows.Forms.Label noLabel;
            System.Windows.Forms.Label İsimLabel;
            System.Windows.Forms.Label soyisimLabel;
            System.Windows.Forms.Label cepTelLabel;
            System.Windows.Forms.Label kullaniciAdiLabel;
            System.Windows.Forms.Label parolaLabel;
            this._MyDatabase_1DataSet1 = new muhasebe._MyDatabase_1DataSet1();
            this.kasiyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kasiyerTableAdapter = new muhasebe._MyDatabase_1DataSet1TableAdapters.kasiyerTableAdapter();
            this.tableAdapterManager = new muhasebe._MyDatabase_1DataSet1TableAdapters.TableAdapterManager();
            this.kasiyerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.kasiyerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kasiyerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTextBox = new System.Windows.Forms.TextBox();
            this.İsimTextBox = new System.Windows.Forms.TextBox();
            this.soyisimTextBox = new System.Windows.Forms.TextBox();
            this.cepTelTextBox = new System.Windows.Forms.TextBox();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            noLabel = new System.Windows.Forms.Label();
            İsimLabel = new System.Windows.Forms.Label();
            soyisimLabel = new System.Windows.Forms.Label();
            cepTelLabel = new System.Windows.Forms.Label();
            kullaniciAdiLabel = new System.Windows.Forms.Label();
            parolaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._MyDatabase_1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerBindingNavigator)).BeginInit();
            this.kasiyerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _MyDatabase_1DataSet1
            // 
            this._MyDatabase_1DataSet1.DataSetName = "_MyDatabase_1DataSet1";
            this._MyDatabase_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasiyerBindingSource
            // 
            this.kasiyerBindingSource.DataMember = "kasiyer";
            this.kasiyerBindingSource.DataSource = this._MyDatabase_1DataSet1;
            // 
            // kasiyerTableAdapter
            // 
            this.kasiyerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.kasiyerTableAdapter = this.kasiyerTableAdapter;
            this.tableAdapterManager.musterilerTableAdapter = null;
            this.tableAdapterManager.satislarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = muhasebe._MyDatabase_1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.urunlerTableAdapter = null;
            // 
            // kasiyerBindingNavigator
            // 
            this.kasiyerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kasiyerBindingNavigator.BindingSource = this.kasiyerBindingSource;
            this.kasiyerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kasiyerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kasiyerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kasiyerBindingNavigatorSaveItem});
            this.kasiyerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kasiyerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kasiyerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kasiyerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kasiyerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kasiyerBindingNavigator.Name = "kasiyerBindingNavigator";
            this.kasiyerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kasiyerBindingNavigator.Size = new System.Drawing.Size(570, 25);
            this.kasiyerBindingNavigator.TabIndex = 0;
            this.kasiyerBindingNavigator.Text = "bindingNavigator1";
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
            // kasiyerBindingNavigatorSaveItem
            // 
            this.kasiyerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kasiyerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kasiyerBindingNavigatorSaveItem.Image")));
            this.kasiyerBindingNavigatorSaveItem.Name = "kasiyerBindingNavigatorSaveItem";
            this.kasiyerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.kasiyerBindingNavigatorSaveItem.Text = "Save Data";
            this.kasiyerBindingNavigatorSaveItem.Click += new System.EventHandler(this.kasiyerBindingNavigatorSaveItem_Click);
            // 
            // kasiyerDataGridView
            // 
            this.kasiyerDataGridView.AutoGenerateColumns = false;
            this.kasiyerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kasiyerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.kasiyerDataGridView.DataSource = this.kasiyerBindingSource;
            this.kasiyerDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kasiyerDataGridView.Location = new System.Drawing.Point(0, 175);
            this.kasiyerDataGridView.Name = "kasiyerDataGridView";
            this.kasiyerDataGridView.Size = new System.Drawing.Size(570, 220);
            this.kasiyerDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "No";
            this.dataGridViewTextBoxColumn2.HeaderText = "No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "İsim";
            this.dataGridViewTextBoxColumn3.HeaderText = "İsim";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Soyisim";
            this.dataGridViewTextBoxColumn4.HeaderText = "Soyisim";
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
            this.dataGridViewTextBoxColumn6.DataPropertyName = "KullaniciAdi";
            this.dataGridViewTextBoxColumn6.HeaderText = "KullaniciAdi";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Parola";
            this.dataGridViewTextBoxColumn7.HeaderText = "Parola";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // noLabel
            // 
            noLabel.AutoSize = true;
            noLabel.Location = new System.Drawing.Point(54, 41);
            noLabel.Name = "noLabel";
            noLabel.Size = new System.Drawing.Size(24, 13);
            noLabel.TabIndex = 2;
            noLabel.Text = "No:";
            // 
            // noTextBox
            // 
            this.noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasiyerBindingSource, "No", true));
            this.noTextBox.Location = new System.Drawing.Point(84, 38);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.Size = new System.Drawing.Size(100, 20);
            this.noTextBox.TabIndex = 3;
            // 
            // İsimLabel
            // 
            İsimLabel.AutoSize = true;
            İsimLabel.Location = new System.Drawing.Point(50, 67);
            İsimLabel.Name = "İsimLabel";
            İsimLabel.Size = new System.Drawing.Size(28, 13);
            İsimLabel.TabIndex = 4;
            İsimLabel.Text = "İsim:";
            // 
            // İsimTextBox
            // 
            this.İsimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasiyerBindingSource, "İsim", true));
            this.İsimTextBox.Location = new System.Drawing.Point(84, 64);
            this.İsimTextBox.Name = "İsimTextBox";
            this.İsimTextBox.Size = new System.Drawing.Size(100, 20);
            this.İsimTextBox.TabIndex = 5;
            // 
            // soyisimLabel
            // 
            soyisimLabel.AutoSize = true;
            soyisimLabel.Location = new System.Drawing.Point(33, 93);
            soyisimLabel.Name = "soyisimLabel";
            soyisimLabel.Size = new System.Drawing.Size(45, 13);
            soyisimLabel.TabIndex = 6;
            soyisimLabel.Text = "Soyisim:";
            // 
            // soyisimTextBox
            // 
            this.soyisimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasiyerBindingSource, "Soyisim", true));
            this.soyisimTextBox.Location = new System.Drawing.Point(84, 90);
            this.soyisimTextBox.Name = "soyisimTextBox";
            this.soyisimTextBox.Size = new System.Drawing.Size(100, 20);
            this.soyisimTextBox.TabIndex = 7;
            // 
            // cepTelLabel
            // 
            cepTelLabel.AutoSize = true;
            cepTelLabel.Location = new System.Drawing.Point(31, 119);
            cepTelLabel.Name = "cepTelLabel";
            cepTelLabel.Size = new System.Drawing.Size(47, 13);
            cepTelLabel.TabIndex = 8;
            cepTelLabel.Text = "Cep Tel:";
            // 
            // cepTelTextBox
            // 
            this.cepTelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasiyerBindingSource, "CepTel", true));
            this.cepTelTextBox.Location = new System.Drawing.Point(84, 116);
            this.cepTelTextBox.Name = "cepTelTextBox";
            this.cepTelTextBox.Size = new System.Drawing.Size(100, 20);
            this.cepTelTextBox.TabIndex = 9;
            // 
            // kullaniciAdiLabel
            // 
            kullaniciAdiLabel.AutoSize = true;
            kullaniciAdiLabel.Location = new System.Drawing.Point(249, 53);
            kullaniciAdiLabel.Name = "kullaniciAdiLabel";
            kullaniciAdiLabel.Size = new System.Drawing.Size(67, 13);
            kullaniciAdiLabel.TabIndex = 10;
            kullaniciAdiLabel.Text = "Kullanici Adi:";
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasiyerBindingSource, "KullaniciAdi", true));
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(322, 50);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(100, 20);
            this.kullaniciAdiTextBox.TabIndex = 11;
            // 
            // parolaLabel
            // 
            parolaLabel.AutoSize = true;
            parolaLabel.Location = new System.Drawing.Point(276, 96);
            parolaLabel.Name = "parolaLabel";
            parolaLabel.Size = new System.Drawing.Size(40, 13);
            parolaLabel.TabIndex = 12;
            parolaLabel.Text = "Parola:";
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasiyerBindingSource, "Parola", true));
            this.parolaTextBox.Location = new System.Drawing.Point(322, 93);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.PasswordChar = 'X';
            this.parolaTextBox.Size = new System.Drawing.Size(100, 20);
            this.parolaTextBox.TabIndex = 13;
            // 
            // Kasiyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 395);
            this.Controls.Add(parolaLabel);
            this.Controls.Add(this.parolaTextBox);
            this.Controls.Add(kullaniciAdiLabel);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Controls.Add(cepTelLabel);
            this.Controls.Add(this.cepTelTextBox);
            this.Controls.Add(soyisimLabel);
            this.Controls.Add(this.soyisimTextBox);
            this.Controls.Add(İsimLabel);
            this.Controls.Add(this.İsimTextBox);
            this.Controls.Add(noLabel);
            this.Controls.Add(this.noTextBox);
            this.Controls.Add(this.kasiyerDataGridView);
            this.Controls.Add(this.kasiyerBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Kasiyer";
            this.Text = "Kasiyer";
            this.Load += new System.EventHandler(this.Kasiyer_Load);
            ((System.ComponentModel.ISupportInitialize)(this._MyDatabase_1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerBindingNavigator)).EndInit();
            this.kasiyerBindingNavigator.ResumeLayout(false);
            this.kasiyerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _MyDatabase_1DataSet1 _MyDatabase_1DataSet1;
        private System.Windows.Forms.BindingSource kasiyerBindingSource;
        private _MyDatabase_1DataSet1TableAdapters.kasiyerTableAdapter kasiyerTableAdapter;
        private _MyDatabase_1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kasiyerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kasiyerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kasiyerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox noTextBox;
        private System.Windows.Forms.TextBox İsimTextBox;
        private System.Windows.Forms.TextBox soyisimTextBox;
        private System.Windows.Forms.TextBox cepTelTextBox;
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.TextBox parolaTextBox;
    }
}