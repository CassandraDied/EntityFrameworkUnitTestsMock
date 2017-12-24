﻿using System;

namespace Tests.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Body { get; set; }

        public Guid PostId { get; set; }
        public Post Post { get; set; }
    }
}
