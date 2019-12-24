using System.Linq;
using Newtonsoft.Json;

namespace ArmenianTextToSpeech
{
    /// <summary>
    /// Dictionary object
    /// </summary>
    public class Dictionary
    {
        /// <summary>
        /// Dictionary word parts
        /// </summary>
        public WordPartList WordParts { get; private set; }

        /// <summary>
        /// Loads word parts for the dictionary using given json dictionary string
        /// </summary>
        /// <param name="dictionary">Dictionary json string</param>
        public void LoadParts(string dictionary)
        {
            WordParts = JsonConvert.DeserializeObject<WordPartList>(dictionary);
            foreach (var item in WordParts)
            {
                item.PartCorrection();
            }
        }

        /// <summary>
        /// Get word part object by part in armenian value
        /// </summary>
        /// <param name="part">Part in armenian value</param>
        /// <returns>Word part object</returns>
        public WordPart GetPart(string part)
        {
            return WordParts.FirstOrDefault(i => i.PartInArmenian.ToLower() == part);
        }
    }
}