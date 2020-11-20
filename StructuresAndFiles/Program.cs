using System;

namespace StructuresAndFiles
{
    class Program
    {
      

        // creating a composite data type which I can use in my program
        struct grade
        {
            public string name;
            public int paper1mark;
            public int paper2mark;
        }
        static void Main(string[] args)
        {
            grade s1;



            s1.name = "Lachlan";
            s1.paper1mark = 40;
            s1.paper2mark = 50;
            Console.WriteLine("{0} got {1}", s1.name, s1.paper1mark + s1.paper2mark);



            // We can even create an array of structs



            grade[] structOFgrades = new grade[12];



            structOFgrades[0].name = "Tom";
            structOFgrades[0].paper1mark = 30;
            structOFgrades[0].paper2mark = 20;
            structOFgrades[1].name = "Nathan";
            structOFgrades[1].paper1mark = 35;
            structOFgrades[1].paper2mark = 40;
            // Add 4 other students to the array and iterate arounfd the array printing out each students 
            // name and total mark. Use a for loop





            // create a bubble sort to sort the array in order of paper1mark




            // write your array of structures out to a file.




        }


    }
}
