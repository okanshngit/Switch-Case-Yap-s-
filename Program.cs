using System;

namespace Switch_Case_Yapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            byte ay = (byte)DateTime.Now.Month;

            switch (ay)
            {   
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;

                default:
                    Console.WriteLine("Nisan Sonrası");
                break;
            }

            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar");
                    break;
                
                
                default:
                break;
            }


        }
    }
}
