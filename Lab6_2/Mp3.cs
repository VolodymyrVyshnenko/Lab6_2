using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_2
{
    class Mp3 : IRecordable
    {
        public Mp3(string path)
        {

        }
        public void Record()
        {
            Console.WriteLine("Work");
        }
        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}