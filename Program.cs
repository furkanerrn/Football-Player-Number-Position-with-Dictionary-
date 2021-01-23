using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            myList<int, string> futbol_forma_mevki = new myList<int, string>();
            futbol_forma_mevki.Add(1, "Kaleci");
            futbol_forma_mevki.Add(2, "Sol Bek");
            futbol_forma_mevki.Add(2, "Sol Bek");
            futbol_forma_mevki.Add(3, "Sağ Bek");
            futbol_forma_mevki.Add(4, "Stoper");
            futbol_forma_mevki.Add(5, "Libero");
            futbol_forma_mevki.Add(6, "Defansif Orta Saha");
            futbol_forma_mevki.Add(7, "Sol Açık");
            futbol_forma_mevki.Add(8, "Sağ Açık");
            futbol_forma_mevki.Add(10, "Orta Saha");
            futbol_forma_mevki.Add(11, "Forvet");


            futbol_forma_mevki.show();

           

        }
        class myList<K,V>
        {
            K[] _keyArray;
            K[] _tempKey;
            V[] _valueArray;
            V[] _tempValue;

            public myList()
            {
                _keyArray = new K[0];
                _valueArray = new V[0];
            }

            public void Add(K key,V value)
            {
                _tempKey = _keyArray;
                _tempValue = _valueArray;

                _keyArray = new K[_keyArray.Length + 1];
                _valueArray = new V[_valueArray.Length + 1];

                for (int i = 0; i <_tempKey.Length; i++)
                {
                    _keyArray[i] = _tempKey[i];
                    _valueArray[i] = _tempValue[i];

                    _keyArray[_keyArray.Length - 1] = key;
                    _valueArray[_valueArray.Length - 1] = value;

                }

            }

            public void show()
            {
                for (int i = 0; i < _keyArray.Length; i++)
                {
                    Console.WriteLine("Numara: "+_keyArray[i]+"  Mevki:  "+_valueArray[i]);
                }
            }
        }
    }
}
