using AssignmentOOP04.Question1;
using AssignmentOOP04.Question2;
using AssignmentOOP04.Question3;

namespace AssignmentOOP04
{
    internal class program
    {
        public static void Main(string [] args)
        {
            #region Q1
            //Circle c = new Circle() { Radius =3, Area = 0};
            //c.DisplayShapeInfo();

            //Rectangle r = new Rectangle() { Dim01=10, Dim02 =20, Area =0};
            //r.DisplayShapeInfo();
            #endregion

            #region Q2
            // BasicAuthenticationService BAS = new BasicAuthenticationService();
            // IAuthenticationService authService =  BAS;
            //Console.WriteLine( authService.AuthorizeUser("Rofida", "1220")? "You can Log in": "Wrong informatin");

            // Console.WriteLine(authService.AuthorizeUser("Rofida", "122@") ? "You can Log in" : "Wrong informatin");
            // Console.WriteLine(authService.AuthenticateUser("Rofida", "admin") ? "Welcome" : "Wrong information");


            #endregion

            #region Q3
            /*In the Main method, we create instances of each notification service class and 
             * call the SendNotification method with sample recipient and message values.*/

            //INotificationService notificationSer;
            //notificationSer = new EmailNotificationService();
            //notificationSer.SendNotification("Rofida", "I'm Trying Email Notification Service ");
            //notificationSer = new SmsNotificationService();
            //notificationSer.SendNotification("Rahma", "Meow");
            //notificationSer = new PushNotificationService();
            //notificationSer.SendNotification("Rana", "It's the end");

            #endregion
        }

    }
}