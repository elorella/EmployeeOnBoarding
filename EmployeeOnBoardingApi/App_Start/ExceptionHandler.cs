using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;
using EmployeeOnBoardingApi.Model;

namespace EmployeeOnBoardingApi
{
    public class ApiExceptionHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            var correlationId = Guid.NewGuid();

            var metadata = new ErrorInfoModel
            {
                Message = context.Exception.Message,
                TimeStamp = DateTime.UtcNow,
                RequestUri = context.Request.RequestUri,
                ErrorId = correlationId,
            };

            //I throw ArgumentException for all the business validation exceptions   
            HttpResponseMessage httpResponseMessage = context.Request.CreateResponse(
                context.Exception is ArgumentException ? HttpStatusCode.BadRequest : HttpStatusCode.InternalServerError,
                metadata);
            context.Result = new ResponseMessageResult(httpResponseMessage);
        }
    }
}