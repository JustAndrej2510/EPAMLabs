using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatrade.Utils
{
    public static class RandomMessageGenerator
    {
        public static string GenerateRandomMessage()
        {
            Random random = new Random();
            var chars = "qwertyuiopasdfghjkzxcvbnm";
            return new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
