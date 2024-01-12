using OOP_Assigment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentTests
{
    public class RoleCheckerAssigmentTests
    {
        [Theory]
        [InlineData(RoleCheckerAssigment.Role.Admin, true)]
        [InlineData(RoleCheckerAssigment.Role.User, false)]
        public void IsAdmin_ReturnsCorrectValue(RoleCheckerAssigment.Role role, bool expectedResult)
        {
            var result = RoleCheckerAssigment.IsAdmin(role);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(RoleCheckerAssigment.Role.Admin, "2024-10-10", true)] // Assuming today is 2023-12-31
        [InlineData(RoleCheckerAssigment.Role.User, "2023-11-30", false)] // Assuming today is 2023-12-31
        public void HasPrivileges_ReturnsCorrectValue(RoleCheckerAssigment.Role role, DateTime validUntil, bool expectedResult)
        {
            var result = RoleCheckerAssigment.HasPrivligies(role, validUntil);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(RoleCheckerAssigment.Role.Admin, "Admin")]
        [InlineData(RoleCheckerAssigment.Role.User, "User")]
        [InlineData(RoleCheckerAssigment.Role.Guest, "Guest")]
        public void RoleToString_ReturnsCorrectString(RoleCheckerAssigment.Role role, string expected)
        {
            // Act
            var result = RoleCheckerAssigment.RoleToString(role);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Admin", RoleCheckerAssigment.Role.Admin)]
        [InlineData("User", RoleCheckerAssigment.Role.User)]
        [InlineData("Guest", RoleCheckerAssigment.Role.Guest)]
        public void StringToRole_ReturnsCorrectRole(string roleString, RoleCheckerAssigment.Role expected)
        {
            // Act
            var result = RoleCheckerAssigment.StringToRole(roleString);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void StringToRole_ThrowsExceptionForInvalidString()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => RoleCheckerAssigment.StringToRole("InvalidRole"));
        }
    }
}
