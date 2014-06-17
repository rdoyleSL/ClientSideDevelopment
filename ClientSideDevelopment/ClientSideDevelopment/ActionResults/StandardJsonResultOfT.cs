namespace ClientSideDevelopment.ActionResults
{
    public class StandardJsonResult<TData> : StandardJsonResult
    {
        public new TData Data
        {
            get { return (TData)base.Data; }
            set { base.Data = value; }
        }
    }
}