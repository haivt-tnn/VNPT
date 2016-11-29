namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account_website.GIOITHIEU")]
    public partial class GIOITHIEU
    {
        [Key]
        public int IDGIOITHIEU { get; set; }

        [StringLength(50)]
        public string TENGIOITHIEU { get; set; }

        public string MOTA { get; set; }

        [StringLength(50)]
        public string URLIMAGE { get; set; }
    }
}
