// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

class Player
{
    public string Name { get; set; }
    public int Position { get; set; }
    public int Score { get; set; }

    void Ruch(int x , int y)
    {
        
    }

    public void akt(int score)
    {
        Score = score;
    }
}

class Board{

    int plansza = 64;

    public int nagroda(int x, int y)
    {
        
    }
}

class Game
{ 
    public int[] lokalizacjaNagroda = new int[20];
    public int poleGracz= int 0;
    public void Gra()
    {
        Random losowanie = new Random();
        int poleGraczDodaj=losowanie.Next(1,7);
        poleGracz =poleGracz+poleGraczDodaj;
        if(poleGracz>64)
        {
            poleGracz=poleGracz% 64;
        }
    }

    public void poleNagroda()
    {
 
        Random losowanie = new Random();
        for (int i = 0; i < 20; i++)
        {
            int x =losowanie.Next(1, 65);
            lokalizacjaNagroda[i] = x;
        }
    }

    public int wynik()
    {
        int wynik = 0;

        foreach (int nagroda in lokalizacjaNagroda)
        {
            if (nagroda == poleGracz) 
            {
                wynik += 1; 
            }
        }

        return wynik; 
    }

}

// interface IWojownik
// {
//     
// }
//
// interface IMag
// {
//     
// }
//
// interface IHealer
// {
//     
// }
internal class Program
{
    public static void Main(string[] args)
    {
        Game gra = new Game();
        gra.poleNagroda();
    }
}