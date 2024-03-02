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
    public partial class illnessChooseForm : Form
    {
        private readonly AppDbContext _dbContext;
        private DataTable dataTable = new();
        public string? temp;
        public illnessChooseForm()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            FillDataGrid();

        }
        private void FillDataGrid()
        {
            try
            {
                dataTable.Clear();
                if (!dataTable.Columns.Contains("Id"))
                {
                    dataTable.Columns.Add("Id", typeof(int));
                    dataTable.Columns.Add("CategoryName", typeof(string));
                }

                var illnesscategory = _dbContext.illnessCategories
                    .ToList();

                foreach (var illnesscategories in illnesscategory)
                {
                    DataRow row = dataTable.NewRow();
                    row["Id"] = illnesscategories.Id;
                    row["categoryname"] = illnesscategories.CategoryName;

                    dataTable.Rows.Add(row);
                }
                illnessDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                illnessDataGridView.RowHeadersVisible = false;
                illnessDataGridView.AllowUserToResizeRows = false;
                illnessDataGridView.AllowUserToResizeColumns = false;

                illnessDataGridView.DataSource = dataTable;

                illnessDataGridView.Columns["Id"].HeaderText = "Идентификатор";
                illnessDataGridView.Columns["categoryname"].HeaderText = "Категория";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = dataTable.DefaultView;
            string filter = $"categoryname like '%{searchTexBox.Text}%'";

            dataView.RowFilter = filter;
        }

        private void illnessDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int currentColumn = 1;
            if (illnessDataGridView.CurrentCell.ColumnIndex == currentColumn)
            {
                temp = illnessDataGridView.CurrentCell.Value.ToString();
                this.Close();
            }
        }

        private void illnessAddButton_Click(object sender, EventArgs e)
        {
            var existComplaint = _dbContext.illnessCategories.ToList();

            IllnessCategory category = new IllnessCategory()
            {
                CategoryName = illnessTextBox.Text
            };

            //bool comlaintExisting = existComplaint.Any(x => x.ComplaintName == category.CategoryName);
            var comlaintExisting = existComplaint.Where(x => x.CategoryName == category.CategoryName);

            if(!comlaintExisting.Any())
            {
                _dbContext.illnessCategories.Add(category);
                _dbContext.SaveChanges();
                FillDataGrid();
            }
            else
            {
                MessageBox.Show("Категория такой болезни уже существует", "Болезнь", buttons:MessageBoxButtons.OK, icon:MessageBoxIcon.Information);
            }
            
        }
    }
}
