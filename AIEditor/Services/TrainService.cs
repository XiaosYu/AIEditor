using AIEditor.Models;
using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AIEditor.Services
{
    public class TrainService : ServerBase
    {
        public static async Task<string> ReceiveAsync(string address, int port, int bufferSize = 128)
        {
            var server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            await server.ConnectAsync(address, port);
            var content = new List<byte>();
            var buffer = new byte[bufferSize];
            while (true)
            {
                var size = await server.ReceiveAsync(buffer);
                if (size < bufferSize)
                {
                    content.AddRange(buffer.Take(size));
                    break;
                }
                else content.AddRange(buffer.Take(size));
            }
            var result = Encoding.UTF8.GetString(content.ToArray());
            server.Close();
            return result;
        }
        public static void Train(AlgorithmInfo algorithm, DataPreProcessInfo processInfo, List<MetricsInfo> metricsInfo, int kfold)
        {
            using (Py.GIL())
            {
                using var scope = Py.CreateScope();
                var module = scope.Exec(File.ReadAllText("PythonCode/train.py"));

                var estimator = new PyString(algorithm.Name);
                var @params = new PyDict();
                foreach (var item in algorithm.Parameters)
                    @params[item.Key] = new PyString(item.Value.ToString());
                var path = new PyString(processInfo.Path);
                var feature_columns = new PyList(processInfo.Infos.Where(s => s.IsFeature).Select(s => new PyString(s.ColumnName)).ToArray());
                var label_columns = new PyList(processInfo.Infos.Where(s => s.IsLabel).Select(s => new PyString(s.ColumnName)).ToArray());
                var normalize_columns = new PyList(processInfo.Infos.Where(s => s.IsNormalize).Select(s => new PyString(s.ColumnName)).ToArray());
                var encode_columns = new PyList(processInfo.Infos.Where(s => s.IsEncode).Select(s => new PyString(s.ColumnName)).ToArray());
                var metrics = new PyList(metricsInfo.Select(s => new PyString(s.Name)).ToArray());
                var cv = new PyInt(kfold);

                module.InvokeMethod("train", estimator, @params, path,
                    feature_columns, label_columns, normalize_columns, encode_columns,
                    metrics, cv);
            }
        }
    }
}
