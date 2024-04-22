using Powtorzeniowy;

class PlikGłówny
{
    static void Main(string[] args)
    {
        //zmienna, która jest odwołaniem do innego skryptu
        Tablice tablica = new Tablice();

        //wywołujemy metodę tworzącą tablicę
        int[] tab = tablica.Tworzenie_tablicy();

        //wywołujemy metodę wyśwetlającą tablicę
        tablica.Wyswietl(tab);
        
       

    }

}