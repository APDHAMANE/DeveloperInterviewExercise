using ThirdPartyTools;

namespace FileData
{
    public class FileDetails_Factory
    {
        private FileDetails_Factory()
        {

        }

        static FileDetails fileDetails = null;
        public static FileDetails GetFileDetailsObject()
        {
            if (fileDetails==null)
            {
                fileDetails = new FileDetails();
            }
            return fileDetails;
        }
    }
}
