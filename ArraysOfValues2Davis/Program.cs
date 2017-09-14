using System;

namespace ArraysOfValues2Davis
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //NOTE: Reference part 1 of Arrays video for previous code

            /*
            string[] names = new string[] {"Eddie", "Alex", "Michael", "David Lee"};

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */
            //'name' is a temporary value to list each item in the array 'names'
            //      When you store data inside an array, you can do many built-in tasks with 
            //one of the many methods that are available to arrays

            string zig = "You can get what you want out of life"
                + "if you help enough other people get what they want";
            //Above is one string of code divided onto two lines, so the code doesn't run of the 
            //right side of the string


            //the variable 'char' can store a single alhpanumeric character, unlike a string
            //The 'toCharArray' chops up a string and puts it into an array of characters/letters
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            //The 'Reverse' will flip the letters in charArray so that they are essentially backwards

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
                //Note: one line doesn't need curly braces
            }
            Console.ReadLine();

            //Use square brackets to access the elements in your arrays, which are created
            //by multiple means seen in part 1 of the video
            //ARRAYS ARE ALWAYS ZERO BASED, OTHERWISE YOU CAN GET AN ERROR

            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine(numbers.Length);
            //The 'number.Length' can help you find out how many items are in your array
            //Here it will be 5 items

            //You can also use the 'foreach' for each value of an array
            //The Reverse can reverse the items values in an array
        }
    }
}
