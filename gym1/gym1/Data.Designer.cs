namespace gym1
{
    partial class Data
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Addbt = new System.Windows.Forms.Button();
            this.Paybt = new System.Windows.Forms.Button();
            this.Logoutbt = new System.Windows.Forms.Button();
            this.Databt = new System.Windows.Forms.Button();
            this.Delebt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.memberTb2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDbDataSet = new gym1.GymDbDataSet();
            this.memberTb2TableAdapter = new gym1.GymDbDataSetTableAdapters.MemberTb2TableAdapter();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.mIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mLastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resettb = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberTb2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.Addbt);
            this.panel1.Controls.Add(this.Paybt);
            this.panel1.Controls.Add(this.Logoutbt);
            this.panel1.Controls.Add(this.Databt);
            this.panel1.Controls.Add(this.Delebt);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 748);
            this.panel1.TabIndex = 19;
            // 
            // Addbt
            // 
            this.Addbt.FlatAppearance.BorderSize = 0;
            this.Addbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbt.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F);
            this.Addbt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Addbt.Image = global::gym1.Properties.Resources.add_user;
            this.Addbt.Location = new System.Drawing.Point(21, 217);
            this.Addbt.Name = "Addbt";
            this.Addbt.Size = new System.Drawing.Size(233, 90);
            this.Addbt.TabIndex = 6;
            this.Addbt.Text = "Add";
            this.Addbt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Addbt.UseVisualStyleBackColor = true;
            this.Addbt.Click += new System.EventHandler(this.Addbt_Click);
            // 
            // Paybt
            // 
            this.Paybt.FlatAppearance.BorderSize = 0;
            this.Paybt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paybt.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F);
            this.Paybt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Paybt.Image = global::gym1.Properties.Resources.cash;
            this.Paybt.Location = new System.Drawing.Point(21, 519);
            this.Paybt.Name = "Paybt";
            this.Paybt.Size = new System.Drawing.Size(233, 84);
            this.Paybt.TabIndex = 5;
            this.Paybt.Text = "Pay";
            this.Paybt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Paybt.UseVisualStyleBackColor = true;
            this.Paybt.Click += new System.EventHandler(this.Paybt_Click);
            // 
            // Logoutbt
            // 
            this.Logoutbt.FlatAppearance.BorderSize = 0;
            this.Logoutbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logoutbt.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F);
            this.Logoutbt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Logoutbt.Image = global::gym1.Properties.Resources.account;
            this.Logoutbt.Location = new System.Drawing.Point(21, 618);
            this.Logoutbt.Name = "Logoutbt";
            this.Logoutbt.Size = new System.Drawing.Size(233, 86);
            this.Logoutbt.TabIndex = 4;
            this.Logoutbt.Text = "LogOut";
            this.Logoutbt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Logoutbt.UseVisualStyleBackColor = true;
            this.Logoutbt.Click += new System.EventHandler(this.Logoutbt_Click);
            // 
            // Databt
            // 
            this.Databt.FlatAppearance.BorderSize = 0;
            this.Databt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Databt.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F);
            this.Databt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Databt.Image = global::gym1.Properties.Resources.personal_data;
            this.Databt.Location = new System.Drawing.Point(21, 421);
            this.Databt.Name = "Databt";
            this.Databt.Size = new System.Drawing.Size(233, 78);
            this.Databt.TabIndex = 3;
            this.Databt.Text = "Data";
            this.Databt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Databt.UseVisualStyleBackColor = true;
            this.Databt.Click += new System.EventHandler(this.Databt_Click);
            // 
            // Delebt
            // 
            this.Delebt.FlatAppearance.BorderSize = 0;
            this.Delebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delebt.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F);
            this.Delebt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Delebt.Image = global::gym1.Properties.Resources.user4;
            this.Delebt.Location = new System.Drawing.Point(21, 313);
            this.Delebt.Name = "Delebt";
            this.Delebt.Size = new System.Drawing.Size(233, 88);
            this.Delebt.TabIndex = 2;
            this.Delebt.Text = "Delete/edit";
            this.Delebt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Delebt.UseVisualStyleBackColor = true;
            this.Delebt.Click += new System.EventHandler(this.Delebt_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 195);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label1.Location = new System.Drawing.Point(86, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gym1.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(36, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(613, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 45);
            this.label2.TabIndex = 20;
            this.label2.Text = "Member Information";
            // 
            // memberTb2BindingSource
            // 
            this.memberTb2BindingSource.DataMember = "MemberTb2";
            this.memberTb2BindingSource.DataSource = this.gymDbDataSet;
            // 
            // gymDbDataSet
            // 
            this.gymDbDataSet.DataSetName = "GymDbDataSet";
            this.gymDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTb2TableAdapter
            // 
            this.memberTb2TableAdapter.ClearBeforeFill = true;
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AutoGenerateColumns = false;
            this.dataView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mIdDataGridViewTextBoxColumn,
            this.mNameDataGridViewTextBoxColumn,
            this.mLastDataGridViewTextBoxColumn,
            this.mAgeDataGridViewTextBoxColumn,
            this.mGenDataGridViewTextBoxColumn,
            this.mPhoneDataGridViewTextBoxColumn,
            this.mTimeDataGridViewTextBoxColumn});
            this.dataView.DataSource = this.memberTb2BindingSource;
            this.dataView.Location = new System.Drawing.Point(385, 269);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowHeadersWidth = 51;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(934, 406);
            this.dataView.TabIndex = 38;
            // 
            // mIdDataGridViewTextBoxColumn
            // 
            this.mIdDataGridViewTextBoxColumn.DataPropertyName = "MId";
            this.mIdDataGridViewTextBoxColumn.HeaderText = "MId";
            this.mIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mIdDataGridViewTextBoxColumn.Name = "mIdDataGridViewTextBoxColumn";
            this.mIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.mIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "MName";
            this.mNameDataGridViewTextBoxColumn.HeaderText = "MName";
            this.mNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
            this.mNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.mNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // mLastDataGridViewTextBoxColumn
            // 
            this.mLastDataGridViewTextBoxColumn.DataPropertyName = "MLast";
            this.mLastDataGridViewTextBoxColumn.HeaderText = "MLast";
            this.mLastDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mLastDataGridViewTextBoxColumn.Name = "mLastDataGridViewTextBoxColumn";
            this.mLastDataGridViewTextBoxColumn.ReadOnly = true;
            this.mLastDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAgeDataGridViewTextBoxColumn
            // 
            this.mAgeDataGridViewTextBoxColumn.DataPropertyName = "MAge";
            this.mAgeDataGridViewTextBoxColumn.HeaderText = "MAge";
            this.mAgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAgeDataGridViewTextBoxColumn.Name = "mAgeDataGridViewTextBoxColumn";
            this.mAgeDataGridViewTextBoxColumn.ReadOnly = true;
            this.mAgeDataGridViewTextBoxColumn.Width = 60;
            // 
            // mGenDataGridViewTextBoxColumn
            // 
            this.mGenDataGridViewTextBoxColumn.DataPropertyName = "MGen";
            this.mGenDataGridViewTextBoxColumn.HeaderText = "MGen";
            this.mGenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mGenDataGridViewTextBoxColumn.Name = "mGenDataGridViewTextBoxColumn";
            this.mGenDataGridViewTextBoxColumn.ReadOnly = true;
            this.mGenDataGridViewTextBoxColumn.Width = 60;
            // 
            // mPhoneDataGridViewTextBoxColumn
            // 
            this.mPhoneDataGridViewTextBoxColumn.DataPropertyName = "MPhone";
            this.mPhoneDataGridViewTextBoxColumn.HeaderText = "MPhone";
            this.mPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mPhoneDataGridViewTextBoxColumn.Name = "mPhoneDataGridViewTextBoxColumn";
            this.mPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.mPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // mTimeDataGridViewTextBoxColumn
            // 
            this.mTimeDataGridViewTextBoxColumn.DataPropertyName = "MTime";
            this.mTimeDataGridViewTextBoxColumn.HeaderText = "MTime";
            this.mTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mTimeDataGridViewTextBoxColumn.Name = "mTimeDataGridViewTextBoxColumn";
            this.mTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.mTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Resettb
            // 
            this.Resettb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Resettb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Resettb.ForeColor = System.Drawing.Color.White;
            this.Resettb.Location = new System.Drawing.Point(1146, 155);
            this.Resettb.Margin = new System.Windows.Forms.Padding(4);
            this.Resettb.Name = "Resettb";
            this.Resettb.Size = new System.Drawing.Size(173, 49);
            this.Resettb.TabIndex = 39;
            this.Resettb.Text = "Reset";
            this.Resettb.UseVisualStyleBackColor = false;
            this.Resettb.Click += new System.EventHandler(this.Resettb_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(934, 155);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(173, 49);
            this.Search.TabIndex = 40;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchName
            // 
            this.SearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SearchName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchName.ForeColor = System.Drawing.Color.White;
            this.SearchName.Location = new System.Drawing.Point(663, 161);
            this.SearchName.Margin = new System.Windows.Forms.Padding(4);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(220, 43);
            this.SearchName.TabIndex = 41;
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1317, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(47, 34);
            this.exit.TabIndex = 42;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1376, 748);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Resettb);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Data_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberTb2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Paybt;
        private System.Windows.Forms.Button Logoutbt;
        private System.Windows.Forms.Button Databt;
        private System.Windows.Forms.Button Delebt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Addbt;
        private GymDbDataSet gymDbDataSet;
        private System.Windows.Forms.BindingSource memberTb2BindingSource;
        private GymDbDataSetTableAdapters.MemberTb2TableAdapter memberTb2TableAdapter;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button Resettb;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mLastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.Button exit;
    }
}