namespace Visual_components_Kouvshinoff.Exeptions
{
    internal class NotMatchToPatternException : Exception
    {
        public string Pattern { get; }
        public string String { get; }

        public NotMatchToPatternException(string pattern, string @string)
        {
            Pattern = pattern;
            String = @string;
        }
    }
}
