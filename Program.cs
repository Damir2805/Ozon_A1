using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozon_A
{
    class Program
    {
        static void Main(string[] args)
        {
            GetData();
        }
        

        //создаем метод GetData, который будет сохранять данные в массиве
        public static void GetData()
        {
            //пользователь будет вводить данные с клавиатуры, которые будут присваиваться строковой
            //переменной num
            string num;

            //вводимые данные будем сохранять в массиве nums
            int i = 0;
            int[] nums = new int[10];
            

            while ((num = Console.ReadLine()) != "")
                nums[i++] = Convert.ToInt32(num);

            
            //создаем массив, в котором будем хранить числа без пары
            int[] unique = new int[nums.Length];

            int countUnique = 0;

            //в цикле ищем числа без пары
            foreach (var val in nums)
            {
                if (Array.IndexOf(nums, val) == Array.LastIndexOf(nums, val))
                {
                    unique[countUnique] = val;
                    countUnique++;
                }
            }

            //удаляем парные числа из массива
            Array.Resize(ref unique, countUnique);

            //выводим полученные данные в консоль           
            Console.WriteLine(String.Join(", ", unique));

            Console.ReadKey();
        }
    }
}
