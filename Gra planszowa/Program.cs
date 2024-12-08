﻿// See https://aka.ms/new-console-template for more information

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
        Console.WriteLine($"Gracz: {Name} wyrzucił: {poleGraczDodaj} i trafił na pole: {poleGracz}.");
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
    private Board board;
    private Player[] players;
    

    public Game(Board board, Player[] players)
    {
        this.board = board;
        this.players = players;
    }
    public void Gra( int wynikKoncowy=30)
    {
        int runda = 1;
       Console.WriteLine("Gra się rozpoczyna");
       foreach (Player player in players)
       {
           if (player.wynik<=wynikKoncowy)
           {
               player.Ruch();
               player.akt();
               runda++;
           }
           else
           {
               Console.WriteLine($"gracz {player.Name} wygrywa osiągając jako pierwszy {player.wynik}.");
               break;
           }
       }

       wyniki();
    }

    public void poleNagroda()
    {
 
    }

    public int wyniki()
    {
        

        

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