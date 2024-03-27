using Microsoft.AspNetCore.Mvc;
using thuong_mai_dien_tu.Data;
using thuong_mai_dien_tu.ViewModels;

namespace thuong_mai_dien_tu.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly Hshop2023Context db;

        public MenuViewComponent(Hshop2023Context context) => db = context;
        public IViewComponentResult Invoke()
        {
            var data = db.Loais.Select(data => new MenuView
            {
                MaLoai=data.MaLoai,
                TenLoai = data.TenLoai,
                SoLuong = data.HangHoas.Count
            }).OrderBy(p => p.TenLoai) ;
            return View("Default",data);
        }
    }
}
