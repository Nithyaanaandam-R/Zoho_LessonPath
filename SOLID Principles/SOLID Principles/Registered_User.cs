public class Registered_User :User
{
    //public string Name { get; set; }
    //public string ID { get; set; }

    protected Password password;

    /*public Registered_User()
    {
        Name = base.Name;
        ID = base.ID;
    }*/

    public override void GenerateID()
    {
        ID = "U" + new Random().Next(1000);
    }
}

public interface IRegisteredUserDataAccess
{
    Registered_User GetDataDB(string id);
}
public class RegisteredUserDetailsDB : IRegisteredUserDataAccess
{
    public Registered_User GetDataDB(string id)
    {
        var user = new Registered_User()
        {
            Name = "Ryan",
            ID = id
        };
        return user;
    }
}

public class RegisteredUserOperations : UserOperations
{
    IRegisteredUserDataAccess _userData;
    public RegisteredUserOperations()
    {
        _userData = DataFactory.GetUserData();
    }
    public override void GetDataDB(string id)
    {
        Console.WriteLine("Registered User Name: " + _userData.GetDataDB(id).Name);
    }

}





