﻿using Microsoft.AspNetCore.Identity;
using SharkGaming.Users;

namespace SharkGaming.MockData
{
    public class MockUser
    {

        //private static PasswordHasher<string> passwordHasher = new PasswordHasher<string>();

        private static List<User> users = new List<User>() {
            new User("phillip", "123"),
            new User("admin", "123"),
            new User("mads","123")
        };

        public static List<User> GetMockUser() { return users; }

    }
}
