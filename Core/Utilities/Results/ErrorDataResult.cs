using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrrorDataResult<T> : DataResult<T>
    {
        public ErrrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrrorDataResult(T data) : base(data, false)
        {

        }

        public ErrrorDataResult(string message) : base(default, false, message)
        {

        }

        public ErrrorDataResult() : base(default, false)
        {

        }

    }
}
