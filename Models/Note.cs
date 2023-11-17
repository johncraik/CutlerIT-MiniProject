using System;
using System.Collections.Generic;

namespace CutlerIT_MiniProject.Models;

public partial class Note
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public string? Note1 { get; set; }

    public string? Date { get; set; }
}
