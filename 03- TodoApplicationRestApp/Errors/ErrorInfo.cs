using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApplication.Errors
{
    public class ErrorInfo
    {
        public string Message { get; set; }
        public int Status { get; set; }
        public Object Data { get; set; }

    }
}
