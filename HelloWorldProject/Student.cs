using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldProject {
    class Student {
        public string FavoriteColor;//don't need var
        public int FavoriteNumber;
        public string Name;

        //method or function
        public void/*doesn't return a value*/ ToConsole() {
            //statement want to execute 
            Console.WriteLine($"Name is {Name}, Color is {FavoriteColor}, Number is {FavoriteNumber}");
        }


        }
    }
