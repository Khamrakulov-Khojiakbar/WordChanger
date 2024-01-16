namespace WinformsMicrosoft.Forms
{
    partial class ComplaintsAddForm
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
            label2 = new Label();
            label3 = new Label();
            symptomTextBox = new TextBox();
            illnessTextBox = new TextBox();
            chooseButton = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 27);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Симптом:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 83);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 2;
            label3.Text = "Болезнь:";
            // 
            // symptomTextBox
            // 
            symptomTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            symptomTextBox.Location = new Point(122, 21);
            symptomTextBox.Name = "symptomTextBox";
            symptomTextBox.Size = new Size(405, 31);
            symptomTextBox.TabIndex = 4;
            // 
            // illnessTextBox
            // 
            illnessTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            illnessTextBox.Location = new Point(122, 80);
            illnessTextBox.Name = "illnessTextBox";
            illnessTextBox.Size = new Size(303, 31);
            illnessTextBox.TabIndex = 5;
            // 
            // chooseButton
            // 
            chooseButton.Location = new Point(431, 80);
            chooseButton.Name = "chooseButton";
            chooseButton.Size = new Size(75, 31);
            chooseButton.TabIndex = 6;
            chooseButton.Text = "Выбрать";
            chooseButton.UseVisualStyleBackColor = true;
            chooseButton.Click += chooseButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(360, 182);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(452, 182);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ComplaintsAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 217);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chooseButton);
            Controls.Add(illnessTextBox);
            Controls.Add(symptomTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ComplaintsAddForm";
            Text = "ComplaintsAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox symptomTextBox;
        private TextBox illnessTextBox;
        private Button chooseButton;
        private Button button1;
        private Button button2;
    }
}