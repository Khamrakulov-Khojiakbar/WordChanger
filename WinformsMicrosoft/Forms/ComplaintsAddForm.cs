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
    public partial class ComplaintsAddForm : Form
    {
        private readonly AppDbContext _dbContext;
        public ComplaintsAddForm()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            illnessChooseForm form = new();
            form.ShowDialog();
            illnessTextBox.Text = form.temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string illnessCategoryName = illnessTextBox.Text;

            int? categoryId = _dbContext.illnessCategories
                .Where(x => x.CategoryName == illnessCategoryName)
                .Select(x => x.Id)
                .FirstOrDefault();

            if (categoryId.HasValue)
            {
                List<Complaints> existComplaints = _dbContext.Complaints
                    .Where(x => x.IllnessCategoryId == categoryId)
                    .ToList();

                string existsComplaintName = symptomTextBox.Text;

                bool complaintExist = existComplaints.Any(x => x.ComplaintName == existsComplaintName);

                if(!complaintExist)
                {
                    Complaints newComplaint = new()
                    {
                        ComplaintName = symptomTextBox.Text,
                        IllnessCategoryId = categoryId.Value
                    };


                    _dbContext.Complaints.Add(newComplaint);

                    _dbContext.SaveChanges();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Такая жалоба уже существует в данной категории.","Дубликат",buttons:MessageBoxButtons.OK, icon:MessageBoxIcon.Information);
                }
               
            }
            else
            {
                MessageBox.Show("Такая категория болезни не найдена");
            }
            
        }
    }
}
