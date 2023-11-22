using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Class1
    {
        // User class representing a user entity
        public class User
        {
            // Properties
            public int UserId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }

            // Constructor
            public User(int userId, string firstName, string lastName, string email)
            {
                UserId = userId;
                FirstName = firstName;
                LastName = lastName;
                Email = email;
            }
        }

        // Payment class representing a payment entity
        public class Payment
        {
            // Properties
            public int PaymentId { get; set; }
            public int UserId { get; set; }
            public decimal Amount { get; set; }

            // Constructor
            public Payment(int paymentId, int userId, decimal amount)
            {
                PaymentId = paymentId;
                UserId = userId;
                Amount = amount;
            }
        }

        //class Program
        //{
        //    static void Main()
        //    {
        //        // Example of creating a user
        //        User user = new User(1, "John", "Doe", "john.doe@example.com");

        //        // Example of creating a payment
        //        Payment payment = new Payment(1001, 1, 50.00m);

        //        // You can now use 'user' and 'payment' objects in your program
        //        Console.WriteLine($"User: {user.FirstName} {user.LastName}, Email: {user.Email}, UserID: {user.UserId}");
        //        Console.WriteLine($"Payment: PaymentID: {payment.PaymentId}, UserID: {payment.UserId}, Amount: {payment.Amount}");

        //        // Add more functionality as needed
        //    }
        //}
    }
}
