using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace IterationDictionary;
public class Program
{
    public static double avg_price(Dictionary<string, double> dict)
    {
        double sum = 0;
        foreach (KeyValuePair<string, double> pair in dict)
        {
            
            sum = sum+ pair.Value;
        }
            sum=sum/dict.Count;
            return sum;
    }
        public  static void show_dict(Dictionary<string, double> dict)
        {
            foreach (KeyValuePair<string, double> pair in dict)
            {
                Console.WriteLine("{0} {1}", pair.Key, pair.Value);

            }

        }

    public static void expensive (Dictionary<string, double> dict) {
        var maxvalue = dict.Values.Max();

        foreach (KeyValuePair<string, double> pair in dict)
        {
            if (pair.Value == maxvalue)
            { string KEY = pair.Key;
                Console.Write(KEY);
            }
        }
    }
        public static void Main(string[] args) {
     
        Dictionary<string, double> dict = new Dictionary<string, double>();
    dict.Add("NYAKA:", 300.50);
    dict.Add("PUMA:", 500.00);
    dict.Add("NOISE:", 200.50);
    dict.Add("SESA:", 400.50);
    dict.Add("FASTRACK:", 200.50);
    Console.WriteLine("The product and their prices are:");
    show_dict(dict);
       // avg_price(dict);
        Console.WriteLine("The average of price are:"+ avg_price(dict));
        
        var maxvalue=dict.Values.Max();
        Console.WriteLine($"The expensive product is:");
        expensive(dict);
        Console.Write(maxvalue);
  }

    }

