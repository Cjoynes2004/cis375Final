using System.Diagnostics;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Media;

namespace CIS375Final
{
    public partial class Form1 : Form
    {
        List<CheckBox> checkboxes = new List<CheckBox>();
        private bool isReusable;
        public Form1()
        {
            InitializeComponent();

            checkboxes.Add(purposeCheck);
            checkboxes.Add(taskCheck);
            checkboxes.Add(systemCheck);
            checkboxes.Add(multCheck);
            checkboxes.Add(generalCheck);
            checkboxes.Add(couplingCheck);
            checkboxes.Add(cohesionCheck);
            checkboxes.Add(modularCheck);
            checkboxes.Add(indieCheck);
            checkboxes.Add(inheritanceCheck);
            checkboxes.Add(sigCheck);
            checkboxes.Add(integrableCheck);
            checkboxes.Add(worthCheck);
            checkboxes.Add(docuCheck);
            checkboxes.Add(planCheck);

            isReusable = false;
        }

        private void reuseButton_Click(object sender, EventArgs e)
        {
            isReusable = CheckReusable(checkboxes);

            if (isReusable)
            {
                answerLabel.Text = $"{classTextBox.Text} is reusable.";
            }
            else
            {
                answerLabel.Text = $"{classTextBox.Text} is not reusable, below are the unchecked questions:\n";
                for (int i = 0; i < checkboxes.Count; i++)
                {
                    if (!checkboxes[i].Checked)
                    {
                        answerLabel.Text += $"{i + 1}, ";
                    }
                }
            }
            isReusable = false;
        }

        public bool CheckReusable(List<CheckBox> checks)
        {
            int score = 0;
            if (!checks[0].Checked || !checks[7].Checked || !checks[10].Checked)
            {
                return false;
            }
            else
            {
                foreach (var checkbox in checks)
                {
                    if (checkbox.Checked)
                    {
                        ++score;
                    }
                }
                if (score >= 10)
                {
                    return true;
                }
                return false;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            foreach (var checkbox in checkboxes)
            {
                checkbox.Checked = false;
            }
            classTextBox.Text = string.Empty;
            answerLabel.Text = string.Empty;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            byte[] pdfBytes = Properties.Resource1.usermanual;
            string tempFilePath = Path.GetTempFileName();
            tempFilePath = Path.ChangeExtension(tempFilePath, ".pdf");

            File.WriteAllBytes(tempFilePath, pdfBytes);
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = tempFilePath,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
