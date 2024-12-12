using SkillPracticeBackendDev.Extensions;
using SkillPracticeBackendDev.SRP;
using SkillPracticeBackendDev.OCP;
using SkillPracticeBackendDev.LSP;
using SkillPracticeBackendDev.ISP;
using SkillPracticeBackendDev.DIP;
using SkillPracticeBackendDev.DI;
using static SkillPracticeBackendDev.Linq.LinqGoodPractice;
using SkillPracticeBackendDev.Linq;
Console.WriteLine("Hello, World!");
List<int> numbers=new List<int> { 1,7,9};
var average = numbers.AverageHelper();
Console.WriteLine("AVG:" + average);
int[] marks = new[] { 80, 100, 90, 20, 40 };
var averagemakr = marks.AverageHelper();
Console.WriteLine($"AVG Marks:{averagemakr}");
// Call the extension method
try
{
    int secondElement = numbers.Second();
    Console.WriteLine("The second element is: " + secondElement);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}
string greeting = "Hello,I am MG.I am from Thailand.";
var rightGreeting = greeting.RightSubstring(10);
Console.WriteLine(rightGreeting);
Console.WriteLine("============SRP===============");
// Employee data
Employee employee = new Employee
{
    Name = "John Doe",
    Salary = 120000
};
// Salary calculation
SalaryCalculator calculator = new SalaryCalculator();
decimal monthlySalary = calculator.CalculateMonthlySalary(employee);
Console.WriteLine($"Monthly Salary of {employee.Name}: {monthlySalary}");
// File saving
EmployeeFileManager fileManager = new EmployeeFileManager();
fileManager.SaveToFile(employee, "employee.txt");
Console.WriteLine("Employee details saved to file.");

Console.WriteLine("============OCP===============");
PaymentProcessor paymentProcessor = new PaymentProcessor();
IPaymentMethod creditCard = new CreditCardPayment();
IPaymentMethod paypalCard=new PayPalPayment();
IPaymentMethod bitcon=new BitcoinPayment();
paymentProcessor.ProcessPayment(creditCard);
paymentProcessor.ProcessPayment(paypalCard);
paymentProcessor.ProcessPayment(bitcon);

Console.WriteLine("============LSP===============");
Fruit fruit = new Apple();
Console.WriteLine(fruit.GetColor());
fruit=new Orange();
Console.WriteLine(fruit.GetColor());

Console.WriteLine("============ISP===============");
IWorkable humanWorker = new HumanWorker();
IWorkable robotWorker = new RobotWorker();
IEatable humanEater = new HumanWorker();

humanWorker.Work(); // Output: Human is working.
robotWorker.Work(); // Output: Robot is working.
humanEater.Eat();   // Output: Human is eating.

Console.WriteLine("============DIP===============");
// Use EmailSender
INotificationService emailSender = new EmailSender();
OrderService orderServiceWithEmail = new OrderService(emailSender);
orderServiceWithEmail.PlaceOrder();

// Use SmsSender
INotificationService smsSender = new SmsSender();
OrderService orderServiceWithSms = new OrderService(smsSender);
orderServiceWithSms.PlaceOrder();
/*
Console.WriteLine("============DI===============");
GameManager gameManager=new GameManager(new HumanPlayer(),new ComputerPlayer());
do
{
    RoundResult result = gameManager.PlayRound();
    if (result == RoundResult.Player1Win)
        Console.WriteLine("YOU:Player 1 wins.");
    else if (result == RoundResult.Player2Win)
        Console.WriteLine("COMPUTER:Player 2 wins.");
    else
        Console.WriteLine("It is a draw.");
    Console.Write("Play again:Y/N?)");
} while (Console.ReadLine().ToUpper() == "Y");
*/
IsEvenDelegate isEvenDel = IsEven;
List<int> nums = new List<int> { 1, 2, 3, 4, 5 };

IEnumerable<int> evenNumbers = nums.Where(n => isEvenDel(n));
foreach (int n in evenNumbers)
{
    Console.Write(n+",");
}
Console.WriteLine("============Linq===============");
var teenAger = LinqGoodPractice.TeenagerStudents();
foreach(var s in teenAger)
{
    Console.WriteLine(s);
}
Console.WriteLine("============Linq===============");
var groupByStudents = from s in teenAger group s by s.Age into sg select new { k=sg.Key,v=sg};
foreach (var g in groupByStudents)
{
    Console.WriteLine(g.k+" "+g.v);
}
// Set operations example
var firstNames = new string[] { "John", "Jane", "Jim", "Jane" };
var lastNames = new string[] { "Doe", "Smith", "Adams", "John" };
Console.WriteLine("============Linq Distinct===============");
var distinctFirstNames = firstNames.Distinct(); // "John", "Jane", "Jim"
foreach (var i in distinctFirstNames)
    Console.Write(i+" ");
var unionNames = firstNames.Union(lastNames); // "John", "Jane", "Jim", "Doe", "Smith", "Adams"
Console.WriteLine("============Linq Union===============");
foreach (var i in unionNames)
    Console.Write(i + " ");
var intersectNames = firstNames.Intersect(lastNames); // "John"
Console.WriteLine("============Linq Intersect===============");
foreach (var i in intersectNames)
    Console.Write(i + " ");
Console.ReadKey();
