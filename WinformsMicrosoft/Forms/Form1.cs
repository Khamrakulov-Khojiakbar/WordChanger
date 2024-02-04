using System.Configuration;
using WinformsMicrosoft.Forms;
using WinformsMicrosoft.WordChanger;

namespace WinformsMicrosoft
{
    public partial class Form1 : Form
    {
        public CheckBox socialLivingConditionsCheckBox;
        public CheckBox occupationalHazardsCheckbox;
        private string retiredStringData = "НЕ НА ПЕНСИИ";
        private string smokigStringData = "НЕ КУРИТ";

        private string? wordFilePath;
        public Form1()
        {
            InitializeComponent();
            InitializeCheckBoxes();
            FalseAll();
            dateTimePicker2.Text = DateTime.Now.ToString("HH:mm");
            wordFilePath = $"{ConfigurationManager.AppSettings["WordFilePath"]}";
        }

        public void InitializeCheckBoxes()
        {
            occupationHazarGoodCheckBox.CheckedChanged += CheckBox_CheckedChanged_SocialLiving;
            occupationHazardsnotbadCheckBox.CheckedChanged += CheckBox_CheckedChanged_SocialLiving;
            occupationHazardVeryGoodCheckBox.CheckedChanged += CheckBox_CheckedChanged_SocialLiving;

            occupationalHazardsCheckBoxNo.CheckedChanged += CheckBox_ChekedChanged_OccupationalHazards;
            occupationalHazardsYes.CheckedChanged += CheckBox_ChekedChanged_OccupationalHazards;
        }

        private void CheckBox_CheckedChanged_SocialLiving(object sender, EventArgs e)
        {
            socialLivingConditionsCheckBox = (CheckBox)sender;

            CheckBox[] checkBoxes = { occupationHazarGoodCheckBox, occupationHazardsnotbadCheckBox, occupationHazardVeryGoodCheckBox };

            foreach (CheckBox check in checkBoxes)
            {
                if (check != sender)
                {
                    check.Checked = false;
                }
            }

        }

        private void CheckBox_ChekedChanged_OccupationalHazards(object sender, EventArgs e)
        {
            occupationalHazardsCheckbox = (CheckBox)sender;

            CheckBox[] checkBoxes = { occupationalHazardsCheckBoxNo, occupationalHazardsYes };

            foreach (CheckBox check in checkBoxes)
            {
                if (check != sender)
                {
                    check.Checked = false;
                }
            }

            if (occupationalHazardsYes.Checked == true)
            {
                occupationalHazardsTextBox.Enabled = true;
            }
            else
                occupationalHazardsTextBox.Enabled = false;

        }

        private void Change_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("ddMMyyyyHHmm");
            try
            {
                if (!string.IsNullOrEmpty(wordFilePath))
                {


                    var helper = new WordHelper(wordFilePath);
                    var items = new Dictionary<string, string>
                {
                        {"<FIO>", textBox1.Text },
                        {"<BD>", dateTimePicker1.Text },
                        {"<DTN>", DateTime.Now.ToString("dd.MM.yyyy") },
                        {"<Time>", DateTime.Now.ToString("HH:mm") },
                        {"<COMPL>", complaintsTextBoxMainForm.Text },
                        {"<PAIN1>", painsMainTextBox.Text },
                        {"<morbi>",  anamnesismorbiTextBox.Text },
                        {"<vitae>",  anamnesisVitaeTextBox.Text},
                        {"<SLC>", $"({socialLivingConditionsCheckBox.Text})" },
                        {"<occupationalHazards>", $"({occupationalHazardsCheckbox.Text}): {occupationalHazardsTextBox.Text}" },
                        {"<retired>", retiredStringData },
                        {"<smoking>", smokigStringData }
                };

                    //helper.FIOForFile = textBox1.Text + DateTime.Now.ToString(" dd_MM_yyyy HH:mm");
                    helper.FIOForFile = textBox1.Text;
                    helper.FIOForFile += $" {time}";
                    helper.Process(items);
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так посмотрите настройки программы", "Не найден файл", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Убедитесь что все поля заполнены!");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComplaintsCrudForm complaintsCrudForm = new ComplaintsCrudForm();
            complaintsCrudForm.ShowDialog();
            complaintsTextBoxMainForm.Text = complaintsCrudForm.complaintsTextBox.Text;
            if (complaintsTextBoxMainForm.Text.EndsWith(", "))
            {
                complaintsTextBoxMainForm.Text = complaintsTextBoxMainForm.Text.Substring(0, complaintsTextBoxMainForm.TextLength - 2);
            }
            if (complaintsTextBoxMainForm.Text.EndsWith(","))
            {
                complaintsTextBoxMainForm.Text = complaintsTextBoxMainForm.Text.Substring(0, complaintsTextBoxMainForm.TextLength - 1);
            }
        }

        private void painOpenButton_Click(object sender, EventArgs e)
        {
            PainInForm painForm = new PainInForm();
            painForm.ShowDialog();
            painsMainTextBox.Text = painForm.painTextBox.Text;
            if (painsMainTextBox.Text.EndsWith(", "))
            {
                painsMainTextBox.Text = painsMainTextBox.Text.Substring(0, painsMainTextBox.TextLength - 2);
            }
            if (painsMainTextBox.Text.EndsWith(","))
            {
                painsMainTextBox.Text = painsMainTextBox.Text.Substring(0, painsMainTextBox.TextLength - 1);
            }

        }

        private void FalseAll()
        {
            retiredCheckBox.Checked = false;
            retiredAge.Enabled = false;
            disabilityAge.Enabled = false;
            disabilityCheckBox.Enabled = false;
            disabilityGroup.Enabled = false;
            smokingAge.Enabled = false;
            packOfSmokeNUmeric.Enabled = false;
        }

        private void retiredCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (retiredCheckBox.Checked == true)
            {
                retiredAge.Enabled = true;
                disabilityCheckBox.Enabled = true;
                retiredStringData = $"На пенсии с {retiredAge} лет";
            }

            else
            {
                disabilityCheckBox.Checked = false;
                retiredCheckBox.Checked = false;
                retiredAge.Enabled = false;
                disabilityAge.Enabled = false;
                disabilityCheckBox.Enabled = false;
                if (retiredCheckBox.Checked == false && disabilityCheckBox.Checked == false)
                {
                    retiredStringData = "НЕ НА ПЕНСИИ";
                }
            }
        }

        private void disabilityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (disabilityCheckBox.Checked == true && retiredAge.Enabled == true)
            {
                disabilityGroup.Enabled = true;
                disabilityAge.Enabled = true;
                retiredStringData += $" Инвалидность: группа {disabilityGroup.Value} с {disabilityAge.Value} лет";
            }
            else
            {
                disabilityGroup.Enabled = false;
                disabilityAge.Enabled = false;

                if (retiredCheckBox.Checked == false && disabilityCheckBox.Checked == false)
                {
                    retiredStringData = "НЕ НА ПЕНСИИ";
                }
            }
        }

        private void smokingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (smokingCheckBox.Checked == true)
            {
                smokingAge.Enabled = true;
                packOfSmokeNUmeric.Enabled = true;
            }
            else
            {
                smokingAge.Enabled = false;
                packOfSmokeNUmeric.Enabled = false;
            }
        }

        private void occupationalHazardsCheckBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            if (occupationalHazardsCheckBoxNo.Checked == true)
            {
                occupationalHazardsYes.Enabled = false;
                occupationalHazardsTextBox.Enabled = false;
                occupationalHazardsYes.Checked = false;
            }
            else
            {
                occupationalHazardsYes.Checked = false;
                occupationalHazardsYes.Enabled = true;
            }
        }

        private void occupationalHazardsYes_CheckedChanged(object sender, EventArgs e)
        {
            if(occupationalHazardsYes.Checked == true)
            {
                occupationalHazardsCheckBoxNo.Checked = false;
                occupationalHazardsCheckBoxNo.Enabled = false;
                occupationalHazardsTextBox.Enabled = true;
            }
            else
            {
                occupationalHazardsTextBox.Enabled = false;
                occupationalHazardsCheckBoxNo.Enabled = true;
                occupationalHazardsCheckBoxNo.Checked = false;
            }
        }
    }
}