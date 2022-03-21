using System;
using System.Collections.Generic;
using System.Text;

namespace _0321
{
    class FileServiceA : IFileService
    {
        public string UploadFile()
        {
            Console.WriteLine("JPG");
            return "上傳成功";
        } 
    }
}
