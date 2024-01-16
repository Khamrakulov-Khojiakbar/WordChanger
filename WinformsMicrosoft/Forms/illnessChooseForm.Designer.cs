namespace WinformsMicrosoft.Forms
{
    partial class illnessChooseForm
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
            illnessDataGridView = new DataGridView();
            panel1 = new Panel();
            searchTexBox = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            illnessTextBox = new TextBox();
            illnessAddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)illnessDataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // illnessDataGridView
            // 
            illnessDataGridView.AllowUserToAddRows = false;
            illnessDataGridView.AllowUserToDeleteRows = false;
            illnessDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            illnessDataGridView.Location = new Point(0, 57);
            illnessDataGridView.Name = "illnessDataGridView";
            illnessDataGridView.ReadOnly = true;
            illnessDataGridView.RowTemplate.Height = 25;
            illnessDataGridView.Size = new Size(800, 345);
            illnessDataGridView.TabIndex = 0;
            illnessDataGridView.DoubleClick += illnessDataGridView_DoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(searchTexBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 56);
            panel1.TabIndex = 1;
            // 
            // searchTexBox
            // 
            searchTexBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            searchTexBox.Location = new Point(94, 5);
            searchTexBox.Name = "searchTexBox";
            searchTexBox.Size = new Size(694, 32);
            searchTexBox.TabIndex = 1;
            searchTexBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 0;
            label1.Text = "Поиск:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(illnessTextBox);
            panel2.Controls.Add(illnessAddButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 399);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 51);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Болезнь:";
            // 
            // illnessTextBox
            // 
            illnessTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            illnessTextBox.Location = new Point(76, 12);
            illnessTextBox.Name = "illnessTextBox";
            illnessTextBox.Size = new Size(601, 27);
            illnessTextBox.TabIndex = 4;
            // 
            // illnessAddButton
            // 
            illnessAddButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            illnessAddButton.Location = new Point(683, 9);
            illnessAddButton.Name = "illnessAddButton";
            illnessAddButton.Size = new Size(105, 32);
            illnessAddButton.TabIndex = 3;
            illnessAddButton.Text = "Добавление болезни";
            illnessAddButton.UseVisualStyleBackColor = true;
            illnessAddButton.Click += illnessAddButton_Click;
            // 
            // illnessChooseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(illnessDataGridView);
            Name = "illnessChooseForm";
            Text = "illnessChooseForm";
            ((System.ComponentModel.ISupportInitialize)illnessDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView illnessDataGridView;
        private Panel panel1;
        public TextBox searchTexBox;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox illnessTextBox;
        private Button illnessAddButton;
    }
}