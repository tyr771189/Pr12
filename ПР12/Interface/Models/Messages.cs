using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime Create { get; set; }
        public int UserId { get; set; }

        public Messages() { }
        public Messages(string message, DateTime create, int userId )
        {
            Message = message;
            Create = create;
            UserId = userId;
        }
    }
}
