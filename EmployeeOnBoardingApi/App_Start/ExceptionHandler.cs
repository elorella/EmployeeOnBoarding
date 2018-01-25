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

            var errorInfoModel = new ErrorInfoModel
            {
                Message = context.Exception.Message,
                TimeStamp = DateTime.UtcNow,
                RequestUri = context.Request.RequestUri,
                ErrorId = correlationId,
            };

            //ArgumentException is thrown for all the business validation exceptions  
            //ArgumentNullException is thrown when an item is not found

            HttpResponseMessage httpResponseMessage;
            if (context.Exception is ArgumentException)
            {
                httpResponseMessage = context.Request.CreateResponse(HttpStatusCode.BadRequest, errorInfoModel);
            }
            else if (context.Exception is ArgumentNullException)
            {
                httpResponseMessage = context.Request.CreateResponse(HttpStatusCode.NotFound, errorInfoModel);
            }
            else
            {
                httpResponseMessage =
                    context.Request.CreateResponse(HttpStatusCode.InternalServerError, errorInfoModel);
            }

            context.Result = new ResponseMessageResult(httpResponseMessage);
        }
    }
}