using System.ComponentModel;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CombinedLD;
public class Program
{
     public static void show_data(Dictionary<string, List<int>> data)
    {
        foreach (KeyValuePair<string, List<int>> group in data)
        {
            Console.WriteLine($"Scores of student {group.Key}:");
            foreach (int i in group.Value)
            { Console.Write($"{i}\t"); } //for tab /t
            Console.WriteLine("\n"); //for new line
        }
    }
    public static float avg_score(Dictionary<string,List<int>> dict)
    {
        float sum = 0;
        foreach (KeyValuePair<string, List<int>> group in dict)
        {
            Console.WriteLine($"The average of {group.Key}:");
            foreach (int i in group.Value) {
                sum = sum + i;
            } sum = sum / 3;
            Console.WriteLine(sum);
            sum = 0;
        }
        
        return sum;
     }
    public static void Main(string[] args)
    {
        Dictionary<string, List<int>> comb = new Dictionary<string, List<int>>()
        {
            ["Deepa"]  = new List<int> { 20, 40, 30 },
            ["Ayiinee"]= new List<int> { 90, 10, 20 },
            ["Yelo"]   = new List<int> { 60, 90, 30 }
        };
        var stud = comb.Keys;
         show_data(comb);
         avg_score(comb);
    }
}
