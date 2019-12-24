using System.Collections.Generic;

namespace ArmenianTextToSpeech
{
    /// <summary>
    /// List if parts object
    /// </summary>
    public class ItemList : List<Item>
    {
        /// <summary>
        /// Calculates all parts rating sum
        /// </summary>
        /// <returns>Parts rating sum</returns>
        public int CalculateRating()
        {
            var rating = 0;
            foreach (var item in this)
            {
                rating += item.Rating;
            }
            return rating;
        }
    }
}