using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaipovMR_01_06
{
    internal class Program
    {
        static void Main (string[] args)
        {
            string v = "";
            while(v != "8")
            {
                Console.WriteLine("1 - добавить базовый элемент" +
                    "\n2 - добавит элемент наследника" +
                    "\n3 - вывести базовый список" +
                    "\n4 - вывести список элементов наследников" +
                    "\n5 - удалить из базового скписка" +
                    "\n6 - удалить из списка наследникв" +
                    "\n7 - вывести стреднее значение качества списков"+
                    "\n8 - выход");
                v = Console.ReadLine();
                switch (v)
                {
                    case "1":
                    {
                        string type ="";
                        double cont, d =0;
                        try
                        {
                            Console.WriteLine("Введите тип кабеля");
                            type = Console.ReadLine().Trim();

                            Console.WriteLine("Введите количество жил");
                            cont = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите диаметр кабеля");
                            d = double.Parse(Console.ReadLine());

                        } catch(Exception ex)
                        {
                            cont = -1;
                            d = -1;
                        }
                        Cabel c = new Cabel(type, cont,d);
                        if(c.IsValid())
                        {
                            Cabel.AddToBaseList(c);
                            Console.WriteLine("Успешно добавлен");
                        }else
                        {
                            Console.WriteLine("Не добавлен");
                        }
                    }
                    break;
                    case "2":
                    {
                        string type = "";
                        double cont, d, width = 0;
                        try
                        {
                            Console.WriteLine("Введите тип кабеля");
                            type = Console.ReadLine().Trim();

                            Console.WriteLine("Введите количество жил");
                            cont = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите диаметр кабеля");
                            d = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите ширину кабеля");
                            width = double.Parse(Console.ReadLine());

                        } catch (Exception ex)
                        {
                            cont = -1;
                            d = -1;
                            width = -1;
                        }
                        CabelChild    c = new CabelChild(type, cont, d, width);
                        if (c.IsValid())
                        {
                            CabelChild.AddToChildList(c);
                            Console.WriteLine("Успешно добавлен");
                        } else
                        {
                            Console.WriteLine("Не добавлен");
                        }
                    }
                    break;
                    case "3":
                    {
                        Console.WriteLine();
                        foreach (Cabel c in Cabel.Spisok)
                        {
                            Console.WriteLine(c.GetInfo());
                        }

                        Console.WriteLine();
                    }
                    break;
                    case "4":
                    {
                        Console.WriteLine();
                        foreach (CabelChild  c in CabelChild.Spisok)
                        {
                            Console.WriteLine(c.GetInfo());
                        }

                        Console.WriteLine();
                    }
                    
                    break ;
                    case "5":
                    {
                        string vi = "";
                            
                        Console.WriteLine("1 - удалить 1 элемент\n2 - удалить несколько");

                        vi = Console.ReadLine();
                        switch (vi)
                        {
                            case "1":
                            {
                                int index = 0;
                                try
                                {
                                    Console.WriteLine("Введите индех удаляемого");
                                    index = int.Parse(Console.ReadLine());


                                } catch (Exception ex)
                                {
                                    index = -1;
                                }

                                if (Cabel.RemoveAt(index))
                                {
                                    Console.WriteLine("Успешно удален");
                                } else
                                {
                                    Console.WriteLine("НЕ удален");
                                }
                                
                            }break; 
                            case "2":
                            {
                                int indexstart, indexend = 0;
                                try
                                {
                                    Console.WriteLine("Введите индех начального");
                                    indexstart = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Введите индех конечного");
                                    indexend = int.Parse(Console.ReadLine());


                                } catch (Exception ex)
                                {
                                    indexstart = -1;
                                    indexend = -1;
                                }

                                if (Cabel.RemoveAt(indexstart, indexend))
                                {
                                    Console.WriteLine("Успешно удалены");
                                } else
                                {
                                    Console.WriteLine("НЕ удалены");
                                }
                                
                            }
                            break;
                            default:
                            {
                                Console.WriteLine("Нет такого выбора");
                            }
                            break;

                        }
                    }
                    break ;
                    case "6":
                    {
                        string vi = "";

                        Console.WriteLine("1 - удалить 1 элемент\n2 - удалить несколько");
                        vi = Console.ReadLine();
                        switch (vi)
                        {
                            case "1":
                            {
                                int index = 0;
                                try
                                {
                                    Console.WriteLine("Введите индех удаляемого");
                                    index = int.Parse(Console.ReadLine());


                                } catch (Exception ex)
                                {
                                    index = -1;
                                }

                                if (CabelChild.RemoveAt(index))
                                {
                                    Console.WriteLine("Успешно удален");
                                } else
                                {
                                    Console.WriteLine("НЕ удален");
                                }

                            }
                            break;
                            case "2":
                            {
                                int indexstart, indexend = 0;
                                try
                                {
                                    Console.WriteLine("Введите индех начального");
                                    indexstart = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Введите индех конечного");
                                    indexend = int.Parse(Console.ReadLine());


                                } catch (Exception ex)
                                {
                                    indexstart = -1;
                                    indexend = -1;
                                }

                                if (CabelChild.RemoveAt(indexstart, indexend))
                                {
                                    Console.WriteLine("Успешно удалены");
                                } else
                                {
                                    Console.WriteLine("НЕ удалены");
                                }

                            }
                            break;
                            default:
                            {
                                Console.WriteLine("Нет такого выбора");
                            }
                            break;

                        }
                    }
                    break;
                    case "7":
                    {
                        if (Cabel.Spisok.Count>0)
                        {
                            Console.WriteLine("среднее значение родительского " + Cabel.Average());
                        }else
                        {
                            Console.WriteLine("элементов в родительском списке нет " );
                        }

                        if(CabelChild.Spisok.Count > 0)
                        {
                            Console.WriteLine("среднее значение класса наследника " + CabelChild.Average());
                        }else
                        {
                            Console.WriteLine("элементов в списке наследника нет ");
                        }


                            
                    }
                    break;
                    case "8":
                    {

                    }break;
                }
            }
        }
    }
}
