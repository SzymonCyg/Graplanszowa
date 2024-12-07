// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

// class Player
// {
//     public string Name { get; set; }
//     public int Position { get; set; }
//     public int Score { get; set; }
//
//     void Ruch(int x , int y)
//     {
//         
//     }
//
//     public void akt(int score)
//     {
//         Score = score;
//     }
// }

// class Board
// {
//     public int rozmiarx;
//     public int rozmiary;
//
//     public int nagroda(int x, int y)
//     {
//         
//     }
// }

class Game
{
    // void przebiegGry()
    // {
    //     
    // }

    public void poleNagroda()
    {
        int[] lokalizacjanagroda = new int[20];
        Random losowanie = new Random();
        for (int i = 0; i < 20; i++)
        {
            int x =losowanie.Next(1, 65);
            lokalizacjanagroda[i] = x;
        }
        foreach (int liczba in lokalizacjanagroda)
        {
            Console.WriteLine(liczba);
        }

    }

    // public int wynik()
    // {
    //     
    // }
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