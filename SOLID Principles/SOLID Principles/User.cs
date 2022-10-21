//Master class for all users - Open/Closed Principle
// A new user just needs to be a derived class and implement their own GenerateID() function

public abstract class User
{
    public string Name { get; set; }
    public string ID { get; set;  }

    public abstract void GenerateID(); 
}

public abstract class UserOperations
{
    public abstract void GetDataDB(string ID);
}



