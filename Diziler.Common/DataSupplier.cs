using System;
using System.Collections.Generic;

namespace Diziler.Common
{
    public class DataSupplier
    {
        public IEnumerable<int> GetNumbers()
        {
            return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        public int[] GetEmptyIntegerArray()
        {
            var array = new int[3];
            return array;
        }

        public string[] GetEmptyStringArray()
        {
            //TODO: Bunun testi yazılacak
            var array = new string[3];
            return array;
        }

        public string GetLyric()
        {
            return "I'm in love with the shape you, We push and pull like a magnet do";
        }

        public int[] GetIntegerArray()
        {
            var array = new int[3];
            array[0] = 1;
            array[1] = 3;
            array[2] = 5;
            return array;

            //return new int[3] { 1, 3, 5 };
        }

        public Person[] GetPeople()
        {
            var p1 = new Person { name = "Can Perk", gender = Gender.Male, age = 32 };
            var p2 = new Person { name = "Dilara İşcanoğlu", gender = Gender.Female, age = 23 };
            var p3 = new Person { name = "Halil Bozkurt", gender = Gender.Male, age = 24 };

            //return new Person[5] { p1, p2, p3 }; dizi uzunlupu belirtilierse verilen eleman sayısı da dizi uzunluğu kadar olmalıdır
            return new Person[] { p1, p2, p3 };
        }
    }
}
