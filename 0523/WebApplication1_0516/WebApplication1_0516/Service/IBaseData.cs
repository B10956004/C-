using System;

namespace WebApplication1_0516.Service
{
    public interface IBaseData
    {
        bool isDelete { get; set; }
        DateTime creDateTime { get; set; }
        DateTime updateDateTime { get; set; }
    }
}
