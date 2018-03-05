﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash411
{
    /// <summary>
    /// Message is a thin wrapper around an array of bytes
    /// </summary>
    class Message
    {
        private byte[] message;

        public Message(byte[] message)
        {
            this.message = message;
        }

        public byte[] GetBytes()
        {
            return this.message;
        }
    }
}
