﻿using System.Collections.Generic;
using WebApplication1_0516.Models;

namespace WebApplication1_0516.Service
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        (int total, List<Student>) GetStudents(int offset, int count);
        (int total, List<Student>) GetStudents(int offset, int count,Dictionary<string,string> queryDic);
        Student GetStudentByStudentNo(string studentNo);
        bool UpdateStudent(Student student);
        bool DeleteStudent(string studentNo);
        bool CreateStudent(Student student);
    }
}
