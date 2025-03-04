public class FieldKeyword
{
    /*
    before
    private string _msg;
    public string Message
    {
        get => _msg;
        set => _msg = value ?? throw new ArgumentNullException(nameof(value));
    }
    */

    public string Message
    {
        get;
        set => field = value ?? throw new ArgumentNullException(nameof(value));
    }
}