namespace Visual_components_Kouvshinoff
{
    partial class CustomComboBox
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox = new ComboBox();
            SuspendLayout();
            // 
            // comboBox
            // 
            comboBox.Dock = DockStyle.Fill;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.ForeColor = SystemColors.ActiveBorder;
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(0, 0);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(258, 23);
            comboBox.TabIndex = 0;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // CustomComboBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox);
            Name = "CustomComboBox";
            Size = new Size(258, 29);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox;
    }
}
