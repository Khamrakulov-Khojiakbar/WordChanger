using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsMicrosoft.Forms
{
    public partial class SecondInfoMenu : Form
    {

        public MainWindowAddPacient mainForm { get; set; }

        public SecondInfoMenu(MainWindowAddPacient form)
        {
            InitializeComponent();
            mainForm = form;
            urineAmountCombobox.SelectedIndex = 0;
        }
        public SecondInfoMenu()
        {
            InitializeComponent();
            urineAmountCombobox.SelectedIndex = 0;
            bladderCombobox.SelectedIndex = 0;
            urinationCombobox.SelectedIndex = 0;
            kidneyPalpationCombobox.SelectedIndex = 0;
            symptomTapping12thRibCheckBoxNegative.Checked = true;
            urineColorCombobox.SelectedIndex = 0;
            thyroidPalpableCombobox.SelectedIndex = 0;
            thyroidSizeCombobox.SelectedIndex = 0;
            thyroidConsistencyCombobox.SelectedIndex = 0;
            thyroidNodulesCombobox.SelectedIndex = 0;
            FeelingCombobox.SelectedIndex = 0;
            FeelingCombobx2.SelectedIndex = 0;
            memoryCombobox.SelectedIndex = 0;
            intelligenceCombobox.SelectedIndex = 0;
            suspiciousnessCheckboxNo.Checked = true;
            suggestibilityCheckboxNo.Checked = true;
            speechTexbox.Text = "Внятная";
            gaitTextbox.Text = "Ровная";
            pathologicalReflexesTexbox.Text = "Отсутствуют";
            dermographsimCombobox1.SelectedIndex = 0;
            dermographsimCombobox2.SelectedIndex = 0;
            rombergPoseCombobox1.SelectedIndex = 0;
            rombergPoseCombobox2.SelectedIndex = 0;


        }

        public void CompleteStrings()
        {
            var mform = mainForm;
            mform.SCM_urineAmountStringData = urineAmountCombobox.SelectedIndex.ToString();
            mform.SCM_bladderStringData = bladderCombobox.SelectedIndex.ToString();
            mform.SCM_urinationStringData = urinationCombobox.SelectedIndex.ToString();
            mform.SCM_kidneyPalpationStringData = kidneyPalpationCombobox.SelectedIndex.ToString();
            mform.SCM_urineColorStringData = urineColorCombobox.SelectedIndex.ToString();
            mform.SCM_thyroidPalpableStringData = thyroidPalpableCombobox.SelectedIndex.ToString();
            mform.SCM_thyroidSizeStringData = thyroidSizeCombobox.SelectedIndex.ToString();
            mform.SCM_thyroidNodelusStringData = thyroidNodulesCombobox.SelectedIndex.ToString();
            mform.SCM_FeelingStringData = FeelingCombobox.SelectedIndex.ToString();
            mform.SCM_Feeling2StringData = FeelingCombobx2.SelectedIndex.ToString();
            mform.SCM_memoryStringData = memoryCombobox.SelectedIndex.ToString();
            mform.SCM_intelligenceStringData = intelligenceCombobox.SelectedIndex.ToString();
            mform.SCM_speechStringData = speechTexbox.Text.ToString();
            mform.SCM_gaitStringData = gaitTextbox.Text.ToString();
            mform.SCM_pathologicalReflexesStringData = pathologicalReflexesTexbox.Text.ToString();
            mform.SCM_dermographsimStringData = dermographsimCombobox1.SelectedIndex.ToString();
            mform.SCM_dermographsim2StringData = dermographsimCombobox2.SelectedIndex.ToString();
            mform.SCM_rombergPoseStringData = rombergPoseCombobox1.SelectedIndex.ToString();
            mform.SCM_rombergPose2StringData = rombergPoseCombobox2.SelectedIndex.ToString();
        }
    }
}
