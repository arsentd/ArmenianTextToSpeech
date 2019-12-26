using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace ArmenianTextToSpeech
{
    /// <summary>
    /// Dictionary of word parts object
    /// </summary>
    public class Dictionary
    {
        /// <summary>
        /// Word parts
        /// </summary>
        public List<WordPart> WordParts { get; private set; }

        /// <summary>
        /// Loads word parts for the dictionary using given dictionary json string
        /// </summary>
        /// <param name="dictionary">Dictionary json string</param>
        public void LoadWordParts(string dictionary)
        {
            WordParts = JsonConvert.DeserializeObject<List<WordPart>>(dictionary);
        }

        /// <summary>
        /// Get word part object by part in armenian value
        /// </summary>
        /// <param name="partInArmenian">Part in armenian value</param>
        /// <returns>Word part object</returns>
        public WordPart GetWordPart(string partInArmenian)
        {
            return WordParts.First(p => p.PartInArmenian.ToLower() == partInArmenian.ToLower());
        }
    }
}