namespace WinformsMicrosoft.Forms
{
    partial class ComplaintsCrudForm
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
            complaintsDataGridView = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            illnessCombobox = new ComboBox();
            completedButton = new Button();
            label1 = new Label();
            complaintsTextBox = new TextBox();
            searchTextBox = new TextBox();
            panel2 = new Panel();
            deleteButton = new Button();
            AddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)complaintsDataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // complaintsDataGridView
            // 
            complaintsDataGridView.AllowUserToAddRows = false;
            complaintsDataGridView.AllowUserToDeleteRows = false;
            complaintsDataGridView.Anchor = AnchorStyles.None;
            complaintsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            complaintsDataGridView.Location = new Point(0, 86);
            complaintsDataGridView.Name = "complaintsDataGridView";
            complaintsDataGridView.ReadOnly = true;
            complaintsDataGridView.RowTemplate.Height = 25;
            complaintsDataGridView.Size = new Size(800, 289);
            complaintsDataGridView.TabIndex = 0;
            complaintsDataGridView.CellDoubleClick += complaintsDataGridView_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(illnessCombobox);
            panel1.Controls.Add(completedButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(complaintsTextBox);
            panel1.Controls.Add(searchTextBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 80);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 49);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Болезнь:";
            // 
            // illnessCombobox
            // 
            illnessCombobox.FormattingEnabled = true;
            illnessCombobox.Location = new Point(593, 45);
            illnessCombobox.Name = "illnessCombobox";
            illnessCombobox.Size = new Size(121, 23);
            illnessCombobox.TabIndex = 4;
            illnessCombobox.SelectedIndexChanged += searchTextBox_TextChanged;
            // 
            // completedButton
            // 
            completedButton.Location = new Point(713, 12);
            completedButton.Name = "completedButton";
            completedButton.Size = new Size(75, 23);
            completedButton.TabIndex = 3;
            completedButton.Text = "Готово";
            completedButton.UseVisualStyleBackColor = true;
            completedButton.Click += completedButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 49);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Поиск:";
            // 
            // complaintsTextBox
            // 
            complaintsTextBox.Location = new Point(12, 12);
            complaintsTextBox.Name = "complaintsTextBox";
            complaintsTextBox.Size = new Size(702, 23);
            complaintsTextBox.TabIndex = 2;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(96, 45);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(154, 23);
            searchTextBox.TabIndex = 0;
            searchTextBox.TextChanged += illnessCombobox_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(deleteButton);
            panel2.Controls.Add(AddButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 381);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 69);
            panel2.TabIndex = 2;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(96, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 33);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 33);
            AddButton.TabIndex = 0;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ComplaintsCrudForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(complaintsDataGridView);
            Name = "ComplaintsCrudForm";
            Text = "ComplaintsCrudForm";
            ((System.ComponentModel.ISupportInitialize)complaintsDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView complaintsDataGridView;
        private Panel panel1;
        private Label label1;
        public TextBox complaintsTextBox;
        private TextBox searchTextBox;
        private Panel panel2;
        private Button completedButton;
        private Button deleteButton;
        private Button AddButton;
        private Label label2;
        private ComboBox illnessCombobox;
    }
}