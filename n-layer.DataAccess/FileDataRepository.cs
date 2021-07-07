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

        public IList<T> Load()
        {
            BinaryFormatter formatter = new BinaryFormatter();

           
            Console.WriteLine($"Читаем данные из файла:\n");

            //Десериализуем данные из файла
            using (var fs = new FileStream(_path, FileMode.Open))
            {
                var newData = (IList<T>)formatter.Deserialize(fs);
                
                return newData;
            }
        }

        public void Save(IList<T> data)
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
