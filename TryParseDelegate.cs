public class TryParseDelegate
{
    delegate bool TryParse<T>(string text, out T result);
    TryParse<int> parse = (string text, out int result) => Int32.TryParse(text, out result);

    public void Parse(string text, out int result) => parse(text, out result);
}