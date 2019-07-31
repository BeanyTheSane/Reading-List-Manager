namespace Book_Manager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStats = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookListQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.random_Book = new Book_Manager.Random_Book();
            this.btnLucky = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateRead = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.btnAdd_Book = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbSeries = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.dagdBook_List = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateReadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_ListDataSet = new Book_Manager.Book_ListDataSet();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.allBooksToolStrip = new System.Windows.Forms.ToolStrip();
            this.allBooksToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.unreadListToolStrip = new System.Windows.Forms.ToolStrip();
            this.unreadListToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.readBooksToolStrip = new System.Windows.Forms.ToolStrip();
            this.readBooksToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.book_ListTableAdapter = new Book_Manager.Book_ListDataSetTableAdapters.Book_ListTableAdapter();
            this.book_List_QueryTableAdapter = new Book_Manager.Random_BookTableAdapters.Book_List_QueryTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ckbxComplete = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.random_Book)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dagdBook_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_ListDataSet)).BeginInit();
            this.allBooksToolStrip.SuspendLayout();
            this.unreadListToolStrip.SuspendLayout();
            this.readBooksToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(994, 650);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(352, 31);
            this.btnStats.TabIndex = 9;
            this.btnStats.Text = "Statistics";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnLucky);
            this.groupBox2.Location = new System.Drawing.Point(994, 472);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 172);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Random Book Suggestion:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn2,
            this.authorDataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.bookListQueryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(339, 98);
            this.dataGridView1.TabIndex = 7;
            // 
            // titleDataGridViewTextBoxColumn2
            // 
            this.titleDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.titleDataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn2.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn2.Name = "titleDataGridViewTextBoxColumn2";
            this.titleDataGridViewTextBoxColumn2.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn2.Width = 52;
            // 
            // authorDataGridViewTextBoxColumn2
            // 
            this.authorDataGridViewTextBoxColumn2.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn2.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn2.Name = "authorDataGridViewTextBoxColumn2";
            this.authorDataGridViewTextBoxColumn2.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn2.Width = 63;
            // 
            // bookListQueryBindingSource
            // 
            this.bookListQueryBindingSource.DataMember = "Book_List Query";
            this.bookListQueryBindingSource.DataSource = this.random_Book;
            // 
            // random_Book
            // 
            this.random_Book.DataSetName = "Random_Book";
            this.random_Book.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLucky
            // 
            this.btnLucky.Location = new System.Drawing.Point(83, 124);
            this.btnLucky.Name = "btnLucky";
            this.btnLucky.Size = new System.Drawing.Size(183, 33);
            this.btnLucky.TabIndex = 8;
            this.btnLucky.Text = "Next Suggestion";
            this.btnLucky.UseVisualStyleBackColor = true;
            this.btnLucky.Click += new System.EventHandler(this.btnLucky_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbxComplete);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpDateRead);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbAuthor);
            this.groupBox1.Controls.Add(this.btnAdd_Book);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbGenre);
            this.groupBox1.Controls.Add(this.tbSeries);
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Location = new System.Drawing.Point(994, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 287);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Book Entry:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date Read:";
            // 
            // dtpDateRead
            // 
            this.dtpDateRead.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateRead.Location = new System.Drawing.Point(21, 258);
            this.dtpDateRead.Name = "dtpDateRead";
            this.dtpDateRead.Size = new System.Drawing.Size(200, 20);
            this.dtpDateRead.TabIndex = 6;
            this.dtpDateRead.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Author:";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(21, 92);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(308, 20);
            this.tbAuthor.TabIndex = 2;
            // 
            // btnAdd_Book
            // 
            this.btnAdd_Book.Location = new System.Drawing.Point(245, 224);
            this.btnAdd_Book.Name = "btnAdd_Book";
            this.btnAdd_Book.Size = new System.Drawing.Size(84, 48);
            this.btnAdd_Book.TabIndex = 7;
            this.btnAdd_Book.Text = "Add Book";
            this.btnAdd_Book.UseVisualStyleBackColor = true;
            this.btnAdd_Book.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Series:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Title:";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(21, 189);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(308, 20);
            this.tbGenre.TabIndex = 4;
            // 
            // tbSeries
            // 
            this.tbSeries.Location = new System.Drawing.Point(21, 141);
            this.tbSeries.Name = "tbSeries";
            this.tbSeries.Size = new System.Drawing.Size(308, 20);
            this.tbSeries.TabIndex = 3;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(21, 44);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(308, 20);
            this.tbTitle.TabIndex = 1;
            // 
            // dagdBook_List
            // 
            this.dagdBook_List.AllowUserToOrderColumns = true;
            this.dagdBook_List.AutoGenerateColumns = false;
            this.dagdBook_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dagdBook_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dagdBook_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.seriesDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.completeDataGridViewCheckBoxColumn,
            this.dateReadDataGridViewTextBoxColumn});
            this.dagdBook_List.DataSource = this.bookListBindingSource;
            this.dagdBook_List.Location = new System.Drawing.Point(79, 146);
            this.dagdBook_List.Name = "dagdBook_List";
            this.dagdBook_List.Size = new System.Drawing.Size(879, 498);
            this.dagdBook_List.TabIndex = 16;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 52;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 63;
            // 
            // seriesDataGridViewTextBoxColumn
            // 
            this.seriesDataGridViewTextBoxColumn.DataPropertyName = "Series";
            this.seriesDataGridViewTextBoxColumn.HeaderText = "Series";
            this.seriesDataGridViewTextBoxColumn.Name = "seriesDataGridViewTextBoxColumn";
            this.seriesDataGridViewTextBoxColumn.Width = 61;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.Width = 61;
            // 
            // completeDataGridViewCheckBoxColumn
            // 
            this.completeDataGridViewCheckBoxColumn.DataPropertyName = "Complete";
            this.completeDataGridViewCheckBoxColumn.HeaderText = "Complete";
            this.completeDataGridViewCheckBoxColumn.Name = "completeDataGridViewCheckBoxColumn";
            this.completeDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.completeDataGridViewCheckBoxColumn.Width = 76;
            // 
            // dateReadDataGridViewTextBoxColumn
            // 
            this.dateReadDataGridViewTextBoxColumn.DataPropertyName = "Date Read";
            this.dateReadDataGridViewTextBoxColumn.HeaderText = "Date Read";
            this.dateReadDataGridViewTextBoxColumn.Name = "dateReadDataGridViewTextBoxColumn";
            this.dateReadDataGridViewTextBoxColumn.Width = 84;
            // 
            // bookListBindingSource
            // 
            this.bookListBindingSource.DataMember = "Book_List";
            this.bookListBindingSource.DataSource = this.book_ListDataSet;
            // 
            // book_ListDataSet
            // 
            this.book_ListDataSet.DataSetName = "Book_ListDataSet";
            this.book_ListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(856, 650);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 31);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Save Changes";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // allBooksToolStrip
            // 
            this.allBooksToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.allBooksToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allBooksToolStripButton});
            this.allBooksToolStrip.Location = new System.Drawing.Point(630, 650);
            this.allBooksToolStrip.Name = "allBooksToolStrip";
            this.allBooksToolStrip.Size = new System.Drawing.Size(103, 25);
            this.allBooksToolStrip.TabIndex = 19;
            this.allBooksToolStrip.Text = "allBooksToolStrip";
            // 
            // allBooksToolStripButton
            // 
            this.allBooksToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.allBooksToolStripButton.Name = "allBooksToolStripButton";
            this.allBooksToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.allBooksToolStripButton.Text = "All Books";
            this.allBooksToolStripButton.ToolTipText = "Shows all of the books in your list";
            this.allBooksToolStripButton.Click += new System.EventHandler(this.allBooksToolStripButton_Click);
            // 
            // unreadListToolStrip
            // 
            this.unreadListToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.unreadListToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unreadListToolStripButton});
            this.unreadListToolStrip.Location = new System.Drawing.Point(529, 650);
            this.unreadListToolStrip.Name = "unreadListToolStrip";
            this.unreadListToolStrip.Size = new System.Drawing.Size(82, 25);
            this.unreadListToolStrip.TabIndex = 18;
            this.unreadListToolStrip.Text = "unreadListToolStrip";
            // 
            // unreadListToolStripButton
            // 
            this.unreadListToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.unreadListToolStripButton.Name = "unreadListToolStripButton";
            this.unreadListToolStripButton.Size = new System.Drawing.Size(70, 22);
            this.unreadListToolStripButton.Text = "Unread List";
            this.unreadListToolStripButton.ToolTipText = "Shows all of the unread books in your list";
            this.unreadListToolStripButton.Click += new System.EventHandler(this.unreadListToolStripButton_Click);
            // 
            // readBooksToolStrip
            // 
            this.readBooksToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.readBooksToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readBooksToolStripButton});
            this.readBooksToolStrip.Location = new System.Drawing.Point(425, 650);
            this.readBooksToolStrip.Name = "readBooksToolStrip";
            this.readBooksToolStrip.Size = new System.Drawing.Size(84, 25);
            this.readBooksToolStrip.TabIndex = 17;
            this.readBooksToolStrip.Text = "readBooksToolStrip";
            // 
            // readBooksToolStripButton
            // 
            this.readBooksToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.readBooksToolStripButton.Name = "readBooksToolStripButton";
            this.readBooksToolStripButton.Size = new System.Drawing.Size(72, 22);
            this.readBooksToolStripButton.Text = "Read Books";
            this.readBooksToolStripButton.ToolTipText = "Shows all of the read books in your list";
            this.readBooksToolStripButton.Click += new System.EventHandler(this.readBooksToolStripButton_Click);
            // 
            // book_ListTableAdapter
            // 
            this.book_ListTableAdapter.ClearBeforeFill = true;
            // 
            // book_List_QueryTableAdapter
            // 
            this.book_List_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(347, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(706, 90);
            this.label5.TabIndex = 21;
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "btnUpdate";
            this.toolTip1.ToolTipTitle = "testtitle";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(994, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Enabled = false;
            this.lblDate.Location = new System.Drawing.Point(1102, 439);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(244, 30);
            this.lblDate.TabIndex = 24;
            this.lblDate.Visible = false;
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Location = new System.Drawing.Point(748, 650);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(102, 31);
            this.btnDeleteRow.TabIndex = 11;
            this.btnDeleteRow.Text = "Delete Book";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(496, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "You can edit your Book list in the window below.  Press the Save Changes button b" +
    "elow when finished. ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(745, 689);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(486, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "You can delete Records by clicking in the very first column of a row and click th" +
    "e Delete Book button.";
            // 
            // ckbxComplete
            // 
            this.ckbxComplete.AutoSize = true;
            this.ckbxComplete.Location = new System.Drawing.Point(21, 215);
            this.ckbxComplete.Name = "ckbxComplete";
            this.ckbxComplete.Size = new System.Drawing.Size(104, 17);
            this.ckbxComplete.TabIndex = 5;
            this.ckbxComplete.Text = "Book Complete?";
            this.ckbxComplete.UseVisualStyleBackColor = true;
            this.ckbxComplete.CheckedChanged += new System.EventHandler(this.ckbxComplete_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 711);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.allBooksToolStrip);
            this.Controls.Add(this.unreadListToolStrip);
            this.Controls.Add(this.readBooksToolStrip);
            this.Controls.Add(this.dagdBook_List);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Better Book Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.random_Book)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dagdBook_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_ListDataSet)).EndInit();
            this.allBooksToolStrip.ResumeLayout(false);
            this.allBooksToolStrip.PerformLayout();
            this.unreadListToolStrip.ResumeLayout(false);
            this.unreadListToolStrip.PerformLayout();
            this.readBooksToolStrip.ResumeLayout(false);
            this.readBooksToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLucky;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd_Book;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbSeries;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.DataGridView dagdBook_List;
        private Book_ListDataSet book_ListDataSet;
        private System.Windows.Forms.BindingSource bookListBindingSource;
        private Book_ListDataSetTableAdapters.Book_ListTableAdapter book_ListTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolStrip allBooksToolStrip;
        private System.Windows.Forms.ToolStripButton allBooksToolStripButton;
        private System.Windows.Forms.ToolStrip unreadListToolStrip;
        private System.Windows.Forms.ToolStripButton unreadListToolStripButton;
        private System.Windows.Forms.ToolStrip readBooksToolStrip;
        private System.Windows.Forms.ToolStripButton readBooksToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn completeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReadDataGridViewTextBoxColumn;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Random_Book random_Book;
        private System.Windows.Forms.BindingSource bookListQueryBindingSource;
        private Random_BookTableAdapters.Book_List_QueryTableAdapter book_List_QueryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.DateTimePicker dtpDateRead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckbxComplete;
    }
}

