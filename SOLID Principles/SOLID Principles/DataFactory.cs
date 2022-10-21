public class DataFactory
{
    public static IRegisteredUserDataAccess GetUserData()
    {
        return new RegisteredUserDetailsDB();
    }

    public static IPasswordDetails GetPassword()
    {
        return new Password_from_DB();
    }

    public static IAdminDataAccess GetAdminData()
    {
        return new AdminData_fromDB();
    }
}




