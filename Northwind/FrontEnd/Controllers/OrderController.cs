using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class OrderController : Controller
    {
        IOrderHelper _orderHelper;
        IEmployeesHelper _employeesHelper;
        ICustomerHelper _customerHelper;
        IShipperHelper _shipperHelper;
        public OrderController(IOrderHelper orderHelper, IEmployeesHelper employeesHelper, ICustomerHelper customerHelper, IShipperHelper shipperHelper)
        {
            _orderHelper = orderHelper;
            _employeesHelper = employeesHelper;
            _customerHelper = customerHelper;
            _shipperHelper = shipperHelper;
        }

        // GET: OrderController
        public ActionResult Index()
        {
            return View(_orderHelper.GetAll());
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            OrderViewModel order = new OrderViewModel();
            order.Shippers = _shipperHelper.GetShippers();
            order.Customers = _customerHelper.GetAll();
            order.Employees = _employeesHelper.GetAll();
            return View(order);
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderViewModel order)
        {
            try
            {
                _orderHelper.AddOrder(order);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
