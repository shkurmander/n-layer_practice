
using n_layer.UserAPI;
using n_layer.UserAPI.Interface;
using System;
using System.Collections.Generic;

namespace n_layer.ConsoleUI
{
    public class UIRepo

    {
        private UserAPIImpl _api;
        public UIRepo()
        { 
           _api = new UserAPIImpl();
        }
    
        
        public  void DrawMainMenu()
        {
            const int ind = 45;
            //int position = 5;
            void MakeIndent()
            {
                Console.SetCursorPosition(ind, Console.CursorTop);
                
            }
            

            Console.Clear();

            Console.SetCursorPosition(42, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ну здравствуй прокрастинатор!!!");
            Console.ResetColor();

            Console.SetCursorPosition(35, 12);
            Console.WriteLine("********************************************");
            MakeIndent();
            Console.WriteLine("1. Вывести список задач");
            MakeIndent();
            Console.WriteLine("2. Добавить новую задачу");
            MakeIndent();
            Console.WriteLine("3. Поиск задачи");
            Console.SetCursorPosition(35, Console.CursorTop);
            Console.WriteLine("********************************************");


        }

        public void  AddNewTargetDialog()
        {
            var tmp = new TargetPL();
            Console.Clear();

            Console.WriteLine("Введите название задачи:");
            tmp.Name = Console.ReadLine();
            Console.WriteLine("Введите описание задачи:");
            tmp.Text = Console.ReadLine();
            Console.WriteLine("Введите приоритет задачи от 1 до 5 :");
            tmp.Priority = Int32.Parse(Console.ReadLine());

            _api.AddNewTarget(tmp);
            
        }


        public  void PrintTodoList()
        {
                        
            Console.Clear();
            
            foreach (var item in _api.GetTodoList())
            {
                PrintTarget(item);
            }            

        }
        public  void PrintTarget(TargetPL target)
        {
            const int ind = 10;
            void MakeIndent()
            {
                Console.SetCursorPosition(ind, Console.CursorTop);
            }
            MakeIndent();
            Console.WriteLine(target.Name);
            Console.WriteLine(target.Text);
            Console.WriteLine(target.Priority);
            Console.WriteLine(target.State);

        }

        public  int FindTargetDialog()
        {

            Console.WriteLine("Введите название задачи:");


        }

    }
    


}
