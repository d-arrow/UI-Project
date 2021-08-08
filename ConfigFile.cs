using IniParser;
using IniParser.Model;
using IniParser.Model.Configuration;
using IniParser.Parser;
using System.IO;
using System.Text;

namespace SingleplayerLauncher
{
    internal class ConfigFile
    {
        private FileIniDataParser fileParser;
        private readonly string path; // (filename too)
        public IniData data;

        //FUTURE FEATURE - Local Directory
        //once we always know where the local file is (c://{some place}/file) we can have a method to check if it exists and/or create it
        //private readonly string configDirectory = string.Format(@"{0}\config", GetLocalDir());

        public ConfigFile(string filePath, bool newFile = false)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new System.Exception("A required variable was null at runtime.");
            }

            path = filePath;

            CreateNewParser();

            if (!newFile && File.Exists(path))
            {
                data = fileParser.ReadFile(path);
            }
            else
            {
                data = new IniData();
            }
        }

        public void Write(IniData data)
        {
            //We should be able to find this path as a default at some point in the future
            //until then, we need to throw an exception
            if (string.IsNullOrEmpty(path))
            {
                throw new System.Exception("A required variable was null at runtime.");
            }

            if (fileParser == null)
            {
                CreateNewParser();
            }

            //BUG CHECK -- do we need the filename, or the full path for writing this file?
            //probably full path, but need to double check
            var fileName = Path.GetFileName(path);

            fileParser.WriteFile(fileName, data, new UTF8Encoding(false));
        }

        private void CreateNewParser()
        {
            var parserConfig = new IniParserConfiguration
            {
                CommentString = ";",
                SkipInvalidLines = true,
                AllowDuplicateKeys = true,
                AssigmentSpacer = "",
                AllowCreateSectionsOnFly = true
            };

            var iniParser = new IniDataParser(parserConfig);
            fileParser = new FileIniDataParser(iniParser);
        }


    }
}
