//Home work

//1.write an algorithm to find all elememnt in an array that are greater than a given value..

int[] numbers = {15,30,3,42,63};
int target = 3;
FindAllElement(numbers, target);


static void FindAllElement(int[] numbers, int target)
{
    foreach(int item in numbers )
    {
        if(item  > target)
        {
            Console.WriteLine(item);
        }
    }
    Console.WriteLine("Element greater than " + target + "");
}


//2.write an algorithm to find a target value in a list of integers return the count or display a the target value occcur in the list

// int [] ade = 
// {
//     4,2,9,9,7
// };
// // int[] Number = {4,2,9,9,7};
// int target = 7;
// LinearSearch(ade,target);

// int[] numbers = { 12, 45, 7, 23, 56, 89, 34 };
// int[] smallestNumbers = GetSecondThirdNdFourthSmallestValues(numbers, 4);

// Console.WriteLine("Smallest numbers:");
// foreach (int number in smallestNumbers)
// {
//     Console.WriteLine(number);
// }


// static void LinearSearch(int [] number,int targets)
// {
//     int count = 0;
//     for(int i = 0; i < number.Length; i++)
//     {
//         if(number[i] == targets)
//         {
//             count++;
//             Console.WriteLine($"my target {targets} count {count}" );   
//         }
//     }

// }  



//3.Give a string array,given a string value and a.search for characters in the string,b.sorting in decending order
// static void SearchForCharacters(string [] ola, string target)
// {
//     for (int i = 0; i < ola.Length; i++)
//     {
//         if (ola[i] == target)
//         {
//             System.Console.WriteLine("Target found::" + "   "+  ola[i]);
//         }
        
//     }
//             // System.Console.WriteLine("Target not found" +" "+ target);
// }

//write an algorithm to find the second smallest value,modify the algoritm to find the third smallest value,fourth smallest value

//Last assignment solve using for loop

// static int[] GetSecondThirdNdFourthSmallestValues(int[] numbers, int count)
// {
//     int[] smallestNumbers = new int[count];
//     for (int i = 0; i < count; i++)
//     {
//         smallestNumbers[i] = int.MaxValue;
//     }

//     foreach (int number in numbers)
//     {
//         for (int i = 0; i < count; i++)
//         {
//             if (number < smallestNumbers[i])
//             {
//                 // Shift elements to the right
//                 for (int j = count - 1; j > i; j--)
//                 {
//                     smallestNumbers[j] = smallestNumbers[j - 1];
//                 }
//                 smallestNumbers[i] = number;
//                 break;
//             }
//         }
//     }

//     return smallestNumbers;
// }
int a = 10;
Console.WriteLine(a);
//i wish to be a software engr
