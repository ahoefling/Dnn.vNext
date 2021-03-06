﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Dnn.vNext.Data
{
    public class ModuleSetting
    {
        [Key, Column(Order = 0)]
/*PK*/  public int ModuleId { get; set; }

        [Key, Column(Order = 1)]
/*PK*/  public string SettingName { get; set; }

        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId{ get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual Module Module { get; set; }
}
}
