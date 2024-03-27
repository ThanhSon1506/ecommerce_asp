using Microsoft.AspNetCore.Mvc;
using thuong_mai_dien_tu.Data;
using thuong_mai_dien_tu.ViewModels;

namespace thuong_mai_dien_tu.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly Hshop2023Context db;

        public HangHoaController(Hshop2023Context context) => db = context;
        public IActionResult Index(int? loai)
        {
            var _hanghoas = db.HangHoas.AsQueryable();
            if (loai.HasValue)
            {
                _hanghoas = _hanghoas.Where(p => p.MaLoai == loai.Value);
            }
            var result = _hanghoas.Select(p => new HangHoaView
            {
                MaHangHoa = p.MaHh,
                TenHangHoa = p.TenHh,
                DonGia = p.DonGia ?? 0,
                Hinh =p.Hinh ?? "",
                MoTaDonVi = p.MoTaDonVi ?? "",
                TenLoai = p.MaLoaiNavigation.TenLoai

            }) ;
            return View(result);
        }
    }
}
