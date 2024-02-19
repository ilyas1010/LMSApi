using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;
[PrimaryKey(nameof(TestId))]
public partial class Test
{
    public int TestId { get; set; }

    public int? TestCode { get; set; }

    public byte? LabId { get; set; }

    public string TestName { get; set; } = null!;

    public string? BloodQty { get; set; }

    public string? Vacutainer { get; set; }

    public short? RequiredTime { get; set; }

    public int? DisplayOrder { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsSingle { get; set; }

    public bool? AddDetail { get; set; }

    public string? TestComments { get; set; }

    public int? ParentTest { get; set; }

    public bool? IsDefaultoParent { get; set; }

    public string? UserId { get; set; }

    public string? DateTimeStamp { get; set; }
       
}
