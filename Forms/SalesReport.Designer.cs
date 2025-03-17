namespace BookHaven.Forms
{
    partial class SalesReport
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
            salesGridView = new DataGridView();
            filterBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)salesGridView).BeginInit();
            SuspendLayout();
            // 
            // salesGridView
            // 
            salesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesGridView.Location = new Point(9, 167);
            salesGridView.Name = "salesGridView";
            salesGridView.RowHeadersWidth = 51;
            salesGridView.Size = new Size(782, 276);
            salesGridView.TabIndex = 0;
            salesGridView.CellFormatting += SalesGridView_CellFormatting;
            // 
            // filterBox
            // 
            filterBox.FormattingEnabled = true;
            filterBox.Location = new Point(514, 94);
            filterBox.Name = "filterBox";
            filterBox.Size = new Size(274, 28);
            filterBox.TabIndex = 1;
            filterBox.SelectedIndexChanged += filterBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 94);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 2;
            label1.Text = "Filter Sales Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(326, 22);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 3;
            label2.Text = "Sales Report";
            // 
            // backBtn
            // 
            backBtn.Location = new Point(9, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 21;
            backBtn.Text = "< Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click_1;
            // 
            // SalesReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(filterBox);
            Controls.Add(salesGridView);
            Name = "SalesReport";
            Text = "SalesReport";
            ((System.ComponentModel.ISupportInitialize)salesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView salesGridView;
        private ComboBox filterBox;
        private Label label1;
        private Label label2;
        private Button backBtn;
    }
}