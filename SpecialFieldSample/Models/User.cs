using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeComb.Yuuko.Schema;

namespace SpecialFieldSample.Models
{
    public class User
    {
        [SingleBy]
        [NotEditable]
        public string Username { get; set; }

        [SHA1]
        public string Password { get; set; }
    }
}