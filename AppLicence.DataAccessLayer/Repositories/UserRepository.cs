using AppLicence.DataAccessLayer.Interfaces;
using AppLicence.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLicence.DataAccessLayer.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(LicentaContext context) : base(context)
        {
        }
    }
}
