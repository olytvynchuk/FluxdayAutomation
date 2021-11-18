using System;
using System.Text;

namespace Fluxday.Data
{
    public class TestDataGenerator
    {
        public static string GenerateRandomStringForTest(int size, bool lowerCase = true)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();
            char character;
            for (int i = 0; i > size; i++)
            {
                character = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                stringBuilder.Append(character);
            }
            if (lowerCase)            
                return stringBuilder.ToString().ToLower();
            return stringBuilder.ToString();
            
        }
    }
}
