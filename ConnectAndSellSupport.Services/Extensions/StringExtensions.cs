namespace ConnectAndSellSupport.Services.Extensions
{
    public static class StringExtensions
    {
        public static string Format(this string input, params ActionType[] actionTypes)
        {
            // To do : update to dynamic regex generation
            foreach (var actionType in actionTypes)
            {
                input = actionType switch
                {
                    ActionType.RemoveComma =>
                        input.Replace(",", ""),
                    ActionType.RemoveBackwardSlash =>
                        input.Replace("\\", ""),
                    ActionType.RemoveBrackets =>
                        input.Replace("(", "").Replace(")", ""),
                    ActionType.RemoveForwardSlash =>
                        input.Replace("/", ""),
                    ActionType.RemoveHyphen =>
                        input.Replace("-", ""),
                    ActionType.RemoveSpace =>
                        input.Replace(" ", ""),
                    _ => input,
                };
            }

            return input;
        }

        public enum ActionType : byte
        {
            RemoveComma,
            RemoveBackwardSlash,
            RemoveBrackets,
            RemoveForwardSlash,
            RemoveHyphen,
            RemoveSpace
        }
    }
}
