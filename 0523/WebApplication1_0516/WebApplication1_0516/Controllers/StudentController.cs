using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        [HttpPost]
        public IActionResult Index(Dictionary<string,string>queryDic,int nowPage = 1)//分頁
        {
            //var list=_studentService.GetStudents();
            int count = 10;
            int offset = (nowPage - 1) * count;
            var (total, list) = _studentService.GetStudents(offset, count);
            ViewData["Total"] = total;
            ViewData["nowPage"] = nowPage;

            ViewData["query_studentName"] = queryDic["studentName"];
            ViewData["query_studentNo"] = queryDic["studentNo"];
            ViewData["query_githubLink"] = queryDic["githubLink"];
            return View(list);
        }
        public IActionResult Update(string studentNo)//更新
        {
            var student = _studentService.GetStudentByStudentNo(studentNo);
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
            var student = _studentService.GetStudentByStudentNo(studentNo);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(string studentNo)
        {
            _studentService.DeleteStudent(studentNo);
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            _studentService.CreateStudent(student);
            return RedirectToAction("Index");
        }

        public  IActionResult Detail(string studentNo)
        {
            var student = _studentService.GetStudentByStudentNo(studentNo);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
    }
}
