namespace Custom_encryption
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            bt1 = new System.Windows.Forms.Button();
            bt2 = new System.Windows.Forms.Button();
            tb1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tb2 = new System.Windows.Forms.TextBox();
            bt3 = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(bt1, 0, 0);
            tableLayoutPanel1.Controls.Add(bt2, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(8, 287);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(643, 53);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // bt1
            // 
            bt1.BackColor = System.Drawing.Color.FromArgb(79, 69, 87);
            bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt1.ForeColor = System.Drawing.Color.FromArgb(244, 238, 224);
            bt1.Location = new System.Drawing.Point(4, 3);
            bt1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bt1.Name = "bt1";
            bt1.Size = new System.Drawing.Size(313, 45);
            bt1.TabIndex = 0;
            bt1.Text = "Encrypt";
            bt1.UseVisualStyleBackColor = false;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.BackColor = System.Drawing.Color.FromArgb(79, 69, 87);
            bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt2.ForeColor = System.Drawing.Color.FromArgb(244, 238, 224);
            bt2.Location = new System.Drawing.Point(325, 3);
            bt2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bt2.Name = "bt2";
            bt2.Size = new System.Drawing.Size(314, 45);
            bt2.TabIndex = 1;
            bt2.Text = "Decrypt";
            bt2.UseVisualStyleBackColor = false;
            bt2.Click += bt2_Click;
            // 
            // tb1
            // 
            tb1.BackColor = System.Drawing.Color.FromArgb(109, 93, 110);
            tb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb1.ForeColor = System.Drawing.Color.FromArgb(244, 238, 224);
            tb1.Location = new System.Drawing.Point(19, 63);
            tb1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tb1.Name = "tb1";
            tb1.Size = new System.Drawing.Size(625, 28);
            tb1.TabIndex = 1;
            tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(244, 238, 224);
            label1.Location = new System.Drawing.Point(256, 9);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(141, 31);
            label1.TabIndex = 2;
            label1.Text = "Input Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(244, 238, 224);
            label2.Location = new System.Drawing.Point(248, 120);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(159, 31);
            label2.TabIndex = 4;
            label2.Text = "Output Text";
            // 
            // tb2
            // 
            tb2.BackColor = System.Drawing.Color.FromArgb(109, 93, 110);
            tb2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb2.ForeColor = System.Drawing.Color.FromArgb(244, 238, 224);
            tb2.Location = new System.Drawing.Point(15, 173);
            tb2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tb2.Name = "tb2";
            tb2.Size = new System.Drawing.Size(625, 28);
            tb2.TabIndex = 3;
            tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt3
            // 
            bt3.BackColor = System.Drawing.Color.FromArgb(79, 69, 87);
            bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt3.ForeColor = System.Drawing.Color.FromArgb(244, 238, 224);
            bt3.Location = new System.Drawing.Point(280, 232);
            bt3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bt3.Name = "bt3";
            bt3.Size = new System.Drawing.Size(96, 32);
            bt3.TabIndex = 6;
            bt3.Text = "Set Key";
            bt3.UseVisualStyleBackColor = false;
            bt3.Click += bt3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(57, 54, 70);
            ClientSize = new System.Drawing.Size(656, 348);
            Controls.Add(bt3);
            Controls.Add(label2);
            Controls.Add(tb2);
            Controls.Add(label1);
            Controls.Add(tb1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Custom Encryption";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button bt3;
    }
}

