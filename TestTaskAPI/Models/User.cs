﻿using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace TestTaskAPI.Models
{
    [Index(nameof(Username), IsUnique = true)]
    public class User
    {
        public int Id { get; set; }

        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public DateOnly BirthDate { get; set; }
        public required string Address { get; set; }
    }
}
