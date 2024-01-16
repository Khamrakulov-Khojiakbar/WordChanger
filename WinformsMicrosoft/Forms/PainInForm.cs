using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsMicrosoft.Domain;

namespace WinformsMicrosoft.Forms
{
    public partial class PainInForm : Form
    {
        private readonly AppDbContext _dbContext;
        private DataTable dataTable = new();
        public PainInForm()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            FillDataGridView();
        }

        private void completedButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillDataGridView()
        {
            try
            {
                dataTable.Clear();
                if (!dataTable.Columns.Contains("TypeOfPain"))
                {
                    dataTable.Columns.Add("TypeOfPain", typeof(string));
                }

                var pains = _dbContext.Pains.ToList();

                foreach (var p in pains)
                {
                    DataRow row = dataTable.NewRow();
                    row["TypeOfPain"] = p.TypeOfPain;

                    dataTable.Rows.Add(row);
                }

                painDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                painDataGridView.RowHeadersVisible = false;
                painDataGridView.AllowUserToResizeColumns = false;
                painDataGridView.AllowUserToResizeRows = false;

                painDataGridView.DataSource = dataTable;

                painDataGridView.Columns["TypeOfPain"].HeaderText = "Боли";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void painDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string? data = painDataGridView.CurrentCell.Value.ToString();
            if (!painTextBox.Text.Contains(data))
            {
                painTextBox.Text += $"{data + ", "}";
            }
            else
            {
                MessageBox.Show($"\"{data}\" уже существует в тексте", "Ошибка добавления", buttons: MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = dataTable.DefaultView;
            string filter = $"typeofpain like '%{searchTextBox.Text}%'";

            dataView.RowFilter = filter;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<Pains> existPain = _dbContext.Pains.ToList();
            if (!string.IsNullOrEmpty(PainAddTextBox.Text))
            {
                Pains pains = new()
                {
                    TypeOfPain = PainAddTextBox.Text
                };

                bool painExist = existPain.Any(x => x.TypeOfPain == pains.TypeOfPain);

                if (!painExist)
                {
                    _dbContext.Pains.Add(pains);
                    _dbContext.SaveChanges();
                    FillDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Заполните поле добваления", "Ошибка добавления", buttons: MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string selectedType = painDataGridView.CurrentCell.Value.ToString();

            var painToDelete = _dbContext.Pains.FirstOrDefault(x => x.TypeOfPain == selectedType);

            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (painToDelete != null)
            {

                _dbContext.Pains.Remove(painToDelete);
                _dbContext.SaveChanges();
                FillDataGridView();
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления", "Удаление....", buttons: MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
