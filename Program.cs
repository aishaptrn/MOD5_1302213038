// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

class Penjumlahan
{
    public void JumlahTigaAngka<T>(T data1, T data2, T data3)
    {
        T temp;
        temp = (dynamic)data1 + (dynamic)data2 + (dynamic)data3;
        Console.WriteLine("Hasil penjumlahan adalah " + temp);
    }
}

class MainProgram
{
    static void Main(string[] args)
    {
        Penjumlahan sum = new Penjumlahan();

        int numA = 13;
        int numB = 02;
        int numC = 21;
        sum.JumlahTigaAngka(numA, numB, numC);
    }
}