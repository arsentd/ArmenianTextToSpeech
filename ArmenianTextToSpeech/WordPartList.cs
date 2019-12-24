using System.Collections.Generic;

namespace ArmenianTextToSpeech
{
    /// <summary>
    /// List if word parts object
    /// </summary>
    public class WordPartList : List<WordPart>
    {
        /// <summary>
        /// Calculates all word parts rating sum
        /// </summary>
        /// <returns>Word parts rating sum</returns>
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