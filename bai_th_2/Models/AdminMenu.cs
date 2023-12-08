using System;
using System.Collections.Generic;

namespace bai_th_2.Models;

public partial class AdminMenu
{
    public long AdminMenuId { get; set; }

    public string? ItemNemu { get; set; }

    public int? ItemLevel { get; set; }

    public int? ParenLevel { get; set; }

    public int? ItemOrder { get; set; }

    public bool? IsaActive { get; set; }

    public string? AreaName { get; set; }

    public string? ControlerName { get; set; }

    public string? ActionName { get; set; }

    public string? Icon { get; set; }

    public string? IdName { get; set; }
}
