using hwC_Step;

///                                         17th les HW
///                                         დავალების აღწერა:
///          Student - ების სიიდან წამოიღეთ ის სტუდენტები, რომელთა: 
///          1.ქულაც 5 - ზე მეტია. 2.ქალაქიც იწყება 'a'- ზე



List<Student> students = new List<Student>
{
    new Student { Name = "Alice Johnson", Age = 16, Grade = 10, City = "New York" },
    new Student { Name = "Benjamin Lee", Age = 17, Grade = 11, City = "Los Angeles" },
    new Student { Name = "Charlotte Smith", Age = 15, Grade = 9, City = "Chicago" },
    new Student { Name = "Daniel Brown", Age = 18, Grade = 12, City = "New York" },  
    new Student { Name = "Ella Davis", Age = 16, Grade = 10, City = "Phoenix" },
    new Student { Name = "Frank Miller", Age = 17, Grade = 11, City = "Los Angeles" },   
    new Student { Name = "Grace Wilson", Age = 15, Grade = 9, City = "San Antonio" },
    new Student { Name = "Henry Moore", Age = 18, Grade = 12, City = "Chicago" },        
    new Student { Name = "Isabella Taylor", Age = 16, Grade = 10, City = "Dallas" },
    new Student { Name = "Jack Anderson", Age = 17, Grade = 11, City = "San Jose" },
    new Student { Name = "Katherine Thomas", Age = 15, Grade = 9, City = "Austin" },
    new Student { Name = "Liam Martinez", Age = 18, Grade = 12, City = "Phoenix" },         
    new Student { Name = "Mia Robinson", Age = 16, Grade = 10, City = "San Antonio" },     
    new Student { Name = "Noah Clark", Age = 17, Grade = 11, City = "Dallas" }              
};

var orderedByAge = students.OrderByDescending(x => x.Age);
Print(orderedByAge);

Console.WriteLine("==============================");

var isAllAdult = students.All(s => s.Age >= 18);
Console.WriteLine(isAllAdult);

Console.WriteLine("==============================");

var gradeAbove5 = students.Where(a => a.Grade > 5);
Print(gradeAbove5);

Console.WriteLine("==============================");
var cityStartsWithA = students.Where(a => a.City.StartsWith("a", StringComparison.OrdinalIgnoreCase));
Print(cityStartsWithA);

static void Print<T>(IEnumerable<T> collection)
{
    foreach (var item in collection)
    {
        Console.WriteLine(item);
    }
}













///                                          16th les HW
///                                           ლამბდას სავარჯიშოები 
/// 1. დაწერეთ ლამბდა, რომელიც იღებს რიცხვების სიას და აბრუნებს მათ კვადრატების სიას. 
/// 2. შექმენით ლამბდა, რომელიც ლექსიკონიდან (Dictionary<string, int>)
/// აბრუნებს იმ ელემენტებს, რომელთა მნიშვნელობა მეტია 10-ზე   
///                                                    1.
///                                                    
//List<double> numberList = [2, 3, 7, 5, 12];
//Func<List<double>, List<double>> squares = numbers =>
//{
//    List<double> result = new List<double>();
//    foreach (var number in numbers)
//    {
//        result.Add(Math.Pow(number, 2));
//    }
//    return result;
//};
//List<double> squaresResult = squares(numberList);

//foreach (var value in squaresResult)
//{
//    Console.WriteLine(value);
//}

///                                                    2.
///                                                    


//Dictionary<int, string> dictionary = new Dictionary<int, string>()
//{
//    {5, "five"},
//    {15, "fifteen"},
//    {25, "twenty five"},
//    {8, "eight"}
//};

//string result = string.Empty;

//Action<string> action = s =>
//{
//    foreach (var item in dictionary)
//    {

//        if (item.Key > 10)
//        {
//            result = item.Value;
//            Console.WriteLine(result);

//        }

//    }
//};

//action("some value");


















//using System;

///                                  15th les HW
///                                   Delegates 
///                                   
/// 1. დაწერეთ პროგრამა, რომელიც: · იღებს სტრინგების სიას; 
/// · Predicate<string> - ით ფილტრავს მხოლოდ მათ, რომლებიც 5-ზე მეტ სიმბოლოს შეიცავს; 
/// · Action<string> - ით თითოეულს ბეჭდავს დიდ ასოებში. 
/// 2. დამატებითი სავარჯიშო: · შექმენით საკუთარი delegate, 
/// რომელიც იღებს ორ მთელ რიცხვს და აბრუნებს განსხვავებას; 
/// · დაწერეთ პროგრამა, რომელიც ამ delegate-ს იყენებს როგორც ცვლადს.

//string a = "hello";
//string b = "hello world";
//string c = "mAkE thIS UpPeRCAsE";

//Predicate<string> predocate = s => s.Length > 5;
//Console.WriteLine(predocate(a));
//Console.WriteLine(predocate(b));
//Action<string> action = s => Console.WriteLine(s.ToUpper());
//action(c);


//MyDelegate myDelegate = diff;
//Console.WriteLine(myDelegate(2, 3));
//static int diff(int x, int y)
//{
//    int difference;
//    difference = y - x;
//    return difference;
//}


//delegate int MyDelegate(int x, int y);

////////////////////////////////////////////////////////////////////////////////////////

//using System.Reflection.Emit;
//using hwC_Step;

///                                14th les HW
///                            დავალების აღწერა:
///                               Generic 
///  1. შექმენით Pair<T1, T2> Generic კლასი
///  · შეინახოს ორი ტიპის მნიშვნელობა. 
///  · ჰქონდეს კონსტრუქტორი და მეთოდი Print(). 
///  2. Generic მეთოდი, რომელიც აბრუნებს 
///  მინიმუმს public T Min<T>(T a, T b) where T : IComparable<T>     

//class Pair<T1, T2>
//{
//    public T1 First { get; set; }
//    public T2 Second { get; set; }

//    public Pair(T1 first, T2 second)
//    {
//        First = first;
//        Second = second;
//    }

//    public void Print()
//    {
//        Console.WriteLine($"First: {First}, Second: {Second}");
//    }

//}

////////////////////////////////////////////////////////////////////////////////////////////////////////

//T Min<T>(T a, T b) where T : IComparable<T>
//{
//    return a.CompareTo(b) < 0 ? a : b;
//}

//Console.WriteLine(Min(5, 2));



















































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

