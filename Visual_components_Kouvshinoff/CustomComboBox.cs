namespace Visual_components_Kouvshinoff
{
    public partial class CustomComboBox : UserControl
    {
        public void addString(string s)
        {
            if (string.IsNullOrEmpty(s))
                throw new ArgumentNullException(nameof(s));
            try
            {
                comboBox.Items.Add(s);
            }
            catch
            {
                throw;
            }
        }

        public void clearList()
        {
            comboBox.Items.Clear();
        }

        public string selectedString
        {
            get
            {
                return (string)(comboBox.SelectedItem ?? string.Empty);
            }
            set
            {
                comboBox.SelectedItem = value;
            }
        }

        private event EventHandler? _selectedIndexChanged;
        public event EventHandler selectedIndexChanged
        {
            add { _selectedIndexChanged += value; }
            remove { _selectedIndexChanged -= value; }
        }

        public CustomComboBox()
        {
            InitializeComponent();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedIndexChanged?.Invoke(this, e);
        }
    }
}
