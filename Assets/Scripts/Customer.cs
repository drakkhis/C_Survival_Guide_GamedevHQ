
[System.Serializable]
public class Customer
{
    public string FirstName;
    public string LastName;
    public uint Age;
    public string Gender;
    public string Occupation;

    public Customer()
    {

    }

    public Customer(string firstName, string lastName, uint age, string gender, string occupation)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Gender = gender;
        this.Occupation = occupation;
    }
}
