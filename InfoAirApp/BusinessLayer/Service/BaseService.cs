namespace BusinessLayer.Service
{
    public class BaseService
    {
        public BaseService()
        {
            Host = "http://192.168.1.36/api/";
        }

        public string Host { get; set; }
        public string Path { get; set; }
        public string CompletePath
        {
            get
            {
                return Host.Trim('/') + "/" + Path;
            }
        }
    }
}
