using System;
class SPG
{
    static string ReadNumber(){
        Console.Write("Please input a number for the length of your password:");
        return Console.Read();
    }
    static void Main()
    {
        string readString;
	bool parseResult=false;
	int numberOfChar=0;
	while(!parseResult){
            readString=ReadNumber();
            parseResult=int.TryParse(readString, out numberOfChar);
        }
        string allchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*";
        char[] list = allchar.ToCharArray();
        Random rd = new Random();
        for (int i = 0; i < numberOfChar-1; i++) { Console.Write(list[rd.Next(list.Length)]); }
        Console.ReadLine();
    }
}
