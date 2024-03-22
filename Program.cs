using System;

class Program
{
    static void Main(string[] args)
    {
        
        string text = "Це приклад тексту для перевірки роботи лямбди.";

       
        string wordToFind = "перевірки";

        
        Func<string, string, bool> wordChecker = (inputText, word) =>
            inputText.ToLower().Contains(word.ToLower());

        
        bool containsWord = wordChecker(text, wordToFind);
        Console.WriteLine($"Текст містить слово '{wordToFind}': {containsWord}");
    }
}
