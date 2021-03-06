﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UncleSan.Models
{
    public class User
    {
        /// <summary>
        /// 用户名Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

    }
}