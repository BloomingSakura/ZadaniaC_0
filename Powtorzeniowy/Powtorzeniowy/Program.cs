using Powtorzeniowy;

class PlikGłówny
{
    static void Main(string[] args)
    {
        //zmienna, która jest odwołaniem do innego skryptu
        Tablice tablica = new Tablice();

        //wywołujemy metodę tworzącą tablicę
        int[] tab = tablica.Tworzenie_tablicy();

        tablica.Wyswietl(tab);
        //wywołujemy metodę wyśwetlającą tablicę
        tablica.SortujBabelkowo(tab);

        tablica.Wyswietl(tab);
    }

}