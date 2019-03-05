using StringUtils.Common.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtils.Menu.Json
{
    class ToJsonUtil
    {
        private static StringDispose stringDispose = new StringDispose();

        public static string ToJson(string str)
        {
            return stringDispose.formatJson(str);
        }
    }
}
