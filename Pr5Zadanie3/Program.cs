namespace Pr5Zadanie3;

public class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string text = Console.ReadLine();

        int count = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
            {
                if (i == 0 || text[i - 1] == ' ')
                {
                    count++;
                }
            }
        }

        Console.WriteLine("Количество слов с заглавной буквы: " + count);
    }
}