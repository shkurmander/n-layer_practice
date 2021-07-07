using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace n_layer.DataAccess
{
    class FileDataRepository<T> : IDataRepository<T>

    {
        private string _path;

        public List<T> Load()
        {
            BinaryFormatter formatter = new BinaryFormatter();

           
            Console.WriteLine($"Читаем данные из файла:\n");

            //Десериализуем данные из файла
            using (var fs = new FileStream(_path, FileMode.Open))
            {
                var newData = (List<T>)formatter.Deserialize(fs);
                
                return newData;
            }
        }

        public void Save(List<T> data)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            Console.WriteLine($"Сохраняем данные в файл:\n");

            using (var fs = new FileStream(_path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, data);
                
            }
            
        }
        public FileDataRepository(string path)
        {
            _path = path;
        }
    }
}
