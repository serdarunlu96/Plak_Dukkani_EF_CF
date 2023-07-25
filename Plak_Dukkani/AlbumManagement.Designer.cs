namespace Plak_Dukkani
{
    partial class AlbumManagement
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
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSinger = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            txtDiscount = new TextBox();
            dtpDate = new DateTimePicker();
            label5 = new Label();
            cmbStatus = new ComboBox();
            label6 = new Label();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            dgvAlbumList = new DataGridView();
            groupBox2 = new GroupBox();
            dgvOutofSaleAlbums = new DataGridView();
            groupBox3 = new GroupBox();
            dgvOngoingAlbums = new DataGridView();
            groupBox4 = new GroupBox();
            dgvTopTenAlbums = new DataGridView();
            groupBox5 = new GroupBox();
            dgvDiscountAlbums = new DataGridView();
            btnDel = new Button();
            btnUpdt = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlbumList).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOutofSaleAlbums).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOngoingAlbums).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopTenAlbums).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiscountAlbums).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(159, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 45);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Album Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 98);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 3;
            label2.Text = "Album Singer:";
            // 
            // txtSinger
            // 
            txtSinger.Location = new Point(159, 95);
            txtSinger.Name = "txtSinger";
            txtSinger.Size = new Size(200, 23);
            txtSinger.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 153);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 5;
            label3.Text = "Album Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(159, 145);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 205);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 7;
            label4.Text = "Album Discount:";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(159, 202);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(200, 23);
            txtDiscount.TabIndex = 6;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(159, 258);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 264);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 9;
            label5.Text = "Album Date:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Yes", "No" });
            cmbStatus.Location = new Point(161, 317);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(198, 23);
            cmbStatus.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 320);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 11;
            label6.Text = "Sales Status:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(50, 382);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvAlbumList);
            groupBox1.Location = new Point(12, 430);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 263);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Album List";
            // 
            // dgvAlbumList
            // 
            dgvAlbumList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbumList.Dock = DockStyle.Fill;
            dgvAlbumList.Location = new Point(3, 19);
            dgvAlbumList.Name = "dgvAlbumList";
            dgvAlbumList.RowTemplate.Height = 25;
            dgvAlbumList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlbumList.Size = new Size(504, 241);
            dgvAlbumList.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvOutofSaleAlbums);
            groupBox2.Location = new Point(557, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(294, 322);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Out of Sale Albums";
            // 
            // dgvOutofSaleAlbums
            // 
            dgvOutofSaleAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutofSaleAlbums.Dock = DockStyle.Fill;
            dgvOutofSaleAlbums.Location = new Point(3, 19);
            dgvOutofSaleAlbums.Name = "dgvOutofSaleAlbums";
            dgvOutofSaleAlbums.RowTemplate.Height = 25;
            dgvOutofSaleAlbums.Size = new Size(288, 300);
            dgvOutofSaleAlbums.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvOngoingAlbums);
            groupBox3.Location = new Point(879, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(291, 322);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ongoing Albums";
            // 
            // dgvOngoingAlbums
            // 
            dgvOngoingAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOngoingAlbums.Dock = DockStyle.Fill;
            dgvOngoingAlbums.Location = new Point(3, 19);
            dgvOngoingAlbums.Name = "dgvOngoingAlbums";
            dgvOngoingAlbums.RowTemplate.Height = 25;
            dgvOngoingAlbums.Size = new Size(285, 300);
            dgvOngoingAlbums.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvTopTenAlbums);
            groupBox4.Location = new Point(560, 355);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(291, 335);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "The 10 most Recently Added Albums";
            // 
            // dgvTopTenAlbums
            // 
            dgvTopTenAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopTenAlbums.Dock = DockStyle.Fill;
            dgvTopTenAlbums.Location = new Point(3, 19);
            dgvTopTenAlbums.Name = "dgvTopTenAlbums";
            dgvTopTenAlbums.RowTemplate.Height = 25;
            dgvTopTenAlbums.Size = new Size(285, 313);
            dgvTopTenAlbums.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgvDiscountAlbums);
            groupBox5.Location = new Point(882, 355);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(285, 332);
            groupBox5.TabIndex = 19;
            groupBox5.TabStop = false;
            groupBox5.Text = "Albums on Sale With Discount";
            // 
            // dgvDiscountAlbums
            // 
            dgvDiscountAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiscountAlbums.Dock = DockStyle.Fill;
            dgvDiscountAlbums.Location = new Point(3, 19);
            dgvDiscountAlbums.Name = "dgvDiscountAlbums";
            dgvDiscountAlbums.RowTemplate.Height = 25;
            dgvDiscountAlbums.Size = new Size(279, 310);
            dgvDiscountAlbums.TabIndex = 0;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(161, 382);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 23);
            btnDel.TabIndex = 22;
            btnDel.Text = "DELETE";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnUpdt
            // 
            btnUpdt.Location = new Point(284, 382);
            btnUpdt.Name = "btnUpdt";
            btnUpdt.Size = new Size(75, 23);
            btnUpdt.TabIndex = 23;
            btnUpdt.Text = "UPDATE";
            btnUpdt.UseVisualStyleBackColor = true;
            btnUpdt.Click += btnUpdt_Click;
            // 
            // AlbumManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 717);
            Controls.Add(btnUpdt);
            Controls.Add(btnDel);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(cmbStatus);
            Controls.Add(label5);
            Controls.Add(dtpDate);
            Controls.Add(label4);
            Controls.Add(txtDiscount);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(txtSinger);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "AlbumManagement";
            Text = "Album Management";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlbumList).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOutofSaleAlbums).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOngoingAlbums).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTopTenAlbums).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDiscountAlbums).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtSinger;
        private Label label3;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtDiscount;
        private DateTimePicker dtpDate;
        private Label label5;
        private ComboBox cmbStatus;
        private Label label6;
        private Button btnAdd;
        private GroupBox groupBox1;
        private DataGridView dgvAlbumList;
        private GroupBox groupBox2;
        private DataGridView dgvOutofSaleAlbums;
        private GroupBox groupBox3;
        private DataGridView dgvOngoingAlbums;
        private GroupBox groupBox4;
        private DataGridView dgvTopTenAlbums;
        private GroupBox groupBox5;
        private DataGridView dgvDiscountAlbums;
        private Button button1;
        private Button btnDel;
        private Button btnUpdt;
    }
}