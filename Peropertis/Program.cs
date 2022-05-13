

class User
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public DateTime Datetime { get; set; }


    public void GetUser(string id,string name,string lastname,string phonenumber,string email,DateTime dateTime)
    {
        Id = id;
        Name = name;
        LastName = lastname;
        PhoneNumber = phonenumber;
        Email = email;
        Datetime = dateTime;

    }
}
