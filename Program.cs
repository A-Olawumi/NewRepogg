 namespace Toll_collecting_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Total=0; 
            
            for (int i = 0; i < 5; i++)
            {


                New_Class new_class = new New_Class();
                Console.WriteLine("You are welcome to Owoda. please enter your name:");
                string name = Console.ReadLine();
                Console.WriteLine("please enter your ID card number:");
                string digits = Console.ReadLine();
                Console.WriteLine("Please {0}, what type of vehicle do you drive? \n Minibus: 1 \n Tricycle; 2 \n Bike; 3 \n Bus; 4", name);
                int vehicletype = Convert.ToInt32(Console.ReadLine());
                int y;
                if (vehicletype == 1)
                {
                    y = 800;
                }
                else if (vehicletype == 2)
                {
                    y = 600;
                }
                else if (vehicletype == 3)
                {
                    y = 400;
                }
                else if (vehicletype == 4)
                {
                    y = 1000;

                }
                else
                {
                    y = 0;

                }
                Console.WriteLine("please enter the number of trips");
                int numberofTrips = Convert.ToInt32(Console.ReadLine());

                int answer = new_class.Amount(y, numberofTrips);
                Console.WriteLine(answer);
                Console.WriteLine("Are you a member of the Union? (Yes/No)");
                string unionmember = Console.ReadLine();
                string unionmemberLower = unionmember.ToLower();
                if (unionmemberLower == "yes")
                {
                    int answer2 = (int)new_class.discount(answer);
                    Console.WriteLine("Hi {0} , you have completed {1} trips and your fee is {2}. You are qualified for a discount,your fee is {3}", name, numberofTrips, answer, answer2);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Hi {0} ,you made {1} trips and your fee is {2}", name, numberofTrips, answer);
                }
                Total += answer;
                Console.WriteLine("Total fee is " + answer);

            }
            Console.WriteLine("total amount collected today is " + Total);

               
        }
    }
}