namespace ArmenianTextToSpeech
{
    /// <summary>
    /// Part object
    /// </summary>
    public class WordPart
    {
        /// <summary>
        /// Part in Armenian
        /// </summary>
        public string PartInArmenian { get; set; }

        /// <summary>
        /// Part in English transcription
        /// </summary>
        public string PartInEnglishTranscription { get; set; }

        /// <summary>
        /// Rating
        /// </summary>
        public int Rating { get; set; }
    }
}