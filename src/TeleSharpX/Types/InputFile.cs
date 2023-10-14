namespace TeleSharpX.Types
{
    public enum InputFileType
    {
        File,
        Id
    }
    public class InputFile
    {
        public InputFileType Type { get; internal set; }
        private string _id;
        internal InputFile()
        {
            
        }

        public static InputFile FromFileId(string id)
        {
            return new InputFile()
            {
                Type = InputFileType.Id,
                _id = id
            };
        }
    }
}