using Microsoft.EntityFrameworkCore;
using System.Data;

namespace WinformsMicrosoft.Forms
{
    public partial class ComplaintsCrudForm : Form
    {
        private readonly AppDbContext _dbContext;
        private DataTable dataTable = new();
        public ComplaintsCrudForm()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            FillDataGridView();
            FillCombobox();
        }

        private void completedButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void complaintsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentColumn = 1;
            if (complaintsDataGridView.CurrentCell.ColumnIndex == currentColumn)
            {
                string data = complaintsDataGridView.CurrentCell.Value.ToString();
                if (!complaintsTextBox.Text.Contains(data))
                {
                    complaintsTextBox.Text += $"{data + ", "}";
                }
                else
                {
                    MessageBox.Show($"{data} уже существует в тексте", "Ошибка добавления", buttons: MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void FillDataGridView()
        {
            try
            {
                dataTable.Clear();
                if (!dataTable.Columns.Contains("Id"))
                {
                    dataTable.Columns.Add("Id", typeof(int));
                    dataTable.Columns.Add("ComplaintName", typeof(string));
                    dataTable.Columns.Add("CategoryName", typeof(string));
                }

                var complaints = _dbContext.Complaints
                    .Include(x => x.illnessCategory)
                    .ToList();

                foreach (var complaint in complaints)
                {
                    DataRow row = dataTable.NewRow();
                    row["Id"] = complaint.Id;
                    row["ComplaintName"] = complaint.ComplaintName;
                    row["CategoryName"] = complaint.illnessCategory.CategoryName;

                    dataTable.Rows.Add(row);
                }

                complaintsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                complaintsDataGridView.RowHeadersVisible = false;
                complaintsDataGridView.AllowUserToResizeRows = false;
                complaintsDataGridView.AllowUserToResizeColumns = false;

                complaintsDataGridView.DataSource = dataTable;

                complaintsDataGridView.Columns["Id"].HeaderText = "Идентификатор";
                complaintsDataGridView.Columns["ComplaintName"].HeaderText = "Название жалобы";
                complaintsDataGridView.Columns["CategoryName"].HeaderText = "Категория болезни";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void FillCombobox()
        {
            var illnessCategory = _dbContext.illnessCategories
                .Select(x => x.CategoryName).ToList();

            illnessCombobox.DataSource = illnessCategory;
        }



        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = dataTable.DefaultView;
            string filter = $"CategoryName like '%{illnessCombobox.Text}%' and ComplaintName like '%{searchTextBox.Text}%'";

            dataView.RowFilter = filter;
        }

        private void illnessCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dataView = dataTable.DefaultView;
            string filter = $"CategoryName like '%{illnessCombobox.Text}%' and ComplaintName like '%{searchTextBox.Text}%'";

            dataView.RowFilter = filter;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //string currentIndex1 = complaintsDataGridView.SelectedRows[0].Cells["Id"].Value.ToString();
            int currentValue = int.Parse(complaintsDataGridView.CurrentCell.Value.ToString());

            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (currentValue is int)
                {
                    var deletedIndex = _dbContext.Complaints.Find(currentValue);
                    if (deletedIndex != null)
                    {
                        _dbContext.Complaints.Remove(deletedIndex);

                        _dbContext.SaveChanges();

                        FillDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Выберите идентификатор для удаления", "Удаление....", buttons: MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            ComplaintsAddForm form = new();
            form.ShowDialog();
            FillDataGridView();
            FillCombobox();
        }
    }


    
}

