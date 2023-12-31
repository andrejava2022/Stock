﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock.Models.DTO;

public class CreateProductRequestDto
{
    [Required]
    [StringLength(50,MinimumLength = 5)]
    public string? Name { get; set; }

    [Required]
    [StringLength (100,MinimumLength = 10)]
    public string? Description { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    [ForeignKey("Category")]
    public int CategoryId { get; set; }
     
}
