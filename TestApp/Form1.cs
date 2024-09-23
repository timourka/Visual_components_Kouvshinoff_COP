using System.Drawing.Text;

namespace TestApp
{
    public partial class Form1 : Form
    {
        private class testClass
        {
            public int biba { get { return _biba;  } set { _biba = value; } }
            private int _biba;
            public double boba;
            public string? stroka;

            public testClass() { }

            public testClass(int biba, double boba, string stroka)
            {
                this.biba = biba;
                this.boba = boba;
                this.stroka = stroka;
            }

            public override string ToString()
            {
                return $"биба: {biba}, боба: {boba}, строка: {stroka}";
            }
        }

        public Form1()
        {
            InitializeComponent();
            customComboBox.addString("aboba");
            customComboBox.addString("baobab");
            customComboBox.selectedString = "aboba";

            customTextBox4Date.setExemple("22.01.2004");
            customTextBox4Date.pattern = "dd.MM.yyyy";
            customTextBox4Date.date = DateTime.Today;

            customListBox.setPattern("биба: {biba}, боба: {boba}, строка: {stroka};", '{', '}');
            customListBox.AddLine<testClass>(new(1, 0.2, "lol"));
            customListBox.AddLine<testClass>(new(1, 0.2, ";"));
        }

        private void customComboBox_selectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"customComboBox_selectedIndexChanged\n{customComboBox.selectedString}");
            }
            catch { }
        }

        private void customListBox_selectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"customListBox_selectedIndexChanged\n{customListBox.getSelected<testClass>()}");
            }
            catch { }
        }

        private void customTextBox4Date_textChanged(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"customTextBox4Date_textChanged\n{customTextBox4Date.date}");
            }
            catch { }
        }
    }
}
