namespace ArmenianTextToSpeech
{
    /// <summary>
    /// Part object
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Value
        /// </summary>
        public string Part { get; set; }

        /// <summary>
        /// Trascription
        /// </summary>
        public string Trascription { get; set; }

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
            var length = Part.Length - 1;
            if (Part[length] == 'ո')
            {
                Part = Part.Remove(length, 1).Insert(length, "օ");
            }
            for (var i = 1; i < length; i++)
            {
                if (Part[i] == 'ո' && Part[i + 1] != 'ւ')
                {
                    Part = Part.Remove(i, 1).Insert(i, "օ");
                }
            }
        }

        /// <summary>
        /// Solves first letter 'ը' problem
        /// </summary>
        private void CorrectYToEmptyProblem()
        {
            if (Part.StartsWith("ը"))
            {
                Part.Remove(0, 1);
            }
        }
    }
}