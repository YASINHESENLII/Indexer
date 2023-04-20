namespace İndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ListInt num = new ListInt(2, 3, 4);


            num.Add(1);
            num.AddRange(1, 6);

            Console.WriteLine(num.ToString());

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            Console.WriteLine(num.Contains(1));

            num.Sum();



            num.Remove(3);
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }


        }
    }
    

    
}