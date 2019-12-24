namespace ArmenianTextToSpeech
{
    /// <summary>
    /// Part object
    /// </summary>
    public class WordPart
    {
        /// <summary>
        /// Part in armenian
        /// </summary>
        public string PartInArmenian { get; set; }

        /// <summary>
        /// Part in english transcription
        /// </summary>
        public string PartInEnglishTranscription { get; set; }

        /// <summary>
        /// Rating
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// Part constructor
        /// </summary>
        public void PartCorrection()
        {
            CorrectVoToOProblem();
            CorrectYToEmptyProblem();
        }

        /// <summary>
        /// Solves 'ո' letter to 'օ' letter problem 
        /// </summary>
        private void CorrectVoToOProblem()
        {
            var length = PartInArmenian.Length - 1;
            if (PartInArmenian[length] == 'ո')
            {
                PartInArmenian = PartInArmenian.Remove(length, 1).Insert(length, "օ");
            }
            for (var i = 1; i < length; i++)
            {
                if (PartInArmenian[i] == 'ո' && PartInArmenian[i + 1] != 'ւ')
                {
                    PartInArmenian = PartInArmenian.Remove(i, 1).Insert(i, "օ");
                }
            }
        }

        /// <summary>
        /// Solves first letter 'ը' problem
        /// </summary>
        private void CorrectYToEmptyProblem()
        {
            if (PartInArmenian.StartsWith("ը"))
            {
                PartInArmenian.Remove(0, 1);
            }
        }
    }
}