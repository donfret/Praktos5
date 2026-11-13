namespace Pr5Zadanie2;

public class Program
{
    static void Main()
    {
        Console.Write("Введите строку с пробелами: ");
        string text = Console.ReadLine();

        int first = text.IndexOf(' ');
        int last = text.LastIndexOf(' ');

        if (first != -1 && last != -1 && first < last)
        {
            string result = text.Substring(first + 1, last - first - 1);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Недостаточно пробелов");
        }
    }
}