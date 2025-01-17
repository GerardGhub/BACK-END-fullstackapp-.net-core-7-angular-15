﻿namespace WebAPI.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }   
        public string Email { get; set; }
        public long Phone { get; set; }
        public long Salary { get; set; } 
        public string Department { get; set; }
        public string Position { get; set; }
    }
}
