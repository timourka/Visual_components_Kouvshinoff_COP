using System.Globalization;
using Visual_components_Kouvshinoff.Exeptions;

namespace Visual_components_Kouvshinoff
{
    public partial class CustomTextBox4Date : UserControl
    {
        public string? pattern {  get; set; }

        public void setExemple(string exemple)
        {
            toolTip.SetToolTip(textBox, exemple);
        }

        public CustomTextBox4Date()
        {
            InitializeComponent();
        }

        private event EventHandler? _textChanged;
        public event EventHandler TextChanged
        {
            add { _textChanged += value; }
            remove { _textChanged -= value; }
        }

        public DateTime text
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
