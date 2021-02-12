using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    class MyDictionary<Tk,Tv> // değişken ismi T type, generic class oluşturduk
    {
        Tk[] itemsK;
        Tv[] itemsV;
        public MyDictionary()
        {
            itemsK= new Tk[0];
            itemsV = new Tv[0];
        }
        public void Add(Tk itemK, Tv itemV)
        {
            Tk[] tempKey = itemsK;
            Tv[] tempValue = itemsV;
            itemsK = new Tk[itemsK.Length + 1];
            itemsV = new Tv[itemsV.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                itemsK[i] = tempKey[i];
                itemsV[i] = tempValue[i];
            }
            itemsK[itemsK.Length - 1] = itemK;
            itemsV[itemsV.Length - 1] = itemV;
            Console.WriteLine("eklendi\n"+itemsK[0]+" "+itemsV[0]);
        }
    }

    }

