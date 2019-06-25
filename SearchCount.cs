using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchySorty
{
    class SearchCount
    {

        private int numberOfElements;

        public SearchCount(int numberOfElements)
        {
            this.numberOfElements = numberOfElements;
            Counter = 0;
            Numbers = new int[numberOfElements];
        }


        public int[] Numbers { get; set; }
        public int Counter { get; set; }

        public void LinearSearch(int searchedValue)
        {

            for (var i = 0; i < numberOfElements; i++)

            {
                Counter++;
                if (Numbers[i] == searchedValue)
                    return;
            }


        }

        public void BinarySearch(int searchedValue)
        {
            var maxpoint = numberOfElements;
            var minpoint = 0;
            do
            {
                int midpoint = minpoint + (maxpoint - minpoint) / 2;
                Counter++;
                if (Numbers[midpoint] == searchedValue)
                    return;
                else if (Numbers[midpoint] < searchedValue)
                {
                    minpoint = midpoint + 1;
                }

                else
                {
                    maxpoint = midpoint - 1;
                }



            } while (minpoint <= maxpoint);
        }

        public void BubbleAscSort()
        {

            for (var i = 0; i < numberOfElements -1 ; i++)
            {
                for (var c = i + 1; c < numberOfElements;c ++)
                {
                    if (Numbers[c] < Numbers [i])
                    {
                        var temp = Numbers[i];
                        Numbers[i] = Numbers[c];
                        Numbers[c] = temp;

                    }
                }
            }
                    

                
                    
                    
            

            
        }

        public void SelectionDescSort()
        {
            for (var i = 0; i < numberOfElements - 1; i++)
            {
                var highest = Numbers[i];
                var highestIndex = 0;
                for (var c = i + 1; c < numberOfElements; c++)
                {
                    if (Numbers[c] > highest)
                    {
                        highest = Numbers[c];
                        highestIndex = c;
                    }
                }

                if (Numbers[i] != Numbers [highestIndex])
                {
                    var temp = Numbers[i];
                    Numbers[i] = Numbers[highestIndex];
                    Numbers[highestIndex] = temp;
                }
            }
        }

        

        


    }

}
