namespace sonoTopish
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, count1 = 1, num2;
            Random rnd = new Random();
            num = rnd.Next(1, 100);
            Console.WriteLine(num); // --> random sonni chiqarish;
            Console.WriteLine("1 dan 100 gacha izlanayotgan sonni kiriting: ");
            for (int i = 1; i <= 100; i++)
            {
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 < num)
                {
                    if (num2 > 0 && num2 < 100)
                    {
                        Console.WriteLine("Kattaroq son kiritng : ");
                    }
                    else Console.WriteLine("1 va 100 oraliqda son kiritng!");
                    count1++;
                }
                else if (num2 > num)
                {
                    if (num2 > 0 && num2 <= 100)
                    {
                        Console.WriteLine("Kichikroq son kiritng : ");
                    }
                    else Console.WriteLine("1 va 100 oraliqda son kiritng!");
                    //Console.WriteLine("Kichikroq son kiriitng : "); 
                    count1++;
                }
                else
                {
                    Console.WriteLine("Siz " + count1 + " ta urunishda topdingiz;");
                    break;
                }
            }
        }
    }
}
