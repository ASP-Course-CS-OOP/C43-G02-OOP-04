namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01

            #region Q01 - What is the primary purpose of an interface in C#?

            //a) To provide a way to implement multiple inheritance

            #endregion

            #region Q02 - Which of the following is NOT a valid access modifier for interface members in C#?

            // a) private

            #endregion

            #region Q03 - Can an interface contain fields in C#?

            // b) No

            #endregion

            #region Q04 - In C#, can an interface inherit from another interface?

            // b) Yes, interfaces can inherit from multiple interfaces

            #endregion

            #region Q05 - Which keyword is used to implement an interface in a class in C#?

            // d) implements

            #endregion

            #region Q06 - Can an interface contain static methods in C#?

            // a) Yes

            #endregion

            #region Q07 - In C#, can an interface have explicit access modifiers for its members?

            // b) No, all members are implicitly public

            #endregion

            #region Q08 - What is the purpose of an explicit interface implementation in C#?

            // b) To provide a clear separation between interface and class members

            #endregion

            #region Q09 - In C#, can an interface have a constructor?

            // b) No, interfaces cannot have constructors

            #endregion

            #region Q10 - How can a C# class implement multiple interfaces?

            // c) By separating interface names with commas

            #endregion

            #endregion

            #region Part02

            #region Q01 - Define an interface named IShape with a property Area and a methodDisplayShapeInfo.Create two interfaces, ICircle and IRectangle, that inherit fromIShape.Implement these interfaces in classes Circle and Rectangle. Test yourimplementation by creating instances of both classes and displaying their shapeinformation.

            //ICircle circle = new Circle(5);
            //circle.DisplayShapeInfo();

            //IRectangle rectangle = new Rectangle(4, 6);
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Q02 - In this example, we start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser.The BasicAuthenticationServiceclass implements this interface and provides the specific implementation for thesemethods.

            //IAuthenticationService authService = new BasicAuthenticationService();

            //string username = "user1";
            //string password = "password1";
            //string role = "Admin";

            //if (authService.AuthenticateUser(username, password))
            //{
            //    Console.WriteLine($"{username} authenticated successfully.");
            //    if (authService.AuthorizeUser(username, role))
            //    {
            //        Console.WriteLine($"{username} authorized as {role}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{username} is not authorized as {role}.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Authentication failed.");
            //}

            #endregion

            #region Q03 - we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.

                //INotificationService emailService = new EmailNotificationService();
                //emailService.SendNotification("eslam.saadany22@gmail.com", "Welcome to the platform!");

                //INotificationService smsService = new SmsNotificationService();
                //smsService.SendNotification("01022010887", "Your OTP is 123456.");

                //INotificationService pushService = new PushNotificationService();
                //pushService.SendNotification("Iphone 8 Plus", "You have a new message.");

            #endregion

            #endregion

        }
    }
}
