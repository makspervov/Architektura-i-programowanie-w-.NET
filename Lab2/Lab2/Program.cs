namespace Lab2.Solution
{
    class Program
    {
        static async Task Main(string[] args)
        {
            UsdCourse.Current = await UsdCourse.GetUsdCourseAsync();

            List<Fruit> fruitList = new List<Fruit>();

            for (int i = 0; i < 15; i++)
            {
                Fruit fruit = Fruit.Create();
                fruitList.Add(fruit);
            }

            var f = fruitList
                .Where(fruit => fruit.IsSweet)
                .OrderByDescending(fruit => fruit.Price);

            foreach (Fruit fruit in f)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadLine();
        }
    }
}
