namespace BookHaven.Forms
{
    partial class OrderDetailView
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
            orderDetailsGridView = new DataGridView();
            orderIdLabel = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)orderDetailsGridView).BeginInit();
            SuspendLayout();
            // 
            // orderDetailsGridView
            // 
            orderDetailsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDetailsGridView.Location = new Point(23, 166);
            orderDetailsGridView.Name = "orderDetailsGridView";
            orderDetailsGridView.RowHeadersWidth = 51;
            orderDetailsGridView.Size = new Size(729, 250);
            orderDetailsGridView.TabIndex = 0;
            // 
            // orderIdLabel
            // 
            orderIdLabel.AutoSize = true;
            orderIdLabel.Font = new Font("Segoe UI", 12F);
            orderIdLabel.Location = new Point(23, 76);
            orderIdLabel.Name = "orderIdLabel";
            orderIdLabel.Size = new Size(0, 28);
            orderIdLabel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(301, 23);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 2;
            label1.Text = "Order Details";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(731, 1);
            button1.Name = "button1";
            button1.Size = new Size(40, 37);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // OrderDetailView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(772, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(orderIdLabel);
            Controls.Add(orderDetailsGridView);
            Name = "OrderDetailView";
            Text = "OrderDetailView";
            ((System.ComponentModel.ISupportInitialize)orderDetailsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView orderDetailsGridView;
        private Label orderIdLabel;
        private Label label1;
        private Button button1;
    }
}