using ClientPortal.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientPortal.Common.SeedUserData
{
    public static class SeedDataInitializer
    {
        public static void SeedData(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            SeedRole(roleManager);
            SeedUser(userManager);
        }
        public static void SeedUser(UserManager<User> userManager)
        {
            if (userManager.FindByNameAsync(CommonConstants.DefaultUserEmail.ToString()).Result == null)
            {
                User user = new User();
                user.Id = Guid.NewGuid().ToString();
                user.FirstName = CommonConstants.DefaultFirstName.ToString();
                user.LastName = CommonConstants.DefaultLastName.ToString();
                user.Email = CommonConstants.DefaultUserEmail.ToString();
                user.EmailConfirmed = true;
                user.PhoneNumber = CommonConstants.DefaultPhoneNumber.ToString();
                user.PhoneNumberConfirmed = true;
                user.UserName = CommonConstants.DefaultUserName.ToString();
                user.IsActive = true;
                IdentityResult result = userManager.CreateAsync(user, CommonConstants.DefaultPassword).Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, CommonConstants.SuperAdmin.ToString()).Wait();

                }
            }
        }
        public static void SeedRole(RoleManager<Role> roleManager)
        {
            if (!roleManager.RoleExistsAsync(CommonConstants.SuperAdmin.ToString()).Result)
            {
                Role role = new Role();
                role.Id = Guid.NewGuid().ToString();
                role.Name = CommonConstants.SuperAdmin.ToString();

                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
                if (roleResult.Succeeded)
                {

                }
            }
        }
    }
}
