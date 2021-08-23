using System;
class Program
{
    static void Main()
    {
        string allchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*";
        char[] list = allchar.ToCharArray();
        Random rd = new Random();
        for (int i = 0; i < 3300; i++) { Console.Write(list[rd.Next(list.Length)]); }
        Console.ReadLine();
    }
}