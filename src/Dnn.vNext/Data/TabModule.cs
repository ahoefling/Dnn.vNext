﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Dnn.vNext.Data
{
    public class TabModule
    {
        [Key]
        public int TabModuleId { get; set; }
        public int PageId { get; set; }
/*FK*/  public int ModuleId { get; set; }

        /// <summary>
        /// The name of the html element where the module exists
        /// </summary>
        public string ElementId { get; set; }

        /// <summary>
        /// The order of the module in the html element.
        /// </summary>
        /// <remarks>
        /// If there are more than 1 module in the same element, the order
        /// determines how the modules are displayed on the screen.
        /// </remarks>
        public int Order { get; set; }


/*FK*/  public int TabId { get; set; }
        public string PaneName { get; set; }
        public int ModuleOrder { get; set; }
        public int CacheTime { get; set; }
        public string Alignment { get; set; }
        public string Color { get; set; }
        public string Border { get; set; }
        public string IconFile { get; set; }
        public int Visibility { get; set; }
        public string ContainerSrc { get; set; }
        public int DisplayTitle { get; set; }
        public int DisplayPrint { get; set; }
        public int DisplaySyndicate { get; set; }
        public int IsWebSlice { get; set; }
        public string WebSliceTitle { get; set; }
        public DateTime? WebSliceExpiryDate { get; set; }
        public int? WebSliceTTL { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public int IsDeleted { get; set; }
        public string CacheMethod { get; set; }
        public string ModuleTitle { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public string CultureCode { get; set; }
        public Guid UniqueId { get; set; }
        public Guid VersionGuid { get; set; }
        public Guid DefaultLanguageGuid { get; set; }
        public Guid LocalizedVersionGuid { get; set; }


        public virtual Module Module { get; set; }
        public virtual Tab Tab { get; set; }
        public virtual ICollection<TabModuleSetting> TabModuleSetting { get; set; }
    }
}
