namespace Kreata.Backend.Datas.Responses
{
    public class ErrorStore
    {
        public ErrorStore(string error)
        {
            Error = string.Empty;
        }

        public string Error { get; set; } = string.Empty;
        public bool HasError => !string.IsNullOrEmpty(Error);
        public void ClearAndAddError(String error)
        {
            Error = error;
        }
        public void AppendNewError(string error)
        {
            Error = $"{Error}\n{error}";
        }

    }
}
