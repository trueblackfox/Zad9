using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCH_PRCT_9
{
    class Point2
    {//класс для списка с информационным полем Head
        Head info;//информационное поле
        Point2 next;//адресное поле

        //свойства
        public Head Info
        {
            get { return info; }
            set { info = value; }
        }
        public Point2 Next
        {
            get { return next; }
            set { next = value; }
        }

        //конструкторы

        public Point2()//конструктор без параметров
        {
            info = null;
            next = null;
        }
    }
}
