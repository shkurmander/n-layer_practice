using n_layer.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace n_layer.DataAccess
{
    public class FileContext
    {
        private string _path;

        public string FilePath { get => _path; }
        public List<Target> Targets { get; set; }

        public FileContext(string path)
        {
            _path = path;
            Targets = new List<Target>();
            if (File.Exists(_path))
            {
               
                //Десериализуем данные из файла
                using (var sr = new StreamReader(_path))
                {
                    try
                    {
                        string json = sr.ReadToEnd();
                        Targets = JsonConvert.DeserializeObject<List<Target>>(json);
                           
                    }
                    catch (Exception)
                    {
                        Targets = new List<Target>();
                        Console.WriteLine("В файле нет данных!");
                    }
                }               
                
            }
        }
         
        
    }
}
