// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

class Player
{
    private int[] lokalizacjaNagroda;
    private int plansza;
    public string Name { get; set; }
    public int poleGracz { get; set; }
    public int wynik { get; set; }

    public Player(int[] lokalizacjaNagroda,int plansza)
    {
        this.lokalizacjaNagroda = lokalizacjaNagroda;
        this.plansza = plansza;
        this.poleGracz = 0;
        this.wynik = 0;
    }


    
    public void Ruch()
    {
        Random losowanie = new Random();
        int poleGraczDodaj=losowanie.Next(1,7);
        poleGracz =poleGracz+poleGraczDodaj;
        if(poleGracz>plansza)
        {
            poleGracz=poleGracz % plansza;
        }
        Console.WriteLine($"\nGracz: {Name} wyrzucił: {poleGraczDodaj} i trafił na pole: {poleGracz}.");
    }

    public void akt()
    {
        foreach (int nagroda in lokalizacjaNagroda)
        {
            if (nagroda == poleGracz) 
            {
                wynik += 1; 
                Console.WriteLine($"Gracz: {Name} trafił na pole nagroda obecny wynik to: {wynik}.");
                break;
            }
        }
    }
}

class Board{
    public int plansza { get; private set; }
    public Board(int rozmiar =64)
    {
        plansza = rozmiar;       
    }


    public int[] nagroda(int liczbaNagrod=40)
    {
        
        Random losowanie = new Random();
        int[] lokalizacjaNagroda = new int [liczbaNagrod];
        for (int i = 0; i < liczbaNagrod; i++)
        {
            int x =losowanie.Next(1, 65);
            lokalizacjaNagroda[i] = x;
        }
        return lokalizacjaNagroda;
    }
}

class Game
{ 
    private Board board;
    private Player[] players;
    

    public Game(Board board, Player[] players)
    {
        this.board = board;
        this.players = players;
    }
    public void Gra( int wynikKoncowy=10)
    {
        int runda = 1;
       Console.WriteLine("Gra się rozpoczyna");
       int i = 0;
       while (i!=1)
       {
           Console.WriteLine($"\nRunda: {runda}");
           foreach (Player player in players)
           {
               if (player.wynik < wynikKoncowy)
               {
                   player.Ruch();
                   player.akt();
                   runda++;
               }
               else
               {
                   Console.WriteLine($"gracz {player.Name} wygrywa osiągając jako pierwszy {player.wynik}.");
                   i++;
                   break;
               }
           }
       }

       wyniki();
    }

    public void wyniki()
    {
        foreach (var player in players)
        {
            Console.WriteLine($"\nGracz: {player.Name} zdobył {player.wynik} punktow");
        }
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
        Player[] players =
        {
            new Player(lokalizacjaNagroda, board.plansza) { Name = "gracz1" },
            new Player(lokalizacjaNagroda, board.plansza) { Name = "gracz2" },
            new Player(lokalizacjaNagroda, board.plansza) { Name = "gracz3" }
        };

        Game game = new Game(board, players);
        game.Gra();
    }
}