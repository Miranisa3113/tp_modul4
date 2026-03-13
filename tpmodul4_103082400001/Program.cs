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
class DoorMachine
{
    enum State
    {
        Terkunci,
        Terbuka
    }

    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void bukaPintu()
    {
        if (currentState == State.Terkunci)
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    public void kunciPintu()
    {
        if (currentState == State.Terbuka)
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        KodePos kode = new KodePos();

        Console.WriteLine("Kode Pos Batununggal: " + kode.getKodePos("Batununggal"));

        DoorMachine pintu = new DoorMachine();

        pintu.bukaPintu();
        pintu.kunciPintu();

        Console.ReadLine();
    }
}