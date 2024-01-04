using OOP_Assigment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentTests
{
    public class RoleCheckerTests
    {
        [Theory]
        [InlineData(RoleChecker.Role.Admin, true)]
        [InlineData(RoleChecker.Role.User, false)]
        public void IsAdmin_ReturnsCorrectValue(RoleChecker.Role role, bool expectedResult)
        {
            var result = RoleChecker.IsAdmin(role);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(RoleChecker.Role.Admin, "2024-01-01", true)] // Assuming today is 2023-12-31
        [InlineData(RoleChecker.Role.User, "2023-11-30", false)] // Assuming today is 2023-12-31
        public void HasPrivileges_ReturnsCorrectValue(RoleChecker.Role role, DateTime validUntil, bool expectedResult)
        {
            var result = RoleChecker.HasPrivligies(role, validUntil);
            Assert.Equal(expectedResult, result);
        }
    }
}
