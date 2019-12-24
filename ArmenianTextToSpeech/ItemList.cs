using System.Collections.Generic;

namespace ArmenianTextToSpeech
{
    /// <summary>
    /// List if parts object
    /// </summary>
    public class ItemList : List<Item>
    {
        /// <summary>
        /// Calculates all parts rates sum
        /// </summary>
        /// <returns>Parts rates sum</returns>
        public int CalculateRate()
        {
            var rate = 0;
            foreach (var item in this)
            {
                rate += item.Rate;
            }
            return rate;
        }
    }
}