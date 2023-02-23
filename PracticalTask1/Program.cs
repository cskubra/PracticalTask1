using System;

class ArrayExample
{
    static void Main()
    {
        char[] letters = { 'k', 'u', 'b', 'r', 'a', ' ', 'c', 'a', 'l', 'i', 's', 'k','a', 'n' };
        string name = "";
        int[] a = new int[14];
        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
        Console.ReadKey();
    }

    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}