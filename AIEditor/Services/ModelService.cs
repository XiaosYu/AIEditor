using AIEditor.Extensions;
using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
// C#
namespace AIEditor.Services
{
    public class ModelService: ServerBase
    {
        public Task<List<string>> ListAllModelAsync()
        {
            using (Py.GIL())
            {
                using var scope = Py.CreateScope();
                var module = scope.Exec(File.ReadAllText("PythonCode/models.py"));
                var result = module.InvokeMethod("list_models").ToList<string>();
                return Task.FromResult(result);
            }
        }

        public Task<Dictionary<string, object?>> QueryModelParameters(string modelName) 
        {
            using (Py.GIL())
            {
                using var scope = Py.CreateScope();
                var module = scope.Exec(File.ReadAllText("PythonCode/models.py"));
                var args = new PyString(modelName);
                var result = module.InvokeMethod("query_model_parameters", args);
                var dict = result.ToDictionary();
                return Task.FromResult(dict);
            }
        }
    }
}
