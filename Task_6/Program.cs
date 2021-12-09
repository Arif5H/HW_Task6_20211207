using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
        //Username: ArifHH
        //Password: F14us4Ever               
            Methods entrycheck = new Methods();
            step1:
            try
            {
                Console.Write("Username:  ");
                entrycheck.UserName = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto step1;
            }
            step2:
            try
            {
                Console.Write($"Password  of {entrycheck.username}:  ");
                entrycheck.Password = Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto step2;
            }

                bool isLoggedin = entrycheck.Login();

                if (isLoggedin)
                {
                    Console.WriteLine("You are LOGGED IN");
                }
                else
                {
                    Console.WriteLine("TRY AGAIN");
                    goto step1;
                }
      


        }
            
            
    }
}

