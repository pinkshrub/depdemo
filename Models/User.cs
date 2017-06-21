using System;

namespace logdemo.Models
{
    public class User : BaseEntity
    {
        public int userid { get; set; }
        public string name { get; set; }
        public string password  { get; set; }
    }
}
