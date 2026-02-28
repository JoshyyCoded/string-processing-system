using System;

namespace StringProcessingApp.Services
{
    public class StringService
    {
        private string origText = "";
        private string currentText = "";

        public void SetText(string text)
        {
            origText = text;
            currentText = text;
        }

        public string GetText()
        {
            return currentText;
        }

        public void ToUpperCase()
        {
            currentText = currentText.ToUpper();
        }

        public void ToLowerCase()
        {
            currentText = currentText.ToLower();
        }

        public int CountCharacters()
        {
            return currentText.Length;
        }

        public bool ContainsWord(string word)
        {
            return currentText.Contains(word, StringComparison.OrdinalIgnoreCase);
        }

        public void ReplaceWord(string oldWord, string newWord)
        {
            currentText = currentText.Replace(oldWord, newWord);
        }

        public string ExtractSubstring(int startIndex, int length)
        {
            return currentText.Substring(startIndex, length);
        }

        public void TrimSpaces()
        {
            currentText = currentText.Trim();
        }

        public void ResetText()
        {
            currentText = origText;
        }
    }
}
