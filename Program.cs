using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        public Program(){}

        public int findMostFrequentNumber(int[] List)
        {
            //for now we will call the first item in the list the most popular
            int mostCommon = List[0];

            //Creating a count to use for comparison, and a tempCount that will increment with each element in the array 
            int count = 1;
            int tempCount; 

            //creating a temp, this will move from element to element in the array of ints 
            int temp = 0;

            for (int i = 0; i < (List.Count() - 1); i++)
            {
                temp = List[i];
                tempCount = 0; 

                for(int j = 1; j < List.Count(); j++)
                {
                    //incrementing the tempCount when a match is found 
                    if(temp == List[j])
                    {
                        tempCount++; 
                    }
                }
                //checking to see if on number appears more than another
                if(tempCount > count)
                {
                    mostCommon = temp;
                    count = tempCount; 
                }
            }
           


                return mostCommon; 
        }

        static void Main(string[] args)
        {
            int[] List = { 1, 2, 4, 3, 2, 1, 3, 4, 5, 6, 7, 88, 7, 2, 545, 3, 3, 2, 2, 3, 4, 5, 6, 4, 2, 45, 6, 7, 2, 4, 3, 5, 6, 7, 8, 9 }; 
            Program prog = new Program();
            Console.WriteLine("I am the most commonly found number in this list: " + prog.findMostFrequentNumber(List));
            Console.Read(); 
             
        }
    }
}
