using System.Diagnostics;

namespace VS_Code;

class Program
{
    static void Main(string[] args)
    {
    
        
        int[] arr = new int[100_000];
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(0,20);            
        }

        var sw1 = new Stopwatch();
        sw1.Start();
        System.Console.WriteLine(ArraySum(0,arr));
        sw1.Stop();
        System.Console.WriteLine(sw1.Elapsed  + " recurse");

        var sw2 = new Stopwatch();
        sw2.Start();
        System.Console.WriteLine(ArraySumLoop(0,arr));
        sw2.Stop();
        System.Console.WriteLine(sw2.Elapsed + " loop");



            ulong ArraySum(int firstIndex, int[] array)
            { 
                if (firstIndex  == array.Length-1)
                {
                    return (ulong)array[firstIndex];
                }
                else
                {            
                    return (ulong)array[firstIndex] + (ulong)ArraySum(firstIndex+1,arr);                
                }
            }

            ulong ArraySumLoop (int firstIndex, int[] array)
            {
                ulong sum =0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += (ulong)array[i];
                    
                }
                return sum;
            }

    }
}
