namespace Фгещк.qwe
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clients
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Фамилия { get; set; }

        [StringLength(50)]
        public string Имя { get; set; }

        [StringLength(50)]
        public string Отчество { get; set; }

        [Column("Номер телефона")]
        [StringLength(50)]
        public string Номер_телефона { get; set; }

        public int? Возраст { get; set; }
    }
}
