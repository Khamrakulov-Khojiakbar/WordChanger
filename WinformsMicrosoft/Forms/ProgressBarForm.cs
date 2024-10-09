namespace WinformsMicrosoft.Forms
{
    public partial class ProgressBarForm : Form
    {

        public ProgressBarForm()
        {
            InitializeComponent();
        }
        int i = 1;
        public void WorkProgressBar(int nums, string name)
        {
            progressBar.Maximum = nums;
            if (nums > progressBar.Value)
            {
                progressBar.Value = nums - (nums - i);
                i++;
                label2.Text = name;
                
                Thread.Sleep(ReturnRandomNumber());
            }
        }

        public void WorkProgressBar(int nums, string name, string key)
        {
            try
            {
                progressBar.Maximum = nums;
                if (nums > progressBar.Value)
                {
                    progressBar.Value = nums - (nums - i);
                    i++;
                    label2.Text = $"{name}, \t {key}";

                    Thread.Sleep(ReturnRandomNumber());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + key);
            }

            
        }

        private int ReturnRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(10, 150);
        }

    }
}
