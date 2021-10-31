namespace Business.Service
{
    public class BaseService
    {
        public BaseService()
        {
            Host = "https://localhost:44335/api/";
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
        //public string Path
        //{
        //    get
        //    {
        //        return string.Format("{0}/{1}/", ApiBasePath.Trim().Trim('/').Trim(), ApiController.Trim().Trim('/'));
        //    }
        //}
    }
}
