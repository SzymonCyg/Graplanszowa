// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

class Player
{
    public string Name;
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

class Board
{
    public int rozmiarx;
    public int rozmiary;

    public int nagroda(int x, int y)
    {
        
    }
}

class Game
{
    void przebiegGry()
    {
        
    }

    void poleNagroda()
    {
        
    }

    public int wynik()
    {
        
    }
}

interface IWojownik
{
    
}

interface IMag
{
    
}

interface IHealer
{
    
}
internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}