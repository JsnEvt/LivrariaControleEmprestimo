﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LivrariaControleEmprestimo.DATA.Models;

public partial class Cliente
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("CPF")]
    [StringLength(14)]
    [Unicode(false)]
    public string Cpf { get; set; }

    [Required]
    [Column("nome")]
    [StringLength(100)]
    [Unicode(false)]
    public string Nome { get; set; }

    [Required]
    [Column("endereco")]
    [StringLength(50)]
    [Unicode(false)]
    public string Endereco { get; set; }

    [Required]
    [Column("cidade")]
    [StringLength(50)]
    [Unicode(false)]
    public string Cidade { get; set; }

    [Required]
    [Column("bairro")]
    [StringLength(50)]
    [Unicode(false)]
    public string Bairro { get; set; }

    [InverseProperty("IdClienteNavigation")]
    public virtual ICollection<Emprestimo> Emprestimo { get; set; } = new List<Emprestimo>();
}