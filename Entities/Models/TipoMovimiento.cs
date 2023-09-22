﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class TipoMovimiento
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Empresa))]
        public Guid EmpresaId { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime? DateModify { get; set; }
        public Guid IdUserEntry { get; set; }
        public Guid? IdUserModify { get; set; }
        public string? Estado { get; set; }
        public Empresa? Empresa { get; set; }
        public ICollection<Movimiento>? Movimientos { get; set; }
    }
}
