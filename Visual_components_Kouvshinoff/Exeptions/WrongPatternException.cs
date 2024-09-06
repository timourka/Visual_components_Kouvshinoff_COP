namespace Visual_components_Kouvshinoff.Exeptions
{
    internal class WrongPatternException : Exception
    {
        public char wrongChar { get; }

        public WrongPatternException(char wrongChar)
        {
            this.wrongChar = wrongChar;
        }
    }
}
