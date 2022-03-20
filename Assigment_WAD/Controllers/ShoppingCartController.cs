using Assigment_WAD.Data;
using Assigment_WAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assigment_WAD.Controllers
{
    public class ShoppingCartController : Controller
    {
        private MyIdentityDbContext db = new MyIdentityDbContext();
        // GET: ShoppingCart
        public ActionResult Index()
        {
            List<ShoppingCart> giohang = Session["shop"] as List<ShoppingCart>;
            return View(giohang);
        }
        
        public ActionResult Add(int SanPhamID)
        {
            if (Session["shop"] == null) // Nếu giỏ hàng chưa được khởi tạo
            {
                Session["shop"] = new List<ShoppingCart>();  // Khởi tạo Session["giohang"] là 1 List<CartItem>
            }

            List<ShoppingCart> giohang = Session["shop"] as List<ShoppingCart>;  // Gán qua biến giohang dễ code

            // Kiểm tra xem sản phẩm khách đang chọn đã có trong giỏ hàng chưa

            if (giohang.FirstOrDefault(m => m.ProductId == SanPhamID) == null) // ko co sp nay trong gio hang
            {
                Product sp = db.Products.Find(SanPhamID);  // tim sp theo sanPhamID

                ShoppingCart newItem = new ShoppingCart()
                {
                    ProductId = SanPhamID,
                    ProductName = sp.Name,
                    Amout = 1,
                    Thumbnail = sp.Thumbnail,
                    Prices = sp.Prices

                };  // Tạo ra 1 CartItem mới

                giohang.Add(newItem);  // Thêm CartItem vào giỏ 
            }
            else
            {
                // Nếu sản phẩm khách chọn đã có trong giỏ hàng thì không thêm vào giỏ nữa mà tăng số lượng lên.
                ShoppingCart cardItem = giohang.FirstOrDefault(m => m.ProductId == SanPhamID);
                cardItem.Amout++;
            }

            // Action này sẽ chuyển hướng về trang chi tiết sp khi khách hàng đặt vào giỏ thành công. Bạn có thể chuyển về chính trang khách hàng vừa đứng bằng lệnh return Redirect(Request.UrlReferrer.ToString()); nếu muốn.
            return RedirectToAction("Index", "ShoppingCart");
        }
        public RedirectToRouteResult XoaKhoiGio(int SanPhamID)
        {
            List<ShoppingCart> giohang = Session["shop"] as List<ShoppingCart>;
            ShoppingCart itemXoa = giohang.FirstOrDefault(m => m.ProductId == SanPhamID);
            if (itemXoa != null)
            {
                giohang.Remove(itemXoa);
            }
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult ChangeAmount(int SanPhamID, int soluongmoi)
        {
            // tìm carditem muon sua
            List<ShoppingCart> giohang = Session["shop"] as List<ShoppingCart>;
            ShoppingCart itemSua = giohang.FirstOrDefault(m => m.ProductId == SanPhamID);
            if (itemSua != null)
            {
                itemSua.Amout = soluongmoi;
            }
            return RedirectToAction("Index");

        }
    }
}