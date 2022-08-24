using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TryCatchLab001
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"((?!\d+$)[a-zA-Z0-9_.]{1,30})", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(args[0]);
            try
            {
                //Lord Voldemort
                if (args[0] == "Voldemort")
                {
                    throw new Exception("Тсс! Это имя нельзя произносить!");
                }
                else
                {
                    if (args[0] == "Lord_Voldemort")
                    {
                        throw new Exception("Тсс! Это имя ТОЖЕ нельзя произносить!");
                    }
                    else
                    {
                        if (matches.Count > 0)
                        {
                            Console.WriteLine("Здравствуйте, {0}!", args[0]);
                        }
                        else
                        {
                            throw new Exception("Так нельзя!");
                        }
                    }

                }

            }
            catch (Exception ex001) when (ex001.Message == "Тсс! Это имя нельзя произносить!")
            {
                //Console.WriteLine("Случилось {0}", ex001.ToString());
                Console.WriteLine("Непроизносимое имя: {0}", ex001.Message);
                //throw;
            }
            catch (Exception ex004) when (ex004.Message == "Так нельзя!")
            {
                Console.WriteLine("{0} Можно только буквы и буквы + цифры!", ex004.Message);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Нет аргумента командной строки");
            }
            catch (Exception ex002)
            {
                Console.WriteLine("Возникло: {0}", ex002.ToString());
            }

            //finally
            //{

            //}

        }
    }
}