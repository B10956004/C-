using Microsoft.AspNetCore.Mvc;
using WebApplication1_0516.Models;
using WebApplication1_0516.Service;

namespace WebApplication1_0516.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index(int nowPage=1)//分頁
        {
            //var list=_studentService.GetStudents();
            int count = 10;
            int offset=(nowPage-1)*count;
            var (total, list) = _studentService.GetStudents(offset, count);
            ViewData["Total"]=total;
            ViewData["nowPage"] = nowPage;
            return View(list);
        }
        public IActionResult Update(string studentNo)//更新
        {
            var student=_studentService.GetStudentByStudentNo(studentNo);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.UpdateStudent(student);
                return RedirectToAction("Index");//導至清單頁面
            }
            return View(student);
        }
        public IActionResult Delete(string studentNo)
        {
            _studentService.DeleteStudent(studentNo);
            return RedirectToAction("Index");
        }
    }
}
