using System;
using StringProcessingApp.Services;

namespace StringProcessingApp.Views
{
    public class StringView
    {
        private StringService service = new StringService();

        public void Run()
        {
            bool input = true;

            Console.WriteLine("STRING PROCESSING SYSTEM");

            while (input)
            {
                Console.WriteLine("== MENU ==");
                Console.WriteLine("1. Enter Text");
                Console.WriteLine("2. View Current Text");
                Console.WriteLine("3. Convert to UPPERCASE");
                Console.WriteLine("4. Convert to lowercase");
                Console.WriteLine("5. Count Characters");
                Console.WriteLine("6. Check if Contains Word");
                Console.WriteLine("7. Replace Word");
                Console.WriteLine("8. Extract Substring");
                Console.WriteLine("9. Trim Spaces");
                Console.WriteLine("10. Reset Text");
                Console.WriteLine("11. Exit");
                Console.Write("Choose option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        EnterText();
                        break;
                    case "2":
                        ViewCurrentText();
                        break;
                    case "3":
                        ConvertToUpperCase();
                        break;
                    case "4":
                        ConvertToLowerCase();
                        break;
                    case "5":
                        CountCharacters();
                        break;
                    case "6":
                        CheckContainsWord();
                        break;
                    case "7":
                        ReplaceWord();
                        break;
                    case "8":
                        ExtractSubstring();
                        break;
                    case "9":
                        TrimSpaces();
                        break;
                    case "10":
                        ResetText();
                        break;
                    case "11":
                        input = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private void EnterText()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            service.SetText(text);
            Console.WriteLine("Text saved.");
        }

        private void ViewCurrentText()
        {
            Console.WriteLine("Current Text: " + service.GetText());
        }

        private void ConvertToUpperCase()
        {
            service.ToUpperCase();
            Console.WriteLine("Converted to UPPERCASE.");
        }

        private void ConvertToLowerCase()
        {
            service.ToLowerCase();
            Console.WriteLine("Converted to lowercase.");
        }

        private void CountCharacters()
        {
            Console.WriteLine("Character Count: " + service.CountCharacters());
        }

        private void CheckContainsWord()
        {
            Console.Write("Enter word to check: ");
            string word = Console.ReadLine();

            if (service.ContainsWord(word))
            {
                Console.WriteLine($"{word} word is found.");
            }
            else
            {
                Console.WriteLine($"{word} word is not found.");
            }
        }

        private void ReplaceWord()
        {
            Console.Write("Word to replace: ");
            string oldWord = Console.ReadLine();
            Console.Write("Replace with: ");
            string newWord = Console.ReadLine();
            service.ReplaceWord(oldWord, newWord);
            Console.WriteLine("Word replaced.");
        }

        private void ExtractSubstring()
        {
            try
            {
                Console.Write("Start index: ");
                int start = int.Parse(Console.ReadLine());

                Console.Write("Length: ");
                int length = int.Parse(Console.ReadLine());

                string result = service.ExtractSubstring(start, length);
                Console.WriteLine("Substring: " + result);
            }
            catch
            {
                Console.WriteLine("Invalid index or length.");
            }
        }

        private void TrimSpaces()
        {
            service.TrimSpaces();
            Console.WriteLine("Spaces trimmed.");
        }

        private void ResetText()
        {
            service.ResetText();
            Console.WriteLine("Text reset to original text.");
        }
    }
}
