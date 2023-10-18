using System.IO;

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
        internal string _id;
        internal byte[] _file;
        internal string _name;

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

        public static InputFile FromFilePath(string path)
        {
            return new InputFile()
            {
                Type = InputFileType.File,
                _file = System.IO.File.ReadAllBytes(path),
                _name = Path.GetFileName(path),
            };
        }
        public static InputFile FromUrl(string url)
        {
            return new InputFile()
            {
                Type = InputFileType.Id,
                _id = url
            };
        }

        internal InputFile ToBody() => this;
    }
}