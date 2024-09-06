namespace TestApp
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
            customComboBox = new Visual_components_Kouvshinoff.CustomComboBox();
            customListBox = new Visual_components_Kouvshinoff.CustomListBox();
            customTextBox4Date = new Visual_components_Kouvshinoff.CustomTextBox4Date();
            SuspendLayout();
            // 
            // customComboBox
            // 
            customComboBox.Location = new Point(12, 21);
            customComboBox.Name = "customComboBox";
            customComboBox.selectedString = "";
            customComboBox.Size = new Size(776, 33);
            customComboBox.TabIndex = 0;
            // 
            // customListBox
            // 
            customListBox.Location = new Point(12, 60);
            customListBox.Name = "customListBox";
            customListBox.selectedIndex = -1;
            customListBox.Size = new Size(776, 344);
            customListBox.TabIndex = 1;
            // 
            // customTextBox4Date
            // 
            customTextBox4Date.Location = new Point(12, 410);
            customTextBox4Date.Name = "customTextBox4Date";
            customTextBox4Date.pattern = null;
            customTextBox4Date.Size = new Size(776, 28);
            customTextBox4Date.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customTextBox4Date);
            Controls.Add(customListBox);
            Controls.Add(customComboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Visual_components_Kouvshinoff.CustomComboBox customComboBox;
        private Visual_components_Kouvshinoff.CustomListBox customListBox;
        private Visual_components_Kouvshinoff.CustomTextBox4Date customTextBox4Date;
    }
}
