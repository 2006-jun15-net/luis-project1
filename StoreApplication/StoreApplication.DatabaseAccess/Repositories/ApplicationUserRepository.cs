using Microsoft.AspNetCore.Identity;
using StoreApplication.DatabaseAccess.Models;
using StoreApplication.Domain.Interfaces;
using StoreApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreApplication.DatabaseAccess.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly StoreApplicationDBContext _storeApplicationDBContext;

        public ApplicationUserRepository(StoreApplicationDBContext storeApplicationDBContext)
        {
            _storeApplicationDBContext = storeApplicationDBContext;
        }
        public IEnumerable<ApplicationUser> GetAll()
        {
            var entities = _storeApplicationDBContext.Users;

            return entities.Select(e => new ApplicationUser
            {
                UserName = e.UserName,
                Email = e.Email,

            });
        }

        public ApplicationUser GetByUsername(string username)
        {
            IdentityUser entity = _storeApplicationDBContext.Users.First(c => c.UserName.Equals(username));
            return new ApplicationUser
            {
                UserName = entity.UserName,
                Email = entity.Email,

            };
        }

        //public void RegisterApplicationUser(IdentityUser identityUser)
        //{
        //    var entity = new ApplicationUser
        //    {
                
        //        UserName = identityUser.UserName,
        //        Email = identityUser.Email
        //    };

        //    _storeApplicationDBContext.ApplicationUser.Add(entity);
        //    _storeApplicationDBContext.SaveChanges();

        //}

       
        //public void Remove(ApplicationUser applicationUser)
        //{
        //    var entity = _storeApplicationDBContext.ApplicationUser.First(c => c.UserName.Equals(applicationUser.UserName));
        //    _storeApplicationDBContext.ApplicationUser.Remove(entity);
        //    _storeApplicationDBContext.SaveChanges();
        //}

        
        //public void Update(ApplicationUser applicationUser)
        //{
        //    var entity = _storeApplicationDBContext.ApplicationUser.First(c => c.ApplicationUserId == applicationUser.ApplicationUserId);
        //    entity.FirstName = applicationUser.FirstName;
        //    entity.LastName = applicationUser.LastName;
        //    entity.UserName = applicationUser.UserName;
        //    _storeApplicationDBContext.ApplicationUser.Update(entity);
        //    _storeApplicationDBContext.SaveChanges();
        //}

        //public ApplicationUser GetByFullName(string firstName, string lastName)
        //{

        //    if (_storeApplicationDBContext.ApplicationUsers.GetAll().Any(c => c.FirstName.Equals(FirstName)) && _storeApplicationDBContext.ApplicationUser.GetAll().Any(c => c.LastName.Equals(LastName)))
        //    {
        //        ApplicationUsers applicationUser = repository.GetAll().First(c => c.FirstName.Equals(FirstName) && c.LastName.Equals(LastName));
        //        Console.WriteLine($" ApplicationUser ID: {applicationUser.ApplicationUserId} Name: {applicationUser.FirstName} {applicationUser.LastName}");
        //        return applicationUser;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"There are no applicationUsers by that name");
        //        return null;
        //    }
        //}

        //public void Register(ApplicationUser applicationUser)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
