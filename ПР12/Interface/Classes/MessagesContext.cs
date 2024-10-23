using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.Models;
using Interface.Interfaces;

namespace Interface.Classes
{
   public class MessagesContext : Messages, IMessages
    {
        public static List<Messages> AllMessages;

        public MessagesContext() => All(out AllMessages);

        public MessagesContext(string message, DateTime create, int userId) : base(message, create, userId) { }

        public void All(out List<Messages> messages) => messages = new List<Messages>();

        public void Delete() => AllMessages.Remove(this);

        public void Save(bool update = false)
        {
            if (!update)
            {
                AllMessages.Add(this);
            }
        }
    }
}
