using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itw_training_dotnet7.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public bool Success {get; set;} = true;
        public String Message {get; set;} = string.Empty;
    }
}