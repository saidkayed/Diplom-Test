namespace ExceptionUnitTest
{
    internal class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            if (name == null || name.Trim().Length == 0)
            {
                throw new ArgumentException("Name cannot be null or empty");
            }

            if (age < 0 || age > 150)
            {
                throw new ArgumentException("Age cannot be negative and bigger than 150");
            }

            this.name = name;
            this.age = age;
        }


        static void Main(string[] args)
        {
            
        }
    }
}