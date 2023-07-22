﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class RepartoDetalle
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Reparto))]
        public Guid RepartoId { get; set; }
        [ForeignKey(nameof(Producto))]
        public Guid ProductoId { get; set; }    
        public decimal Cantidad { get; set; }   
        public DateTime DateEntry { get; set; }
        public DateTime DateModify { get; set; }
        public Guid IdUserEntry { get; set; }
        public Guid IdUserModify { get; set; }
        public string? Estado { get; set; }
        public Reparto? Reparto { get; set; }
        public Producto? Producto { get; set; }
    }
}
