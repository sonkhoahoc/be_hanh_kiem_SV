﻿using System.ComponentModel.DataAnnotations;

namespace hanhkiemUtehy.Entity
{
    public class IAuditableEntity
    {
        [Key]
        public long id { set; get; }
        public long userAdded { set; get; } = 0;
        public long? userUpdated { set; get; }
        public DateTime dateAdded { get; set; } = DateTime.Now;
        public DateTime? dateUpdated { get; set; } 
        public bool is_delete { get; set; } = false;
    }
}
