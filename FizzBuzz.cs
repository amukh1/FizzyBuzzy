using System;

namespace CSharp
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n");
        int x = 15;
        for (int i = 1; i < x + 1; i++)
{
    String resp = "";
    if(i % 3 == 0)
    {
        resp = resp + "Fizz";
    };
    if(i % 5 == 0)
    {
        resp = resp + "Buzz";
    };
    if(i % 3 != 0 && i % 5 != 0)
    {
        resp = i.ToString();
    };
  Console.WriteLine(resp);
};
    }
}

}
