
using n_layer.Entities;
using n_layer.IoC;
using n_layer.UserAPI;
using n_layer.UserAPI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace n_layer.ConsoleUI
{
    public class UIRepo

    {
        IUserAPI _api;
        
        public UIRepo(DependencyResolver resolver)
        {
            _api = new TargetUserAPI(resolver.TargetService);

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
                Console.WriteLine("2. Вывести список задач по приоритету");
                MakeIndent();
                Console.WriteLine("3. Добавить новую задачу");
                MakeIndent();
                Console.WriteLine("4. Поиск задачи");
                MakeIndent();
                Console.WriteLine("5. Удаление задачи");
                MakeIndent();
                Console.WriteLine("6. Выход");
                Console.SetCursorPosition(35, Console.CursorTop);
                Console.WriteLine("********************************************");

                switch (Console.ReadLine())
                {
                    case "1" : PrintTodoList(); break;
                    case "2" : PrintSortedList(); break;
                    case "3": AddNewTargetDialog(); break;
                    case "4": FindTargetDialog(); break;
                    case "5": DeleteTargetDialog(); break;
                    case "6": exit = true; break;

                    default:
                        break;
                }
            } while (!exit);
            


        }
        //Удаление задачи
        private void DeleteTargetDialog()
        {
            FindTargetDialog();
            Console.WriteLine("Введите идентификатор задачи, которую надо удалить");
            int id;
            if (Int32.TryParse(Console.ReadLine(), out id))
            {
                _api.DeleteTarget(id);
                Console.WriteLine("Запись удалена");

            }
            else
            {
                Console.WriteLine("Некорректное значение идентификатора");
                
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();

        }

        // Создаем новую задачу
        public void  AddNewTargetDialog()
        {
            var tmp = new Target();
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
            Console.Write("дата окончания срока исполнения (дд.мм.гггг): ");
            tmp.DateExpired = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            _api.AddNewTarget(tmp);
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
        //Поиск
        public void FindTargetDialog()
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
            
            Console.ReadKey();

        }

        public  void PrintTodoList()
        {
                        
            Console.Clear();
            
            foreach (var item in _api.GetAll().ToList())
            {
                PrintTarget(item);
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }

        
        public void PrintSortedList()
        {

            Console.Clear();

            foreach (var item in _api.GetSortByPriority())
            {
                PrintTarget(item);
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
        public void PrintTodoList(List<Target> lst)
        {

            Console.Clear();

            foreach (var item in lst)
            {
                PrintTarget(item);
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();

        }
        public void PrintTarget(Target target)
        {
            
            
            Console.WriteLine($"Id:\t {target.Id}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Задача:\t{ target.Name}");
            Console.ResetColor();
            Console.WriteLine($"Описание:\t {target.Text}");
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
            Console.WriteLine($"Срок:\t {target.DateExpired}");
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
