using System;

namespace Numbr{
    class Gurssr 
    {
        static void Main  (string[] args){
            Random rndm= new Random();
            int rndm_int =rndm.Next(100);

            Console.WriteLine("Guess num between 1-100");
            bool tru = true;
            while (!!tru&& !false) {
Console.Beep();
                Thread.Sleep(500);
                string guess=Console.ReadLine();
                if (Convert.ToInt32(guess)==rndm_int){         
                    Console.WriteLine("Du hast gebonnen");
                    break;                      // bweak if num == is right numm

                                                                                    //hi
                } // end if-loop
                    if (Convert.ToInt32(guess)<rndm_int){//if loop
                    Console.WriteLine("Du hast zu klein");
                }                                           // end if-loop
            if (Convert.ToInt32(guess)>rndm_int){                                   //if loop
                    Console.WriteLine("Du hast zu groß");
                }           // end if-loop
            }
            Console.WriteLine("");
        } 
    }
}
//