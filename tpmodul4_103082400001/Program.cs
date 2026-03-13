using System.Collections.Generic;
using System;


class KodePos
{
    private Dictionary<string, string> kodePosTable = new Dictionary<string, string>()
    {
        {"Batununggal","40266"},
        {"Kujangsari","40287"},
        {"Mengger","40267"},
        {"Wates","40256"},
        {"Cijaura","40287"},
        {"Jatisari","40286"},
        {"Margasari","40286"},
        {"Sekejati","40286"},
        {"Kebonwaru","40272"},
        {"Maleer","40274"},
        {"Samoja","40273"}
    };

    public string getKodePos(string kelurahan)
    {
        return kodePosTable[kelurahan];
    }
}
class Program
{
    static void Main(string[] args)
    {
        KodePos kode = new KodePos();

        Console.WriteLine("Kode Pos Batununggal: " + kode.getKodePos("Batununggal"));

        Console.ReadLine();
    }
}