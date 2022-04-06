using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandB
{
    public class Editor
    {
        public string text = "asdahdfggfjsadfasdgasdf";

        public string GetSelection(int startingpoint, int endpoint)
        {
            var slicedstring = "";
            for (int i = startingpoint; i < endpoint - startingpoint; i++)
            {
                slicedstring += text[i];
            }
            return slicedstring;
        }

        //public string DeleteSelection(int startingpoint, int endpoint)
        //{
        //    for (int i = startingpoint; i < endpoint - startingpoint; i++)
        //    {
        //        text.Remove(startingpoint, endpoint - startingpoint);
        //    }
        //    return text;
        //}
    }
}
