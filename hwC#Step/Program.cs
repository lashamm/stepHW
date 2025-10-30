/////                                20th les HW
///

///                                 Factorial extension method
using hwC_Step;
using System.Threading.Channels;

int number = 5;
Console.WriteLine(number.Factorial());
Console.WriteLine("////////////////////////////");



List<int> list = new List<int> { 1, 1, 2, 3, 3, 4, 5, 5 };

list.RemoveDublicate().ForEach(Console.WriteLine);
Console.WriteLine("//////////////////////////////");



List<int> average = new List<int> {3, 4 , 7, 10 };

Console.WriteLine(average.Average());
Console.WriteLine("/////////////////////////////////");




















/////                                 19th les HW
/////                                 



////                                      1.


//string text = "i miss lorem";
//string text2 = "i need lorem in c#";

//Console.WriteLine(text.wordcount());
//Console.WriteLine(text2.wordcount());
//Console.WriteLine("////////////////////////////////////////////");



////                                     2.


//var items = new List<string> { "apple", null, "banana", null, "cherry" };

//var filtered = items.WhereNotNull();
//Console.WriteLine(string.Join(", ", filtered));
//Console.WriteLine("////////////////////////////////////////////");


////                                     3.


//DateTime today = DateTime.Now;
//Console.WriteLine(today.ToFriendlyDate());
//Console.WriteLine("////////////////////////////////////////////");


////                                    4.


//int number = 15;
//int number2 = 25;

//Console.WriteLine(number.IsInRange(5,20));
//Console.WriteLine(number2.IsInRange(5, 20));
//Console.WriteLine("////////////////////////////////////////////");

////                                    5.

//var numbers = new List<int> { 1, 2, 3, 4, 5 };
//var reversed = new List<int> { 5, 4, 3, 2, 1 };
//numbers.ReverseList();
//Console.WriteLine(string.Join(", ", numbers));
//reversed.ReverseList();
//Console.WriteLine(string.Join(", ", reversed));

////using hwC_Step.old;


//////                                    18th les HW
/////



//List<Product> products = new List<Product>
//{
//    new Product { Id = 1, Name = "Laptop", Category = "Electronics", Description = "High performance laptop", Price = 999.99m },
//    new Product { Id = 2, Name = "Headphones", Category = "Electronics", Description = "Noise-cancelling headphones", Price = 199.99m },
//    new Product { Id = 3, Name = "Coffee Mug", Category = "Kitchenware", Description = "Ceramic coffee mug", Price = 9.99m },
//    new Product { Id = 4, Name = "Office Chair", Category = "Furniture", Description = "Ergonomic office chair", Price = 149.99m },
//    new Product { Id = 5, Name = "Smartphone", Category = "Electronics", Description = "Latest model smartphone", Price = 699.99m },
//    new Product { Id = 6, Name = "Bluetooth Speaker", Category = "Electronics", Description = "Portable Bluetooth speaker", Price = 59.99m },
//    new Product { Id = 7, Name = "Notebook", Category = "Stationery", Description = "100-page ruled notebook", Price = 2.49m },
//    new Product { Id = 8, Name = "Desk Lamp", Category = "Furniture", Description = "LED desk lamp", Price = 29.99m },
//    new Product { Id = 9, Name = "Backpack", Category = "Accessories", Description = "Water-resistant backpack", Price = 49.99m },
//    new Product { Id = 10, Name = "Water Bottle", Category = "Kitchenware", Description = "Insulated water bottle", Price = 19.99m },
//    new Product { Id = 11, Name = "Monitor", Category = "Electronics", Description = "27-inch 4K monitor", Price = 299.99m },
//    new Product { Id = 12, Name = "Wireless Mouse", Category = "Electronics", Description = "Ergonomic wireless mouse", Price = 24.99m },
//    new Product { Id = 13, Name = "Keyboard", Category = "Electronics", Description = "Mechanical keyboard", Price = 89.99m },
//    new Product { Id = 14, Name = "Sneakers", Category = "Footwear", Description = "Running sneakers", Price = 79.99m },
//    new Product { Id = 15, Name = "Sunglasses", Category = "Accessories", Description = "UV protection sunglasses", Price = 39.99m },
//    new Product { Id = 16, Name = "T-shirt", Category = "Clothing", Description = "Cotton t-shirt", Price = 14.99m },
//    new Product { Id = 17, Name = "Jeans", Category = "Clothing", Description = "Denim jeans", Price = 49.99m },
//    new Product { Id = 18, Name = "Watch", Category = "Accessories", Description = "Digital wristwatch", Price = 129.99m },
//    new Product { Id = 19, Name = "Tablet", Category = "Electronics", Description = "10-inch tablet", Price = 399.99m },
//    new Product { Id = 20, Name = "Charger", Category = "Electronics", Description = "Fast USB charger", Price = 14.99m },
//    new Product { Id = 21, Name = "Flash Drive", Category = "Electronics", Description = "64GB USB flash drive", Price = 19.99m },
//    new Product { Id = 22, Name = "Camera", Category = "Electronics", Description = "Digital camera", Price = 249.99m },
//    new Product { Id = 23, Name = "Bookshelf", Category = "Furniture", Description = "Wooden bookshelf", Price = 89.99m },
//    new Product { Id = 24, Name = "Cookware Set", Category = "Kitchenware", Description = "10-piece cookware set", Price = 129.99m },
//    new Product { Id = 25, Name = "Blender", Category = "Kitchenware", Description = "High-speed blender", Price = 59.99m },
//    new Product { Id = 26, Name = "Yoga Mat", Category = "Fitness", Description = "Non-slip yoga mat", Price = 24.99m },
//    new Product { Id = 27, Name = "Dumbbells", Category = "Fitness", Description = "Set of 2 dumbbells", Price = 39.99m },
//    new Product { Id = 28, Name = "Running Shorts", Category = "Clothing", Description = "Lightweight running shorts", Price = 19.99m },
//    new Product { Id = 29, Name = "Baseball Cap", Category = "Accessories", Description = "Adjustable baseball cap", Price = 12.99m },
//    new Product { Id = 30, Name = "Electric Kettle", Category = "Kitchenware", Description = "1.7L electric kettle", Price = 29.99m },
//};

//List<User> users = new List<User>
//{
//    new User { Age = 25, Name = "Alice" },
//    new User { Age = 30, Name = "Bob" },
//    new User { Age = 22, Name = "Charlie" },
//    new User { Age = 35, Name = "Diana" },
//    new User { Age = 28, Name = "Eve" },
//    new User { Age = 33, Name = "Frank" },
//    new User { Age = 17, Name = "Grace" },
//    new User { Age = 31, Name = "Henry" },
//    new User { Age = 14, Name = "Iris" },
//    new User { Age = 29, Name = "Jack" },
//    new User { Age = 16, Name = "Karen" },
//    new User { Age = 34, Name = "Liam" },
//    new User { Age = 23, Name = "Mia" },
//    new User { Age = 32, Name = "Noah" },
//    new User { Age = 21, Name = "Olivia" },
//    new User { Age = 36, Name = "Paul" },
//    new User { Age = 28, Name = "Quinn" },
//    new User { Age = 30, Name = "Rachel" },
//    new User { Age = 25, Name = "Sam" },
//    new User { Age = 17, Name = "Tina" },
//    new User { Age = 33, Name = "Ulysses" },
//    new User { Age = 19, Name = "Vera" },
//    new User { Age = 31, Name = "Walter" },
//    new User { Age = 26, Name = "Xena" },
//    new User { Age = 24, Name = "Yuri" },
//    new User { Age = 15, Name = "Zoe" },
//    new User { Age = 12, Name = "Aaron" },
//    new User { Age = 28, Name = "Bella" },
//    new User { Age = 12, Name = "Chris" },
//    new User { Age = 10, Name = "Daisy" }
//};

////var groups = products.GroupBy(x => x.Category);

////foreach (var group in groups)
////{
////Console.WriteLine(group.Key);
////foreach (var item in group)
////{
////Console.WriteLine("\t" + item.Name);
////}
////}

//List<Order> orders = new List<Order>();

//Random rand = new Random();
//DateTime startDate = DateTime.Now.AddMonths(-3);

//for (int i = 1; i <= 50; i++)
//{
//orders.Add(new Order
//{
//Id = i,
//PurchaseTime = startDate.AddDays(rand.Next(1, 90)).AddHours(rand.Next(0, 24)).AddMinutes(rand.Next(0, 60)),
//ProductId = rand.Next(1, 31),  
//UserId = rand.Next(100, 121)   
//});
//}
/////////
//var joinedItems = from o in orders
//join p in products on o.ProductId equals p.Id
//                  select new
//{
//Id = o.Id,
//PurchaseTime = o.PurchaseTime,
//ProductName = p.Name,
//Category =p.Category,
//Description =p.Description,
//Price = p.Price,
//                  };





//foreach (var item in joinedItems)
//{
////Console.WriteLine($"{item.PurchaseTime}, {item.ProductName}, {item.Description}");
//}

//// პროდუქტის ფასი 50-ზე მეტია
//var moreThan50 = products.Where(p => p.Price > 50);

//// შეძენა გუშინ მოხდა
//var yesterday = DateTime.Now.AddDays(-1);
////Print(yesterday);

//// კატეგორია Electronics - ის პროდუქტები
//var uniqueProducts = products.DistinctBy(x => x.Category).Select(x => x.Category);
//////////////////////////////////////
/////

/////        18+ buyers


//foreach (var product in uniqueProducts)
//{
//Console.WriteLine(product);
//}



























/////                                         17th les HW
/////                                         დავალების აღწერა:
/////          Student - ების სიიდან წამოიღეთ ის სტუდენტები, რომელთა: 
/////          1.ქულაც 5 - ზე მეტია. 2.ქალაქიც იწყება 'a'- ზე



//List<Student> students = new List<Student>
//{
//    new Student { Name = "Alice Johnson", Age = 16, Grade = 10, City = "New York" },
//    new Student { Name = "Benjamin Lee", Age = 17, Grade = 11, City = "Los Angeles" },
//    new Student { Name = "Charlotte Smith", Age = 15, Grade = 9, City = "Chicago" },
//    new Student { Name = "Daniel Brown", Age = 18, Grade = 12, City = "New York" },  
//    new Student { Name = "Ella Davis", Age = 16, Grade = 10, City = "Phoenix" },
//    new Student { Name = "Frank Miller", Age = 17, Grade = 11, City = "Los Angeles" },   
//    new Student { Name = "Grace Wilson", Age = 15, Grade = 9, City = "San Antonio" },
//    new Student { Name = "Henry Moore", Age = 18, Grade = 12, City = "Chicago" },        
//    new Student { Name = "Isabella Taylor", Age = 16, Grade = 10, City = "Dallas" },
//    new Student { Name = "Jack Anderson", Age = 17, Grade = 11, City = "San Jose" },
//    new Student { Name = "Katherine Thomas", Age = 15, Grade = 9, City = "Austin" },
//    new Student { Name = "Liam Martinez", Age = 18, Grade = 12, City = "Phoenix" },         
//    new Student { Name = "Mia Robinson", Age = 16, Grade = 10, City = "San Antonio" },     
//    new Student { Name = "Noah Clark", Age = 17, Grade = 11, City = "Dallas" }              
//};

//var orderedByAge = students.OrderByDescending(x => x.Age);
//Print(orderedByAge);

//Console.WriteLine("==============================");

//var isAllAdult = students.All(s => s.Age >= 18);
//Console.WriteLine(isAllAdult);

//Console.WriteLine("==============================");

//var gradeAbove5 = students.Where(a => a.Grade > 5);
//Print(gradeAbove5);

//Console.WriteLine("==============================");
//var cityStartsWithA = students.Where(a => a.City.StartsWith("a", StringComparison.OrdinalIgnoreCase));
//Print(cityStartsWithA);

//static void Print<T>(IEnumerable<T> collection)
//{
//    foreach (var item in collection)
//    {
//        Console.WriteLine(item);
//    }
//}













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

