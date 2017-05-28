namespace muhasebe
{
    partial class hsatis
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
            System.Windows.Forms.Label fiyatLabel;
            System.Windows.Forms.Label kDVLabel;
            System.Windows.Forms.Label urunAdiLabel;
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this._MyDatabase_1DataSet = new muhasebe._MyDatabase_1DataSet();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerTableAdapter = new muhasebe._MyDatabase_1DataSetTableAdapters.urunlerTableAdapter();
            this.tableAdapterManager = new muhasebe._MyDatabase_1DataSetTableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stokDurumuCheckBox = new System.Windows.Forms.CheckBox();
            this.kDVTextBox = new System.Windows.Forms.TextBox();
            this.urunAdiTextBox = new System.Windows.Forms.TextBox();
            this.fiyatTextBox = new System.Windows.Forms.TextBox();
            this.tadet = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            fiyatLabel = new System.Windows.Forms.Label();
            kDVLabel = new System.Windows.Forms.Label();
            urunAdiLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._MyDatabase_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // fiyatLabel
            // 
            fiyatLabel.AutoSize = true;
            fiyatLabel.Location = new System.Drawing.Point(34, 50);
            fiyatLabel.Name = "fiyatLabel";
            fiyatLabel.Size = new System.Drawing.Size(43, 18);
            fiyatLabel.TabIndex = 5;
            fiyatLabel.Text = "Fiyat:";
            // 
            // kDVLabel
            // 
            kDVLabel.AutoSize = true;
            kDVLabel.Location = new System.Drawing.Point(185, 51);
            kDVLabel.Name = "kDVLabel";
            kDVLabel.Size = new System.Drawing.Size(42, 18);
            kDVLabel.TabIndex = 7;
            kDVLabel.Text = "KDV:";
            // 
            // urunAdiLabel
            // 
            urunAdiLabel.AutoSize = true;
            urunAdiLabel.Location = new System.Drawing.Point(9, 20);
            urunAdiLabel.Name = "urunAdiLabel";
            urunAdiLabel.Size = new System.Drawing.Size(68, 18);
            urunAdiLabel.TabIndex = 9;
            urunAdiLabel.Text = "Urün Adı:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 203);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(770, 246);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyUp);
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "No";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Kodu";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 280;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyatı";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adet";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tutarı";
            this.columnHeader5.Width = 137;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(10, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(318, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(98, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "ÇIKAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(160, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Kodu / Barkod";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.tadet);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 179);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kDVTextBox);
            this.groupBox3.Controls.Add(kDVLabel);
            this.groupBox3.Controls.Add(this.urunAdiTextBox);
            this.groupBox3.Controls.Add(urunAdiLabel);
            this.groupBox3.Controls.Add(this.fiyatTextBox);
            this.groupBox3.Controls.Add(fiyatLabel);
            this.groupBox3.Controls.Add(this.stokDurumuCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(9, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 82);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // stokDurumuCheckBox
            // 
            this.stokDurumuCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.urunlerBindingSource, "StokDurumu", true));
            this.stokDurumuCheckBox.Location = new System.Drawing.Point(253, 23);
            this.stokDurumuCheckBox.Name = "stokDurumuCheckBox";
            this.stokDurumuCheckBox.Size = new System.Drawing.Size(10, 15);
            this.stokDurumuCheckBox.TabIndex = 4;
            this.stokDurumuCheckBox.TabStop = false;
            this.stokDurumuCheckBox.UseVisualStyleBackColor = true;
            // 
            // kDVTextBox
            // 
            this.kDVTextBox.BackColor = System.Drawing.Color.White;
            this.kDVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunlerBindingSource, "KDV", true));
            this.kDVTextBox.Location = new System.Drawing.Point(226, 47);
            this.kDVTextBox.Name = "kDVTextBox";
            this.kDVTextBox.ReadOnly = true;
            this.kDVTextBox.Size = new System.Drawing.Size(67, 24);
            this.kDVTextBox.TabIndex = 8;
            this.kDVTextBox.TabStop = false;
            // 
            // urunAdiTextBox
            // 
            this.urunAdiTextBox.BackColor = System.Drawing.Color.White;
            this.urunAdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunlerBindingSource, "UrunAdi", true));
            this.urunAdiTextBox.Location = new System.Drawing.Point(81, 17);
            this.urunAdiTextBox.Name = "urunAdiTextBox";
            this.urunAdiTextBox.ReadOnly = true;
            this.urunAdiTextBox.Size = new System.Drawing.Size(212, 24);
            this.urunAdiTextBox.TabIndex = 10;
            this.urunAdiTextBox.TabStop = false;
            // 
            // fiyatTextBox
            // 
            this.fiyatTextBox.BackColor = System.Drawing.Color.White;
            this.fiyatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunlerBindingSource, "Fiyat", true));
            this.fiyatTextBox.Location = new System.Drawing.Point(81, 47);
            this.fiyatTextBox.Name = "fiyatTextBox";
            this.fiyatTextBox.ReadOnly = true;
            this.fiyatTextBox.Size = new System.Drawing.Size(100, 24);
            this.fiyatTextBox.TabIndex = 6;
            this.fiyatTextBox.TabStop = false;
            // 
            // tadet
            // 
            this.tadet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tadet.Location = new System.Drawing.Point(409, 23);
            this.tadet.Name = "tadet";
            this.tadet.Size = new System.Drawing.Size(55, 24);
            this.tadet.TabIndex = 4;
            this.tadet.TextChanged += new System.EventHandler(this.tadet_TextChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(463, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 26);
            this.button4.TabIndex = 3;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(368, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 26);
            this.button3.TabIndex = 2;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(543, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 178);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tutar :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(87, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 22);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "KDV :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(87, 72);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(110, 22);
            this.textBox4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Toplam :";
            // 
            // button5
            // 
            this.button5.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(17, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 60);
            this.button5.TabIndex = 6;
            this.button5.Text = "TAMAMLA";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(117, 105);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 60);
            this.button6.TabIndex = 7;
            this.button6.Text = "İPTAL ET";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // hsatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 449);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "hsatis";
            this.Text = "hsatis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.hsatis_FormClosing);
            this.Load += new System.EventHandler(this.hsatis_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._MyDatabase_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private _MyDatabase_1DataSet _MyDatabase_1DataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private _MyDatabase_1DataSetTableAdapters.urunlerTableAdapter urunlerTableAdapter;
        private _MyDatabase_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox stokDurumuCheckBox;
        private System.Windows.Forms.TextBox fiyatTextBox;
        private System.Windows.Forms.TextBox kDVTextBox;
        private System.Windows.Forms.TextBox urunAdiTextBox;
        private System.Windows.Forms.TextBox tadet;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}