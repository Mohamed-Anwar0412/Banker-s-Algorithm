namespace Banker_s_Algorithm
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
            currentAllocation = new DataGridView();
            totalView = new DataGridView();
            maxNeed = new DataGridView();
            available = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)currentAllocation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxNeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)available).BeginInit();
            SuspendLayout();
            // 
            // currentAllocation
            // 
            currentAllocation.AllowUserToAddRows = false;
            currentAllocation.AllowUserToDeleteRows = false;
            currentAllocation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            currentAllocation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            currentAllocation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            currentAllocation.Location = new Point(49, 77);
            currentAllocation.Name = "currentAllocation";
            currentAllocation.RowHeadersWidth = 50;
            currentAllocation.Size = new Size(324, 139);
            currentAllocation.TabIndex = 0;
            // 
            // totalView
            // 
            totalView.AllowUserToAddRows = false;
            totalView.AllowUserToDeleteRows = false;
            totalView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            totalView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            totalView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            totalView.Location = new Point(433, 77);
            totalView.Name = "totalView";
            totalView.RowHeadersWidth = 50;
            totalView.Size = new Size(310, 83);
            totalView.TabIndex = 1;
            // 
            // maxNeed
            // 
            maxNeed.AllowUserToAddRows = false;
            maxNeed.AllowUserToDeleteRows = false;
            maxNeed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            maxNeed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            maxNeed.Location = new Point(49, 281);
            maxNeed.Name = "maxNeed";
            maxNeed.RowHeadersWidth = 50;
            maxNeed.Size = new Size(324, 139);
            maxNeed.TabIndex = 2;
            // 
            // available
            // 
            available.AllowUserToAddRows = false;
            available.AllowUserToDeleteRows = false;
            available.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            available.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            available.EditMode = DataGridViewEditMode.EditProgrammatically;
            available.Location = new Point(433, 224);
            available.Name = "available";
            available.RowHeadersWidth = 50;
            available.Size = new Size(310, 139);
            available.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(132, 39);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 4;
            label1.Text = "Current Allocation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(568, 39);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 5;
            label2.Text = "Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(153, 245);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 6;
            label3.Text = "Max Need";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(568, 188);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 7;
            label4.Text = "Available";
            // 
            // button1
            // 
            button1.Location = new Point(473, 398);
            button1.Name = "button1";
            button1.Size = new Size(94, 42);
            button1.TabIndex = 8;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(609, 398);
            button2.Name = "button2";
            button2.Size = new Size(92, 42);
            button2.TabIndex = 9;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Data
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 474);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(available);
            Controls.Add(maxNeed);
            Controls.Add(totalView);
            Controls.Add(currentAllocation);
            Name = "Data";
            Text = "Data";
            ((System.ComponentModel.ISupportInitialize)currentAllocation).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalView).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxNeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)available).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView currentAllocation;
        private DataGridView totalView;
        private DataGridView maxNeed;
        private DataGridView available;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}