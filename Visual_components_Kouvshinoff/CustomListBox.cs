using System.Reflection;
using System.Text;
using Visual_components_Kouvshinoff.Exeptions;

namespace Visual_components_Kouvshinoff
{
    public partial class CustomListBox : UserControl
    {
        private class Element
        {
            public string s;
            public bool isParam;
            public Element(string s, bool isParam)
            {
                this.s = s;
                this.isParam = isParam;
            }
        }

        private List<Element>? _pattern;

        public void setPattern(string pattern, char startSymbol, char endSymbol)
        {
            _pattern = new List<Element>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == endSymbol)
                    throw new WrongPatternException(pattern[i]);
                else if (pattern[i] == startSymbol)
                {
                    _pattern.Add(new(sb.ToString(), false));
                    sb.Clear();
                    i++;
                    while (i < pattern.Length && pattern[i] != endSymbol)
                    {
                        sb.Append(pattern[i]);
                        i++;
                    }
                    if (pattern[i] == endSymbol)
                    {
                        _pattern.Add(new(sb.ToString(), true));
                        sb.Clear();
                    }
                    else
                        throw new WrongPatternException(pattern[i]);
                }
                else
                    sb.Append(pattern[i]);
            }
            if (sb.Length > 0)
                _pattern.Add(new(sb.ToString(), false));
        }

        public int selectedIndex
        {
            set { listBox.SelectedIndex = value; }
            get { return listBox.SelectedIndex; }
        }

        public T getSelected<T>() where T : new()
        {
            T ret = new T();

            string text = listBox.Text;
            if (selectedIndex == -1)
                throw new Exception();
            if (_pattern == null)
                throw new ArgumentNullException(nameof(_pattern));
            int start = 0;
            for (int i = 0; i < _pattern.Count; i++)
            {
                var el = _pattern[i];
                if (el.isParam)
                {
                    StringBuilder sb = new StringBuilder();
                    int end = i == _pattern.Count - 1 ? text.Length : text.IndexOf(_pattern[i + 1].s, start);
                    if (end == start)
                        end = start + _pattern[i + 1].s.Length;
                    for (int j = start; j < end; j++)
                    {
                        sb.Append(text[j]);
                    }
                    FieldInfo? fieldInfo = typeof(T).GetField(el.s);
                    if (fieldInfo == null)
                        throw new NullReferenceException(el.s);

                    // Преобразуем строку к типу поля и присваиваем значение
                    object convertedValue = Convert.ChangeType(sb.ToString(), fieldInfo.FieldType);
                    fieldInfo.SetValue(ret, convertedValue);

                    start = end;
                }
                else
                    start += el.s.Length;
            }

            return ret;
        }

        public void AddLine<T>(T value)
        {
            StringBuilder sb = new StringBuilder();
            if (_pattern == null)
                throw new ArgumentNullException(nameof(_pattern));
            foreach (var el in _pattern)
            {
                if (el.isParam)
                {
                    FieldInfo? fieldInfo = typeof(T).GetField(el.s);
                    if (fieldInfo == null)
                        throw new NullReferenceException(el.s);
                    sb.Append(fieldInfo.GetValue(value));
                }
                else
                {
                    sb.Append(el.s);
                }
            }
            listBox.Items.Add(sb.ToString());
        }

        public void clearList()
        {
            listBox.Items.Clear();
        }

        public CustomListBox()
        {
            InitializeComponent();
        }

        private event EventHandler? _selectedIndexChanged;
        public event EventHandler selectedIndexChanged
        {
            add { _selectedIndexChanged += value; }
            remove { _selectedIndexChanged -= value; }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedIndexChanged?.Invoke(this, e);
        }
    }
}
