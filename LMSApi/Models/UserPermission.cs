using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;
[PrimaryKey(nameof(UserId),nameof(PermissionId))]
public  class UserPermission
{
    public byte PermissionId { get; set; }

    public string UserId { get; set; } = null!;
}
