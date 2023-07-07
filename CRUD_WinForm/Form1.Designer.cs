namespace CRUD_WinForm
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
            this.Judul = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_idPenduduk = new System.Windows.Forms.TextBox();
            this.txbx_nama = new System.Windows.Forms.TextBox();
            this.txbx_tempatLahir = new System.Windows.Forms.TextBox();
            this.txbx_sex = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.txbx_tglLahir = new System.Windows.Forms.TextBox();
            this.Alamat = new System.Windows.Forms.Label();
            this.txbx_alamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_noTelp = new System.Windows.Forms.Label();
            this.txbx_nomorTelp = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPendudukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaLengkapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempatLahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalLahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendudukBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kTPDataSet = new CRUD_WinForm.KTPDataSet();
            this.pendudukTableAdapter = new CRUD_WinForm.KTPDataSetTableAdapters.PendudukTableAdapter();
            this.txbx_search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendudukBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kTPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Judul
            // 
            this.Judul.AutoSize = true;
            this.Judul.BackColor = System.Drawing.Color.Transparent;
            this.Judul.Font = new System.Drawing.Font("Gill Sans MT", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Judul.ForeColor = System.Drawing.Color.Black;
            this.Judul.Location = new System.Drawing.Point(626, 49);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(714, 60);
            this.Judul.TabIndex = 0;
            this.Judul.Text = "CRUD and Search Data Penduduk";
            this.Judul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Judul.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Penduduk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tempat Lahir";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nama Lengkap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 612);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 34);
            this.label5.TabIndex = 5;
            this.label5.Text = "Jenis Kelamin (L/P)";
            // 
            // txbx_idPenduduk
            // 
            this.txbx_idPenduduk.Location = new System.Drawing.Point(318, 214);
            this.txbx_idPenduduk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbx_idPenduduk.Multiline = true;
            this.txbx_idPenduduk.Name = "txbx_idPenduduk";
            this.txbx_idPenduduk.Size = new System.Drawing.Size(332, 66);
            this.txbx_idPenduduk.TabIndex = 6;
            this.txbx_idPenduduk.TextChanged += new System.EventHandler(this.txbx_nim_TextChanged);
            // 
            // txbx_nama
            // 
            this.txbx_nama.Location = new System.Drawing.Point(318, 309);
            this.txbx_nama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbx_nama.Multiline = true;
            this.txbx_nama.Name = "txbx_nama";
            this.txbx_nama.Size = new System.Drawing.Size(332, 66);
            this.txbx_nama.TabIndex = 7;
            // 
            // txbx_tempatLahir
            // 
            this.txbx_tempatLahir.Location = new System.Drawing.Point(318, 402);
            this.txbx_tempatLahir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbx_tempatLahir.Multiline = true;
            this.txbx_tempatLahir.Name = "txbx_tempatLahir";
            this.txbx_tempatLahir.Size = new System.Drawing.Size(332, 66);
            this.txbx_tempatLahir.TabIndex = 8;
            // 
            // txbx_sex
            // 
            this.txbx_sex.Location = new System.Drawing.Point(318, 598);
            this.txbx_sex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbx_sex.Multiline = true;
            this.txbx_sex.Name = "txbx_sex";
            this.txbx_sex.Size = new System.Drawing.Size(332, 66);
            this.txbx_sex.TabIndex = 9;
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.LightGreen;
            this.insert.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.insert.FlatAppearance.BorderSize = 5;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insert.Location = new System.Drawing.Point(148, 921);
            this.insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(195, 92);
            this.insert.TabIndex = 10;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // read
            // 
            this.read.BackColor = System.Drawing.Color.LightSkyBlue;
            this.read.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.read.FlatAppearance.BorderSize = 5;
            this.read.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.read.Location = new System.Drawing.Point(876, 921);
            this.read.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(195, 92);
            this.read.TabIndex = 11;
            this.read.Text = "Read";
            this.read.UseVisualStyleBackColor = false;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.IndianRed;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.delete.FlatAppearance.BorderSize = 5;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Location = new System.Drawing.Point(1469, 921);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(195, 92);
            this.delete.TabIndex = 12;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Update.FlatAppearance.BorderSize = 5;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update.Location = new System.Drawing.Point(455, 921);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(195, 92);
            this.Update.TabIndex = 13;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // txbx_tglLahir
            // 
            this.txbx_tglLahir.Location = new System.Drawing.Point(318, 504);
            this.txbx_tglLahir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbx_tglLahir.Multiline = true;
            this.txbx_tglLahir.Name = "txbx_tglLahir";
            this.txbx_tglLahir.Size = new System.Drawing.Size(332, 66);
            this.txbx_tglLahir.TabIndex = 15;
            // 
            // Alamat
            // 
            this.Alamat.AutoSize = true;
            this.Alamat.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alamat.Location = new System.Drawing.Point(35, 519);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(174, 34);
            this.Alamat.TabIndex = 14;
            this.Alamat.Text = "Tanggal Lahir";
            // 
            // txbx_alamat
            // 
            this.txbx_alamat.Location = new System.Drawing.Point(318, 698);
            this.txbx_alamat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbx_alamat.Multiline = true;
            this.txbx_alamat.Name = "txbx_alamat";
            this.txbx_alamat.Size = new System.Drawing.Size(332, 66);
            this.txbx_alamat.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 712);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 34);
            this.label6.TabIndex = 16;
            this.label6.Text = "Alamat";
            // 
            // txbx_noTelp
            // 
            this.txbx_noTelp.AutoSize = true;
            this.txbx_noTelp.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_noTelp.Location = new System.Drawing.Point(35, 812);
            this.txbx_noTelp.Name = "txbx_noTelp";
            this.txbx_noTelp.Size = new System.Drawing.Size(222, 34);
            this.txbx_noTelp.TabIndex = 18;
            this.txbx_noTelp.Text = "Nomor Telephone";
            // 
            // txbx_nomorTelp
            // 
            this.txbx_nomorTelp.Location = new System.Drawing.Point(318, 791);
            this.txbx_nomorTelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbx_nomorTelp.Multiline = true;
            this.txbx_nomorTelp.Name = "txbx_nomorTelp";
            this.txbx_nomorTelp.Size = new System.Drawing.Size(332, 66);
            this.txbx_nomorTelp.TabIndex = 19;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Salmon;
            this.Search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Search.FlatAppearance.BorderSize = 5;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Location = new System.Drawing.Point(1186, 921);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(195, 92);
            this.Search.TabIndex = 20;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPendudukDataGridViewTextBoxColumn,
            this.namaLengkapDataGridViewTextBoxColumn,
            this.tempatLahirDataGridViewTextBoxColumn,
            this.tanggalLahirDataGridViewTextBoxColumn,
            this.jenisKelaminDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.noTelpDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pendudukBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(673, 214);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1210, 549);
            this.dataGridView1.TabIndex = 21;
            // 
            // iDPendudukDataGridViewTextBoxColumn
            // 
            this.iDPendudukDataGridViewTextBoxColumn.DataPropertyName = "ID_Penduduk";
            this.iDPendudukDataGridViewTextBoxColumn.Frozen = true;
            this.iDPendudukDataGridViewTextBoxColumn.HeaderText = "ID_Penduduk";
            this.iDPendudukDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iDPendudukDataGridViewTextBoxColumn.Name = "iDPendudukDataGridViewTextBoxColumn";
            this.iDPendudukDataGridViewTextBoxColumn.Width = 200;
            // 
            // namaLengkapDataGridViewTextBoxColumn
            // 
            this.namaLengkapDataGridViewTextBoxColumn.DataPropertyName = "Nama_Lengkap";
            this.namaLengkapDataGridViewTextBoxColumn.HeaderText = "Nama_Lengkap";
            this.namaLengkapDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.namaLengkapDataGridViewTextBoxColumn.Name = "namaLengkapDataGridViewTextBoxColumn";
            this.namaLengkapDataGridViewTextBoxColumn.Width = 200;
            // 
            // tempatLahirDataGridViewTextBoxColumn
            // 
            this.tempatLahirDataGridViewTextBoxColumn.DataPropertyName = "Tempat_Lahir";
            this.tempatLahirDataGridViewTextBoxColumn.HeaderText = "Tempat_Lahir";
            this.tempatLahirDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tempatLahirDataGridViewTextBoxColumn.Name = "tempatLahirDataGridViewTextBoxColumn";
            this.tempatLahirDataGridViewTextBoxColumn.Width = 200;
            // 
            // tanggalLahirDataGridViewTextBoxColumn
            // 
            this.tanggalLahirDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Lahir";
            this.tanggalLahirDataGridViewTextBoxColumn.HeaderText = "Tanggal_Lahir";
            this.tanggalLahirDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tanggalLahirDataGridViewTextBoxColumn.Name = "tanggalLahirDataGridViewTextBoxColumn";
            this.tanggalLahirDataGridViewTextBoxColumn.Width = 200;
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            this.jenisKelaminDataGridViewTextBoxColumn.Width = 200;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 200;
            // 
            // noTelpDataGridViewTextBoxColumn
            // 
            this.noTelpDataGridViewTextBoxColumn.DataPropertyName = "No_Telp";
            this.noTelpDataGridViewTextBoxColumn.HeaderText = "No_Telp";
            this.noTelpDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.noTelpDataGridViewTextBoxColumn.Name = "noTelpDataGridViewTextBoxColumn";
            this.noTelpDataGridViewTextBoxColumn.Width = 200;
            // 
            // pendudukBindingSource
            // 
            this.pendudukBindingSource.DataMember = "Penduduk";
            this.pendudukBindingSource.DataSource = this.kTPDataSet;
            // 
            // kTPDataSet
            // 
            this.kTPDataSet.DataSetName = "KTPDataSet";
            this.kTPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pendudukTableAdapter
            // 
            this.pendudukTableAdapter.ClearBeforeFill = true;
            // 
            // txbx_search
            // 
            this.txbx_search.Location = new System.Drawing.Point(1399, 791);
            this.txbx_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbx_search.Multiline = true;
            this.txbx_search.Name = "txbx_search";
            this.txbx_search.Size = new System.Drawing.Size(265, 66);
            this.txbx_search.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(870, 812);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(402, 34);
            this.label7.TabIndex = 22;
            this.label7.Text = "Search or Delete By ID Penduduk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1108);
            this.Controls.Add(this.txbx_search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.txbx_nomorTelp);
            this.Controls.Add(this.txbx_noTelp);
            this.Controls.Add(this.txbx_alamat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbx_tglLahir);
            this.Controls.Add(this.Alamat);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.read);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.txbx_sex);
            this.Controls.Add(this.txbx_tempatLahir);
            this.Controls.Add(this.txbx_nama);
            this.Controls.Add(this.txbx_idPenduduk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Judul);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendudukBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kTPDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbx_idPenduduk;
        private System.Windows.Forms.TextBox txbx_nama;
        private System.Windows.Forms.TextBox txbx_tempatLahir;
        private System.Windows.Forms.TextBox txbx_sex;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox txbx_tglLahir;
        private System.Windows.Forms.Label Alamat;
        private System.Windows.Forms.TextBox txbx_alamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txbx_noTelp;
        private System.Windows.Forms.TextBox txbx_nomorTelp;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KTPDataSet kTPDataSet;
        private System.Windows.Forms.BindingSource pendudukBindingSource;
        private KTPDataSetTableAdapters.PendudukTableAdapter pendudukTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPendudukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaLengkapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempatLahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalLahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txbx_search;
        private System.Windows.Forms.Label label7;
    }
}

