using Archimedes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Business.Abstract
{
    public interface IUserService
    {
        void Create(AppUser entity);
        void Update(AppUser entity);
        void Delete(AppUser entity);
        AppUser GetById(int id);
        AppUser GetByName(string name);
        List<AppUser> GetAll();
    }
}
