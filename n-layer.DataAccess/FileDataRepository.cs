using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace n_layer.DataAccess
{
    class FileDataRepository<T> : IDataRepository<T>

    {
        private string _path;

        public List<T> Load()
        {
            BinaryFormatter formatter = new BinaryFormatter();

           
            Console.WriteLine($"Читаем данные из файла....\n");
            if (File.Exists(_path))
            {
                try
                {
                    //Десериализуем данные из файла
                    using (var fs = new FileStream(_path, FileMode.Open))
                    {
                        try
                        {
                            var newData = (List<T>)formatter.Deserialize(fs);
                            return newData;
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Файл пустой!");
                        }
                        
                                                                 
                        
                    }
                }
                catch (FileNotFoundException)
                {

                    Console.WriteLine("Файл не найден, вы еще не добавляли задачи!");
                    

                }
            }
            return new List<T>();



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
