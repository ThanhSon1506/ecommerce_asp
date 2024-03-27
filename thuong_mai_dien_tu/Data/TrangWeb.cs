using System;
using System.Collections.Generic;

namespace thuong_mai_dien_tu.Data;

public partial class TrangWeb
{
    public int MaTrang { get; set; }

    public string TenTrang { get; set; } = null!;

    public string Url { get; set; } = null!;

    public virtual ICollection<PhanQuyen> PhanQuyens { get; set; } = new List<PhanQuyen>();
}
