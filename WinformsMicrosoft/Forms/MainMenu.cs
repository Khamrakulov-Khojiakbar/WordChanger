using System.Configuration;
using WinformsMicrosoft.Forms;
using WinformsMicrosoft.WordChanger;

namespace WinformsMicrosoft
{
    public partial class MainWindowAddPacient : Form
    {
        public CheckBox socialLivingConditionsCheckBox;
        public CheckBox occupationalHazardsCheckbox;

        private string? wordFilePath;

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
        private string pregnancyProcessStringData = "";
        private string breastsStringData = "";
        private string generalConditionStringData = "";
        private string bodytemperatureStringData = "";
        private string pacientWeightStringData = "";
        private string pacientHeightStringData = "";
        private string consciousStringData = "";
        private string positionStringData = "";
        private string bodyTypeStringData = "";
        public string skinCoverStringData { get; set; }
        public string subSkinCoverStringData { get; set; }
        public string lungsMobilityDownPart { get; set; }
        private string nasalBreathingStringData = "";
        private string lymphNodesStringData = "";
        public string jointsStringData { get; set; }
        public string bonesStringData { get; set; }
        public string musculesStringData { get; set; }
        public string hearingStringData { get; set; }
        public string eyesStringData { get; set; }
        public string skinSensivityStringData { get; set; }
        public string charmStringData { get; set; }
        public string ribCageStringData { get; set; }
        public string chestBreathingStringData { get; set; }
        public string muscleBreathingStringData { get; set; }
        public string voiceTremosStringData { get; set; }
        public string lungBiteStringData { get; set; }
        public string lowerBordersStringData { get; set; }
        public string lungsMobitlityStringData { get; set; }
        public string ausculatationLungsStringData { get; set; }
        public string wheezingStringData { get; set; }
        public string heartExamStringData { get; set; }
        public string precordialPulsationStringData { get; set; }
        public string epigastricPulsationStringData { get; set; }
        public string pulsationVisibleStringData { get; set; }
        public string cyanosisStringData { get; set; }
        public string neckVeinsSwellingStringData { get; set; }
        public string rightHeartBorderStringData { get; set; }
        public string leftHeartBorderStringData { get; set; }
        public string topHeartBorderStringData { get; set; }
        public string ausculatationHeartStringData { get; set; }
        public string systolicNoiseStringData { get; set; }
        public string flapValveStringData { get; set; }
        public string leftEdgeSternumStringData { get; set; }
        public string dystonicNoiseStringData { get; set; }
        public string pulmonaryArteryStringData { get; set; }
        public string systolicAndDistonicNoisesStringData { get; set; }
        public string veinsStringData { get; set; }
        public string pulseRhytmStringData { get; set; }
        public string frequencyStringData { get; set; }
        public string heartRateDeficitStringData { get; set; }
        public string bloodPressureStringData { get; set; }
        public string umbilicalAreaNoiseStringData { get; set; }
        public string slizistayaPolostiRtaStringData { get; set; }
        public string teethStringData { get; set; }
        public string pharynxStringData { get; set; }
        public string tonsilsStringData { get; set; }
        public string stomachStringData { get; set; }
        public string liverStringData { get; set; }
        public string priPalpaciiKrayStringData { get; set; }
        public string priPalpaciiPoverhStringData { get; set; }
        public string boleznennostStringData { get; set; }
        public string konsitenciaStringData { get; set; }
        public string simptomyJelchnogoPuzyryaStringData { get; set; }
        public string podJeludochnyaJelezaStringData { get; set; }
        public string selezenkaGranicStringData { get; set; }
        public string nijnyayaGranicaStringData { get; set; }
        public string priPalpaciiKraySelezenkaStringData { get; set; }
        public string priPalpaciiPoverhnostSelezenkaStringData { get; set; }
        public string boleznennocstSelezenkaStringData { get; set; }
        public string konsistenciaSelezenkaStringData { get; set; }
        public string stulSoSlovStringData { get; set; }
        public string palpaciyaCheckBoxStringData { get; set; }



        public MainWindowAddPacient()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            panel1.BackColor = ColorTranslator.FromHtml("#C5EBAA");
            panel2.BackColor = ColorTranslator.FromHtml("#A5DD9B");
            panel3.BackColor = ColorTranslator.FromHtml("#A5DD9B");
            panel4.BackColor = ColorTranslator.FromHtml("#A5DD9B");
            panel5.BackColor = ColorTranslator.FromHtml("#F6F193");
            InitializeCheckBoxes();
            DontDoThis();
            IntializePregnancyCheckBox();
            FalseAll();
            alcoholAge.Value = 18;
            dateTimePicker2.Text = DateTime.Now.ToString("HH:mm");
            wordFilePath = $"{ConfigurationManager.AppSettings["WordFilePath"]}";
        }

        private void DontDoThis()
        {
            DontWrite(chestBreathingCombobox);
            DontWrite(muscleBreathingCombobox);
            DontWrite(voiceTremosCombobox);
            DontWrite(ribCageComboBox);
            DontWrite(lungBiteCombobox);
            DontWrite(lowerBordersCombobox);
            DontWrite(ausculatationLungsCombobox);
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
            pregnancyProccessingTextBox.Enabled = false;
            complaintsTextBoxMainForm.Enabled = false;
        }

        private void FillAll()
        {

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
                FillStrings();
                if (!string.IsNullOrEmpty(wordFilePath))
                {


                    var helper = new WordHelper(wordFilePath);
                    var items = new Dictionary<string, string>
                {
                    #region Fields program first page
                        {"<FIO>", textBox1.Text },
                        {"<BD>", dateTimePicker1.Text },
                        {"<DTN>", DateTime.Now.ToString("dd.MM.yyyy") },
                        {"<Time>", DateTime.Now.ToString("HH:mm") },
                        {"<COMPL>", complaintsTextBoxMainForm.Text },
                        {"<PAIN1>", painsMainTextBox.Text },
                        {"morbi",  anamnesismorbiTextBox.Text},
                        {"vitae",  anamnesisVitaeTextBox.Text},
                        {"<SLC>", $"({socialLivingConditionsCheckBox.Text})" },
                        {"<occupationalHazards>", $"({occupationalHazardsCheckbox.Text}) {occupationalHazardsTextBox.Text}" },
                        {"<retired>", retiredStringData },
                        {"<disability>", disabilityStringData },
                        {"<smoking>", smokigStringData },
                        {"<alcohol>", alchoholDrinking },
                        {"<pastillness>", pastIllness },
                        {"<zimoticdiseases>", zimoticdiseasesString },
                        {"<allergyHistory>", allergyHistoryStringData},
                        {"<pregnancyData>", $"{pregnancyStringData}" },
                        {"<pregnancyDataCheckBox>", pregnancyCheckBoxStringData},
                        {"<climatericNum>", climatericStringData },
                        {"<gestationData>", gestationNumericStringData },
                        {"<childBearingData>", childBearingStringData },
                        {"<abortsData>", abortsNumericStringData },
                        {"<pregnancyProccessing>", pregnancyProcessStringData },
                        {"<breasts>", breastsStringData },
                    #endregion

                    #region Sostoyanie bolnogo
                        {"<generalCondition>", generalConditionStringData},
                        {"<bodyT>", bodytemperatureStringData},
                        {"<weightP>", pacientWeightStringData},
                        {"<heightP>", pacientHeightStringData},
                        {"<pacientConscious>", consciousStringData},
                        {"<pacientPosition>", positionStringData},
                        {"<bodyType>", bodyTypeStringData },
                        {"<skinCover>", skinCoverStringData},
                        {"<subSkinTissue>", subSkinCoverStringData},
                        {"<nails>", nailsTextBox.Text},
                        {"<muscules>", musculesStringData},
                        {"<bones>", bonesStringData},
                        {"<joints>", jointsStringData},
                        {"<lymphNodes>", lymphNodesStringData},
                        {"<eyes>", eyesStringData},
                        {"<hearing>", hearingStringData},
                        {"<skinSensivity>", skinSensivityStringData},
                    #endregion

                    #region Sistema Dyhaniya
                        {"<nasalBreathing>", nasalBreathingStringData},
                        {"<ribCage>", ribCageStringData},
                        {"<chestBreathing>", chestBreathingStringData},
                        {"<muscleBreathing>", muscleBreathingStringData},
                        {"<voiceTremos>", voiceTremosStringData},
                        {"<lungBite>", lungBiteStringData},
                        {"<lowerBorders>", lowerBordersStringData},
                        {"<lungsMobilityDownPart>", lungsMobilityDownPart},
                        {"<ausculatationData>", ausculatationHeartStringData},
                        {"<wheezingData>", wheezingStringData},
                    #endregion

                    #region Serdechno-Sosudistaya sistema
                        {"<heartExam>", heartExamStringData},
                        {"<precordialPulsation>", precordialPulsationStringData},
                        {"<epicgastricPulsation>", epigastricPulsationStringData},
                        {"<pulsationVisible>", pulsationVisibleStringData},
                        {"<cyanosisData>", cyanosisStringData},
                        {"<neckveinsSwelling>", neckVeinsSwellingStringData},
                        //{"<>"}
                        {"<ausculatationHeaart>", ausculatationHeartStringData},
                        {"<systolicNoise>", systolicNoiseStringData},
                        {"<dystonicNoise>", dystonicNoiseStringData},
                        {"<pulmonaryArtery>", pulmonaryArteryStringData},
                        {"systolicAndDistonicNoises", systolicAndDistonicNoisesStringData},
                        {"<flapValve>", flapValveStringData},
                        {"<leftEdgeSternum>", leftEdgeSternumStringData},
                        //{}
                        {"<veinsData>", veinsStringData},
                        {"<pulseRhytm>", pulseRhytmStringData},
                        {"<freq>", frequencyStringData},
                        {"<hrd>", heartRateDeficitStringData},
                        {"<bloodPressure>", bloodPressureStringData},
                        {"<umAreaNoise>", umbilicalAreaNoiseStringData},

                        

                    #endregion

                    #region Sistema-pishevareniya

                        {"<slizistayaPolos>", slizistayaPolostiRtaStringData},
                        {"<teeth>", teethStringData},
                        {"<tongue>", },
                        {"<pharynx>", pharynxStringData},
                        {"<tonsils>", tonsilsStringData},
                        {"<stomachData>", stomachStringData},
                        {"<liverData>", liverStringData},
                        {"<liverU>", liverUpNUm.ToString()},
                        {"<dn>", liverDownNum.ToString()},
                        {"<ln>", liverLeftNum.ToString()},
                        {"<livPal>", priPalpaciiKrayStringData},
                        {"<livPov>", priPalpaciiPoverhStringData},
                        {"<livbol>", boleznennostStringData},
                        {"<livKon>", konsitenciaStringData},
                        {"<palpacChkBox>", palpaciyaCheckBoxStringData},
                        {"<symptJelch>", simptomyJelchnogoPuzyryaStringData},
                        {"<>", },
                        {"<>", },
                        {"<>", },
                        {"<>", },
                        {"<>", },



                    #endregion





                };

                    //helper.FIOForFile = textBox1.Text + DateTime.Now.ToString(" dd_MM_yyyy HH:mm");
                    helper.FIOForFile = textBox1.Text;
                    helper.FIOForFile += $" {time}";

                    string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string appFolderPath = Path.Combine(documentsPath, "Пациенты Авангард");

                    helper.Process(items);
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo($"{appFolderPath}/{helper.FIOForFile + ".docx"}") { UseShellExecute = true }); ;
                }
                else
                {
                    MessageBox.Show("Возможно указан не верный путь к файлу", "Не найден файл", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"FileNotFound Error: {ex.Message}", "Не найден файл", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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


        #region
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

        private void pregnancyProcessingChekcBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pregnancyProcessingChekcBoxOtherValue.Checked != true)
            {
                pregnancyProccessingTextBox.Enabled = false;
                pregnancyProcessingNormalCheckBox.Enabled = true;
                pregnancyProcessingSwellingCheckBox.Enabled = true;
                pregProcessingAGCheckBox.Enabled = true;
                pregProcessingBelokCheckBox.Enabled = true;

            }
            else
            {
                pregnancyProccessingTextBox.Enabled = true;
                pregnancyProcessingNormalCheckBox.Enabled = false;
                pregnancyProcessingSwellingCheckBox.Enabled = false;
                pregProcessingAGCheckBox.Enabled = false;
                pregProcessingBelokCheckBox.Enabled = false;
            }
        }

        private void pregnancyProccessingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (pregnancyProcessingChekcBoxOtherValue.Checked != true)
            {
                pregnancyProccessingTextBox.Enabled = false;
            }
            else
            {
                pregnancyProccessingTextBox.Enabled = true;
                pregnancyProcessStringData = pregnancyProccessingTextBox.Text;
            }
        }

        CheckBox pregnancyProcessCheckBox;

        private void pregnancyProcessingCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox activeCheckBox = sender as CheckBox;

            if (activeCheckBox.Checked && activeCheckBox != pregnancyProcessCheckBox && pregnancyProcessCheckBox != null)
            {
                pregnancyProcessCheckBox.Checked = false;
            }

            //pregnancyProcessCheckBox = activeCheckBox.Checked ? activeCheckBox : null;
            if (activeCheckBox.Checked)
            {
                pregnancyProcessCheckBox = activeCheckBox;
                pregnancyProcessStringData = pregnancyProcessCheckBox.Text;
            }
            else
            {
                pregnancyProcessCheckBox = null;
            }


        }

        CheckBox bodyTypeLastCheckedCheckBox;
        private void bodyTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox activeCheckBox = sender as CheckBox;

            if (activeCheckBox.Checked && activeCheckBox != bodyTypeLastCheckedCheckBox && bodyTypeLastCheckedCheckBox != null)
            {
                bodyTypeLastCheckedCheckBox.Checked = false;
            }

            //bodyTypeLastCheckedCheckBox = activeCheckBox.Checked ? activeCheckBox : null;
            if (activeCheckBox.Checked)
            {
                bodyTypeLastCheckedCheckBox = activeCheckBox;
                bodyTypeStringData = bodyTypeLastCheckedCheckBox.Text;
            }
            else
            {
                bodyTypeLastCheckedCheckBox = null;
            }

        }
        /*
                private void GetlastCheckBoxText()
                {
                    if (pregnancyProcessingChekcBoxOtherValue.Enabled != false)
                    {
                        pregnancyStringData = pregnancyProcessCheckBox.Text;
                    }
                    else
                    {
                        pregnancyStringData = pregnancyProccessingTextBox.Text;
                    }

                }*/

        private void breastsTextBox_TextChanged(object sender, EventArgs e)
        {
            breastsStringData = breastsTextBox.Text;
        }

        CheckBox pacientConsciousChk;
        private void pacientConsciousCheckBoxes(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;

            if (activeCheckBox.Checked && activeCheckBox != pacientConsciousChk && pacientConsciousChk != null)
            {
                pacientConsciousChk.Checked = false;
            }

            //pacientConsciousChk = activeCheckBox.Checked ? activeCheckBox : null;
            if (activeCheckBox.Checked)
            {
                pacientConsciousChk = activeCheckBox;
                consciousStringData = pacientConsciousChk.Text.ToUpper();
            }
            else
            {
                pacientConsciousChk = null;
            }
        }

        CheckBox pacientPositionChkTemp;
        private void pacientPositionCheckBoxes(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;

            if (activeCheckBox.Checked && activeCheckBox != pacientPositionChkTemp && pacientPositionChkTemp != null)
            {
                pacientPositionChkTemp.Checked = false;
            }

            // pacientPositionChkTemp = activeCheckBox.Checked ? activeCheckBox : null; 

            if (activeCheckBox.Checked)
            {
                pacientPositionChkTemp = activeCheckBox;
                positionStringData = pacientPositionChkTemp.Text.ToUpper();
            }
            else
            {
                pacientPositionChkTemp = null;
            }
        }

        private void generalStatePresentTime_TextChanged(object sender, EventArgs e)
        {
            generalConditionStringData = generalStatePresentTime.Text.ToUpper();
        }

        private void bodyTemperature_TextChanged(object sender, EventArgs e)
        {
            bodytemperatureStringData = bodyTemperature.Text;
        }

        private void pacientWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            pacientWeightStringData = pacientWeightTextBox.Text;
        }

        private void pacientHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            pacientHeightStringData = pacientHeightTextBox.Text;
        }
        CheckBox bodyTypeCheckBoxTemp;
        private void bodyTypeCheckBoxes(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;

            if (activeCheckBox.Checked && activeCheckBox != bodyTypeCheckBoxTemp && bodyTypeCheckBoxTemp != null)
            {
                bodyTypeCheckBoxTemp.Checked = false;
            }

            // pacientPositionChkTemp = activeCheckBox.Checked ? activeCheckBox : null; 

            if (activeCheckBox.Checked)
            {
                bodyTypeCheckBoxTemp = activeCheckBox;
                bodyTypeStringData = bodyTypeCheckBoxTemp.Text.ToUpper();
            }
            else
            {
                bodyTypeCheckBoxTemp = null;
            }
        }


        private void DontWrite(ComboBox combobox)
        {
            if (combobox.SelectedItem != null && combobox.SelectedItem.ToString() == "др")
            {
                combobox.DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            }

        }
        #endregion
        CheckBox lungsMobility;
        private void lungsMobilityCheckBoxes(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;

            if (activeCheckBox.Checked && activeCheckBox != lungsMobility && lungsMobility != null)
            {
                lungsMobility.Checked = false;
            }

            if (activeCheckBox.Checked)
            {
                lungsMobility = activeCheckBox;
                if (lungsMobility.Text == "в норме")
                {
                    lungsMobilityDownPart = lungsMobility.Text;
                    lungsMobilityNumericDown.Enabled = false;
                }
                else
                {
                    if (lungsMobilityNumericDown.Enabled == false)
                        lungsMobilityNumericDown.Enabled = true;
                    lungsMobilityDownPart = $"{lungsMobility.Text} {lungsMobilityNumericDown.Value} см";

                }
            }
            else
            {
                lungsMobility = null;
            }
        }

        private void lungsMobilityNumericDown_ValueChanged(object sender, EventArgs e)
        {
            lungsMobilityDownPart = $"{lungsMobility.Text} {lungsMobilityNumericDown.Value} см";
        }

        private void ausculatationLungs_SelectedIndexChanged(object sender, EventArgs e)
        {
            DontWrite(ausculatationLungsCombobox);
        }

        private void furtherOpenButton_Click(object sender, EventArgs e)
        {
            SecondInfoMenu secondInfoMenu = new SecondInfoMenu();
            secondInfoMenu.Show();
        }

        private void nasalBreathingTextBox_TextChanged(object sender, EventArgs e)
        {
            nasalBreathingStringData = nasalBreathingTextBox.Text;
        }

        private void lymphNodesTextBox_TextChanged(object sender, EventArgs e)
        {
            lymphNodesStringData = lymphNodesTextBox.Text;
        }

        private void jointsTextBox_TextChanged(object sender, EventArgs e)
        {
            //jointsStringData = jointsTextBox.Text;
        }

        private void bonesTextBox_TextChanged(object sender, EventArgs e)
        {
            //bonesStringData = bonesTextBox.Text;
        }

        private void musculesTextBox_TextChanged(object sender, EventArgs e)
        {
            //musculesStringData = musculesTextBox.Text;
        }

        private void eyesTextBox_TextChanged(object sender, EventArgs e)
        {
            // eyesStringData = eyesTextBox.Text;
        }

        private void hearingTextBox_TextChanged(object sender, EventArgs e)
        {
            //  hearingStringData = hearingTextBox.Text;
        }

        private void skinSensivityTextBox_TextChanged(object sender, EventArgs e)
        {
            // skinSensivityStringData = skinSensivityTextBox.Text;
        }

        private void charmTextBox_TextChanged(object sender, EventArgs e)
        {
            // charmStringData = charmTextBox.Text;
        }

        private void ribCageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ribCageStringData = ribCageComboBox.SelectedIndex.ToString();
        }

        private void chestBreathingCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chestBreathingStringData = chestBreathingCombobox.SelectedIndex.ToString();
        }




        private  void FillStrings()
        {
                skinCoverStringData = skinCoverTextBox.Text;
                subSkinCoverStringData = subSkinTissueTextBox.Text;
                lymphNodesStringData = lymphNodesTextBox.Text;
                nasalBreathingStringData = nasalBreathingTextBox.Text;
                jointsStringData = jointsTextBox.Text;
                bonesStringData = bonesTextBox.Text;
                musculesStringData = musculesTextBox.Text;
                hearingStringData = hearingTextBox.Text;
                eyesStringData = eyesTextBox.Text;
                skinSensivityStringData = skinSensivityTextBox.Text;
                charmStringData = charmTextBox.Text;
                ribCageStringData = ribCageComboBox.SelectedIndex.ToString();
                chestBreathingStringData = chestBreathingCombobox.SelectedIndex.ToString();
                muscleBreathingStringData = muscleBreathingCombobox.SelectedIndex.ToString();
                voiceTremosStringData = voiceTremosCombobox.SelectedIndex.ToString();
                lungBiteStringData = lungBiteCombobox.SelectedIndex.ToString();
                lowerBordersStringData = lowerBordersCombobox.SelectedIndex.ToString();
                ausculatationLungsStringData = ausculatationLungsCombobox.SelectedIndex.ToString();
                wheezingStringData = wheezingCombobo.SelectedIndex.ToString();
                heartExamStringData = heartExamCombobo.SelectedIndex.ToString();
                precordialPulsationStringData = precordialPulsationCombobox.SelectedIndex.ToString();
                epigastricPulsationStringData = epigastricPulsationCombobox.SelectedIndex.ToString();
                pulsationVisibleStringData = pulsationVisibleCombobox.SelectedIndex.ToString();
                cyanosisStringData = cyanosisCombobox.SelectedIndex.ToString();
                neckVeinsSwellingStringData = neckVeinsSwellingCombobox.SelectedIndex.ToString();
                rightHeartBorderStringData = rightHeartBorderTextBox.Text;
                leftHeartBorderStringData = leftHeartBorderTextBox.Text;
                topHeartBorderStringData = topHeartBordertextBox.Text;
                ausculatationHeartStringData = ausculatationHeartCombobox.SelectedIndex.ToString();
                systolicNoiseStringData = systolicNoiseCombobox.SelectedIndex.ToString();
                flapValveStringData = flapValveTextBox.Text;
                leftEdgeSternumStringData = leftEdgeSternumTextBox.Text;
                dystonicNoiseStringData = dystonicNoiseCombobox.SelectedIndex.ToString();
                pulmonaryArteryStringData = pulmonaryArteryCombobox.SelectedIndex.ToString();
                systolicAndDistonicNoisesStringData = systolicAndDistonicNoisesCombobox.SelectedIndex.ToString();
                veinsStringData = veinsTextBox.Text;
                pulseRhytmStringData = pulseRhytmTextBox.Text;
                frequencyStringData = frequencyTextBox.Text;
                heartRateDeficitStringData = heartRateDeficitTextBox.Text;
                bloodPressureStringData = $"{bloodPressureTextBox.Text}/{bloodPressure2TextBox.Text} ";
                umbilicalAreaNoiseStringData = umbilicalAreaNoiseTextBox.Text;
                slizistayaPolostiRtaStringData = slizistayaPolostiRtaCombobox.SelectedIndex.ToString();
                teethStringData = teethTextBox.Text;
                pharynxStringData = pharynxTextBox.Text;
                tonsilsStringData = tonsilsTextBox.Text;
                stomachStringData = $"{stomachCombobox.SelectedIndex.ToString()} {stomachCombobox1.SelectedIndex.ToString()} {stomachCombobox2.SelectedIndex.ToString()}";
                liverStringData = liverCombobox.SelectedIndex.ToString();
                priPalpaciiKrayStringData = priPalpaciiKrayCombobox.SelectedIndex.ToString();
                priPalpaciiPoverhStringData = priPalpaciiPovernostCombobox.SelectedIndex.ToString();
                boleznennostStringData = boleznennostCombobox.SelectedIndex.ToString();
                konsitenciaStringData = konsitenciaCombobox.SelectedIndex.ToString();
                simptomyJelchnogoPuzyryaStringData = simptomyJelchnogoPuzyryaCombobox.SelectedIndex.ToString();
                podJeludochnyaJelezaStringData = podJeludochnyaJelezaCombobox.SelectedIndex.ToString();
                selezenkaGranicStringData = selezenkaGranicCombobox.SelectedIndex.ToString();
                nijnyayaGranicaStringData = nijnyayaGranicaCombobox.SelectedIndex.ToString();
                priPalpaciiKraySelezenkaStringData = priPalpaciiKrayCombobox.SelectedIndex.ToString();
                priPalpaciiPoverhnostSelezenkaStringData = priPalpaciiPoverhnostSelezenkaCombobox.SelectedIndex.ToString();
                boleznennocstSelezenkaStringData = boleznennocstSelezenkaCombobox.SelectedIndex.ToString();
                konsistenciaSelezenkaStringData = konsistenciaSelezenkaCombobox.SelectedIndex.ToString();
                stulSoSlovStringData = stulSoSlovCombobox.SelectedIndex.ToString();
                palpaciyaCheckBoxStringData = "пальпируется";
        }
        CheckBox palpaciyaChkBoxTemp;
        private void palpaciyaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;

            if(activeCheckBox.Checked && activeCheckBox != palpaciyaChkBoxTemp && palpaciyaChkBoxTemp != null)
            {
                palpaciyaChkBoxTemp.Checked = false;
            }

            if(activeCheckBox.Checked)
            {
                palpaciyaChkBoxTemp = activeCheckBox;
                palpaciyaCheckBoxStringData = palpaciyaChkBoxTemp.Text.ToUpper();
            }
            else
            {
                palpaciyaChkBoxTemp = null;
            }
        }

        public string SCM_urineAmountStringData { get; set; }
        public string SCM_bladderStringData { get; set; }
        public string SCM_urinationStringData { get; set; }
        public string SCM_kidneyPalpationStringData { get; set; }
        public string SCM_urineColorStringData { get; set; }
        public string SCM_thyroidPalpableStringData { get; set; }
        public string SCM_thyroidSizeStringData { get; set; }
        public string SCM_thyroidNodelusStringData { get; set; }
        public string SCM_FeelingStringData { get; set; }
        public string SCM_Feeling2StringData { get; set; }
        public string SCM_memoryStringData { get; set; }
        public string SCM_intelligenceStringData { get; set; }
        public string SCM_speechStringData { get; set; }
        public string SCM_gaitStringData { get; set; }
        public string SCM_pathologicalReflexesStringData { get; set; }
        public string SCM_dermographsimStringData { get; set; }
        public string SCM_dermographsim2StringData { get; set; }
        public string SCM_rombergPoseStringData { get; set; }

        public string SCM_rombergPose2StringData { get; set; }



    }
}