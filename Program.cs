namespace _3SA_W2_ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Vytejte v hrátkách s poli");
                Console.WriteLine("*************************");
                ArrayPlay01.CreateConsoleMenu(); //zavolej vytvoreni menu
                string responseIn = Console.ReadLine();
                if (responseIn == "1")
                {
                    Console.WriteLine("--- zvoleno 1 ---");
                    //Vyzvi uzivatele k zadani poctu cisel
                    //zkonvertuj jeho odpoved jako int numberOfItems
                    //Pokud konverze selze a nebo cislo je vetsi nez 100000 tak zadej 1000.

                    int numberOfItems = 100;
                    int [] numberArray = ArrayPlay01.GenerateArrayOfNumbers1t06(numberOfItems);
                    //do console napis radku s kazdou polozkou vygenerovaneho pole
                    //Zavolej funkci na vypsani statistic do Console 
                    for (int ii=0;ii<numberArray.Length; ii++)
                    {
                        Console.WriteLine(numberArray[ii]);
                    }
                }
                else if (responseIn == "2")
                {
                    Console.WriteLine("--- zvoleno 2 ---");
                    //Vyzvi uzivatele k zadani rady cisel oddelenyma carkou
                    //nacti toto do prommenne string radaCiselString
                    //Zavolej funkci ParseStringIntoArrayOfInts ze tridy ArrayPlay01
                    //Zavolej funkci SortArray ze tridy ArrayPlay01 a setrid toto pole
                    //vytiskni do Console serazene hodnoty.

                }
                else if (responseIn == "3")
                {
                    Console.WriteLine("--- zvoleno 3 ---");
                    break;
                }
                else
                {
                    Console.WriteLine("Chybná volba zkus znovu");
                }
            }
        }
    }
}
