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
    }
}