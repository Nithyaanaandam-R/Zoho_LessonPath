public class Usersignin_singleResponsibility
{
    Password pass;
     
    public void Usersignin()
    {
        Console.WriteLine("Enter UserMAil");
        Console.WriteLine("Enter Password");
        pass = new Password(Console.ReadLine());
    }
}

public class Password //splitting password responsibility and not including such functions in User class
{
    string hashkey;
    string hashword;
    public Password(string passWord)
    {
        //Call hashing and verify password
    }

    public bool Verify_Hashed_Password()
    {
        //Verifies Password with DB
        return true;
    }

    public string Hashing_function(string pass)
    {
        //Hashing function

        return hashword;
    }
}