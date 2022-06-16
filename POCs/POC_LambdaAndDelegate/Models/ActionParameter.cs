using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_LambdasAndDelegates.Models
{
     public class ActionParameter <T>: BaseModel
    {
        public T Content { get; set; }

        public ActionParameter(T content)
        {
            Content = content;
        }
    }
}
