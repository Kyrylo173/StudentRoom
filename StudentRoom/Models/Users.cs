﻿namespace StudentRoom.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password {  get; set; }
        
        public string Role { get; set; }
        public string? TeacherPin { get; set; }
    }
}
