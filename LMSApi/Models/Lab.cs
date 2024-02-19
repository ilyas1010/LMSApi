using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;

public partial class Lab
{
    [Key]
    public byte LabId { get; set; }

    public string LabName { get; set; } = null!;

}
