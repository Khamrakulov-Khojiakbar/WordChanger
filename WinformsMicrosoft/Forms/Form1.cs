using System.Configuration;
using WinformsMicrosoft.Forms;
using WinformsMicrosoft.WordChanger;

namespace WinformsMicrosoft
{
    public partial class Form1 : Form
    {
        public CheckBox socialLivingConditionsCheckBox;
        public CheckBox occupationalHazardsCheckbox;


        private string? wordFilePath;
        public Form1()
        {
            InitializeComponent();
            InitializeCheckBoxes();
            dateTimePicker2.Text = DateTime.Now.ToString("HH:mm");
            wordFilePath = $"{ConfigurationManager.AppSettings["WordFilePath"]}";
        }

        public void InitializeCheckBoxes()
        {
            checkBox1.CheckedChanged += CheckBox_CheckedChanged_SocialLiving;
            checkBox2.CheckedChanged += CheckBox_CheckedChanged_SocialLiving;
            checkBox3.CheckedChanged += CheckBox_CheckedChanged_SocialLiving;

            occupationalHazardsCheckBoxNo.CheckedChanged += CheckBox_ChekedChanged_OccupationalHazards;
            occupationalHazardsYes.CheckedChanged += CheckBox_ChekedChanged_OccupationalHazards;
        }

        private void CheckBox_CheckedChanged_SocialLiving(object sender, EventArgs e)
        {
            socialLivingConditionsCheckBox = (CheckBox)sender;

            CheckBox[] checkBoxes = { checkBox1, checkBox2, checkBox3 };

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
                    {"<occupationalHazards>", $"({occupationalHazardsCheckbox.Text}): {occupationalHazardsTextBox.Text}" }
                };

                    //helper.FIOForFile = textBox1.Text + DateTime.Now.ToString(" dd_MM_yyyy HH:mm");
                    helper.FIOForFile = textBox1.Text;
                    helper.FIOForFile += $" {time}";
                    helper.Process(items);
                }
                else
                {
                    MessageBox.Show("���-�� ����� �� ��� ���������� ��������� ���������", "�� ������ ����", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("��������� ��� ��� ���� ���������!");
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
    }
}