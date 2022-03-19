using System;
using System.Threading;

namespace StopWatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("S = Segundos");
      Console.WriteLine("M = Minutos");
      Console.WriteLine("0 = Sair");

      Console.WriteLine("Quanto tempo deseja contar?");
    }

    static void Start(int time)
    {
      int currentTime = 0;

      while (currentTime != time)
      {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000); // Tempo em milisegundos
      }

      Console.Clear();
      Console.WriteLine("StopWatch finalizado!");
      Thread.Sleep(2500);
    }

  }
}