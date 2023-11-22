using System;

namespace TextFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
           // Ввод текста с консоли
        Console.WriteLine("Введите текст:");
        string inputText = Console.ReadLine();

        // Приводим текст к нормальному виду
        string normalizedText = NormalizeText(inputText);

        // Выводим результат
        Console.WriteLine("Нормализованный текст:");
        Console.WriteLine(normalizedText);
    }

    static string NormalizeText(string text)
    {
        // Разделяем текст на предложения
        string[] sentences = text.Split('.', '!', '?');

        // Обработка каждого предложения
        for (int i = 0; i < sentences.Length; i++)
        {
            // Удаляем лишние пробелы в предложении
            sentences[i] = sentences[i].Trim();

            // Проверяем, чтобы предложение было не пустым
            if (!string.IsNullOrEmpty(sentences[i]))
            {
                // Преобразуем первую букву предложения в заглавную
                sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1).ToLower();
            }
        }

        // Соединяем предложения в одну строку с разделителями
        string result = string.Join(". ", sentences);

        return result;
        }
    }
}