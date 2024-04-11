using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Зчитування чисел з файлу
            string[] numbers = File.ReadAllText(@"D:/Дз/Програмування/111.txt").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Перетворення рядка чисел в масив цілих чисел та знаходження їх суми
            int[] intNumbers = Array.ConvertAll(numbers, int.Parse);
            int sum = intNumbers.Sum();

            // Виведення суми елементів масиву
            Console.WriteLine($"Сума елементів масиву: {sum}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл не знайдено.");
        }
        catch (IOException)
        {
            Console.WriteLine("Помилка читання з файлу.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Файл містить некоректні дані.");
        }

        Console.ReadLine(); // Чекаємо на натискання клавіші перед завершенням програми
    }
}
