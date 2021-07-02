using System;
using System.Collections.Generic;
using System.IO;

namespace DicitionaryEx
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter file full path: ");
            string path = Console.ReadLine();


            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    Dictionary<string, int> resultVotes = new Dictionary<string, int>();


                    while (!sr.EndOfStream)
                    {
                        string[] votingRecord = sr.ReadLine().Split(',');
                        string candidate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);

                        if (resultVotes.ContainsKey(candidate))
                        {
                            resultVotes[candidate] += votes;
                        }
                        else
                        {
                            resultVotes[candidate] = votes;
                        }
                    }

                    foreach (var item in resultVotes)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
