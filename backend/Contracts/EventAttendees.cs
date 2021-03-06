﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace TFTI.Contracts
{
    [Table("events_attendees")]
    public class EventAttendees
    {
        [Key]
        public int event_attendee_id { get; set; }

        [Required]
        public int event_id { get; set; }

        public int user_id { get; set; }

    }
}
