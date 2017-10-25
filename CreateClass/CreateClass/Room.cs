using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Room
    {
        public int RoomNumber { get; set; }

        public Room() { }

        public Room(int Number) {
            this.RoomNumber = Number;
        }
    }
}
