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
            User user1 = new User(1, "Temiloluwa", "Orekunrin", "Orekunrintemiloluwa769.com");
            User user2 = new User(1, "Temiloluwa", "Orekunrin", "Orekunrintemiloluwa769.com");
            User user3 = new User(1, "Temiloluwa", "Orekunrin", "Orekunrintemiloluwa769.com");
            User user4 = new User(1, "Temiloluwa", "Orekunrin", "Orekunrintemiloluwa769.com");
            User user5 = new User(1, "Temiloluwa", "Orekunrin", "Orekunrintemiloluwa769.com");

            // Example of creating a payment
            Payment payment = new Payment(1001, 1, 50.00m);

            // You can now use 'user' and 'payment' objects in your program
            Console.WriteLine($"User: {user1.FirstName} {user1.LastName}, Email: {user1.Email}, UserID: {user1.UserId}");
            Console.WriteLine($"User: {user2.FirstName} {user2.LastName}, Email: {user2.Email}, UserID: {user2.UserId}");
            Console.WriteLine($"User: {user3.FirstName} {user3.LastName}, Email: {user3.Email}, UserID: {user3.UserId}");
            Console.WriteLine($"User: {user4.FirstName} {user4.LastName}, Email: {user4.Email}, UserID: {user4.UserId}");
            Console.WriteLine($"User: {user5.FirstName} {user5.LastName}, Email: {user5.Email}, UserID: {user5.UserId}");
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