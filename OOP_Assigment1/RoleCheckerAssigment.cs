using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment1
{
    public static class RoleCheckerAssigment
    {
        public enum Role
        {
            Admin,
            User,
            Guest
        }

        public static bool IsAdmin(Role role)
        {
            //Assigment 11: Return true if role is Admin, otherwise return false.
            throw new NotImplementedException();
        }


        public static bool HasPrivligies(Role role, DateTime validUntill)
        {
            //Assigment 12: Return true if role is Admin or User and validUntill is in the future, otherwise return false.
            throw new NotImplementedException();
        }

        public static string RoleToString(Role role)
        {
            //Assigment 13: Implement a method RoleToString(Role role) that converts the Role enum to its string representation.
            throw new NotImplementedException();
        }

        public static Role StringToRole(string roleString)
        {
            //Assigment 14: Write a method StringToRole(string roleString) that converts a string to the corresponding Role enum. 
            //If the string does not match any role, throw an appropriate exception.
            //Hint: Remember how conversion worked on ints (especially TryParse)
            throw new NotImplementedException();
        }
    }
}
