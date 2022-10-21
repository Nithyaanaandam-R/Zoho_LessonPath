using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        User user = new Admininstrator();
        user.GenerateID();

        UserOperations useroperations = new AdminOperations();
        Console.WriteLine("Admin: " + user.ID);
        useroperations.GetDataDB(user.ID);

        user = new Registered_User();
        user.GenerateID();  

        Console.WriteLine("User: " + user.ID);
        useroperations = new RegisteredUserOperations();
        useroperations.GetDataDB(user.ID);
        
    }
}



