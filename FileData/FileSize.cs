using ThirdPartyTools;

namespace FileData
{
    public class FileSize
    {
        public static int PrintFileSize(string argument)
        {
            FileDetails fileDetails = FileDetails_Factory.GetFileDetailsObject();
            return fileDetails.Size(argument);
        }
    }
}
