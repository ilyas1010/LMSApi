using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;
[PrimaryKey(nameof(RegionId))]
public partial class ReferalRegion
{
    public short RegionId { get; set; }

    public string? RegionName { get; set; }
}
