using SkillPracticeBackendDev.Extensions;
using SkillPracticeBackendDev.LSP;
using SkillPracticeBackendDev.OCP;
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
PaymentProcessor paymentProcessor = new PaymentProcessor();
IPaymentMethod creditCard = new CreditCardPayment();
IPaymentMethod paypalCard=new PayPalPayment();
IPaymentMethod bitcon=new BitcoinPayment();
paymentProcessor.ProcessPayment(creditCard);
paymentProcessor.ProcessPayment(paypalCard);
paymentProcessor.ProcessPayment(bitcon);
Fruit fruit = new Apple();
Console.WriteLine(fruit.GetColor());
fruit=new Orange();
Console.WriteLine(fruit.GetColor());