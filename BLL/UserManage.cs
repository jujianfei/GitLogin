﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class UserManage
    {
        public bool JudgeUser(Entity.UserInfo user)
        {
            DAL.UserManage um = new DAL.UserManage();
            return um.JudgeUser(user);
        }
    }
}
