namespace Фгещк.qwe
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductNew")]
    public partial class ProductNew
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string Тип { get; set; }

        [StringLength(50)]
        public string Артикул { get; set; }

        [StringLength(50)]
        public string Название { get; set; }

        public int? Цена { get; set; }
    }
}
