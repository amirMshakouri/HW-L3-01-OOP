using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task4
{
    using System;

    public class RoomFullException : Exception
    {
        public RoomFullException()
            : base("the room is full and has no space")
        {

        }
    }
}
