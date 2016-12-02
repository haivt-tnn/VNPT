namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account_website.DANH_MUC_TINH_TRANG_PHONG")]
    public partial class DANH_MUC_TINH_TRANG_PHONG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TINHTRANG { get; set; }

        [StringLength(255)]
        public string CHITIET { get; set; }
    }
}
