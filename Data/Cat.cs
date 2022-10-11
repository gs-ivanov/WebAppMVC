namespace WebAppMVC.Data
{
    public class Cat
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public int Age { get; init; }

        public Owner Owner { get; init; }
    }
}
