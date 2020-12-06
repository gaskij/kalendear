﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFTI.Contracts
{
    public class NewItem
    {
        public int item_id { get; set; }

        [Required]
        public int event_id { get; set; }

        public int userid { get; set; }

        public string item_name { get; set; }

        public int amount { get; set; }

        public string unit_type { get; set; }
    }
}