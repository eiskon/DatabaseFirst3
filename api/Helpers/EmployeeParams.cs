namespace api.Helpers
{
    public class EmployeeParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 5;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }

        public int EmployeeId { get; set; }
        public string LastName { get; set; }
    }
}      
 