﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class UserMessage
    {
        [Key]
        public int UserMessageID { get; set; }
        public string? SenderName { get; set; }
        public string? SenderMail { get; set; }
        public string? ReceiverName { get; set; }
        public string? ReceiverMail { get; set; }
        public string? Subject { get; set; }
        public string? Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public bool IsRead { get; set; }
        public bool IsDraft { get; set; }
    }
}
