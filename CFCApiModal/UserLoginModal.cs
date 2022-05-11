using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CFCApiModal
{
    public class UserLoginModal
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string MailId { get; set; }
        public string Password { get; set; }
        public string AccountCreationType { get; set; }
        public string UserType { get; set; }
    }
}
