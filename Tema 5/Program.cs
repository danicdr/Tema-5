using System;

class Program
{
    static void Main()
    {
        //1.Scrieti un program care va afisa pozitia unui substring intr-un string, ambele siruri de caractere fiind citite de la tastatura

        //Console.WriteLine("Introduceti textul:");
        //string sir = console.ReadLine();

        //Console.WriteLine("Introduceti subsirul:");
        //string substring = Console.ReadLine();

        //int pozitia = sir.IndexOf(substring);

        //Console.WriteLine($"Substringul este la pozitia {pozitia} in sirul {sir}");



        //2.Scrieti un program care sa verifice daca un sir de caractere citit de la tastatura este sau nu palindrom.

        //Console.WriteLine("Introduceti textul:");
        //string sir = Console.ReadLine();
        // length = sir.Length;

        //for (int i = 0; i < length / 2; i++)
        //{
        //if (sir[i] != sir[length - i - 1])
        //{
        //Console.WriteLine("Nu e palindrom");

        //}
        //}

        //Console.WriteLine("E palindrom");


        

      5.using System;

class Program
{
    // Ex 4
    // Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit
    // de la tastatura, ignorand caseing-ul literelor.
    // Exemplu:
    // Input: Elena are mere
    // Output: e apare de 5 ori
    static void Main()
    {
        Console.WriteLine("Introduceti un sir de caractere:");
        var text = Console.ReadLine();
        Console.WriteLine(CountLetter(text.ToLower()));
    }

    static string CountLetter(string text)
    {
        int[] LettersArr = new int[255];

        int max = 0;
        char countletter = ' ';

        for (int i = 0; i < text.Length; i++)
        {
            LettersArr[text[i]]++;
            if (max < LettersArr[text[i]])
            {
                max = LettersArr[text[i]];
                countletter = text[i];
            }
        }

        return $@"Litera {(char)countletter} apare de {max} ori";
    }
}




        //6.Screiti un program care va numara vocalele dintr-un sir de caractere citit de la tastatura.

        //Console.WriteLine("Introduceti textul:");
        //string sir = Console.ReadLine();

        //int numarvocale = NumaraVocale(sir);
        //Console.WriteLine($"Numarul de vocale in sirul {sir} este de {numarvocale}.");
    //}

    //static int NumaraVocale(string input)
   //{
        //int count = 0;
        //string vocale = "aeiouăâîAEIOUĂÂÎ";

        //foreach (char c in input)
        //{
           //if (vocale.Contains(c))
            //{
                //count++;
            //}
        //}
        //return count;
    }
}
