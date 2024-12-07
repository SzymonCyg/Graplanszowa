// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

class Player
{
    public string Name { get; set; }
    public int Position { get; set; }
    public int Score { get; set; }

    void Ruch()
    {
        
    }

    public void akt(int score)
    {
        Score = score;
    }
}

class Board{

    int plansza = 64;

    public int[] nagroda(int liczbaNagrod=20)
    {
        
        Random losowanie = new Random();
        int[] lokalizacjaNagroda = new int [liczbaNagrod];
        for (int i = 0; i < 20; i++)
        {
            int x =losowanie.Next(1, 65);
            lokalizacjaNagroda[i] = x;
        }
        return lokalizacjaNagroda;
    }
}

class Game
{ 
    private int[] lokalizacjaNagroda;

    public Game(int[] lokalizacjaNagroda)
    {
        this.lokalizacjaNagroda = lokalizacjaNagroda;
    }
    public int poleGracz=0;
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
        Board board = new Board();
        int[] lokalizacjaNagroda = board.nagroda();
        Game game = new Game(lokalizacjaNagroda);

        
    }
}