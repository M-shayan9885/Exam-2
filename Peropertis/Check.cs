public class Check
{
    public void check()
    {
        Console.WriteLine("please enter your email");
        string? email = Console.ReadLine();
        if(string.IsNullOrEmpty(email))
        {
            Console.WriteLine("Error");
        }
        else if (email == User.email)
        {
            Console.WriteLine("you in");
        }
    }
    public void LogIn()
    {
        foreach (var item in User)
        {
            if (item == null)
            {
                Console.WriteLine("please try again");
            }
            else if (string.IsNullOrEmpty(item.Email))
            {
                Console.WriteLine("please try again");
            }
            else if (string.IsNullOrEmpty(item.password))
            {
                Console.WriteLine("please try again");
            }
    

        }
        
    }

    public void Register()
    {


    }

}
