using System;
using System.Collections.Generic;
using System.Text;

namespace Client.DataObject.Request
{
    public class UserDto
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string AccessKey { get; set; }
    }
}
