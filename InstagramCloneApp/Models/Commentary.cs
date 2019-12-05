using System;

namespace InstagramCloneApp.Models
{
    public class Commentary
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public User User {get; set;}
        public string Text { get; set; }
    }
}