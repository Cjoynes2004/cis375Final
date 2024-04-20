namespace CIS375Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            titleLabe = new Label();
            classLabel = new Label();
            classTextBox = new TextBox();
            explainLabel = new Label();
            purposeLabel = new Label();
            taskLabel = new Label();
            domainLabel = new Label();
            functionLabel = new Label();
            repeatLabel = new Label();
            multipleLabel = new Label();
            generalLabel = new Label();
            reuseLabel = new Label();
            docuLabel = new Label();
            planLabel = new Label();
            purposeCheck = new CheckBox();
            taskCheck = new CheckBox();
            systemCheck = new CheckBox();
            multCheck = new CheckBox();
            generalCheck = new CheckBox();
            docuCheck = new CheckBox();
            planCheck = new CheckBox();
            reuseabilityLabel = new Label();
            couplingLabel = new Label();
            cohesionLabel = new Label();
            modularLabel = new Label();
            indieLabel = new Label();
            sigLabel = new Label();
            integrableLabel = new Label();
            worthLabel = new Label();
            worthCheck = new CheckBox();
            integrableCheck = new CheckBox();
            sigCheck = new CheckBox();
            indieCheck = new CheckBox();
            modularCheck = new CheckBox();
            cohesionCheck = new CheckBox();
            couplingCheck = new CheckBox();
            reuseButton = new Button();
            inheritanceLabel = new Label();
            inheritanceCheck = new CheckBox();
            answerLabel = new Label();
            resetButton = new Button();
            helpButton = new Button();
            SuspendLayout();
            // 
            // titleLabe
            // 
            titleLabe.AutoSize = true;
            titleLabe.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabe.Location = new Point(351, 9);
            titleLabe.Name = "titleLabe";
            titleLabe.Size = new Size(332, 39);
            titleLabe.TabIndex = 0;
            titleLabe.Text = "Reusable Class TinyTool";
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            classLabel.Location = new Point(14, 99);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(87, 15);
            classLabel.TabIndex = 1;
            classLabel.Text = "Name of Class:";
            // 
            // classTextBox
            // 
            classTextBox.Location = new Point(106, 96);
            classTextBox.Name = "classTextBox";
            classTextBox.Size = new Size(100, 23);
            classTextBox.TabIndex = 2;
            // 
            // explainLabel
            // 
            explainLabel.AutoSize = true;
            explainLabel.Location = new Point(187, 48);
            explainLabel.Name = "explainLabel";
            explainLabel.Size = new Size(678, 45);
            explainLabel.TabIndex = 3;
            explainLabel.Text = resources.GetString("explainLabel.Text");
            explainLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // purposeLabel
            // 
            purposeLabel.AutoSize = true;
            purposeLabel.Location = new Point(14, 160);
            purposeLabel.Name = "purposeLabel";
            purposeLabel.Size = new Size(322, 15);
            purposeLabel.TabIndex = 4;
            purposeLabel.Text = "1. Is the primary purpose of the object/class clearly defined?";
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.Location = new Point(14, 190);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(355, 15);
            taskLabel.TabIndex = 5;
            taskLabel.Text = "2. Have you identified the key tasks the application must perform?";
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            domainLabel.Location = new Point(14, 132);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new Size(157, 15);
            domainLabel.TabIndex = 6;
            domainLabel.Text = "Understanding the Domain";
            // 
            // functionLabel
            // 
            functionLabel.AutoSize = true;
            functionLabel.Location = new Point(14, 218);
            functionLabel.Name = "functionLabel";
            functionLabel.Size = new Size(388, 30);
            functionLabel.TabIndex = 7;
            functionLabel.Text = "3. Have you identified existing systems that have similar functionality to \r\nyour proposed class?";
            // 
            // repeatLabel
            // 
            repeatLabel.AutoSize = true;
            repeatLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            repeatLabel.Location = new Point(14, 282);
            repeatLabel.Name = "repeatLabel";
            repeatLabel.Size = new Size(135, 15);
            repeatLabel.TabIndex = 8;
            repeatLabel.Text = "Assessing Repeatability";
            // 
            // multipleLabel
            // 
            multipleLabel.AutoSize = true;
            multipleLabel.Location = new Point(14, 308);
            multipleLabel.Name = "multipleLabel";
            multipleLabel.Size = new Size(355, 15);
            multipleLabel.TabIndex = 9;
            multipleLabel.Text = "4. Is the object/class used in multiple places throughout the code?";
            // 
            // generalLabel
            // 
            generalLabel.AutoSize = true;
            generalLabel.Location = new Point(14, 333);
            generalLabel.Name = "generalLabel";
            generalLabel.Size = new Size(368, 15);
            generalLabel.TabIndex = 10;
            generalLabel.Text = "5. Can the object/class attributes and methods be easily generalized?";
            // 
            // reuseLabel
            // 
            reuseLabel.AutoSize = true;
            reuseLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reuseLabel.Location = new Point(14, 394);
            reuseLabel.Name = "reuseLabel";
            reuseLabel.Size = new Size(120, 15);
            reuseLabel.TabIndex = 11;
            reuseLabel.Text = "Documenting Reuse";
            // 
            // docuLabel
            // 
            docuLabel.AutoSize = true;
            docuLabel.Location = new Point(14, 421);
            docuLabel.Name = "docuLabel";
            docuLabel.Size = new Size(293, 15);
            docuLabel.TabIndex = 12;
            docuLabel.Text = "14. Does the object/class have proper documentation?";
            // 
            // planLabel
            // 
            planLabel.AutoSize = true;
            planLabel.Location = new Point(14, 447);
            planLabel.Name = "planLabel";
            planLabel.Size = new Size(344, 15);
            planLabel.TabIndex = 13;
            planLabel.Text = "15. Is there a maintenance plan for the reuse of the object/class?";
            // 
            // purposeCheck
            // 
            purposeCheck.AutoSize = true;
            purposeCheck.Location = new Point(406, 160);
            purposeCheck.Name = "purposeCheck";
            purposeCheck.Size = new Size(15, 14);
            purposeCheck.TabIndex = 14;
            purposeCheck.UseVisualStyleBackColor = true;
            // 
            // taskCheck
            // 
            taskCheck.AutoSize = true;
            taskCheck.Location = new Point(406, 190);
            taskCheck.Name = "taskCheck";
            taskCheck.Size = new Size(15, 14);
            taskCheck.TabIndex = 15;
            taskCheck.UseVisualStyleBackColor = true;
            // 
            // systemCheck
            // 
            systemCheck.AutoSize = true;
            systemCheck.Location = new Point(406, 219);
            systemCheck.Name = "systemCheck";
            systemCheck.Size = new Size(15, 14);
            systemCheck.TabIndex = 16;
            systemCheck.UseVisualStyleBackColor = true;
            // 
            // multCheck
            // 
            multCheck.AutoSize = true;
            multCheck.Location = new Point(406, 308);
            multCheck.Name = "multCheck";
            multCheck.Size = new Size(15, 14);
            multCheck.TabIndex = 17;
            multCheck.UseVisualStyleBackColor = true;
            // 
            // generalCheck
            // 
            generalCheck.AutoSize = true;
            generalCheck.Location = new Point(406, 334);
            generalCheck.Name = "generalCheck";
            generalCheck.Size = new Size(15, 14);
            generalCheck.TabIndex = 18;
            generalCheck.UseVisualStyleBackColor = true;
            // 
            // docuCheck
            // 
            docuCheck.AutoSize = true;
            docuCheck.Location = new Point(406, 421);
            docuCheck.Name = "docuCheck";
            docuCheck.Size = new Size(15, 14);
            docuCheck.TabIndex = 19;
            docuCheck.UseVisualStyleBackColor = true;
            // 
            // planCheck
            // 
            planCheck.AutoSize = true;
            planCheck.Location = new Point(406, 448);
            planCheck.Name = "planCheck";
            planCheck.Size = new Size(15, 14);
            planCheck.TabIndex = 20;
            planCheck.UseVisualStyleBackColor = true;
            // 
            // reuseabilityLabel
            // 
            reuseabilityLabel.AutoSize = true;
            reuseabilityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reuseabilityLabel.Location = new Point(427, 132);
            reuseabilityLabel.Name = "reuseabilityLabel";
            reuseabilityLabel.Size = new Size(122, 15);
            reuseabilityLabel.TabIndex = 21;
            reuseabilityLabel.Text = "Assessing Reusability";
            // 
            // couplingLabel
            // 
            couplingLabel.AutoSize = true;
            couplingLabel.Location = new Point(427, 159);
            couplingLabel.Name = "couplingLabel";
            couplingLabel.Size = new Size(236, 15);
            couplingLabel.TabIndex = 22;
            couplingLabel.Text = "6. Does the object/class have low coupling?";
            // 
            // cohesionLabel
            // 
            cohesionLabel.AutoSize = true;
            cohesionLabel.Location = new Point(427, 189);
            cohesionLabel.Name = "cohesionLabel";
            cohesionLabel.Size = new Size(242, 15);
            cohesionLabel.TabIndex = 23;
            cohesionLabel.Text = "7. Does the object/class have high cohesion?";
            // 
            // modularLabel
            // 
            modularLabel.AutoSize = true;
            modularLabel.Location = new Point(427, 218);
            modularLabel.Name = "modularLabel";
            modularLabel.Size = new Size(248, 15);
            modularLabel.TabIndex = 24;
            modularLabel.Text = "8. Is the class modular and hides information?";
            // 
            // indieLabel
            // 
            indieLabel.AutoSize = true;
            indieLabel.Location = new Point(427, 243);
            indieLabel.Name = "indieLabel";
            indieLabel.Size = new Size(316, 15);
            indieLabel.TabIndex = 25;
            indieLabel.Text = "9. Does the object/class exercise functional independence?";
            // 
            // sigLabel
            // 
            sigLabel.AutoSize = true;
            sigLabel.Location = new Point(427, 293);
            sigLabel.Name = "sigLabel";
            sigLabel.Size = new Size(352, 30);
            sigLabel.TabIndex = 26;
            sigLabel.Text = "11. Can you integrate the object/class into your program without \r\nmaking significant changes?\r\n";
            // 
            // integrableLabel
            // 
            integrableLabel.AutoSize = true;
            integrableLabel.Location = new Point(427, 334);
            integrableLabel.Name = "integrableLabel";
            integrableLabel.Size = new Size(346, 15);
            integrableLabel.TabIndex = 27;
            integrableLabel.Text = "12. Is the class easily integrable with current software interfaces? ";
            // 
            // worthLabel
            // 
            worthLabel.AutoSize = true;
            worthLabel.Location = new Point(427, 360);
            worthLabel.Name = "worthLabel";
            worthLabel.Size = new Size(364, 30);
            worthLabel.TabIndex = 28;
            worthLabel.Text = "13. Is it worthwhile (efficient in time, space, cost, or other resources)\r\nto integrate your class into your system?";
            // 
            // worthCheck
            // 
            worthCheck.AutoSize = true;
            worthCheck.Location = new Point(801, 361);
            worthCheck.Name = "worthCheck";
            worthCheck.Size = new Size(15, 14);
            worthCheck.TabIndex = 29;
            worthCheck.UseVisualStyleBackColor = true;
            // 
            // integrableCheck
            // 
            integrableCheck.AutoSize = true;
            integrableCheck.Location = new Point(801, 335);
            integrableCheck.Name = "integrableCheck";
            integrableCheck.Size = new Size(15, 14);
            integrableCheck.TabIndex = 30;
            integrableCheck.UseVisualStyleBackColor = true;
            // 
            // sigCheck
            // 
            sigCheck.AutoSize = true;
            sigCheck.Location = new Point(801, 294);
            sigCheck.Name = "sigCheck";
            sigCheck.Size = new Size(15, 14);
            sigCheck.TabIndex = 31;
            sigCheck.UseVisualStyleBackColor = true;
            // 
            // indieCheck
            // 
            indieCheck.AutoSize = true;
            indieCheck.Location = new Point(801, 243);
            indieCheck.Name = "indieCheck";
            indieCheck.Size = new Size(15, 14);
            indieCheck.TabIndex = 32;
            indieCheck.UseVisualStyleBackColor = true;
            // 
            // modularCheck
            // 
            modularCheck.AutoSize = true;
            modularCheck.Location = new Point(801, 218);
            modularCheck.Name = "modularCheck";
            modularCheck.Size = new Size(15, 14);
            modularCheck.TabIndex = 33;
            modularCheck.UseVisualStyleBackColor = true;
            // 
            // cohesionCheck
            // 
            cohesionCheck.AutoSize = true;
            cohesionCheck.Location = new Point(801, 189);
            cohesionCheck.Name = "cohesionCheck";
            cohesionCheck.Size = new Size(15, 14);
            cohesionCheck.TabIndex = 34;
            cohesionCheck.UseVisualStyleBackColor = true;
            // 
            // couplingCheck
            // 
            couplingCheck.AutoSize = true;
            couplingCheck.Location = new Point(801, 159);
            couplingCheck.Name = "couplingCheck";
            couplingCheck.Size = new Size(15, 14);
            couplingCheck.TabIndex = 35;
            couplingCheck.UseVisualStyleBackColor = true;
            // 
            // reuseButton
            // 
            reuseButton.Location = new Point(741, 403);
            reuseButton.Name = "reuseButton";
            reuseButton.Size = new Size(75, 23);
            reuseButton.TabIndex = 36;
            reuseButton.Text = "Reusable?";
            reuseButton.UseVisualStyleBackColor = true;
            reuseButton.Click += reuseButton_Click;
            // 
            // inheritanceLabel
            // 
            inheritanceLabel.AutoSize = true;
            inheritanceLabel.Location = new Point(427, 269);
            inheritanceLabel.Name = "inheritanceLabel";
            inheritanceLabel.Size = new Size(238, 15);
            inheritanceLabel.TabIndex = 37;
            inheritanceLabel.Text = "10. Does the object/class utilize inheritance?";
            // 
            // inheritanceCheck
            // 
            inheritanceCheck.AutoSize = true;
            inheritanceCheck.Location = new Point(801, 269);
            inheritanceCheck.Name = "inheritanceCheck";
            inheritanceCheck.Size = new Size(15, 14);
            inheritanceCheck.TabIndex = 38;
            inheritanceCheck.UseVisualStyleBackColor = true;
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            answerLabel.Location = new Point(427, 447);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(0, 15);
            answerLabel.TabIndex = 39;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(660, 403);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 40;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // helpButton
            // 
            helpButton.Location = new Point(14, 25);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(75, 23);
            helpButton.TabIndex = 41;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 182, 213);
            ClientSize = new Size(1053, 591);
            Controls.Add(helpButton);
            Controls.Add(resetButton);
            Controls.Add(answerLabel);
            Controls.Add(inheritanceCheck);
            Controls.Add(inheritanceLabel);
            Controls.Add(reuseButton);
            Controls.Add(couplingCheck);
            Controls.Add(cohesionCheck);
            Controls.Add(modularCheck);
            Controls.Add(indieCheck);
            Controls.Add(sigCheck);
            Controls.Add(integrableCheck);
            Controls.Add(worthCheck);
            Controls.Add(worthLabel);
            Controls.Add(integrableLabel);
            Controls.Add(sigLabel);
            Controls.Add(indieLabel);
            Controls.Add(modularLabel);
            Controls.Add(cohesionLabel);
            Controls.Add(couplingLabel);
            Controls.Add(reuseabilityLabel);
            Controls.Add(planCheck);
            Controls.Add(docuCheck);
            Controls.Add(generalCheck);
            Controls.Add(multCheck);
            Controls.Add(systemCheck);
            Controls.Add(taskCheck);
            Controls.Add(purposeCheck);
            Controls.Add(planLabel);
            Controls.Add(docuLabel);
            Controls.Add(reuseLabel);
            Controls.Add(generalLabel);
            Controls.Add(multipleLabel);
            Controls.Add(repeatLabel);
            Controls.Add(functionLabel);
            Controls.Add(domainLabel);
            Controls.Add(taskLabel);
            Controls.Add(purposeLabel);
            Controls.Add(explainLabel);
            Controls.Add(classTextBox);
            Controls.Add(classLabel);
            Controls.Add(titleLabe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabe;
        private Label classLabel;
        private TextBox classTextBox;
        private Label explainLabel;
        private Label purposeLabel;
        private Label taskLabel;
        private Label domainLabel;
        private Label functionLabel;
        private Label repeatLabel;
        private Label multipleLabel;
        private Label generalLabel;
        private Label reuseLabel;
        private Label docuLabel;
        private Label planLabel;
        private CheckBox purposeCheck;
        private CheckBox taskCheck;
        private CheckBox systemCheck;
        private CheckBox multCheck;
        private CheckBox generalCheck;
        private CheckBox docuCheck;
        private CheckBox planCheck;
        private Label reuseabilityLabel;
        private Label couplingLabel;
        private Label cohesionLabel;
        private Label modularLabel;
        private Label indieLabel;
        private Label sigLabel;
        private Label integrableLabel;
        private Label worthLabel;
        private CheckBox worthCheck;
        private CheckBox integrableCheck;
        private CheckBox sigCheck;
        private CheckBox indieCheck;
        private CheckBox modularCheck;
        private CheckBox cohesionCheck;
        private CheckBox couplingCheck;
        private Button reuseButton;
        private Label inheritanceLabel;
        private CheckBox inheritanceCheck;
        private Label answerLabel;
        private Button resetButton;
        private Button helpButton;
    }
}
