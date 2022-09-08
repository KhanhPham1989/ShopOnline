using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using Pro3_Sem3.Models;
using Microsoft.AspNetCore.Http;

using Pro3_Sem3.ServicesIMP;
using Microsoft.EntityFrameworkCore;

namespace Pro3_Sem3.Controllers
{
    public class UserController : Controller
    {
        private readonly DatabaseContext db;
        private readonly Services ser;
        private string cartUser = "cart";
        public UserController(DatabaseContext _db, Services _ser)
        {
            db = _db;
            ser = _ser;
        }

        public IActionResult Index()
        { 
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string UserName, string pass)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var UserLogin = ser.checkLogin(UserName, pass);
                    if(UserLogin != null)
                    {
                        HttpContext.Session.SetString("no", UserLogin.Cusid.ToString());
                        HttpContext.Session.SetString("customerName", UserLogin.Cusfullname.ToString());
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return RedirectToAction("Login","User");
                    }
                    
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Fail!!!");
                }
            }
            catch (Exception ex)
            {

                //ViewBag.msg = ex.Message;
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("no") == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                HttpContext.Session.Remove("no");
                HttpContext.Session.Remove("customerName");
                return RedirectToAction("Login");
            }

        }

        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Register(Customer Newcus)
        {
            var models = db.Customers.SingleOrDefault(n => n.Username.Equals(Newcus.Username));
            if (models != null && models.Cusemail.Equals(Newcus.Cusemail))
            {
                ViewBag.msg = "This email has been register!!";
                return RedirectToAction("Register");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    db.Customers.Add(Newcus);
                    db.SaveChanges();
                    ViewBag.msg = "Register Successfull!! Please Login.";
                    return RedirectToAction("Login");
                }
                return View();
            }

        }
        [HttpGet]
        public IActionResult Details(string UserName)
        {
            var detail = db.Customers.Where(c => c.Username.Equals(UserName)).SingleOrDefault();
            if (detail != null)
            {
                return View(detail);
            }
            else
            {
                return View("Login");
            }
        }
        [HttpGet]
        public IActionResult EditInfomation(int? id)
        {
            var edit = db.Customers.Find(id);

            // if (edit == null) return NotFound();
            return View(edit);
        }
        [HttpPost]
        public IActionResult EditInfomation(Customer EditCus)
        {
            try
            {
                var edit = db.Customers.SingleOrDefault(e => e.Cusid.Equals(EditCus.Cusid));
                if (edit != null && ModelState.IsValid)
                {
                    edit.Cusaddress = EditCus.Cusaddress;
                    edit.Userpass = EditCus.Userpass;
                    edit.Cusphone = EditCus.Cusphone;
                    edit.Cusemail = EditCus.Cusemail;
                    db.Customers.Update(edit);
                    db.SaveChanges();
                    return View("Login");
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
            return View("EditInfomation");
        }

        public IActionResult Delete(int? id) // cus
        {
            var delete = db.Customers.Find(id);
            db.Customers.Remove(delete);
            db.SaveChanges();
            return RedirectToAction("Login");
        }

        public IActionResult GetAllPayment()
        {
            if (HttpContext.Session.GetString("no") == null)
            {
                return RedirectToAction("Login");
            }
            string s = HttpContext.Session.GetString("no");
            var result = db.Payments.Include(a => a.Cus).Include(b => b.Cater).Include(x => x.Cater.Foods).ToList();
            return View(result);

        }

        //public IActionResult GetPayment(bool question)
        //{
        //    var resurl = db.Payments.Where(x => x.Status.Equals(question)).ToList();
        //    ViewBag.boolen = new SelectList()
        //}

        public IActionResult SubmitPayment(Payment newPayment,int food_id) 
        {
            var catererID = db.Foods.SingleOrDefault(p => p.Foodid.Equals(food_id));
            var userID = db.Customers.SingleOrDefault(c => c.Cusid.Equals(newPayment.Cusid));
            if((newPayment.DeliveryDate.Day - newPayment.OrderDate.Day)<7)
            {
                Payment UserPayment = new Payment()
                {
                    OrderDate = newPayment.OrderDate,
                    Cusid = userID.Cusid,
                    Caterid = catererID.Caterid,
                    DeliveryDate = newPayment.DeliveryDate,
                    Amount = newPayment.Amount,
                    Status = false,
                    PaymentDetails = newPayment.PaymentDetails
                };
                db.Payments.Add(UserPayment);
                db.SaveChanges();
                return View();
            }    else
            {
                return null;
            }    
           
        }

      

        public IActionResult AddMenu(PaymentDetail newDetails) 
        {
          
            List<PaymentDetail> paymentDetails = new List<PaymentDetail>();
            var Foodid = db.Foods.Where(p => p.Foodid.Equals(newDetails.Foodid)).SingleOrDefault();
            var addproduct = paymentDetails.SingleOrDefault(x => x.Foodid.Equals(newDetails.Foodid));
            if (addproduct != null && newDetails.Paymentid==addproduct.Paymentid)
            {
                addproduct.Quantity++;
                return View("MenuDetails2");
            }
            PaymentDetail newpay = new PaymentDetail()
            {
                Paymentid = newDetails.Paymentid,
                Foodid = Foodid.Foodid,
                Quantity = 1,
                Total = Foodid.Foodprice,
            };
            db.PaymentDetails.Add(newpay);
            db.SaveChanges();
            return View("MenuDetails2", paymentDetails);
        }

        public PaymentDetail Get()
        {
            var cusID = HttpContext.Session.GetString("no");
            if (cusID == null)
            {
                return null;
            }
            return null;
        }


    }
}

