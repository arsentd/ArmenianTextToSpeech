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

            CheckWord(word);
            word = CorrectVoToOProblem(word);
            word = CorrectDualLetterUProblem(word);

            var parts = WordToParts(word);
            var wordToSpeak = PartsToWord(parts);

            var synthesizer = new SpeechSynthesizer();
            synthesizer.Rate = speed;
            synthesizer.SpeakAsync(wordToSpeak);
        }

        /// <summary>
        /// Splits given word to word parts
        /// </summary>
        /// <param name="word">Word</param>
        /// <returns>List of word parts</returns>
        private WordPartList WordToParts(string word)
        {
            var parts = new WordPartList();
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
                var parts1 = new WordPartList();
                var parts2 = new WordPartList();
                for (var i = 0; i < word.Length; i += 2)
                {
                    if (i == 0)
                    {
                        var partText = word[0].ToString();
                        parts1.Add(dictionary.GetPart(partText));
                    }
                    else
                    {
                        var partText = word[i - 1].ToString() + word[i].ToString();
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

                var rating1 = parts1.CalculateRating();
                var rating2 = parts1.CalculateRating();
                if (rating1 > rating2)
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
        /// Combines the given word parts to word
        /// </summary>
        /// <param name="parts">Word parts list</param>
        /// <returns>Word</returns>
        private string PartsToWord(WordPartList parts)
        {
            var word = string.Empty;
            foreach (var part in parts)
            {
                word += part.PartInEnglishTranscription + "-";
            }
            word = word.Remove(word.Length - 1, 1);
            return word;
        }

        /// <summary>
        /// Check if the given word is not empty and does not contain spaces and if only armenian letters are used.
        /// </summary>
        /// <param name="word">Word</param>
        private void CheckWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentNullException(nameof(word) ,"Word can not be empty.");
            }
            else if (word.Contains(" "))
            {
                throw new ArgumentException("Word can not contain spaces.", nameof(word));
            }
            else
            {
                foreach (var symbol in word)
                {
                    if (!((symbol >= 'ա' && symbol <= 'և') || (symbol >= 'Ա' && symbol <= 'Ֆ')))
                    {
                        throw new ArgumentOutOfRangeException(nameof(word), "Word must contain only Armenian letters.");
                    }
                }
            }
        }

        /// <summary>
        /// Solves 'ո' letter to 'օ' letter problem 
        /// </summary>
        /// <param name="word">Word</param>
        /// <returns>Word with solved 'ո' letter to 'օ' letter problem</returns>
        private string CorrectVoToOProblem(string word)
        {
            var length = word.Length - 1;
            if (word[length] == 'ո')
            {
                word = word.Remove(length, 1).Insert(length, "օ");
            }
            for (var i = 1; i < length; i++)
            {
                if (word[i] == 'ո' && word[i + 1] != 'ւ')
                {
                    word = word.Remove(i, 1).Insert(i, "օ");
                }
            }
            return word;
        }

        /// <summary>
        /// Solves letter 'ու' to 'ւ' problem
        /// </summary>
        /// <param name="word">Word</param>
        /// <returns>Word with solved letter 'ու' to 'ւ' problem</returns>
        private string CorrectDualLetterUProblem(string word)
        {
            return word.Replace("ու", "ւ");
        }
    }
}