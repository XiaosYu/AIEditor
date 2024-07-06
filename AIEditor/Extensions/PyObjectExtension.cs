using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AIEditor.Extensions
{
    public static class PyObjectExtension
    {

        public static object? Parse(this PyObject @object)
        {
            var typeString = @object.GetPythonType().ToString();
            return typeString switch
            {
                "<class 'bool'>" => @object.As<bool>(),
                "<class 'int'>" => @object.As<int>(),
                "<class 'str'>" => @object.As<string>(),
                "<class 'float'>" => @object.As<float>(),
                _ => null,
            };
        }

        public static List<T> ToList<T>(this PyObject @object)
        {
            var result = new List<PyObject>();
            var list = PyList.AsList(@object);
            return list.Select(s => s.As<T>()).ToList();
        }

        public static Dictionary<string, object?> ToDictionary(this PyObject @object)
        {
            var result = new Dictionary<string, object?>();
            var dict = new PyDict(@object);
            foreach (var item in dict.Items())
            {
                result.Add(item[0].As<string>(), item[1].Parse());
            }
            return result;
        }
    }
}
