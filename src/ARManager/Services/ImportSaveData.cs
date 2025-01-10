using System.Text.Json;

namespace ARManager.Services
{
    public class ImportSaveData
    {
        string path = Path.Combine("", @"..\..\..\..\..\Planes.json");
<<<<<<< HEAD
       
=======
        //public const string ConfigPath = "config.json";
        public const string TransactionsPath = "transactions.json";
>>>>>>> 7635da8a363c61bef392b41ce0a4914e9eb02138

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
<<<<<<< HEAD
                    Console.WriteLine("Plik planes.json już istnieje.");
=======
                    Console.WriteLine("Plik transactions.json już istnieje.");
>>>>>>> 7635da8a363c61bef392b41ce0a4914e9eb02138
                }
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                Console.WriteLine($"Wystąpił błąd podczas tworzenia pliku: {ex.Message}");
=======
                Console.WriteLine($"Wystąpił błąd podczas tworzenia plików: {ex.Message}");
>>>>>>> 7635da8a363c61bef392b41ce0a4914e9eb02138
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
