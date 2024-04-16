namespace CIS375Final
{
    public partial class Form1 : Form
    {
        List<CheckBox> checkboxes = new List<CheckBox>();
        private bool isReusable;
        private int score;
        public Form1()
        {
            InitializeComponent();

            checkboxes.Add(generalCheck);
            checkboxes.Add(purposeCheck);
            checkboxes.Add(taskCheck);
            checkboxes.Add(docuCheck);
            checkboxes.Add(cohesionCheck);
            checkboxes.Add(couplingCheck);
            checkboxes.Add(indieCheck);
            checkboxes.Add(integrableCheck);
            checkboxes.Add(modularCheck);
            checkboxes.Add(multCheck);
            checkboxes.Add(planCheck);
            checkboxes.Add(sigCheck);
            checkboxes.Add(systemCheck);
            checkboxes.Add(worthCheck);
            checkboxes.Add(inheritanceCheck);

            isReusable = false;
            score = 0;
        }

        private void reuseButton_Click(object sender, EventArgs e)
        {
            if (!purposeCheck.Checked || !modularCheck.Checked || !sigCheck.Checked)
            {
                isReusable = false;
            }
            else
            {
                foreach (var checkbox in checkboxes)
                {
                    if (checkbox.Checked)
                    {
                        ++score;
                    }
                }
                if (score >= 10)
                {
                    isReusable = true;
                }
            }

            if (isReusable)
            {
                answerLabel.Text = $"{classTextBox.Text} is reusable.";
            }
            else
            {
                answerLabel.Text = $"{classTextBox.Text} is not reusable.";
            }
            score = 0;
        }
    }
}
