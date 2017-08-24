using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class IDisposableDemo : IDisposable
    {
        public StreamWriter writer { get; set; }
        public StreamReader reader { get; set; }
        public void ToRead_Write()
        {

            //Writing data to text file
            writer = new StreamWriter(new FileStream(@"D:\project_dir\freshbatch-july17\Assignments\dotNet\C# PPT\IDisposableDemo.txt", FileMode.OpenOrCreate));
            writer.WriteLine("IDisposableDemo1 ");
            writer.WriteLine("IDisposableDemo2 ");
            writer.WriteLine("IDisposableDemo3 ");
            writer.Flush();
            writer.Close();

           // Reading Data from the above created file
            reader = new StreamReader(@"D:\project_dir\freshbatch-july17\Assignments\dotNet\C# PPT\IDisposableDemo.txt");
            Console.WriteLine(reader.ReadToEnd());


        }
        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {

            if (disposing)
            {
                GC.SuppressFinalize(this);
            }
            if (writer != null)
            {
                writer.Dispose();
                //writer.WriteLine(writer);
                //writer.Flush();
            }
        }
    }
}
