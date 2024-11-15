﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LivrariaControleEmprestimo.DATA.Models;

public partial class VwEmprestimoNovo
{
    [Key]
    public int? IdEmprestimo { get; set; }

    [Required]
    [Column("nomeCliente")]
    [StringLength(100)]
    [Unicode(false)]
    public string NomeCliente { get; set; }

    [Required]
    [Column("nomeLivro")]
    [StringLength(50)]
    public string NomeLivro { get; set; }

    [Column("EIDLivro")]
    public int? Eidlivro { get; set; }

    [Column("EIDCliente")]
    public int? Eidcliente { get; set; }

    [Column("dataEmprestimo", TypeName = "datetime")]
    public DateTime? DataEmprestimo { get; set; }

    [Column("dataEntrega", TypeName = "datetime")]
    public DateTime? DataEntrega { get; set; }

    [Column("entregue")]
    public bool? Entregue { get; set; }
}