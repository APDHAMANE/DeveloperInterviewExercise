namespace FileData
{
    public static class Validations_FileSize
    {
        public static bool ValidateFirstArgument(string argument)
        {
            return (argument == Constants_FileSize.first || argument == Constants_FileSize.second || argument == Constants_FileSize.third || argument == Constants_FileSize.fourth);
        }
    }
}
