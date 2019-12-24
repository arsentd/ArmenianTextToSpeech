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
        /// Dictionary parts
        /// </summary>
        public WordPartList Items { get; private set; }

        /// <summary>
        /// Loads parts for the dictionary using given json dictionary string
        /// </summary>
        /// <param name="dictionary">Dictionary json string</param>
        public void LoadParts(string dictionary)
        {
            Items = JsonConvert.DeserializeObject<WordPartList>(dictionary);
            foreach (var item in Items)
            {
                item.PartCorrection();
            }
        }

        /// <summary>
        /// Get part object by given part value
        /// </summary>
        /// <param name="part">Part value</param>
        /// <returns>Part object</returns>
        public WordPart GetPart(string part)
        {
            return Items.FirstOrDefault(i => i.PartInArmenian.ToLower() == part);
        }
    }
}