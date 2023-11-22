using static Assignment_1.Class1;

namespace FirstConsoleApplication
{


    class Program
    {

        // A program that calculates the angle of a triangle

        static double TriangleArea(double x, double y)
        {

            double Area;
            Area = (x * y) / 2;
            return Area;
        }

        public static void Main(string[] args)
        {

            // Example of creating a user
            User user = new User(1, "Temiloluwa", "Orekunrin", "Orekunrintemiloluwa769.com");

            // Example of creating a payment
            Payment payment = new Payment(1001, 1, 50.00m);

            // You can now use 'user' and 'payment' objects in your program
            Console.WriteLine($"User: {user.FirstName} {user.LastName}, Email: {user.Email}, UserID: {user.UserId}");
            Console.WriteLine($"Payment: PaymentID: {payment.PaymentId}, UserID: {payment.UserId}, Amount: {payment.Amount}");


            double x, y;
            Console.WriteLine("Enter the base of the Triangle");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of the Triangle");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Area of this Triangle is {0}", TriangleArea(x, y));
            System.Console.ReadLine();
        }

    }
}