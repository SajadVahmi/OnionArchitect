﻿using System;


namespace OnionArchitect.Api.V1.Dtos.Users
{
    public class UserDto
    {       
        public int Id { get; set; }
        public bool PhoneNumberConfirmed { get; set; }     
        public string PhoneNumber { get; set; }                
        public bool EmailConfirmed { get; set; }      
        public string Email { get; set; }            
        public string UserName { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
    }
}
