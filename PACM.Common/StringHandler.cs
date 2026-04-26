namespace PACM.Common
{
    public class StringHandler
    {
        public string InsertSpaces(string source)
        {
            var result = string.Empty;
            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach (var letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim(); // Trim any spaces already there.
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }
    }
}
