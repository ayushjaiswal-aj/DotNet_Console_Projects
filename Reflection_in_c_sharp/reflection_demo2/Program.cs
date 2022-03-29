using System;
using System.Reflection;

namespace reflection_demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //fill code here
            Type myType = typeof(Hall);
            FieldInfo[] myFields = myType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (FieldInfo field in myFields)
            {
                string fieldType = field.FieldType.ToString().Split(".")[1];
                Console.WriteLine($"{fieldType} {field.Name}");
            }
        }
    }
}