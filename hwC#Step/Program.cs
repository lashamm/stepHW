//                                           3rd les HW 1

int n;
int sum = 0;
Console.WriteLine("Enter number");
n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    sum += i;

}
Console.WriteLine(sum);

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

