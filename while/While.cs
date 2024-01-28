using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadzaj liczby od 0 do 10. Aby zakończyć, wpisz 5.");

        int userInput;
        int sum = 0;
        int minValue = int.MaxValue;

        while (true)
        {
            Console.Write("Podaj liczbę: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 5)
                break;

            if (userInput < 0 || userInput > 10)
            {
                Console.WriteLine("Liczba powinna być w zakresie od 0 do 10. Spróbuj ponownie.");
                continue;
            }

            sum += userInput * userInput;

            if (userInput < minValue)
                minValue = userInput;
        }

        Console.WriteLine($"Suma kwadratów: {sum}");
        Console.WriteLine($"Najmniejsza wartość: {minValue}");

        Console.ReadLine();
    }
}
