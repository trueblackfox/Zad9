using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UCH_PRCT_9
{
    class Head
    {//класс для списка с информационным полем int
        int info;//информационное поле
        Head next;//адресное поле

        //свойства
        public int Info
        {
            get { return info; }
            set { info = value; }
        }
        public Head Next
        {
            get { return next; }
            set { next = value; }
        }

        //конструкторы
        public Head()//конструктор без параметров
        {
            info = default(int);
            next = null;
        }


        public override string ToString()
        {
            return info + " ";
        }
    }
}
