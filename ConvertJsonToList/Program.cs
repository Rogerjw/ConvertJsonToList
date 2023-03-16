using System.Text.Json;

namespace ConvertJsonToList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            var actualPath = path.Substring(0, path.LastIndexOf("bin", StringComparison.Ordinal));
            var projectPath = new Uri(actualPath).LocalPath;
            var file = projectPath + "\\json1.json";

            var eros = ReadJsonFile(file).EROS;
            foreach (var ero in eros)
            {
                Console.WriteLine($"{ero.moduleName} {ero.URL}, {ero.Screename}");
            }
        }
        public static Rootobject ReadJsonFile(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Rootobject>(json);
        }

    }
}