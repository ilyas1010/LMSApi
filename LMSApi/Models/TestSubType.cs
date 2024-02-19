using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;
[PrimaryKey( nameof(SubTestId))]
public partial class TestSubType
{
    public int SubTestId { get; set; }

    public string SubTestName { get; set; } = null!;

}
