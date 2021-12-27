using System;
namespace Number
{
    class Number_guess
    {
        static void Main(String[] args)
        {
            int guessed_no =8;
           int guesses=0;
            int user_guess=0;
            bool flag=true;
        
            Console.WriteLine("Lets! play ");
            Console.WriteLine("The no is bet 1 and 20");
            Console.WriteLine("Enter your guess , or -1 to stop");
            do{
            Console.WriteLine("What is your guess");
          String value=Console.ReadLine();
          try{
            user_guess=Convert.ToInt32(value);
          //  Console.WriteLine(user_guess);
          if(user_guess==-1)
            {
                flag=false;
            }
           else if(user_guess<guessed_no)
            {
                Console.WriteLine("Nope, higher than that");
                guesses++;
            }
            else if(user_guess>guessed_no)
            {
                Console.WriteLine("Nope, lower than that");
                guesses++;
            }
            
            else{
                Console.WriteLine($"You got it in {guesses} guesses");
                flag=false;
            }
           
             }
             catch(Exception e)
             {
                 Console.WriteLine("Hmm..That's doesnt look like a no , try agin");
                 guesses++;
             }
             
              }
            while(flag);
            
            
            

        }
    }
}