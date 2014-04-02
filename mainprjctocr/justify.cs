using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCR
{
    class justify
    {
        public string Justify(string s,Int32 count)
        {
            if(count<=0)
                return s;
            Int32 middle=s.Length/2;
            IDictionary<Int32,Int32>spaceoffsetsToParts=new Dictionary<Int32,Int32>();
            string[] parts=s.Split(' ');
            for(Int32 partIndex=0,offset=0;partIndex<parts.Length;partIndex++)
            {
                spaceoffsetsToParts.Add(offset,partIndex);
                offset+=parts[partIndex].Length+1;
            }
            foreach(var pair in spaceoffsetsToParts.OrderBy(entry=>Math.Abs(middle-entry.Key)))
            {
                count--;
                if(count<0)
                    break;
                parts[pair.Value]+=' ';
            }
            return String.Join("",parts);
        }
    }
}
