// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

class Player
{
    private int[] lokalizacjaNagroda;
    private int plansza;

    public Player(int[] lokalizacjaNagroda,int plansza)
    {
        this.lokalizacjaNagroda = lokalizacjaNagroda;
        this.plansza = plansza;
        int poleGracz = 0;
    }
    public string Name { get; set; }
    public int poleGracz { get; set; }
    public int wynik { get; set; }

    
    void Ruch()
    {
        Random losowanie = new Random();
        int poleGraczDodaj=losowanie.Next(1,7);
        poleGracz =poleGracz+poleGraczDodaj;
        if(poleGracz>plansza)
        {
            poleGracz=poleGracz % plansza;
        }
    }

    public void akt(int wynik)
    {
        foreach (int nagroda in lokalizacjaNagroda)
        {
            if (nagroda == poleGracz) 
            {
                wynik += 1; 
            }
        }
    }
}

class Board{
    public Board()
    {
        int plansza = 64;        
    }


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
    public void Gra()
    {
       
    }

    public void poleNagroda()
    {
 
    }

    public int wynik()
    {
        int wynik = 0;

        

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
        int plansza = board.oard();
        Game game = new Game(lokalizacjaNagroda);

        
    }
}