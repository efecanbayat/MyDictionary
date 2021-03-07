using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<_Key,_Value>
    {
        _Key[] keys;
        _Value[] values;

        public MyDictionary()
        {
            keys = new _Key[0];
            values = new _Value[0];
        }

        public void Add(_Key key,_Value value)
        {
            _Key[] tempKeys = keys;
            keys = new _Key[keys.Length + 1];
            
            _Value[] tempValues = values;
            values = new _Value[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " " + values[i]);
            }
            
        }
      
    }
}
