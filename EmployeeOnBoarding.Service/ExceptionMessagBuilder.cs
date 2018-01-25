using System;
using System.Collections.Generic;
using FluentValidation.Results;

namespace EmployeeOnBoarding.Service
{
    public static class ExceptionMessagBuilder
    {
        public static string Build(IEnumerable<ValidationFailure> validationFailures)
        {
            string response = string.Empty;
            foreach (var validationFailure in validationFailures)
            {
                response += validationFailure.ErrorMessage;
                response += Environment.NewLine;
            }

            if (!string.IsNullOrEmpty(response))
            {
                response = response.TrimEnd(Environment.NewLine.ToCharArray());
            }

            return response;
        }
    }
}
