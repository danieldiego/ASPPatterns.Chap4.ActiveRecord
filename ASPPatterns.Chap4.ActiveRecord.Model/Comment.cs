﻿using System;
using Castle.ActiveRecord;

namespace ASPPatterns.Chap4.ActiveRecord.Model
{
    [ActiveRecord("Comments")]
    public class Comment : ActiveRecordBase<Comment>
    {
        [PrimaryKey]
        public int Id { get; set; }
        [BelongsTo("PostId")]
        public Post Post { get; set; }
        [Property]
        public string Text { get; set; }
        [Property]
        public string Author { get; set; }
        [Property]
        public DateTime DateAdded { get; set; }
    }
}
