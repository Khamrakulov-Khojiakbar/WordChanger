using System.Configuration;
using System.Runtime.CompilerServices;
using WinformsMicrosoft.Forms;
using WinformsMicrosoft.WordChanger;

namespace WinformsMicrosoft
{
    public partial class Form1 : Form
    {
        public CheckBox socialLivingConditionsCheckBox;
        public CheckBox occupationalHazardsCheckbox;
        private string retiredStringData = "НЕ НА ПЕНСИИ";
        private string disabilityStringData = "НЕТ ИНВАЛИДНОСТИ";
        private string smokigStringData = "НЕ КУРИТ";
        private string alchoholDrinking = "НЕ УПОТРЕБЛЯЕТ АЛЬКОГОЛЬ";
        private string pastIllness = "ОТРИЦАЕТ";
        private string zimoticdiseasesString = "ОТРИЦАЕТ";
        private string allergyHistoryStringData = "ОТРИЦАЕТ";
        private string pregnancyStringData = "";
        private string pregnancyCheckBoxStringData = "";
        private string climatericStringData = "";
        private string gestationNumericStringData = "";
        private string childBearingStringData = "";
        private string abortsNumericStringData = "";
        private string? wordFilePath;

        public Form1()
        {
            InitializeComponent();
            InitializeCheckBoxes();
            IntializePregnancyCheckBox();
            FalseAll();
            alcoholAge.Value = 18;
            dateTimePicker2.Text = DateTime.Now.ToString("HH:mm");
            wordFilePath = $"{ConfigurationManager.AppSettings["WordFilePath"]}";
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
            alcoholAge.Enabled = false;
            pregnancyNumeric.Enabled = false;
            foreach (var a in pregnancyCheckBox_ChekedChanged1())
            {
                a.Enabled = false;
            }
            climactericNumeric.Enabled = false;
            abortsNumericUp.Enabled = false;
            childBearingNumericUp.Enabled = false;
            gestationNumericUp.Enabled = false;
        }


        #region CheckBoxChangesMethods

        public void InitializeCheckBoxes()
        {
            occupationHazarGoodCheckBox.CheckedChanged += CheckBox_CheckedChanged_SocialLiving;
            occupationHazardsnotbadCheckBox.CheckedChanged += CheckBox_CheckedChanged_SocialLiving;
            occupationHazardVeryGoodCheckBox.CheckedChanged += CheckBox_CheckedChanged_SocialLiving;

            occupationalHazardsCheckBoxNo.CheckedChanged += CheckBox_ChekedChanged_OccupationalHazards;
            occupationalHazardsYes.CheckedChanged += CheckBox_ChekedChanged_OccupationalHazards;
        }

        private void IntializePregnancyCheckBox()
        {
            regularPregnancyCheckBox.CheckedChanged += pregnancyCheckBox_ChekedChanged;
            unregularCheckBox.CheckedChanged += pregnancyCheckBox_ChekedChanged;
            illnessPregnancyCheckBox.CheckedChanged += pregnancyCheckBox_ChekedChanged;
            unillnessPregnancyCheckBox.CheckedChanged += pregnancyCheckBox_ChekedChanged;
        }


        private CheckBox[] pregnancyCheckBox_ChekedChanged1()
        {

            CheckBox[] checkBoxes = { regularPregnancyCheckBox, unregularCheckBox, illnessPregnancyCheckBox, unillnessPregnancyCheckBox };

            return checkBoxes;
        }

        private void pregnancyCheckBox_ChekedChanged(object sender, EventArgs e)
        {
            int checkCount = 0;
            pregnancyCheckBoxStringData = ""; // Очистим строку перед добавлением новых данных
            CheckBox[] checkBoxes = { regularPregnancyCheckBox, unregularCheckBox, illnessPregnancyCheckBox, unillnessPregnancyCheckBox };

            foreach (var check in checkBoxes)
            {
                if (check.Checked == true)
                {
                    checkCount++;
                    if (checkCount <= 2)
                    {
                        pregnancyCheckBoxStringData += $" {check.Text}";
                    }
                    else
                    {
                        check.Checked = false; // Если уже отмечено два флажка, снимаем отметку с остальных
                    }
                }
            }
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
        #endregion

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
                        {"<morbi>",  anamnesismorbiTextBox.Text},
                        {"<vitae>",  anamnesisVitaeTextBox.Text},
                        {"<SLC>", $"({socialLivingConditionsCheckBox.Text})" },
                        {"<occupationalHazards>", $"({occupationalHazardsCheckbox.Text}) {occupationalHazardsTextBox.Text}" },
                        {"<retired>", retiredStringData },
                        {"<disability>", disabilityStringData },
                        {"<smoking>", smokigStringData },
                        {"<alcohol>", alchoholDrinking },
                        {"<pastillness>", pastIllness },
                        {"<zimoticdiseases>", zimoticdiseasesString },
                        {"<allergyHistory>", allergyHistoryStringData},
                        {"<pregnancyData>", $"{pregnancyStringData} ({pregnancyCheckBoxStringData})" },
                        {"<climatericNum>", climatericStringData },
                        {"<gestationData>", gestationNumericStringData },
                        {"<childBearingData>", childBearingStringData },
                        {"<abortsData>", abortsNumericStringData }
                        

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
        #region Begin of program
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
        #endregion

        #region OccupationHazardsMethods


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
            if (occupationalHazardsYes.Checked == true)
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
        #endregion

        #region retiredAll

        private void retiredAge_ValueChanged(object sender, EventArgs e)
        {
            if (retiredCheckBox.Checked == true)
            {
                retiredAge.Enabled = true;
                disabilityCheckBox.Enabled = true;
                retiredStringData = $"На пенсии с {retiredAge.Value} лет";
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

        private void retiredCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (retiredCheckBox.Checked == true)
            {
                retiredAge.Enabled = true;
                disabilityCheckBox.Enabled = true;
                retiredStringData = $"На пенсии с {retiredAge.Value} лет";
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

        #endregion

        #region DisabilityAll
        private void disabilityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (disabilityCheckBox.Checked == true && retiredAge.Enabled == true)
            {
                disabilityGroup.Enabled = true;
                disabilityAge.Enabled = true;
                disabilityStringData = $" Инвалидность: группа {disabilityGroup.Value} с {disabilityAge.Value} лет";
            }
            else
            {
                disabilityGroup.Enabled = false;
                disabilityAge.Enabled = false;

                if (retiredCheckBox.Checked == false && disabilityCheckBox.Checked == false)
                {
                    disabilityStringData = "НЕТ ИНВАЛИДНОСТИ";
                }
            }
        }

        private void disabilityGroup_ValueChanged(object sender, EventArgs e)
        {
            if (disabilityCheckBox.Checked == true && retiredAge.Enabled == true)
            {
                disabilityGroup.Enabled = true;
                disabilityAge.Enabled = true;
                disabilityStringData = $" Инвалидность: группа {disabilityGroup.Value} с {disabilityAge.Value} лет";
            }
            else
            {
                disabilityGroup.Enabled = false;
                disabilityAge.Enabled = false;

                if (retiredCheckBox.Checked == false && disabilityCheckBox.Checked == false)
                {
                    disabilityStringData = "НЕТ ИНВАЛИДНОСТИ";
                }
            }
        }

        private void disabilityAge_ValueChanged(object sender, EventArgs e)
        {
            if (disabilityCheckBox.Checked == true && retiredAge.Enabled == true)
            {
                disabilityGroup.Enabled = true;
                disabilityAge.Enabled = true;
                disabilityStringData = $" Инвалидность: группа {disabilityGroup.Value} с {disabilityAge.Value} лет";
            }
            else
            {
                disabilityGroup.Enabled = false;
                disabilityAge.Enabled = false;

                if (retiredCheckBox.Checked == false && disabilityCheckBox.Checked == false)
                {
                    disabilityStringData = "НЕТ ИНВАЛИДНОСТИ";
                }
            }
        }
        #endregion

        #region AboutSmokingAll
        private void smokingAge_ValueChanged(object sender, EventArgs e)
        {
            if (smokingCheckBox.Checked == true)
            {
                smokingAge.Enabled = true;
                packOfSmokeNUmeric.Enabled = true;
                smokigStringData = $"с {smokingAge.Value} лет {packOfSmokeNUmeric.Value} пачек в день";
            }
            else
            {
                smokigStringData = "НЕ КУРИТ";
                smokingAge.Enabled = false;
                packOfSmokeNUmeric.Enabled = false;
            }
        }

        private void packOfSmokeNUmeric_ValueChanged(object sender, EventArgs e)
        {
            if (smokingCheckBox.Checked == true)
            {
                smokingAge.Enabled = true;
                packOfSmokeNUmeric.Enabled = true;
                smokigStringData = $"с {smokingAge.Value} лет {packOfSmokeNUmeric.Value} пачек в день";
            }
            else
            {
                smokigStringData = "НЕ КУРИТ";
                smokingAge.Enabled = false;
                packOfSmokeNUmeric.Enabled = false;
            }
        }

        private void smokingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (smokingCheckBox.Checked == true)
            {
                smokingAge.Enabled = true;
                packOfSmokeNUmeric.Enabled = true;
                smokigStringData = $"с {smokingAge.Value} лет {packOfSmokeNUmeric.Value} пачек в день";
            }
            else
            {
                smokigStringData = "НЕ КУРИТ";
                smokingAge.Enabled = false;
                packOfSmokeNUmeric.Enabled = false;
            }
        }
        #endregion

        #region AboutAlcohol
        private void alcoholAge_ValueChanged(object sender, EventArgs e)
        {
            if (alcoholCheckBox.Checked == true)
            {
                alcoholAge.Enabled = true;
                alchoholDrinking = $"с {alcoholAge.Value} лет";
            }
            else
            {
                alcoholAge.Enabled = false;
                alchoholDrinking = "НЕ УПОТРЕБЛЯЕТ АЛЬКОГОЛЬ";
            }
        }

        private void alcoholCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (alcoholCheckBox.Checked == true)
            {
                alchoholDrinking = $"с {alcoholAge.Value} лет";
                alcoholAge.Enabled = true;
            }
            else
            {
                alchoholDrinking = "НЕ УПОТРЕБЛЯЕТ АЛЬКОГОЛЬ";
                alcoholAge.Enabled = false;
            }
        }
        #endregion

        #region pastIllness
        private void pastIllnessTextBox_TextChanged(object sender, EventArgs e)
        {
            if (pastIllnessTextBox.Text != "ОТРИЦАЕТ")
            {
                pastIllness = pastIllnessTextBox.Text;
            }
            else
            {
                pastIllness = "ОТРИЦАЕТ";
            }
        }
        #endregion



        private void zimoticdeseasesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (zimoticdeseasesTextBox.Text != "ОТРИЦАЕТ")
            {
                zimoticdiseasesString = zimoticdeseasesTextBox.Text;
            }
            else
            {
                zimoticdiseasesString = "ОТРИЦАЕТ";
            }
        }

        private void allergyHistoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (allergyHistoryTextBox.Text != "ОТРИЦАЕТ")
            {
                allergyHistoryStringData = allergyHistoryTextBox.Text;
            }
            else
            {
                allergyHistoryStringData = "ОТРИЦАЕТ";
            }
        }

        private void pregnancyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pregnancyCheckBox.Checked == true)
            {
                pregnancyNumeric.Enabled = true;
                climactericNumeric.Enabled = true;
                abortsNumericUp.Enabled = true;
                childBearingNumericUp.Enabled = true;
                gestationNumericUp.Enabled = true;

                foreach (var a in pregnancyCheckBox_ChekedChanged1())
                {
                    a.Enabled = true;
                }
            }
            else
            {
                pregnancyNumeric.Enabled = false;
                climactericNumeric.Enabled = false;
                abortsNumericUp.Enabled = false;
                childBearingNumericUp.Enabled = false;
                gestationNumericUp.Enabled = false;
                foreach (var a in pregnancyCheckBox_ChekedChanged1())
                {
                    a.Enabled = false;
                }
            }
        }

        private void pregnancyNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (pregnancyCheckBox.Checked = true)
            {
                pregnancyNumeric.Enabled = true;
                pregnancyStringData = $"с {pregnancyNumeric.Value} лет";
            }
            else
            {
                pregnancyNumeric.Enabled = false;
                pregnancyStringData = "";
            }
        }

        private void climactericNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (pregnancyCheckBox.Checked = true)
            {
                climactericNumeric.Enabled = true;
                climatericStringData = $"{climactericNumeric.Value}";
            }
            else
            {
                climactericNumeric.Enabled = false;
            }
        }

        private void gestationNumericUp_ValueChanged(object sender, EventArgs e)
        {
            if (pregnancyCheckBox.Checked = true)
            {
                gestationNumericUp.Enabled = true;
                gestationNumericStringData = $"{gestationNumericUp.Value}";
            }
            else
            {
                gestationNumericUp.Enabled = false;
            }
        }

        private void childBearingNumericUp_ValueChanged(object sender, EventArgs e)
        {
            if (pregnancyCheckBox.Checked = true)
            {
                childBearingNumericUp.Enabled = true;
                childBearingStringData = $"{childBearingNumericUp.Value}";
            }
            else
            {
                childBearingNumericUp.Enabled = false;
            }
        }

        private void abortsNumericUp_ValueChanged(object sender, EventArgs e)
        {
            if (pregnancyCheckBox.Checked = true)
            {
                abortsNumericUp.Enabled = true;
                abortsNumericStringData = $"{abortsNumericUp.Value}";
            }
            else
            {
                abortsNumericUp.Enabled = false;
            }
            
        }

    }
}