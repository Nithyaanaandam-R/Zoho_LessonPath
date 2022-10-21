//Single Responsibility Property

public class Password
{
    public readonly int _hashkey = 103;
    private int hashedPassword;

    public int HashedPassword
    {
        get
        {
            return hashedPassword;
        }
        set
        {
            hashedPassword = value;
        }
    }
} 

public interface IPasswordDetails
{
    Password GetPassword();
    int GetHashedPassword();
}
//Interface Segregation principle
public interface IVerifyPassword
{
    bool VerifyPassword(string password);
}
public class Password_from_DB : IPasswordDetails    
{
    public Password GetPassword()
    {
        var pass = new Password()
        {
            HashedPassword = 23541623
        }; 
        
        return pass;
    }

    public int GetHashedPassword()
    {
        var pass = new Password();
        return pass.HashedPassword;
    }
}//Actually supposed to interact with DB
public class PasswordOperations : IPasswordDetails, IVerifyPassword
{
    IPasswordDetails _password;

    public PasswordOperations()
    {
        _password = DataFactory.GetPassword();
    }
    public Password GetPassword()
    {
        return _password.GetPassword();
    }

    public int GetHashedPassword()
    {
        return _password.GetHashedPassword();
    }

    public bool VerifyPassword(string LoginPassword)
    {       

        if (_password.GetHashedPassword() == LoginPassword.GetHashCode())
            return true;
        else
            return false;
        
    }

}






