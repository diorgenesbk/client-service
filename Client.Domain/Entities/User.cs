﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Domain.Entities
{
    public class User : BaseEntity
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string AccessKey { get; set; }
    }
}
