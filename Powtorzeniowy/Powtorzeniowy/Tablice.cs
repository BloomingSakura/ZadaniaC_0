using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powtorzeniowy
{
    public class Tablice
    {
        //Tworzymy publicze funkcje w skrypcie Tablice
        public void Wyswietl(int[] tab)
        {
           for(int i = 0; i < tab.Length; i++)
           {
                Console.Write(tab[i]+ ", ");
           }
        }
        public int[] Tworzenie_tablicy()
        {
            //pobieramy długość tablicy od użytkownika
            Console.WriteLine("Ile znaków ma mieć tablica?");
            int dl = int.Parse(Console.ReadLine());

            //tworzymy pustą tablicę o podanej długości
            int[] ints = new int[dl];

            //dodajemy kolejno elementy do tablicy
            for(int i = 0; i < dl; i++)
            {
                Console.Write("Podaj kolejny element:");
                ints[i] = int.Parse(Console.ReadLine());
            }
            return ints;
        }
    }
}
