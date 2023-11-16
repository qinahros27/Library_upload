namespace Library.src.Manage.TypeOfCustomer
{
    public abstract class Person 
    {
        public string Name {get;set;} = string.Empty;
        public int Id {get;set;}

        public Person(int id, string name) 
        {
            Id = id;
            Name = name;
        }
    }
}