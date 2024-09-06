using System.Drawing.Text;

namespace TestApp
{
    public partial class Form1 : Form
    {
        private class testClass
        {
            int biba; double boba; string stroka;

            public testClass(int biba, double boba, string stroka)
            {
                this.biba = biba;
                this.boba = boba;
                this.stroka = stroka;
            }
        }
        public Form1()
        {
            InitializeComponent();
            customComboBox.addString("aboba");
            customComboBox.addString("baobab");
            customComboBox.selectedString = "aboba";

            customTextBox4Date.setExemple("22.01.2004");
            customTextBox4Date.pattern = "dd.mm.yyyy";
            customTextBox4Date.text = DateTime.Now;

            customListBox.setPattern("биба: {biba}, боба: {boba}, строка:{stroka}");
            customListBox.AddLine<testClass>(new(1, 0.2, "lol"));
        }
    }
}
