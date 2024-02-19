using System;
using System.Collections.Generic;

namespace LMSApi.Models;
using System.ComponentModel.DataAnnotations;
public partial class PatientDiagnosis
{
    [Key]
    public short DiagnoseId { get; set; }

    public string? DiagnoseName { get; set; }
}
