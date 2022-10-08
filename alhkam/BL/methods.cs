using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace alhkam.BL
{
    class methods
    {
        public MemoryStream ma = new MemoryStream();
        public byte[] by;

        // convert to bytes
        public byte[] convert_byte()
        {
            return ma.ToArray();
        }

        // Convert bytes to image


        public MemoryStream convert_image()
        {
            ma = new MemoryStream(by);
            return ma;
        }

    }
}
