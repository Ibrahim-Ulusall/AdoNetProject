using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
	public class SuccessResult:Result
	{
        public SuccessResult(string message,bool success):base(message,true)
        {
            
        }
        public SuccessResult(string message): base(message,true)
        {
            
        }
        public SuccessResult():base(true)
        {

        }
    }
}
