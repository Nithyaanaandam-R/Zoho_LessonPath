

public class Admininstrator : User
{
    //public string ID { get; set; }
    //public string Name { get; set; }
    public Password AdminPassword { get; set; }

    /* public Admininstrator()
    {
        ID = base.ID;
        Name = base.Name;
    } */

    public override void GenerateID() //Overriding the inherited abstract method
    {
        ID = "A" + new Random().Next(100);    
    }
}

public interface IAdminDataAccess
{
    Admininstrator GetDataDB(string adminID);    
}

public class AdminData_fromDB: IAdminDataAccess
{    
    public Admininstrator GetDataDB(string adminID)
    {
        var admin = new Admininstrator()
        {
            ID = adminID,
            Name = "Abd_" + adminID
        };


        return admin;   
    }
}

public class AdminOperations : UserOperations
{
    IAdminDataAccess _adminDataAccess;
    public AdminOperations()
    {
        _adminDataAccess = DataFactory.GetAdminData();
    }
    public override void GetDataDB(string adminID)
    {
        Console.WriteLine("Admin Name: " + _adminDataAccess.GetDataDB(adminID).Name);
    }
}



