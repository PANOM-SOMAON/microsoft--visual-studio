namespace gym1
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Addbt = new System.Windows.Forms.Button();
            this.Paybt = new System.Windows.Forms.Button();
            this.Logoutbt = new System.Windows.Forms.Button();
            this.Databt = new System.Windows.Forms.Button();
            this.Delebt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.TabIndex = 20;
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
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1317, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(47, 34);
            this.exit.TabIndex = 43;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1376, 748);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Addbt;
        private System.Windows.Forms.Button Paybt;
        private System.Windows.Forms.Button Logoutbt;
        private System.Windows.Forms.Button Databt;
        private System.Windows.Forms.Button Delebt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
    }
}