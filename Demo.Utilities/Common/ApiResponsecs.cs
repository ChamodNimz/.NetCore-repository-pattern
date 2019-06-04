using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Utilities.Common
{
    public class ApiResponse
    {
        public int Status { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }

        public static ApiResponse Exception()
        {
            return new ApiResponse { Status = 400, Data = new { Name = "sds", Drink = "Coke" }, Message = "Some unexpected thing happened ..! " };
        }
    }
}
