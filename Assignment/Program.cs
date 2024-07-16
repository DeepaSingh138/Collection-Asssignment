using System.Security.Cryptography.X509Certificates;

namespace Assignment1;

public class Program
{
     public  static void show_basket (List<string> fruits) {

        foreach (var fruit in fruits)
        {
            Console.WriteLine("*" + fruit);

        }
    }
        public static void Main(string[] args)
    {       //Assignment 1: Basic List Operation
        var fruits = new List<string>();
        fruits.Add("Peaches");
        fruits.Add("Cherry");
        fruits.Add("Pineapple");
        fruits.Add("Kiwi");
        fruits.Add("Watermelon");
        Console.WriteLine("\"Fruits stored are:\"");

        show_basket(fruits);
        fruits.Add("Custurd Apple");
        Console.WriteLine("\"Basket of Fruits contains:\"");
        show_basket(fruits);
        fruits.RemoveAt(2);
        Console.WriteLine("\"Removing second index fruit\"");
        show_basket(fruits);
        Console.WriteLine("\"The third fruit is :" + fruits[3]);

     if (fruits.Contains("Kiwi"))
        {
            Console.WriteLine("Yes, your favourite food is present in list");
        }
     }
}