using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18_Aug
{
    public class CustomStringBuilder
    {
        public static List<char> _CustomStringBuilder = new List<char>();
        public CustomStringBuilder(string str)
        {
            for (int i = 0; i<str.Length; i++)
            {
                _CustomStringBuilder.Add(str[i]);
            }
            
        }
        public void Append(string str)
        {
            for (int i=0; i<str.Length; i++)
            {
                _CustomStringBuilder.Add(str[i]);
            }
        }

        public void RemoveAt(int index)
        {
            for (int i = 0; i<_CustomStringBuilder.Count; i++)
            {
                if (index == i)
                {
                    _CustomStringBuilder.RemoveAt(index);
                }
            }
        }
        public void InsertAt(int index,string value)
        {
            for (int i = 0; i < _CustomStringBuilder.Count; i++)
            {
                if (index == i)
                {
                    for (int k = 0; k < value.Length; k++)
                    {
                        _CustomStringBuilder.Insert(index,value[k]);
                    }
                }
            }
        }
        public override string ToString()
        {
            return new string(_CustomStringBuilder.ToArray());
        }
    }

    //public static class test
    //{
    //    public static CustomStringBuilder Append(this CustomStringBuilder value, string multiplier)
    //    {
            
    //    }
    //}

    //public  class test1
    //{
    //    public void test2()
    //    {
    //        CustomStringBuilder csb = new CustomStringBuilder();
            
    //    }
        
        
    //}
}
