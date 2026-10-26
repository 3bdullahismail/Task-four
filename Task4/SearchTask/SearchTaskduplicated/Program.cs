namespace SearchTask
{
    internal class Program
    {
        static void Cheak(List<int>numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                for(int j = i+1; j < numbers.Count; j++) {
                    if (numbers[i] == numbers[j])
                    {
                        throw new Exception($"Duplicate number found: {numbers[i]}");
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>();
                Console.WriteLine("Enter the number of elements:");
                int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine($"Enter number {i + 1}:");
                    numbers.Add(Convert.ToInt32(Console.ReadLine()));
                }

                Cheak(numbers);
                Console.WriteLine("No duplicates found.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: please enter valid integers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


        }
    }
}
