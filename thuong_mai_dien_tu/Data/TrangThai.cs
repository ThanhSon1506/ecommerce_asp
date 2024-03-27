using System;
using System.Collections.Generic;

namespace thuong_mai_dien_tu.Data;

public partial class TrangThai
{
    public int MaTrangThai { get; set; }

    public string TenTrangThai { get; set; } = null!;

    public string? MoTa { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
