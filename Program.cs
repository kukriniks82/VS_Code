namespace VS_Code;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[20];
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next();
            Console.Write(arr[1] + ", ");
        }


    }
}
