using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int x = 3;
        int y = 4;
        HelloWorld instance = new HelloWorld();
        int sonuc = instance.ArttırVeTopla(ref x, ref y);
        Console.WriteLine(sonuc);
    }
    
    public int ArttırVeTopla (ref int x, ref int y)
    {
        x+=1;
        y+=y;
        return (x+y);
    }
}
