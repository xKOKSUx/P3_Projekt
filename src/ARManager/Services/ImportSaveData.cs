using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace ARManager.Services
{
    public class ImportSaveData
    {
        string path = Path.Combine("", @"..\..\..\..\..\Planes.json");




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
                    Console.WriteLine("Plik planes.json już istnieje.");



                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Wystąpił błąd podczas tworzenia pliku: {ex.Message}");

            }
        }

        public void SaveToFile(object data)
        {
            string path = Path.Combine("", @"..\..\..\..\..\Planes.json");
            string jsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, jsonData);
        }

        
        public static T? ReadFromFile<T>()
        {
            string path = Path.Combine("", @"..\..\..\..\..\Planes.json");
            try
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine("Plik nie istnieje.");
                    return default;
                }

                string jsonData = File.ReadAllText(path);
                if (string.IsNullOrEmpty(jsonData))
                {
                    Console.WriteLine("Plik jest pusty.");
                    return default;
                }

                return JsonSerializer.Deserialize<T>(jsonData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    IncludeFields = true
                });
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Błąd podczas deserializacji JSON: {ex.Message}");
                return default;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas odczytu pliku: {ex.Message}");
                return default;
            }
        }

        public void DeleteFile()
        {

            if (File.Exists(path)) File.Delete(path);
            Console.WriteLine("Pliki zostały usunięte.");
        }
    }
}
