using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SA_W2_ArrayLists
{
    internal static class ArrayPlay01
    {
        internal static string CreateConsoleMenu()
        {
            //Todo create menu:
            //Vyber následující
            //1 - vytvorit pole nahodnych cisel od 1-6
            //2 - napis carkou nebo pomlkou oddelene cisla, seradim je
            //3 - ukonci program
            string MenuOut = "";
            return MenuOut;
        }

        internal static int[] GenerateArrayOfNumbers1t06(int numberOfItems)
        {
            //Vytvorte pole nahodnych cisel velikosti numberOfItems
            return new int[] { 1,2,3,3};
        }
        internal static string GiveStatisticsOnPassedNumArray(int[] arrayIn)
        {
            string statisticSummary = "";
            double computedAverage = -1; //Spocitejte pomoci projiti hodnot pole prumernou hodnotu
            int minimum = -1; //spocitat
            int maximum = -1; //spocitat
           
            statisticSummary += $"AVERAGE = {computedAverage}";
            statisticSummary += "/n" + $"MINIMUM = {minimum}";
            statisticSummary += "/n" + $"MAXIMUM = {maximum}";
            return statisticSummary;
        }
        internal static int[] ParseStringIntoArrayOfInts(string input)
        {
            //zkusi parsovat string input pomoci funkce Split ze třídy String
            if (input == "")
            {
                throw new FormatException("input nemá žádnou hodnotu!");
            }
            string[] stringArray = input.Trim().Split(',');
            if (stringArray.Length == 0)
            {
                stringArray = input.Trim().Split(" ");
            }
            int[] intArrayOut = new int[stringArray.Length];
            for (int i=0; i< stringArray.Length; i++)
            {
                string aktualniPoziceVPoli = stringArray[i].Trim();
                //zkusit zkonvertovat na int
                if (!int.TryParse(aktualniPoziceVPoli, out int aktualniIntParse))
                {
                    throw new FormatException($"Hodnota '{aktualniPoziceVPoli}' není platné číslo (int)!");
                }
                //aktualni zkonvertovane cislo vlozit do pole co vracime
                intArrayOut[i] = aktualniIntParse;
            }
            return intArrayOut;

        }
        internal static int[] SortArray(int[] arrayIn, bool ascend)
        {
            int[] newSortedArrayOut = new int[arrayIn.Length];
            //Pomoci třídy Array seřad pole a vrat ho
            // Pouzij COPY PROC?   Array.Copy()
            //serad pole a vrat volajicimu
            if (ascend) //vzestupne
            {
                //Pouzit Sort()
            }
            else
            {
                //pouzit Reverse()
            }
            return newSortedArrayOut;

        }

    }
}
