using System.Text;

namespace Task.Services
{
    public partial class Task
    {
        static public void Number1()
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            StringBuilder newInput = new StringBuilder();
            if (input.Length % 2 == 0)
            {
                for (int i = (input.Length / 2) - 1; i > -1; i--)
                {
                    newInput.Append(input[i]);
                }
                for (int i = input.Length - 1; i > (input.Length / 2) - 1; i--)
                {
                    newInput.Append(input[i]);
                }
            }
            else
            {
                for (int i = input.Length - 1; i > -1; i--)
                {
                    newInput.Append(input[i]);
                }
                newInput.Append(input);
            }
            Console.WriteLine(newInput);
        }
    }
}