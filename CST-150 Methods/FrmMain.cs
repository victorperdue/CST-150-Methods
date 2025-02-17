namespace CST_150_Methods
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnExecuteMethods(object sender, EventArgs e)
        {
            int num1 = 2, num2 = 3, num3 = 4;
            int randomSum = 0;
            double double1 = 1.1D, double2 = 2.2D, double3 = 3.3D;
            double double4 = 4.4D, double5 = 5.5D;
            string firstString = "This is test number 82.";
            string secondString = "The sky is blue today.";
            double[] doubles = { 4.4D, 23.56D, 24.45D, 16.1D, 125.25D, 45.3D };

            SumInts(num1, num2);
            DisplayResults("Avg of 5 doubles is: " + AvgValue(double1, double2, double3, double4, double5), false);
            randomSum = RandomInt();
            DisplayResults(string.Format("Method 3: Sum of random ints: {0}", randomSum.ToString()), false);
            bool isDivisibleByTwo = DivByTwo(num1, num2, num3);
            DisplayResults("Method 4: Is sum of 3 ints div by 2: " + isDivisibleByTwo, false);
            FewestChars(firstString, secondString);
            double maxDouble = LargestDouble(doubles);
            DisplayResults(string.Format("Method 6: Largest Double: {0}", maxDouble.ToString()), false);
            DisplayResults("Method 7: Reverse String: " + ReverseString(firstString), false);
            DisplayResults("Method 8: Factorial of 5: " + Factorial(5), false);
            DisplayResults("Method 9: Fibonacci(7): " + Fibonacci(7), false);
        }

        private void SumInts(int num1, int num2)
        {
            int sum = num1 + num2;
            DisplayResults("Method 1: The sum of " + num1 + " + " + num2 + " = " + sum, true);
        }

        private double AvgValue(double num1, double num2, double num3, double num4, double num5)
        {
            return (num1 + num2 + num3 + num4 + num5) / 5.0D;
        }

        private int RandomInt()
        {
            Random rand = new Random();
            int num1 = rand.Next(1, 101);
            int num2 = rand.Next(1, 101);
            return num1 + num2;
        }

        private void DisplayResults(string descText, bool clearLabel)
        {
            if (clearLabel)
            {
                lblResults.Text = "";
            }
            lblResults.Text += string.Format("{0}\n", descText);
        }

        private bool DivByTwo(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3) % 2 == 0;
        }

        private void FewestChars(string string1, string string2)
        {
            int count1 = string1.Count(char.IsLetter);
            int count2 = string2.Count(char.IsLetter);
            string result = count1 < count2 ? "string 1 has fewer letters" : count2 < count1 ? "string 2 has fewer letters" : "Both strings have the same number of letters";
            DisplayResults("Method 5: " + result, false);
        }

        private double LargestDouble(double[] arrDoubles)
        {
            return arrDoubles.Max();
        }

        private string ReverseString(string input)
        {
            return new string(input.Reverse().ToArray());
        }

        private int Factorial(int num)
        {
            return num <= 1 ? 1 : num * Factorial(num - 1);
        }

        private int Fibonacci(int n)
        {
            return n <= 1 ? n : Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // You can initialize things here if needed
            Console.WriteLine("FrmMain has loaded successfully!");
        }

    }
}

//namespace CST_150_Methods
//{
//    public partial class FrmMain : Form
//    {
//        public FrmMain()
//        {
//            InitializeComponent();
//        }
//        /// <summary>
//        /// Button click event handler to execute the methods
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void BtnExecuteMethods(object sender, EventArgs e)
//        {
//            ///main method
//            ///Declare and Initialize
//            int num1 = 2, num2 = 3, num3 = 4;
//            int randomSum = 0;
//            double double1 = 1.1D, double2 = 2.2D, double3 = 3.3D;
//            double double4 = 4.4D, double5 = 5.5D;
//            string firstString = "This is test number 82.";
//            string secondString = "The sky is blue today.";
//            double[] doubles = { 4.4D, 23.56D, 24.45D, 16.1D, 125.25D, 45.3D };
//            //First Method Example
//            SumInts(num1, num2);
//            //Second Method 
//            DisplayResults("Avg of 5 doubles is: " + AvgValue(double1, double2, double3, double4, double5), false);
//            //Third Method
//            randomSum = RandomInt();
//            DisplayResults(string.Format("Method 3: Sum of random ints: {0}".ToLower randomSum.ToString()), false);
//            //Forth Method
//            bool isDivisibleByTwo = DivByTwo(num1, num2, num3);
//            DisplayResults("Method 4: Is sum of 3 ints div by 2: " + isDivisibleByTwo, false);
//            //Fifth Method
//            FewestChars(firstString, secondString);
//            //Sixth Method 
//            double maxDouble = LargestDouble(doubles);
//            DisplayResults(string.Format("Method 6; Largest Double: {0}", maxDouble.ToString()), false);
//        }

//        /// <summary>
//        /// Write a method that takes two integers and displays their sum with descriptive text.
//        /// </summary>
//        /// <param name="num1"></param>
//        /// <param name="num2"></param>
//        private void SumInts(int num1, int num2)
//        {
//            // Find the sum
//            int sum = num1 + num2;

//            // Display needs to be it's own method
//            DisplayResults("Method 1: The sum of " + num1 + " + " + num2 + " = " + sum, true);
//        }
//        /// <summary>
//        /// Find the average of the 5 doubles and then return average.
//        /// </summary>
//        /// <param name="num1"></param>
//        /// <param name="num2"></param>
//        /// <param name="num3"></param>
//        /// <param name="num4"></param>
//        /// <param name="num5"></param>
//        /// <returns></returns>
//        private double AvgValue(double num1, double num2, double num3, double num4, double num5)
//        {
//            // Declare and Initialize
//            const double AvgDenominator = 5.0D;

//            // Find and return the average of the 5 doubles
//            return (num1 + num2 + num3 + num4 + num5) / AvgDenominator;
//        }
//        /// <summary>
//        /// Returns a randomly generated int
//        /// </summary>
//        /// <returns></returns>
//        private int RandomInt()
//        {
//            // Declare and Initialize
//            int num1 = 0, num2 = 0, sum = 0;

//            // Get the random numbers
//            // C# provides a Random class to generate random numbers.
//            // Instantiate random number generator create an object called rand
//            // Syntax-> ClassName object/variable name = new ClassName();
//            Random rand = new Random();

//            // Within the Random class there are several methods that have access modifier set to Public that we can use
//            // One of those methods is Next(int min, int max) that returns random number >= min and < max
//            num1 = rand.Next(1, 101);
//            num2 = rand.Next(1, 101);

//            // Generate the sum and return it.
//            // Break this out to multiple lines so it is easier to understand.
//            sum = num1 + num2;

//            return sum;
//        }
//        /// <summary>
//        /// Displays the string that is sent to the method.
//        /// Requires Descriptive text and result both in one string.
//        /// Third parameter is to clear the label before writing to it.
//        /// </summary>
//        /// <param name="descText"></param>
//        /// <param name="result"></param>
//        private void DisplayResults(string descText, bool clearLabel)
//        {
//            // Only clear the label if the parameter is true
//            if (clearLabel)
//            {
//                lblResults.Text = "";
//            }

//            // Display the results in the label
//            lblResults.Text += string.Format("{0}\n", descText);
//        }
//        /// <summary>
//        /// Return bool true or false if the sum of the ints are divisible by 2
//        /// </summary>
//        /// <param name="num1"></param>
//        /// <param name="num2"></param>
//        /// <param name="num3"></param>
//        /// <returns></returns>
//        private bool DivByTwo(int num1, int num2, int num3)
//        {
//            // Find the sum
//            int sum = num1 + num2 + num3;

//            // Is the sum divisible by 2
//            if (sum % 2 == 0)
//            {
//                return true;
//            }

//            // If the sum is not divisible by 2
//            // return false
//            return false;
//        }
//        /// <summary>
//        /// Write a method that takes two strings and displays the
//        /// string that has the fewer letters with descriptive text
//        /// </summary>
//        /// <param name="string1"></param>
//        /// <param name="string2"></param>
//        private void FewestChars(string string1, string string2)
//        {
//            // Declare and Initialize
//            int countChar1 = 0, countChar2 = 0, pointer = 0;
//            // Iterate through the strings using a do while loop
//            // exit loop when both strings have been fully iterated through
//            do
//            {
//                // string1 -> Try and test if the char being pointed to is a letter
//                try
//                {
//                    // Test if char is a letter
//                    if (char.IsLetter(string1[pointer]))
//                    {
//                        // Now we know this index contains a letter and not number
//                        countChar1++;
//                    }
//                }
//                catch (Exception e)
//                {
//                    // If we are here then we know string1 is at the end of the length
//                    // We do not want to do anything
//                }
//                // string2 -> Try and test if the char being pointed to is a letter
//                try
//                {
//                    if (char.IsLetter(string2[pointer]))
//                    {
//                        countChar2++;
//                    }
//                }
//                catch (Exception e)
//                {
//                    // If we are here then we know string2 is at the end of the length
//                    // We do not want to do anything
//                }

//                // Inc the pointer to point to next char
//                pointer++;
//            }
//            while ((pointer < string1.Length) || (pointer < string2.Length));
//            // Now we have the count of chars for each string
//            if (countChar1 < countChar2)
//            {
//                DisplayResults("Method 5: string 1 has fewer letters");
//            }
//            else if (countChar2 < countChar1)
//            {
//                DisplayResults("Method 5: string 2 has fewer letters");
//            }
//            else
//            {
//                DisplayResults("Method 5: Both strings have the same number of letters");
//            }
//        }
//        /// <summary>
//        /// Write a method that takes an array of doubles and returns the largest value in the array.
//        /// </summary>
//        /// <param name="arrDoubles"></param>
//        /// <returns></returns>
//        private double LargestDouble(double[] arrDoubles)
//        {
//            // Declare and Initialize
//            int arrPointer = 0;
//            double valueAtIndex = 0D;
//            double biggestDouble = 0D;

//            // Iterate through array using while loop
//            while (arrPointer < arrDoubles.Length)
//            {
//                // Read double from array at index of pointer
//                valueAtIndex = arrDoubles[arrPointer];

//                // Now test the double against biggestDouble
//                // if the value we just read is larger than value
//                // in biggestDouble - replace with valueAtIndex
//                if (valueAtIndex > biggestDouble)
//                {
//                    // We just found a larger double
//                    biggestDouble = valueAtIndex;
//                }

//                // Inc the pointer so it points to the next index.
//                arrPointer++;

//                // show how arrDoubles [arrPointer++] would do same
//            }
//            //All done so return the biggest double
//            return biggestDouble;
//        }
//    }
//}
