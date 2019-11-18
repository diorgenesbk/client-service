using Client.DataObject.Request;
using Client.Domain.Entities;
using Client.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Service.Business
{
    public class UserService : BaseService<User>
    {
        public UserService(TokenContext context) : base(context) { }

        public UserService(ClientContext context) : base(context)
        {
        }

        public UserDto GetUser(string userName, string password)
        {
            var user = this.Repository.Context.Set<User>()
                .FirstOrDefault(u => u.UserName == userName && u.Password == password);

            if (user != null)
            {
                return new UserDto
                {
                    UserName = user.UserName,
                    AccessKey = user.AccessKey
                };
            }

            return null;

        }
    }
}
