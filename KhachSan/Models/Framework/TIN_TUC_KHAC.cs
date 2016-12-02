namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account_website.TIN_TUC_KHAC")]
    public partial class TIN_TUC_KHAC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MATINTUC { get; set; }

        [StringLength(50)]
        public string TIEUDETINTUC { get; set; }

        public string NOIDUNGTINTUC { get; set; }

        [StringLength(50)]
        public string URLANH { get; set; }

        public DateTime? NGAYTAO { get; set; }

        [StringLength(50)]
        public string NGUOITAO { get; set; }
    }
}
