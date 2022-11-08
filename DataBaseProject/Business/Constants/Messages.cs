using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product is added.";
        public static string ProductNameInvalid = "Product name is not valid.";
        public static string MaintenanceTime = "System expended.";
        public static string ProductListed = "Products are listed.";
        public static string ProductCountOfCategoryError = "At most be 10 items for each category.";
        public static string ProductNameAlreadyExists = "Product is already exists.";
        public static string CategoryLimitExceeded = "Category's limit exceed.";
        public static string AuthorizationDenied = "YYou do not have authority.";
        public static string UserRegistered = "User is registered.";
        public static string UserNotFound = "User could not found.";
        public static string PasswordError = "Password incorrect.";
        public static string SuccessfulLogin = "Succesful enter.";
        public static string UserAlreadyExists = "User is already exists.";
        public static string AccessTokenCreated = "Token is created.";
    }
}
