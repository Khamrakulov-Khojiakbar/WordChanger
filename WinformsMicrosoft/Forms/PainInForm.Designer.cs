namespace WinformsMicrosoft.Forms
{
    partial class PainInForm
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
            panel1 = new Panel();
            completedButton = new Button();
            label1 = new Label();
            painTextBox = new TextBox();
            searchTextBox = new TextBox();
            painDataGridView = new DataGridView();
            deleteButton = new Button();
            AddButton = new Button();
            panel2 = new Panel();
            PainAddTextBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)painDataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(completedButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(painTextBox);
            panel1.Controls.Add(searchTextBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 80);
            panel1.TabIndex = 4;
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
            // painTextBox
            // 
            painTextBox.Location = new Point(12, 12);
            painTextBox.Name = "painTextBox";
            painTextBox.Size = new Size(702, 23);
            painTextBox.TabIndex = 2;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(96, 45);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(154, 23);
            searchTextBox.TabIndex = 0;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // painDataGridView
            // 
            painDataGridView.AllowUserToAddRows = false;
            painDataGridView.AllowUserToDeleteRows = false;
            painDataGridView.Anchor = AnchorStyles.None;
            painDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            painDataGridView.Location = new Point(0, 86);
            painDataGridView.Name = "painDataGridView";
            painDataGridView.ReadOnly = true;
            painDataGridView.RowTemplate.Height = 25;
            painDataGridView.Size = new Size(800, 289);
            painDataGridView.TabIndex = 3;
            painDataGridView.CellDoubleClick += painDataGridView_CellDoubleClick;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(722, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 33);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 33);
            AddButton.TabIndex = 0;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(PainAddTextBox);
            panel2.Controls.Add(deleteButton);
            panel2.Controls.Add(AddButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 381);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 69);
            panel2.TabIndex = 5;
            // 
            // PainAddTextBox
            // 
            PainAddTextBox.Location = new Point(84, 9);
            PainAddTextBox.Name = "PainAddTextBox";
            PainAddTextBox.Size = new Size(243, 23);
            PainAddTextBox.TabIndex = 4;
            // 
            // PainInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(painDataGridView);
            Controls.Add(panel2);
            Name = "PainInForm";
            Text = "PainInForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)painDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button completedButton;
        private Label label1;
        public TextBox painTextBox;
        private TextBox searchTextBox;
        private DataGridView painDataGridView;
        private Button deleteButton;
        private Button AddButton;
        private Panel panel2;
        public TextBox PainAddTextBox;
    }
}