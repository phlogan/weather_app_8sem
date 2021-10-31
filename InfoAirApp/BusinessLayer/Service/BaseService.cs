namespace BusinessLayer.Service
{
    public class BaseService
    {
        public BaseService()
        {
            Host = "http://10.0.2.2:63726/api/";
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
