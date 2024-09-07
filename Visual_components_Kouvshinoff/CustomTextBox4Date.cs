using System.Globalization;
using Visual_components_Kouvshinoff.Exeptions;

namespace Visual_components_Kouvshinoff
{
    public partial class CustomTextBox4Date : UserControl
    {
        public CustomTextBox4Date()
        {
            InitializeComponent();
        }

        /// <summary>
        /// шаблон которому должна соответствовать дата, y - год, d - день, M - месяц, подробнее: https://learn.microsoft.com/ru-ru/dotnet/standard/base-types/custom-date-and-time-format-strings
        /// </summary>
        public string? pattern {  get; set; }

        /// <summary>
        /// установить пример который будет отображаться в toolTip
        /// </summary>
        /// <param name="exemple"></param>
        public void setExemple(string exemple)
        {
            toolTip.SetToolTip(textBox, "пример: " + exemple);
        }

        private event EventHandler? _textChanged;
        public event EventHandler textChanged
        {
            add { _textChanged += value; }
            remove { _textChanged -= value; }
        }
        
        public DateTime date
        {
            get
            {
                if (string.IsNullOrEmpty(pattern))
                    throw new NullPatternException();
                DateTime parsedDate;
                if (DateTime.TryParseExact(textBox.Text, pattern, null, DateTimeStyles.None, out parsedDate))
                    return parsedDate;
                else
                    throw new NotMatchToPatternException(pattern, textBox.Text);
            }
            set
            {
                if (string.IsNullOrEmpty(pattern))
                {
                    textBox.Text = string.Empty;
                }
                else
                {
                    textBox.Text = value.ToString(pattern);
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            _textChanged?.Invoke(this, e);
        }
    }
}
