﻿namespace TFTI.Contracts
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public User ClaimedBy { get; set; }
    }
}
