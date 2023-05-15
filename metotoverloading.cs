using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int memleketPlaka = 58;
        string memleket = "Sivas";
        
        HelloWorld hw = new HelloWorld();
        
        hw.print(memleketPlaka);
        
        hw.print(memleket);
    }
    
    public void print(int x){
        Console.WriteLine(x);
    }
    
    public void print(string x){
        Console.WriteLine(x);
    }
    
}
