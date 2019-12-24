using System;
using System.Speech.Synthesis;
using System.Text;

namespace ArmenianTextToSpeech
{
    /// <summary>
    /// Speech object
    /// </summary>
    public class Speech
    {
        /// <summary>
        /// General dictionary object
        /// </summary>
        private Dictionary dictionary { get; set; }

        /// <summary>
        /// Speech object constructor
        /// </summary>
        public Speech()
        {
            var dictionaryString = Encoding.UTF8.GetString(Properties.Resources.dictionary);
            dictionary = new Dictionary();
            dictionary.LoadParts(dictionaryString);
        }

        /// <summary>
        /// Speaks given word with normal speed
        /// </summary>
        /// <param name="word">Word to speak</param>
        public void Speak(string word)
        {
            Speak(word, 0);
        }

        /// <summary>
        /// Speaks given word with given speed
        /// </summary>
        /// <param name="word">Word to speak</param>
        /// <param name="speed">Speed</param>
        public void Speak(string word, int speed)
        {
            word = word.ToLower();
            if (IsCorrectWord(word))
            {
                var parts = WordToParts(word);
                var wordToSpeak = PartsToWord(parts);

                var synthesizer = new SpeechSynthesizer();
                synthesizer.Rate = speed;
                synthesizer.SpeakAsync(wordToSpeak);
            }
            else
            {
                throw new Exception("Word is incorrect.");
            }
        }

        /// <summary>
        /// Splits given word to parts
        /// </summary>
        /// <param name="word">Word</param>
        /// <returns>List of parts</returns>
        private ItemList WordToParts(string word)
        {
            var parts = new ItemList();
            if (word.Length <= 2)
            {
                parts.Add(dictionary.GetPart(word));
            }
            else if (word.Length % 2 == 0)
            {
                for (var i = 0; i < word.Length; i += 2)
                {
                    var partText = word[i].ToString() + word[i + 1].ToString();
                    parts.Add(dictionary.GetPart(partText));
                }
            }
            else if (word.Length % 2 == 1)
            {
                var parts1 = new ItemList();
                var parts2 = new ItemList();
                for (var i = 0; i < word.Length; i += 2)
                {
                    if (i == 0)
                    {
                        var partText = word[0].ToString();
                        parts1.Add(dictionary.GetPart(partText));
                    }
                    else
                    {
                        var partText = word[i].ToString() + word[i + 1].ToString();
                        parts1.Add(dictionary.GetPart(partText));
                    }

                    if (i != word.Length - 1)
                    {
                        var partText = word[i].ToString() + word[i + 1].ToString();
                        parts2.Add(dictionary.GetPart(partText));
                    }
                    else
                    {
                        var partText = word[word.Length - 1].ToString();
                        parts2.Add(dictionary.GetPart(partText));
                    }
                }

                var rate1 = parts1.CalculateRate();
                var rate2 = parts1.CalculateRate();
                if (rate1 > rate2)
                {
                    parts = parts1;
                }
                else
                {
                    parts = parts2;
                }
            }
            return parts;
        }

        /// <summary>
        /// Combines the given parts to word
        /// </summary>
        /// <param name="parts">Parts</param>
        /// <returns>Word</returns>
        private string PartsToWord(ItemList parts)
        {
            var word = string.Empty;
            foreach (var part in parts)
            {
                word += part.Trascription + "-";
            }
            word = word.Remove(word.Length - 1, 1);
            return word;
        }

        /// <summary>
        /// Check if the given word is not empty and do not contain spaces. Also checks if only armenian letters are used.
        /// </summary>
        /// <param name="word">Word</param>
        /// <returns>If word is correct - true, else - false</returns>
        private bool IsCorrectWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word) || word.Contains(" "))
            {
                return false;
            }
            else
            {
                foreach (var symbol in word)
                {
                    if (!((symbol >= 'ա' && symbol <= 'ֆ') || (symbol >= 'Ա' && symbol <= 'Ֆ')))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}