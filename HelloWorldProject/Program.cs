using System;

namespace HelloWorldProject {
    class Program {
        static void Main(string[] args) {

            //create two instances of our class student
            var s1 = new Student();
            s1.Name = "Fred";
            s1.FavoriteColor = "blue";
            s1.FavoriteNumber = 88;
            var s2 = new Student();
            s2.Name = "Betty";
            s2.FavoriteColor = "Green";
            s2.FavoriteNumber = 27;
            //print off method from class for s1
            s1.ToConsole();
            s2.ToConsole();

            Console.WriteLine("This is my Hello World, C# Program!");
            Console.WriteLine("This is another line.");

            //declare variables
            var counter = 0;//assignment statement =
            var name = "Greg";
            name = "123";
            //counter ++;comment
            /*is another way to do a comment across 
             * multiple lines*/
             if (counter == 0) {//an equality test
                Console.WriteLine("Counter is 0");
             }else {
                Console.WriteLine("Counter is not zero");
             }
             
            counter = counter + 1;
            Console.WriteLine("Counter value is " + counter);
            counter+=1;//could increment by 2 or whatever
            Console.WriteLine("another way to write is {0}", counter); //want the first variable after this string {0}
            counter++;//increment operator, can only increment by 1
            Console.WriteLine($"3rd way to write is {counter}");//interpolation==forms strings out of data...the $ predicts there is a var

            //statements
            //add values up to 25
            var sum = 0;
            for (var index = 0; index <= 100; index++){
                sum += index;
                //Console.WriteLine($"index (index)");
                }
            Console.WriteLine($"sum is {sum}");

            }
        }
    }
