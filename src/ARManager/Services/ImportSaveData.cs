using System.Text.Json;

namespace ARManager.Services
{
    public class ImportSaveData
    {
        string path = Path.Combine("", @"..\..\..\..\..\Planes.json");
        //public const string ConfigPath = "config.json";
        public const string TransactionsPath = "transactions.json";

        public void CreateFile()
        {
            try
            {
                if (!File.Exists(path))
                {
                    File.WriteAllText(path, "[]");
                    Console.WriteLine("Utworzono plik planes.json.");
                }
                else
                {
                    Console.WriteLine("Plik transactions.json już istnieje.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas tworzenia plików: {ex.Message}");
            }
        }

        public void SaveToFile(string path, object data)
        {
            string jsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, jsonData);
        }

        public T? ReadFromFile<T>(string path)
        {

            string jsonData = File.ReadAllText(path);
            return JsonSerializer.Deserialize<T>(jsonData);
        }

        public void DeleteFile()
        {

            if (File.Exists(path)) File.Delete(path);
            Console.WriteLine("Pliki zostały usunięte.");
        }
    }
}
