using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SerializationDemo
{
    class BinaryDeSerialization
    {
        public void DeSerialization()
        {
            FileStream fileStream = new FileStream(@"/Example.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializationdemo = (Demo)formatter.Deserialize(fileStream);
            int a = 5;
            //Console.WriteLine("Value of a is "+a);
            //Console.WriteLine("Value of a is {0}", a);
            //Console.WriteLine($"Value of a is {a}");
            Console.WriteLine($"Application name {deserializationdemo.ApplicationName} ---ApplicationId    {deserializationdemo.ApplicationId}");
            Console.ReadKey();
        }
    }
}
