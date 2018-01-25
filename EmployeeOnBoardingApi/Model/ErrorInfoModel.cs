using System;

namespace EmployeeOnBoardingApi.Model
{
    public class ErrorInfoModel
    {
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }
        public Uri RequestUri { get; set; }
        public Guid ErrorId { get; set; }
    }
}
