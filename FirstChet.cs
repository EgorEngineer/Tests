using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat1
{
    internal class FirstChet
    {
        public static (int Index, int Value, long Sum, long Cube, int[] TransformedArray, List<string> Errors) ProcessArray(int[] inputArray)
        {
            List<string> errors = new List<string>();
            int index = -1;
            int value = 0;
            long sum = 0;
            long cube = 0;
        
            if (inputArray == null || inputArray.Length == 0)
            {
                errors.Add("Массив null или пустой.");
                return (-1, 0, 0, 0, inputArray, errors);
            }

            if (inputArray.Length > 1024)
            {
                errors.Add("Размер массива превышает максимальный предел 1024.");
                return (-1, 0, 0, 0, inputArray, errors);
            }

            int[] transformedArray = (int[])inputArray.Clone();
            try
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] < int.MinValue || inputArray[i] > int.MaxValue)
                    {
                        errors.Add($"Элемент на индексе {i} выходит за границы типа int.");
                        return (-1, 0, 0, 0, inputArray, errors);
                    }
                    checked
                    {
                        sum += inputArray[i];
                    }
                }
            }
            catch (OverflowException)
            {
                errors.Add("Переполнение при вычислении суммы элементов массива.");
                return (-1, 0, 0, 0, inputArray, errors);
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] > 0 && inputArray[i] % 2 == 0)
                {
                    index = i;
                    value = inputArray[i];
                    break;
                }
            }

            if (index == -1)
            {
                errors.Add("В массиве нет четных положительных чисел.");
                return (-1, 0, sum, 0, inputArray, errors);
            }

            long difference = value - sum;
            try
            {
                checked
                {
                    cube = difference * difference * difference;
                }
            }
            catch (OverflowException)
            {
                errors.Add("Переполнение при вычислении куба разности.");
                return (-1, 0, sum, 0, inputArray, errors);
            }

            if (cube < int.MinValue || cube > int.MaxValue)
            {
                errors.Add("Куб разности не помещается в тип int для преобразования массива.");
                return (-1, 0, sum, cube, inputArray, errors);
            }

            transformedArray[index] = (int)cube;

            return (index, value, sum, cube, transformedArray, errors);
        }
    }
}