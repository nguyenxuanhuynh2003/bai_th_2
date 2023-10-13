using System;
using System.Collections.Generic;

namespace bai_th_2.Models;

public partial class TbSubscribe
{
    public int SubscribeId { get; set; }

    public string? Email { get; set; }

    public DateTime? CreateDate { get; set; }
}
