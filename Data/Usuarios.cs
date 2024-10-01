namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string DNI { get; set; }
    }
}
