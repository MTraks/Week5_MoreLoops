using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus in "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna, proovi uuesti."

            Console.WriteLine("Sisestage kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisestage salasõna:");
            string userPassword = Console.ReadLine();

            //AND või OR
            
            //"admin" AND "admin1234" --> true
            //"admin1" AND "admin1234" --> false
            //"admin" AND "admin12345" --> false
            //"admin1" AND "admin123" --> false

            if(userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere Tulemast!");
            }
            else 
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovige uuesti.");
            }












        }
    }
}
