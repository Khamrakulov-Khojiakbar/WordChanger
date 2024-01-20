namespace WinformsMicrosoft
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
            Change = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            occupationalHazardsTextBox = new TextBox();
            occupationalHazardsYes = new CheckBox();
            occupationalHazardsCheckBoxNo = new CheckBox();
            label9 = new Label();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label8 = new Label();
            panel4 = new Panel();
            anamnesisVitaeTextBox = new TextBox();
            label7 = new Label();
            panel3 = new Panel();
            anamnesismorbiTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            panel2 = new Panel();
            painOpenButton = new Button();
            complaintsOpenButton = new Button();
            painsMainTextBox = new TextBox();
            complaintsTextBoxMainForm = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Change
            // 
            Change.Location = new Point(1009, 876);
            Change.Margin = new Padding(4, 3, 4, 3);
            Change.Name = "Change";
            Change.Size = new Size(88, 27);
            Change.TabIndex = 13;
            Change.Text = "Изменить";
            Change.UseVisualStyleBackColor = true;
            Change.Click += Change_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(174, 60);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(132, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(175, 14);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(755, 23);
            textBox1.TabIndex = 10;
            textBox1.Text = "Имя Фамилия Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SkyBlue;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(37, 28);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 7;
            label4.Text = "Жалобы:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(8);
            label1.Size = new Size(142, 36);
            label1.TabIndex = 0;
            label1.Text = "ФИО Пациента";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 52);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(8);
            label3.Size = new Size(134, 36);
            label3.TabIndex = 2;
            label3.Text = "Год рождения";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(occupationalHazardsTextBox);
            panel1.Controls.Add(occupationalHazardsYes);
            panel1.Controls.Add(occupationalHazardsCheckBoxNo);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(Change);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1138, 969);
            panel1.TabIndex = 14;
            // 
            // occupationalHazardsTextBox
            // 
            occupationalHazardsTextBox.Enabled = false;
            occupationalHazardsTextBox.Location = new Point(269, 657);
            occupationalHazardsTextBox.Name = "occupationalHazardsTextBox";
            occupationalHazardsTextBox.Size = new Size(706, 23);
            occupationalHazardsTextBox.TabIndex = 21;
            // 
            // occupationalHazardsYes
            // 
            occupationalHazardsYes.AutoSize = true;
            occupationalHazardsYes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            occupationalHazardsYes.Location = new Point(214, 659);
            occupationalHazardsYes.Name = "occupationalHazardsYes";
            occupationalHazardsYes.Size = new Size(51, 19);
            occupationalHazardsYes.TabIndex = 20;
            occupationalHazardsYes.Text = "есть";
            occupationalHazardsYes.UseVisualStyleBackColor = true;
            // 
            // occupationalHazardsCheckBoxNo
            // 
            occupationalHazardsCheckBoxNo.AutoSize = true;
            occupationalHazardsCheckBoxNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            occupationalHazardsCheckBoxNo.Location = new Point(164, 659);
            occupationalHazardsCheckBoxNo.Name = "occupationalHazardsCheckBoxNo";
            occupationalHazardsCheckBoxNo.Size = new Size(45, 19);
            occupationalHazardsCheckBoxNo.TabIndex = 19;
            occupationalHazardsCheckBoxNo.Text = "нет";
            occupationalHazardsCheckBoxNo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(30, 655);
            label9.Name = "label9";
            label9.Size = new Size(128, 21);
            label9.TabIndex = 18;
            label9.Text = "Профвредности:";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.Location = new Point(577, 615);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(79, 19);
            checkBox3.TabIndex = 17;
            checkBox3.Text = "хорошие";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(416, 615);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(164, 19);
            checkBox2.TabIndex = 16;
            checkBox2.Text = "неудовлетворительные";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(268, 615);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(150, 19);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "удовлетворительные";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(30, 614);
            label8.Name = "label8";
            label8.Size = new Size(221, 21);
            label8.TabIndex = 14;
            label8.Text = "Социально бытовые условия:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SkyBlue;
            panel4.Controls.Add(anamnesisVitaeTextBox);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(15, 441);
            panel4.Name = "panel4";
            panel4.Size = new Size(1082, 151);
            panel4.TabIndex = 12;
            // 
            // anamnesisVitaeTextBox
            // 
            anamnesisVitaeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            anamnesisVitaeTextBox.Location = new Point(15, 44);
            anamnesisVitaeTextBox.Multiline = true;
            anamnesisVitaeTextBox.Name = "anamnesisVitaeTextBox";
            anamnesisVitaeTextBox.Size = new Size(1049, 87);
            anamnesisVitaeTextBox.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(409, 10);
            label7.Name = "label7";
            label7.Size = new Size(181, 25);
            label7.TabIndex = 0;
            label7.Text = "ANAMNESIS VITAE";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SkyBlue;
            panel3.Controls.Add(anamnesismorbiTextBox);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(15, 266);
            panel3.Name = "panel3";
            panel3.Size = new Size(1082, 151);
            panel3.TabIndex = 11;
            // 
            // anamnesismorbiTextBox
            // 
            anamnesismorbiTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            anamnesismorbiTextBox.Location = new Point(15, 44);
            anamnesismorbiTextBox.Multiline = true;
            anamnesismorbiTextBox.Name = "anamnesismorbiTextBox";
            anamnesismorbiTextBox.Size = new Size(1049, 87);
            anamnesismorbiTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(409, 10);
            label5.Name = "label5";
            label5.Size = new Size(191, 25);
            label5.TabIndex = 0;
            label5.Text = "ANAMNESIS MORBI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(939, 18);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 17);
            label6.TabIndex = 10;
            label6.Text = "Время:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(1009, 14);
            dateTimePicker2.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(88, 23);
            dateTimePicker2.TabIndex = 9;
            dateTimePicker2.Value = new DateTime(2023, 12, 16, 1, 54, 0, 0);
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(painOpenButton);
            panel2.Controls.Add(complaintsOpenButton);
            panel2.Controls.Add(painsMainTextBox);
            panel2.Controls.Add(complaintsTextBoxMainForm);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(14, 122);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 119);
            panel2.TabIndex = 8;
            // 
            // painOpenButton
            // 
            painOpenButton.Location = new Point(925, 54);
            painOpenButton.Margin = new Padding(4, 3, 4, 3);
            painOpenButton.Name = "painOpenButton";
            painOpenButton.Size = new Size(88, 27);
            painOpenButton.TabIndex = 25;
            painOpenButton.Text = "Выбрать";
            painOpenButton.UseVisualStyleBackColor = true;
            painOpenButton.Click += painOpenButton_Click;
            // 
            // complaintsOpenButton
            // 
            complaintsOpenButton.Location = new Point(925, 26);
            complaintsOpenButton.Margin = new Padding(4, 3, 4, 3);
            complaintsOpenButton.Name = "complaintsOpenButton";
            complaintsOpenButton.Size = new Size(88, 27);
            complaintsOpenButton.TabIndex = 24;
            complaintsOpenButton.Text = "Выбрать";
            complaintsOpenButton.UseVisualStyleBackColor = true;
            complaintsOpenButton.Click += button1_Click;
            // 
            // painsMainTextBox
            // 
            painsMainTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            painsMainTextBox.Location = new Point(138, 61);
            painsMainTextBox.Margin = new Padding(4, 3, 4, 3);
            painsMainTextBox.Name = "painsMainTextBox";
            painsMainTextBox.Size = new Size(778, 25);
            painsMainTextBox.TabIndex = 23;
            // 
            // complaintsTextBoxMainForm
            // 
            complaintsTextBoxMainForm.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            complaintsTextBoxMainForm.Location = new Point(138, 28);
            complaintsTextBoxMainForm.Margin = new Padding(4, 3, 4, 3);
            complaintsTextBoxMainForm.Name = "complaintsTextBoxMainForm";
            complaintsTextBoxMainForm.Size = new Size(778, 25);
            complaintsTextBoxMainForm.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(66, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 21;
            label2.Text = "Боли:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1122, 708);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Change;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label4;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label6;
        private Button painOpenButton;
        private Button complaintsOpenButton;
        private TextBox painsMainTextBox;
        public TextBox complaintsTextBoxMainForm;
        private Panel panel3;
        private TextBox anamnesismorbiTextBox;
        private Label label5;
        private Panel panel4;
        private TextBox anamnesisVitaeTextBox;
        private Label label7;
        private Label label8;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox occupationalHazardsTextBox;
        private CheckBox occupationalHazardsYes;
        private CheckBox occupationalHazardsCheckBoxNo;
        private Label label9;
    }
}