using ThirdPartyTools;

namespace FileData
{
    public static class FileVersion
    {
        public static string PrintFileVersion(string argument)
        {
            FileDetails fileDetails = FileDetails_Factory.GetFileDetailsObject();
            return fileDetails.Version(argument);
        }
    }
}
