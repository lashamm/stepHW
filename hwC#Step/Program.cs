//                                  11th les HW

using hwC_Step._11th_les_stuff;

int playerChoice;
char controlChoice;

Console.WriteLine("Choose your Player:" +
    "\n If you want to play audio player press 1" +
    "\n If you want to play video player press 2");
playerChoice = int.Parse(Console.ReadLine());
Console.Clear();
if (playerChoice == 1)
{
    AudioPlayer audioPlayer = new AudioPlayer();
    audioPlayer.Volume = 50;
    audioPlayer.Play();
    Console.WriteLine(
        $"Audio Player Volume is set to: {audioPlayer.Volume}" +
        $"\nif you want to pause it press 'P'," +
        $"\nif you want to stop it press 'S'.");
    if (char.TryParse(Console.ReadLine().ToLower(), out controlChoice))
    {
        if (controlChoice == 'p')
        {
            Console.Clear();
            audioPlayer.Pause();
        }
        else if (controlChoice == 's')
        {
            Console.Clear();
            audioPlayer.Stop();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid input");
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Invalid input");
    }

}
else if (playerChoice == 2)
{
    VideoPlayer videoPlayer = new VideoPlayer();
    videoPlayer.Volume = 50;
    videoPlayer.Play();
    Console.WriteLine(
        $"Video Player Volume is set to: {videoPlayer.Volume}" +
        $"\nif you want to pause it press 'P'," +
        $"\nif you want to stop it press 'S'.");
    if (char.TryParse(Console.ReadLine().ToLower(), out controlChoice))
    {
        if (controlChoice == 'p')
        {
            Console.Clear();
            videoPlayer.Pause();
        }
        else if (controlChoice == 's')
        {
            Console.Clear();
            videoPlayer.Stop();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid input");
        }
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}
else
{
    Console.WriteLine("Invalid choice");
}




///                                10th les HW

//using hwC_Step.Enums;
//using hwC_Step.Models;

//Rectangle rectangle = new Rectangle("red", NamesOfShape.Rectangle, RectangleTypes.Square, 12);
//rectangle.area();

//Circle circle = new Circle("blue", NamesOfShape.Circle, CircleTypes.Full, 15);
//circle.area();

//Triangle triangle = new Triangle("green", NamesOfShape.Triangle, TriangleType.Equilateral, 20);
//triangle.area();




//                                 9th les HW

//using hwC_Step.Models;
//using hwC_Step.Enums;

//int choice;
//char refuel;
//char drive;


//Console.WriteLine(
//    $"Hello, choose a car! " +
//    "\nPress 1. to choose a petrol powered car " +
//    "\nPress 2. to choose a disel powered car" +
//    "\nPress 3. to choose an electric powered car");
//choice = int.Parse(Console.ReadLine());

//if (choice == 1)
//{
//    Car petrolCar = new Car(Fuels.Gasoline, CarFuelType.PetrolCar, 0);
//    Console.Clear();
//    if (petrolCar.Fuel == 0) { 
//        Console.WriteLine($"You need to refuel your car first!" +
//            $"\npress R to refuel");
//        refuel = Console.ReadKey().KeyChar;
//        Console.Clear();
//        if (refuel == 'r' || refuel == 'R')
//        {
//            petrolCar.refuel();
//            Console.WriteLine("press D to drive");
//            drive = Console.ReadKey().KeyChar;
//            Console.Clear();
//            if (drive == 'd' || drive == 'D')
//            {
//                petrolCar.Drive();
//            }
//            else
//            {
//                Console.WriteLine("Invalid input, please try again.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid input, please try again.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid input, please try again.");
//    }
//}

//     if (choice == 2)
//{
//    Car dieselCar = new Car(Fuels.Diesel, CarFuelType.DieselCar, 0);
//    Console.Clear();
//    if (dieselCar.Fuel == 0)
//    {
//        Console.WriteLine($"You need to refuel your car first!" +
//            $"\npress R to refuel");
//        refuel = Console.ReadKey().KeyChar;
//        Console.Clear();
//        if (refuel == 'r' || refuel == 'R')
//        {
//            dieselCar.refuel();
//            Console.WriteLine("press D to drive");
//            drive = Console.ReadKey().KeyChar;
//            Console.Clear();
//            if (drive == 'd' || drive == 'D')
//            {
//                dieselCar.Drive();
//            }
//            else
//            {
//                Console.WriteLine("Invalid input, please try again.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid input, please try again.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid input, please try again.");
//    }
//}
//else if (choice == 3)
//{
//    Car electricCar = new Car(Fuels.Electric, CarFuelType.ElectricCar, 0);
//    Console.Clear();
//    if (electricCar.Fuel == 0)
//    {
//        Console.WriteLine($"You need to charge your car first!" +
//            $"\npress R to charge");
//        refuel = Console.ReadKey().KeyChar;
//        Console.Clear();
//        if (refuel == 'r' || refuel == 'R')
//        {
//            electricCar.refuel();
//            Console.WriteLine("press D to drive");
//            drive = Console.ReadKey().KeyChar;
//            Console.Clear();
//            if (drive == 'd' || drive == 'D')
//            {
//                electricCar.Drive();
//            }
//            else
//            {
//                Console.WriteLine("Invalid input, please try again.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid input, please try again.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid input, please try again.");
//    }
//}
//else
//{
//    Console.WriteLine("Invalid choice");
//}













////                                     8th les HW

//using hwC_Step.Models;
//using hwC_Step.Enums;

//Employ employ1 = new Employ(
//    EmployName.John,
//    new DateTime(1992),
//    EmploySurname.Smith,
//    EmployJobTitle.Developer,
//    EmploySalary.Medium,
//    Country.Georgia
//);
//Employ employ2 = new Employ(
//    EmployName.Jane,
//    new DateTime(1994),
//    EmploySurname.Johnson,
//    EmployJobTitle.Designer,
//    EmploySalary.Low,
//    Country.Norway
//);
//Employ employ3 = new Employ(
//    EmployName.Alice,
//    new DateTime(1982),
//    EmploySurname.Williams,
//    EmployJobTitle.Manager,
//    EmploySalary.High,
//    Country.Japan
//);
//Employ employ4 = new Employ(
//    EmployName.Bob,
//    new DateTime(1978),
//    EmploySurname.Brown,
//    EmployJobTitle.Analyst,
//    EmploySalary.VeryHigh,
//    Country.Spain
//);
//Employ employ5 = new Employ(
//    EmployName.Charlie,
//    new DateTime(2000),
//    EmploySurname.Davis,
//    EmployJobTitle.Developer,
//    EmploySalary.Medium,
//    Country.Georgia
//);
//Employ employ6 = new Employ(
//    EmployName.David,
//    new DateTime(2002),
//    EmploySurname.Wilson,
//    EmployJobTitle.Designer,
//    EmploySalary.Low,
//    Country.Norway
//);
//Employ employ7 = new Employ(
//    EmployName.Gregory,
//    new DateTime(1976),
//    EmploySurname.House,
//    EmployJobTitle.Doctor,
//    EmploySalary.High,
//    Country.Japan
//);
//Employ employ8 = new Employ(
//    EmployName.Frank,
//    new DateTime(1996),
//    EmploySurname.Taylor,
//    EmployJobTitle.Manager,
//    EmploySalary.VeryHigh,
//    Country.Spain
//);

//Employ[] employs = new Employ[8];
//Employ[] employArray = { 
//    employ1,
//    employ2,
//    employ3,
//    employ4,
//    employ5,
//    employ6,
//    employ7,
//    employ8 
//};

//for(int i = 0; i < employArray.Length; i++)
//{
//    if (employArray[i].Country == "Georgia") {
//        employs[i] = employArray[i];
//        employs[i].PrintEmoployInfo();
//    }
//}






//                                     7th les HW 1 and 2


//using hwC_Step.Models;

//Student student = new Student(
//    "John",
//    new DateTime(2000, 5, 15),
//    "Doe",
//    12345, 1
//    );

////student.printInfo(); 

//Lector lector = new Lector(
//    "Jane",
//    "Smith"
//    );
////lector.PrintInfoLector();

//int choice;
//Console.WriteLine("Press 1 to see first HomeWork and press 2 to see Second homework");
//choice = int.Parse(Console.ReadLine());

//if (choice == 1)
//{
//    lector.PrintInfoLector();
//}
//else if (choice == 2)
//{
//    student.printInfo();
//}
//else
//{
//    Console.WriteLine("Invalid choice");
//}




//                                         6th les HW 1 


//int num;
//int power;
//Console.WriteLine("Enter number");
//num = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter power");
//power = int.Parse(Console.ReadLine());

//static void Power(int number, int power)
//{   
//    int result = 1;
//    for (int i = 0; i < power; i++)
//    {
//        result *= number;
//    }
//    Console.WriteLine($"The result of {number} raised to the power of {power} is: {result}");
//}
//Power(num, power);



//                                         6th les HW 2


//int n;
//Console.WriteLine("Enter Number");
//n = int.Parse(Console.ReadLine());

//static void CheckPrime(int number)
//{
//    for (int i = 2; i <= Math.Sqrt(number); i++)
//    {
//        bool isPrime;
//        if (number % i == 0)
//        {
//            Console.WriteLine($"{number} is not prime");
//            isPrime = false;
//            return;
//        }
//    }
//    Console.WriteLine($"{number} is prime");
//}
//CheckPrime(n);



//                                        6th les HW 3


//string word;
//Console.WriteLine("Enter a word");
//word = Console.ReadLine().ToLower();

//static void CheckPalindrome(string input)
//{
//    string reversed = string.Empty;
//    for (int i = input.Length - 1; i >= 0; i--)
//    {
//        reversed += input[i];
//    }

//    if (input == reversed)
//    {
//        Console.WriteLine($"{input} is a palindrome");
//    }
//    else
//    {
//        Console.WriteLine($"{input} is not a palindrome");
//    }
//}

//CheckPalindrome(word);


//                                        6th les HW 4

//using System.Diagnostics.CodeAnalysis;

//int[] num = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};


//static void CheckEvenOdd(int[] number)
//{
//    int sum = 0;
//    for (int i = 0; i < number.Length; i++)
//    {
//        if (number[i] % 2 == 0)
//        {
//            sum += number[i];
//        }
//    }
//    Console.WriteLine(sum);
//}
//CheckEvenOdd(num);





//                                       5th les HW 1
//                                   find length of a string

//string str;
//int length = 0;
//Console.WriteLine("Enter a string");
//str = Console.ReadLine();


//    for(int i = 0; i < str.Length; i++)
//    {
//        length++;
//    }
//    Console.WriteLine($"Length of a {str} is {length}");



//                                       5th les HW 2
//                                   reverse a string

//string str;
//Console.WriteLine("Enter a string");
//str = Console.ReadLine();
//string reversed = string.Empty;

//for (int i = str.Length - 1; i >= 0; i--)
//{
//    reversed += str[i];
//}
//Console.WriteLine($"Reversed string is {reversed}");



//                                       5th les HW 3

//string str;
//int wordCount = 0;
//Console.WriteLine("Enter a string");
//str = Console.ReadLine();

//while (str != null)
//{
//    int index = str.IndexOf(' ');
//    if (index == -1)
//    {
//        wordCount++;
//        break;
//    }
//    else
//    {
//        wordCount++;
//        str = str.Substring(index + 1);
//    }
//}
//Console.WriteLine(wordCount);


//                                       5th les HW 4

//                                   check if two stings are the same

//string str1;
//string str2;

//Console.WriteLine("Enter a first word");
//str1 = Console.ReadLine();
//Console.WriteLine("Enter a second word");
//str2 = Console.ReadLine();

//if (str1 != str2)
//{
//    Console.WriteLine("Not a same words");
//}
//else if (str1 == str2)
//{
//    Console.WriteLine("Same words");
//}
//else
//{
//    Console.WriteLine("Invalid input");
//}



//                                       5th les HW 5
//                                   count symbols numbers and special characters in a string

//string str;

//Console.WriteLine("Enter a string");
//str = Console.ReadLine();
//int letterCount = 0;
//int numberCount = 0;
//int specialCharCount = 0;

//for (int i = 0; i < str.Length; i++)
//{
//    if(char.IsLetter(str[i]))
//    {
//        letterCount++;
//    }
//    else if (char.IsDigit(str[i]))
//    {
//        numberCount++;
//    }
//    else if (!char.IsLetterOrDigit(str[i]))
//    {
//        specialCharCount++;
//    }
//}

//Console.WriteLine($"Letters: {letterCount}, Numbers: {numberCount}, Special Characters: {specialCharCount}");






//                                   4th les HW 1

//int[] nums1 = { 1, 2, 3, 4 };
//int[] nums2 = { 5, 6, 7, 8 };
//int[] resultArray = new int[nums1.Length + nums2.Length];

//for (int i = 0; i < nums1.Length; i++)
//{
//    resultArray[i] = nums1[i];
//}
//for (int i = 0; i < nums2.Length; i++)
//{
//    resultArray[nums1.Length + i] = nums2[i];
//}
//for (int i = 0; i < resultArray.Length; i++)
//{
//    Console.WriteLine(resultArray[i]);
//}


//                                   4th les HW 2

//int targetSum = 10;
//int[] nums = { 2, 6, 7, 12, 3, 7, 11, 9, 5, 1, 4, 8 };

//for (int i = 0; i < nums.Length; i++)
//{
//    for(int j = i + 1; j < nums.Length; j++)
//    {
//        if (nums[i] + nums[j] == targetSum)
//        {
//            Console.WriteLine($"Pair found: {nums[i]} + {nums[j]} = {targetSum}");
//        }
//    }
//}

//                                      4th les HW 3

//int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//for(int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 2 == 0)
//    {
//        Console.WriteLine($"{nums[i]} is even");
//    }
//    else
//    {
//        Console.WriteLine($"{nums[i]} is odd");
//    }
//}

//                                      4th les HW 4

//int[] nums = { 1, 24, 32, 44, 59, 65, 73, 83, 92, 10, 17, 12 };
//int num;
//Console.WriteLine("enter number");
//num = int.Parse(Console.ReadLine());

//for(int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] == num)
//    {
//        Console.WriteLine($"Number {num} is present");
//    }
//};
//if (!nums.Contains(num))
//{
//        Console.WriteLine($"Number {num} is not present");
//}




//                                           3rd les HW 1

//int n;
//int sum = 0;
//Console.WriteLine("Enter number");
//n = int.Parse(Console.ReadLine());
//for (int i = 1; i < n + 1; i++)
//{
//    sum += i;

//}
//Console.WriteLine(sum);

//                                            3rd les HW 2

//int n;
//Console.WriteLine("Enter number");
//n = int.Parse(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine($"{i} * {n} = {i * n}");
//}

//                                            3rd les HW 3

//int pyramid = 10;
//for (int i = 1; i <= pyramid; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write($"{j}");
//    }
//    Console.WriteLine();
//}


//                                            3rd les HW 4

//int n;
//int sum = 0;
//Console.WriteLine("Enter number");
//n = int.Parse(Console.ReadLine());
//for (int i = 1; i < n + 1; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum += i;
//    }

//}
//Console.WriteLine(sum);



//                                            3rd les HW 5

//int n;
//Console.WriteLine("Enter number");
//n = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = 1; i <= n; i++)
//{
//	int square = i * i;
//	Console.WriteLine($"{i} * {i} = {square}");
//	sum += square;
//}
//Console.WriteLine($"sum of the squares are {sum}");

//                                              3rd les HW 6

//int n;
//Console.WriteLine("Enter Number");
//n = int.Parse(Console.ReadLine());
//bool isPrime = true;

//for (int i = 2; i<n; i++)
//{
//    if(n % i == 0)
//    {
//        isPrime = false;
//        break;
//    }
//}
//string result = isPrime ? $"{n} is prime" : $"{n} is not prime";
//Console.WriteLine(result);





//                                             2nd les HW 1


//int year;
//Console.WriteLine("Enter a random year:");
//year = int.Parse(Console.ReadLine());

//if (year % 4 == 0)
//{
//    Console.WriteLine("leap year");
//}
//else
//{
//    Console.WriteLine("not a leap year");
//}



//                                            2nd les HW 2

//int firstQuestion;
//int secondQuestion;
//int thirdQuestion;
//int fourthQuestion;
//int fifthQuestion;
//int finalResult = 0;

//Console.WriteLine("2+2");
//firstQuestion = int.Parse(Console.ReadLine());
//Console.WriteLine("3+1");
//secondQuestion = int.Parse(Console.ReadLine());
//Console.WriteLine("5-1");
//thirdQuestion = int.Parse(Console.ReadLine());
//Console.WriteLine("6/2");
//fourthQuestion = int.Parse(Console.ReadLine());
//Console.WriteLine("2*3");
//fifthQuestion = int.Parse(Console.ReadLine());

//if (firstQuestion == 4)
//{
//    finalResult += 20;
//}
//else
//{
//    finalResult -= 20;
//}
//if (secondQuestion == 4)
//{
//    finalResult += 20;
//}
//else
//{
//    finalResult -= 0;
//}
//if (thirdQuestion == 4)
//{
//    finalResult += 20;
//}
//else
//{
//    finalResult -= 0;
//}
//if (fourthQuestion == 3)
//{
//    finalResult += 20;
//}
//else
//{
//    finalResult -= 0;
//}
//if (fifthQuestion == 6)
//{
//    finalResult += 20;
//}
//else
//{
//    finalResult -= 0;
//}

//if (finalResult >= 60)
//{
//    Console.WriteLine($"You passed the test your score is {finalResult}");
//}
//else
//{
//    Console.WriteLine($"You failed the test, your score is {finalResult} you need atleast 60");
//}



//                                            2nd les HW 3


//string month;

//Console.WriteLine("enter a month");
//month = Console.ReadLine().ToLower();


//if (month == "january" ||
//    month == "march" ||
//    month == "may" ||
//    month == "july" ||
//    month == "august" ||
//    month == "october" ||
//    month == "december")
//{
//    Console.WriteLine("your month has 31 days");
//}
//else if (month == "april" ||
//         month == "june" ||
//         month == "september" ||
//         month == "november")
//{
//    Console.WriteLine("your month has 30 days");
//}
//else if (month == "february")
//{
//    Console.WriteLine("your month has 28 days, or 29 in a leap year");
//}
//else
//{
//    Console.WriteLine("invalid month name entered");
//}



//                                            2nd les HW 4

//int temperature;

//Console.WriteLine("Enter the temperature");
//temperature = int.Parse(Console.ReadLine());

//if (temperature <= 10)
//{
//    Console.WriteLine("it's cold outside");
//}
//else if (temperature > 10 && temperature < 23)
//{
//    Console.WriteLine("it's warm outside");
//}
//else if (temperature >= 23)
//{
//    Console.WriteLine("it's hot outside");
//}
//else
//{
//    Console.WriteLine("invalid temperature entered");
//}




//                                            2nd les HW 5


//char symbol;


//Console.WriteLine("enter a symbol");
//symbol = char.Parse(Console.ReadLine().ToLower());

//if (symbol == 'a' ||
//    symbol == 'e' ||
//    symbol == 'i' ||
//    symbol == 'o' ||
//    symbol == 'u')
//{
//    Console.WriteLine("aso xmovania");
//}
//else if (symbol >= 'a' && symbol <= 'z')
//{
//    Console.WriteLine("aso tanxmovania");
//}
//else
//{
//    Console.WriteLine("invalid symbol entered");
//}


//                                            2nd les HW 6

//string password;
//string confirmPassword;

//Console.WriteLine("enter password");
//password = Console.ReadLine();

//Console.WriteLine("confirm password");
//confirmPassword = Console.ReadLine();

//if (password == confirmPassword)
//{
//    Console.WriteLine("passwords match");
//}
//else
//{
//    Console.WriteLine("passwords do not match");
//}





































//                             1st les HW 1

//string name;
//string lastName;
//int age;
//string favoriteColor;
//string favoriteFood;

//Console.WriteLine("enter your name");
//name = Console.ReadLine();

//Console.WriteLine("enter your LastName");
//lastName = Console.ReadLine();

//Console.WriteLine("enter your age");
//age = int.Parse(Console.ReadLine());

//Console.WriteLine("enter your favorite color");
//favoriteColor = Console.ReadLine();

//Console.WriteLine("enter your favorite food");
//favoriteFood = Console.ReadLine();

//Console.WriteLine($"your name is {name}" +
//    $" your last name is {lastName}" +
//    $" you are {age}" +
//    $" years old your favourite color is {favoriteColor}" +
//    $" and your favorite food is {favoriteFood}");







//                           1st les HW 2 


//double balance;
//double depositAmount;
//double withdrawAmount;

//Console.WriteLine("Enter your balance:");
//balance = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter the amount you want to deposit:");
//depositAmount = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter the amount you want to withdraw:");
//withdrawAmount = double.Parse(Console.ReadLine());

//Console.Clear();

//Console.WriteLine($"Your balance is: {balance + depositAmount - withdrawAmount}");

