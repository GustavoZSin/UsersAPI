
using Microsoft.AspNetCore.Authorization;
using System.Reflection.Metadata.Ecma335;

namespace UsersAPI.Authorization
{
    public class MinimumAge : IAuthorizationRequirement
    {
        public int Age { get; set; }
        public MinimumAge(int age)
        {
            Age = age;
        }
    }
}
