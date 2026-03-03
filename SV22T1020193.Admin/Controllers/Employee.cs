using Microsoft.AspNetCore.Mvc;

namespace SV22T1020193.Admin.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /Employee
        public IActionResult Index()
        {
            // TODO: Lấy danh sách nhân viên từ DB
            return View();
        }

        // GET: /Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Employee/Create
        [HttpPost]
        public IActionResult Create(object model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // TODO: Thêm nhân viên
            // _employeeService.Add(model);

            return RedirectToAction("Index");
        }

        // GET: /Employee/Edit/5
        public IActionResult Edit(int id)
        {
            // TODO: Lấy nhân viên theo id
            // var employee = _employeeService.Get(id);

            return View();
        }

        // POST: /Employee/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, object model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // TODO: Cập nhật nhân viên
            // _employeeService.Update(id, model);

            return RedirectToAction("Index");
        }

        // GET: /Employee/Delete/5
        public IActionResult Delete(int id)
        {
            // TODO: Xóa nhân viên
            // _employeeService.Delete(id);

            return RedirectToAction("Index");
        }

        // GET: /Employee/ChangePassword/5
        public IActionResult ChangePassword(int id)
        {
            // TODO: Lấy thông tin nhân viên nếu cần
            return View();
        }

        // POST: /Employee/ChangePassword/5
        [HttpPost]
        public IActionResult ChangePassword(int id, string newPassword, string confirmPassword)
        {
            if (newPassword != confirmPassword)
            {
                ModelState.AddModelError("", "Mật khẩu không khớp");
                return View();
            }

            // TODO: Đổi mật khẩu
            // _employeeService.ChangePassword(id, newPassword);

            return RedirectToAction("Index");
        }

        // GET: /Employee/ChangeRole/5
        public IActionResult ChangeRole(int id)
        {
            // TODO: Load role hiện tại
            return View();
        }

        // POST: /Employee/ChangeRole/5
        [HttpPost]
        public IActionResult ChangeRole(int id, string role)
        {
            // TODO: Cập nhật role
            // _employeeService.ChangeRole(id, role);

            return RedirectToAction("Index");
        }
    }
}
