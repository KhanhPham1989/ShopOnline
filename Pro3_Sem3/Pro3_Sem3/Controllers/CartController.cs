﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pro3_Sem3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Pro3_Sem3.Controllers
{
    public class CartController : Controller
    {
        private readonly DatabaseContext db;
        private readonly ServicesIMP.Services ser;
        public CartController(DatabaseContext _db, ServicesIMP.Services _ser)
        {
            db = _db;
            ser = _ser;
        }
        public IActionResult Index()
        {
            var cartdetails = db.PaymentDetails.ToList();
            if (HttpContext.Session.GetString("no") == null)
            {
                return RedirectToAction("Login");
            }


            var UserID = int.Parse(HttpContext.Session.GetString("no"));
            var cartItem = db.Payments.ToList().Where(x => x.Cusid.Equals(UserID));


            return View("ShowCart", cartItem);
        }
       
        public IActionResult ShowRes()
        {
            var resurl = db.Caterers.ToList();
            return View(resurl);
        }

        [HttpGet]
        public IActionResult ShowPaymentBeforeGetFood(int resid)
        {
            if (HttpContext.Session.GetString("no") == null)
            {
                return RedirectToAction("Login", "User");
            }

            var UserID = int.Parse(HttpContext.Session.GetString("no"));
            //var resurl = db.Payments.Where(x => x.Paymentid.Equals(resid)).SingleOrDefault();
            var name = db.Customers.SingleOrDefault(x => x.Cusid == UserID);
            ViewBag.name = name.Cusfullname;
            Payment pay = new Payment()
            {
                Caterid = resid,
                Cusid = UserID,
                DeliveryDate = DateTime.Today,
                OrderDate = DateTime.Today,
                Amount = 0,
                Status = false,
            };
            var resname = db.Caterers.SingleOrDefault(x => x.Caterid == resid);
            ViewBag.data = resname.Caterfullname;
            return View("page3", pay);
        }

        [HttpPost]
        public IActionResult ShowPaymentBeforeGetFood(Payment payment)
        {
            if(ModelState.IsValid)
            {
                db.Payments.Add(payment);
                db.SaveChanges();

                HttpContext.Session.SetString(payid, payment.Paymentid.ToString());
                return RedirectToAction("Index2", payment);
            }
            else
            {
                return BadRequest();
            }
        }

        //[HttpGet]
        //public IActionResult ShowFood(Payment payment)
        //{
        //    ViewBag.paymentID = payment.Paymentid;
        //    var resurl = db.Foods.Where(x => x.Caterid == payment.Caterid).ToList();
        //        return View(resurl);
        //}
       
        public IActionResult UpdateQuantity(int food_id, int soluongmoi)
        {
            var cartlist = GetCartItems();
            var foodfind = cartlist.Find(x => x.product.Foodid.Equals(food_id));
              foodfind.quantity = soluongmoi;
            SaveCartSession(cartlist);    
            return Ok();
        }

        public IActionResult DeleteItem(int food_id)
        {
            var deleteItem = db.PaymentDetails.Find(food_id);
            db.PaymentDetails.Remove(deleteItem);
            db.SaveChanges();
            return Ok();
        }


        //////////////////////////////////////////
        public const string CARTKEY = "cart";
        public const string payid = "payid";
        public List<CartItem> cartItems = new List<CartItem>();
        List<CartItem> GetCartItems()
        {

            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }
        // Xóa cart khỏi session
        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
        }

        // Lưu Cart (Danh sách CartItem) vào session
        void SaveCartSession(List<CartItem> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }

        public IActionResult AddToCart(int food_id) // use
        {
            var product = db.Foods
                .Where(p => p.Foodid == food_id)
                .FirstOrDefault();
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.product.Foodid == food_id);
            if (cartitem != null)
            {
                cartitem.quantity++;
            }
            else
            {
                cart.Add(new CartItem() { quantity = 1, product = product });
            }
            SaveCartSession(cart);
            // Chuyển đến trang hiện thị Cart
            return RedirectToAction(nameof(Cart));
        }

        public IActionResult Cart()
        {
            return View(GetCartItems());
        }
     
        public IActionResult Index2(Payment payment)
        {
           
            
           var products = db.Foods.Where(x => x.Caterid == payment.Caterid).ToList();
            return View("SanPham", products);
        }

        /// Thêm sản phẩm vào cart
        [Route("/removecart/{productid:int}", Name = "removecart")]
        public IActionResult RemoveCart([FromRoute] int productid)
        {

            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.product.Foodid == productid);
            if (cartitem != null)
            {
                cart.Remove(cartitem);
            }

            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }

       // [Route("/updatecart", Name = "updatecart")]
        [HttpPost]
        public IActionResult UpdateCart([FromForm] int productid, [FromForm] int quantity)
        {
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.product.Foodid == productid);
            if (cartitem != null)
            {
                cartitem.quantity = quantity;
            }
            SaveCartSession(cart);
            
            return RedirectToAction(nameof(Cart));
        }
        [HttpGet]
        public IActionResult RemovePayment()
        {
            //var UserID = int.Parse(HttpContext.Session.GetString("no"));
            var payid2 = int.Parse(HttpContext.Session.GetString(payid));
            var resurl = db.Payments.SingleOrDefault(x => x.Paymentid.Equals(payid2));

            return View(resurl);
        }
        [HttpPost]
        public IActionResult RemovePayment2()
        {
            //var UserID = int.Parse(HttpContext.Session.GetString("no"));
            var payid2 = int.Parse(HttpContext.Session.GetString(payid));
            var resurl = db.Payments.SingleOrDefault(x => x.Paymentid.Equals(payid2));
            db.Payments.Remove(resurl);
            db.SaveChanges();
            HttpContext.Session.Remove(payid);
            HttpContext.Session.Remove(CARTKEY);
            return RedirectToAction("Index", "Home");
        }


        // Hiện thị giỏ hàng
        //[Route("/cart", Name = "cart")]
        //public IActionResult Cart()
        //{
        //    return View();
        //}

        [Route("/checkout")]
        public IActionResult CheckOut()
        {
            // Xử lý khi đặt hàng
            return View();
        }

        [HttpGet]
        public IActionResult CartPayment(CartItem cartItem,decimal Total)
        {
            PaymentDetail cart = new PaymentDetail();

            var payid2 = int.Parse(HttpContext.Session.GetString(payid));
            if (ModelState.IsValid)
            {
                List<CartItem> check = GetCartItems();
                List<PaymentDetail> details = new List<PaymentDetail>();
                cart.Paymentid = payid2;
                foreach (var item in check)
                {
                    cart.Foodid = item.product.Foodid;
                    cart.Quantity = item.quantity;
                    cart.Total = Total;
                    // cart.Paymentid = payid2;

                    details.Add(cart);
                };
                db.PaymentDetails.AddRange(details);
                db.SaveChanges();
                var pay = db.PaymentDetails.Where(x => x.Paymentid.Equals(payid2)).ToList();
                //db.PaymentDetails.Add(cart);

                //db.PaymentDetails.Add(cart);
                //db.SaveChanges();
                return View("CartPayment", pay);
            }
            else
            {
                return View(nameof(cart));
            }
        }

        [HttpGet]
        public IActionResult Thanhtoan(int id)
        {
            var payid2 = int.Parse(HttpContext.Session.GetString(payid));
            var payid3 = db.Payments.Where(x => x.Paymentid == payid2).SingleOrDefault();
            var total = db.PaymentDetails.SingleOrDefault(x => x.Detailsid.Equals(id));
            payid3.Amount = total.Total;
            db.Payments.Update(payid3);
            return View(payid3);
        }
        [HttpPost]
        public IActionResult Thanhtoan(Payment final)
        {
            var payid2 = int.Parse(HttpContext.Session.GetString(payid));

            var payid3 = db.Payments.Where(x => x.Paymentid == payid2).SingleOrDefault();
            List<CartItem> check = GetCartItems();
            try
            {
                if (ModelState.IsValid)
                {
                    payid3.OrderDate = final.OrderDate;
                    payid3.DeliveryDate = final.DeliveryDate;
                    payid3.Amount = final.Amount;
                    payid3.Status = true;
                    ViewBag.msg = "Update Success";
                    db.Payments.Update(payid3);
                    db.SaveChanges();
                    HttpContext.Session.Remove(payid);
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ViewBag.msg = "Update fail !!";
                }

            }
            catch (Exception e)
            {
                ViewBag.ms = e.Message;
            }
            return RedirectToAction(nameof(Thanhtoan));

        }

    }
}
