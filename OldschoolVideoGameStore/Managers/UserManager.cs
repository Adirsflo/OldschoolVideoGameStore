﻿using OldschoolVideoGameStore.Methods;
using System.Collections.Generic;

namespace OldschoolVideoGameStore.Managers
{
    public static class UserManager
    {
        public static List<IUser> userList = new()
        {
            new Admin("Rida", "Abdal", "admin", "password"),
            new Customer("123", "123", "Adir", "Abdal", 21)
        };
    }
}
