namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Lembda Expression");
            List<Person> listPersonInCity = new List<Person>();
            LambdaDemo.AddRecords(listPersonInCity);
            LambdaDemo.Retrieving_TopTwoRecord_ForAgels_LessThanSixty(listPersonInCity);
            LambdaDemo.CheckingForTeenagerPerson(listPersonInCity);
        }
    }
}