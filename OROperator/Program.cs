using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus in "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna, proovi uuesti."


            //OR (või) ||

            // true || true --> true
            // false || true --> true
            // true || false --> false
            // false || false --> false

            Console.WriteLine("Sisestage kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisestage salasõna:");
            string userPassword = Console.ReadLine();

            if(userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast");
            }

            // "admin1" != "admin" || "admin1234" != "admin1234" --> true || true --> true
            // "admin" != "admin" || "admin123" != "admin1234" --> false || true --> true
            // "admin1" != "admin" || "admin123" != "admin1234" --> true || true --> true

        }
    }
}
