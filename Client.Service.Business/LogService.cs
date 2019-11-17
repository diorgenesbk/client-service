using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Service.Business
{
    public class LogService
    {
        public void LogInformation(string message)
        {

        }

        public void LogWarning(string message)
        {

        }

        public void LogError(Exception ex)
        {
            this.LogError(ex, null);
        }

        public void LogError(Exception ex, string message)
        {

        }
    }
}
