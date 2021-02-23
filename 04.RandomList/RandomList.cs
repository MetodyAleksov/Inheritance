using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, base.Count - 1);

            string item = base[index];

            base.RemoveAt(index);

            return item;
        }
    }
}
