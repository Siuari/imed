namespace Clinica.WebApi.Helpers
{
    public class ResponseHelper
    {
        public string Message { get; set; }
        public bool Sucesso { get; set; }
        public object Result { get; set; }

        public ResponseHelper(string message, bool sucesso, object result)
        {
            Message = message;
            Sucesso = sucesso;
            Result = result;
        }
    }
}
