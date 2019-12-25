using System.Collections.Generic;

namespace ArmenianTextToSpeech
{
    /// <summary>
    /// List of word part objects
    /// </summary>
    public class WordPartList : List<WordPart>
    {
        /// <summary>
        /// Calculates total rating for all word parts in the list
        /// </summary>
        /// <returns>Total word parts rating</returns>
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