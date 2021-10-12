namespace FileData
{
    public static class Validations_FileVersion
    {
        public static bool ValidateFirstArgument(string argument)
        {
            return (argument == Constants_FileVersion.first || argument == Constants_FileVersion.second || argument == Constants_FileVersion.third || argument == Constants_FileVersion.fourth);
        }
    }
}
