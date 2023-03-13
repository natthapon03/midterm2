namespace m{
    class program{
        static void Main(string[] args){
            Console.WriteLine("dayofweek : ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("timeofday : ");
            int t = int.Parse(Console.ReadLine());

            Console.WriteLine("menu : ");
            string m = (Console.ReadLine());


            if(d <=7 && d >=1 ){
                Console.WriteLine();

            if(t <=8 && t >=18){
                Console.WriteLine();

            if(m =="coffee"){
                Console.WriteLine(" ");

            } else {
                Console.WriteLine("Please enter a valid menu");

            }
            } else if(m =="weekendset"){
                Console.WriteLine(" ");

            } else {
                Console.WriteLine("Please enter a valid menu");
            
            }
            } else if(m == "breakfastset"){
                Console.WriteLine(" ");

            } else {
                Console.WriteLine("Please enter a valid menu");
            }


                  

        }

           

    }

            
                
}