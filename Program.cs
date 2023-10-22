using System;
using System.Diagnostics;


for (int j = 0; j < 1000; j++)
{

    Random numRandom = new Random();
    string numeroTarjeta = "" + numRandom.Next(4,5);
    for (int i = 0; i < 16; i++)
    {
      int digito = numRandom.Next(10); 
      numeroTarjeta += digito;
    }

    Console.WriteLine("TDC: " + numeroTarjeta);
    _ = ProcesarPago(numeroTarjeta);
}
Stopwatch sw = Stopwatch.StartNew();
await Task.Delay(10000);
sw.Stop();
Console.WriteLine($"El proceso duró {TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds).TotalSeconds} segundos en completarse");
async Task ProcesarPago(string numTarjeta)
{
    await Task.Delay(10000);
}

