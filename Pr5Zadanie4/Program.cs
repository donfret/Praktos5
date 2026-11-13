namespace Pr5Zadanie4;

public class Program
{
    static void Main()
    {
        Console.Write("Введите строку с разделением через определенный символ: ");
        string s = Console.ReadLine();

        Console.Write("Введите символ-разделитель: ");
        char separator = Convert.ToChar(Console.ReadLine());

        string[] parts = s.Split(separator);

        foreach (string part in parts)
        {
            if (part != "")
            {
                Console.WriteLine(part);
            }
        }
    }
}