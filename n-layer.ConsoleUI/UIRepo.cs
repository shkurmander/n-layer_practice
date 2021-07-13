
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

            var exit = false;

            do
            {
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
                MakeIndent();
                Console.WriteLine("4. Выход");
                Console.SetCursorPosition(35, Console.CursorTop);
                Console.WriteLine("********************************************");

                switch (Console.ReadLine())
                {
                    case "1" : PrintTodoList(); break;
                    case "2": AddNewTargetDialog(); break;
                    case "3": FindTargetDialog(); break;
                    case "4": exit = true; break;

                    default:
                        break;
                }
            } while (!exit);
            


        }

        public void  AddNewTargetDialog()
        {
            var tmp = new TargetPL();
            Console.Clear();

            Console.WriteLine("Введите название задачи:");
            tmp.Name = Console.ReadLine();
            Console.WriteLine("Введите описание задачи:");
            tmp.Text = Console.ReadLine();
            var flag = false;
            while (!flag)
            {
                Console.WriteLine("Введите приоритет задачи от 1 до 5 :");
                try
                {
                    var priority = Int32.Parse(Console.ReadLine());
                    if (CheckPriority(priority))
                    {
                        tmp.Priority = priority;
                        flag = true;
                    }


                }
                catch (Exception)
                {

                    Console.WriteLine("Некорректный ввод, необходимо ввести число"); 
                }
            }   

            _api.AddNewTarget(tmp);
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }


        public  void PrintTodoList()
        {
                        
            Console.Clear();
            
            foreach (var item in _api.GetTodoList())
            {
                PrintTarget(item);
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
        public void PrintTodoList(List<TargetPL> lst)
        {

            Console.Clear();

            foreach (var item in lst)
            {
                PrintTarget(item);
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();

        }
        public void PrintTarget(TargetPL target)
        {
            const int ind = 10;
            void MakeIndent()
            {
                Console.SetCursorPosition(ind, Console.CursorTop);
            }
            MakeIndent();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(target.Name);
            Console.ResetColor();
            Console.WriteLine($"Описание:\n\t {target.Text}");
            switch (target.Priority)
            {
                case 1 :  Console.ForegroundColor = ConsoleColor.Red; break;
                case 2 :  Console.ForegroundColor = ConsoleColor.Magenta; break;
                case 3 :  Console.ForegroundColor = ConsoleColor.Yellow; break;
                case 4 :  Console.ForegroundColor = ConsoleColor.Green; break;
                case 5 :  Console.ForegroundColor = ConsoleColor.Cyan; break;
                default:
                    break;
            }
            Console.WriteLine($"Приоритет:\t {target.Priority}");
            Console.ResetColor();
            if (target.State)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Состояние:\t Выполнено!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Состояние:\t Не выполнено!!!");
            }
            Console.ResetColor();
            Console.WriteLine("===========================================================\n");
            

        }

        public  void FindTargetDialog()
        {
            Console.Clear();

            Console.WriteLine("Введите название задачи:");
            var reqst = Console.ReadLine();
            var result = _api.GetTargetByName(reqst);
            if (result.Count == 0)
            {
                Console.WriteLine("Таких задач не найдено");
            }
            else
                PrintTodoList(result);
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();

        }

        private bool CheckPriority(int check)
        {
            if (check >0 && check<6)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Некорректный приоритет, введите числовое значение от 1 до 5!!!");
                return false;
            }
                
        }

    }
    


}
