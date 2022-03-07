using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus in "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna, proovi uuesti."
            //kasutajal on 3 katset



            int i = 0;

            while (i < 3)
            {


                Console.WriteLine("Sisestage kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisestage salasõna:");
                string userPassword = Console.ReadLine();
                

                if (userName != "admin" || userPassword != "admin1234")
                {
                    i++;
                    Console.WriteLine($"Vale kasutajatunnus või salasõna. Proovi uuesti. ({3-i} katset jäänud) ");
                }
                else
                {
                    Console.WriteLine("Tere tulemast");
                    break;
                }


            }

        }
    }
}
