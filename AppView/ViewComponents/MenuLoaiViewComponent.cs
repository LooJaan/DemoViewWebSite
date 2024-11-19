using AppView.Data;
using AppView.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AppView.ViewComponents
{
    public class MenuLoaiViewComponent : ViewComponent
    {
        private readonly DemoWebShopContext _db;
        public MenuLoaiViewComponent(DemoWebShopContext context) => _db = context;
        public IViewComponentResult Invoke()
        {
            var data = _db.Loais.Select(lo => new MenuLoaiVM
            {
                MaLoai = lo.MaLoai,
                TenLoai = lo.TenLoai,
                SoLuong = lo.HangHoas.Count
            }).OrderBy(p => p.TenLoai);
            return View(data); //Default.cshtml
            //return View("Default", data);
        }
    }
}
