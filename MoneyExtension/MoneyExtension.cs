namespace MoneyExtension;

public static class Money
{
    public static int ToCents(this decimal amount)
    {
        if (amount <= 0)
            return 0;

        var convertedText = amount
            .ToString("N2")
            .Replace(",", "")
            .Replace(".", "");
        if (string.IsNullOrEmpty(convertedText))
            return 0;

        int.TryParse(convertedText, out var result);
        return result;
    }
}