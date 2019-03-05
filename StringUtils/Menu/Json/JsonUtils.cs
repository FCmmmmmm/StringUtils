using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtils.Menu.Json
{
    class JsonUtils
    {
        /**
    * 单位缩进字符串。
    */
        private static String SPACE = "   ";

        /**
         * 返回格式化JSON字符串。
         * 
         * @param json 未格式化的JSON字符串。
         * @return 格式化的JSON字符串。
         */
        public String formatJson(String json)
        {
            StringBuilder result = new StringBuilder();

            int length = json.Length;
            int number = 0;
            char key = (char)0;

            //遍历输入字符串。
            for(int i = 0 ; i < length ; i++)
            {
                //1、获取当前字符。
                key = json[i];

                //2、如果当前字符是前方括号、前花括号做如下处理：
                if((key == '[') || (key == '{'))
                {
                    //（1）如果前面还有字符，并且字符为“：”，打印：换行和缩进字符字符串。
                    if((i - 1 > 0) && (json[i-1] == ':'))
                    {
                        result.Append('\r');
                        result.Append('\n');
                        result.Append(indent(number));
                    }

                    //（2）打印：当前字符。
                    result.Append(key);

                    //（3）前方括号、前花括号，的后面必须换行。打印：换行。
                    result.Append('\r');
                    result.Append('\n');

                    //（4）每出现一次前方括号、前花括号；缩进次数增加一次。打印：新行缩进。
                    number++;
                    result.Append(indent(number));

                    //（5）进行下一次循环。
                    continue;
                }

                //3、如果当前字符是后方括号、后花括号做如下处理：
                if((key == ']') || (key == '}'))
                {
                    //（1）后方括号、后花括号，的前面必须换行。打印：换行。
                    result.Append('\r');
                    result.Append('\n');

                    //（2）每出现一次后方括号、后花括号；缩进次数减少一次。打印：缩进。
                    number--;
                    result.Append(indent(number));

                    //（3）打印：当前字符。
                    result.Append(key);

                    //（4）如果当前字符后面还有字符，并且字符不为“，”，打印：换行。
                    if(((i + 1) < length) && (json[i + 1] != ','))
                    {
                        result.Append('\r');
                        result.Append('\n');
                    }

                    //（5）继续下一次循环。
                    continue;
                }

                //4、如果当前字符是逗号。逗号后面换行，并缩进，不改变缩进次数。
                if((key == ','))
                {
                    result.Append(key);
                    result.Append('\r');
                    result.Append('\n');
                    result.Append(indent(number));
                    continue;
                }

                //5、打印：当前字符。
                result.Append(key);
            }

            return result.ToString();
        }

        /**
         * 返回指定次数的缩进字符串。每一次缩进三个空格，即SPACE。
         * 
         * @param number 缩进次数。
         * @return 指定缩进次数的字符串。
         */
        private String indent(int number)
        {
            StringBuilder result = new StringBuilder();
            for(int i = 0 ; i < number ; i++)
            {
                result.Append(SPACE);
            }
            return result.ToString();
        }
    }
}
