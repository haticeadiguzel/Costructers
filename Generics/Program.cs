using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu normal list
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);


            //Buda bizim oluşturmak istediğimiz list
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Edirne");
            sehirler2.Add("Edirne");
            sehirler2.Add("Edirne");
            sehirler2.Add("Edirne");
            sehirler2.Add("Edirne");
            sehirler2.Add("Edirne");
            sehirler2.Add("Edirne");
            sehirler2.Add("Edirne");

            Console.WriteLine(sehirler2.Count); //Count bir property dir

        }
    }

    class MyList<T> //Generic class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[1] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

      
        public int Count
        {
            get { return _array.Length; }
        }




    }
}
