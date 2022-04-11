namespace BubbleSort
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputtextBox = new System.Windows.Forms.TextBox();
            this.outputtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputButton = new System.Windows.Forms.Button();
            this.outputbutton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputtextBox
            // 
            this.inputtextBox.Location = new System.Drawing.Point(81, 131);
            this.inputtextBox.Name = "inputtextBox";
            this.inputtextBox.Size = new System.Drawing.Size(342, 27);
            this.inputtextBox.TabIndex = 0;
            // 
            // outputtextBox
            // 
            this.outputtextBox.Location = new System.Drawing.Point(81, 251);
            this.outputtextBox.Name = "outputtextBox";
            this.outputtextBox.Size = new System.Drawing.Size(342, 27);
            this.outputtextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ค่าที่รับเข้ามาทั้งหมด 10 ค่า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "เรียงค่าจากน้อยไปมาก";
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(81, 322);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(94, 29);
            this.inputButton.TabIndex = 4;
            this.inputButton.Text = "รับค่า";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // outputbutton
            // 
            this.outputbutton.Location = new System.Drawing.Point(201, 322);
            this.outputbutton.Name = "outputbutton";
            this.outputbutton.Size = new System.Drawing.Size(94, 29);
            this.outputbutton.TabIndex = 5;
            this.outputbutton.Text = "แสดงผล";
            this.outputbutton.UseVisualStyleBackColor = true;
            this.outputbutton.Click += new System.EventHandler(this.outputbutton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(329, 322);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 29);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "เคลียร์ค่า";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 400);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outputbutton);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputtextBox);
            this.Controls.Add(this.inputtextBox);
            this.Name = "Form1";
            this.Text = "เรียงค่าจากน้อยไปมาก";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputtextBox;
        private TextBox outputtextBox;
        private Label label1;
        private Label label2;
        private Button inputButton;
        private Button outputbutton;
        private Button clearButton;
    }
}