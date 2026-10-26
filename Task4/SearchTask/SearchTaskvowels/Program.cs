namespace SearchTaskvowels_
{
    internal class Program
    {
        static void cheack(string text ) {
        
        foreach (char c in text.ToLower( )) {
         if (c == 'a' || c == 'e' || c == 'i'|| c == 'u'|| c == 'o') {

                    Console.WriteLine("The string contain vowels. ");
                }          
            }
            throw new Exception("The string does not contain any vowels.");


        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a string:");
                string input = Console.ReadLine();

                cheack(input);
              
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
