﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DexLK.Authentication.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

       // [JsonIgnore]
        public string Password { get; set; }
        [JsonIgnore]
        [NotMapped]
        public IList<RefreshToken> RefreshTokens { get; set; }
    }
}
