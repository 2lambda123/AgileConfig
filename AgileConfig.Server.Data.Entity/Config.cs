﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileConfig.Server.Data.Entity
{
    public enum ConfigStatus
    {
        Deleted = 0,
        Enabled = 1,
    }

    [Table("config")]
    public class Config
    {
        [Key]
        [Column("id", TypeName = "varchar(36)")]
        public string Id { get; set; }

        [Column("app_id", TypeName = "nvarchar(8)")]
        public string AppId { get; set; }

        [Column("g", TypeName = "nvarchar(50)")]
        public string Group { get; set; }

        [Column("k", TypeName = "nvarchar(50)")]
        public string Key { get; set; }

        [Column("v", TypeName = "nvarchar(200)")]
        public string Value { get; set; }

        [Column("description", TypeName = "nvarchar(100)")]
        public string Description { get; set; }

        [Column("create_time")]
        public DateTime CreateTime { get; set; }

        [Column("update_time")]
        public DateTime? UpdateTime { get; set; }

        [Column("status")]
        public ConfigStatus Status { get; set; }
    }
}