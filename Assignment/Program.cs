using Assignment.Part02___Q2;
using Assignment.Part03___Q3;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01

            #region Q1 - What is the primary purpose of an interface in C#?

            // a) To provide a way to implement multiple inheritance

            #endregion

            #region Q2 - Which of the following is NOT a valid access modifier for interface members in C#?

            // a) private

            #endregion

            #region Q3 - Can an interface contain fields in C#?

            // c) Only if they are static

            #endregion

            #region Q4 - In C#, can an interface inherit from another interface?

            // b) Yes, interfaces can inherit from multiple interfaces

            #endregion

            #region Q5 - Which keyword is used to implement an interface in a class in C#?

            // d) implements

            #endregion

            #region Q6 - Can an interface contain static methods in C#?

            // a) Yes

            #endregion

            #region Q7 - In C#, can an interface have explicit access modifiers for its members?

            // b) No, all members are implicitly public

            #endregion

            #region Q8 - What is the purpose of an explicit interface implementation in C#?

            // b) To provide a clear separation between interface and class members

            #endregion

            #region Q9 - In C#, can an interface have a constructor?

            //b) No, interfaces cannot have constructors

            #endregion

            #region Q10 - How can a C# class implement multiple interfaces?

            // c) By separating interface names with commas

            #endregion

            #endregion

            #region Part02

            #region Q1 - Define an interface named IShape with a property Area and a method DisplayShapeInfo. 

            //ICircle1 circle1 = new Circle1(5);

            //circle1.DisplayShapeInfo();

            //Console.WriteLine("-------------------------------");

            //IRectangle1 rectangle1 = new Rectangle1(4,5);

            //rectangle1.DisplayShapeInfo();

            #endregion

            #region Q2 - In this example, we start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser

            //string name;
            //do
            //{
            //    Console.Write("Enter Your Name: ");
            //    name = Console.ReadLine()!;
            //} while (string.IsNullOrWhiteSpace(name));

            //string password;
            //do
            //{
            //    Console.Write("Enter Your Password: ");
            //    password = Console.ReadLine()!;
            //} while (string.IsNullOrWhiteSpace(password));

            //IAuthenticationServicee authenticationServicee = new BasicAuthenticationServicee();
            //if (authenticationServicee.AuthenticateUser(name, password))
            //{
            //    Console.WriteLine($"Hello {name}, You Are Authenticated!");

            //    Console.Write("Enter Your Role: ");
            //    Enum.TryParse<Role>(Console.ReadLine(), true, out Role role);

            //    if (authenticationServicee.AuthorizeUser(name, role))
            //        Console.WriteLine($"You Are Authorized as {role}!");
            //    else
            //        Console.WriteLine($"Invalid Role for {name}!");
            //}
            //else
            //    Console.WriteLine($"Authenticated for {name} failed!");


            #endregion

            #region Q3 - we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.

            //INotificationServicee notificationService = new EmailNotificationServicee();
            //notificationService.SendNotification("eslam.saadany22@gmail.com", "Hello This is Email Notification!");

            //notificationService = new SmsNotificationServicee();
            //notificationService.SendNotification("01022010887", "This is the OTP (145987)");

            //notificationService = new PushNotificationServicee();
            //notificationService.SendNotification("Iphone 8 plus", "You have 3 missed call!");

            #endregion

            #endregion

        }
    }
}
