using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCH_PRCT_9
{
    class Program
    {
        static int Readint(string msg)
        {// Ввод целого числа с проверкой
            int number; bool ok;// переменная для проверки
            do
            {
                Console.Write(msg);
                ok = int.TryParse(Console.ReadLine(), out number);
                if (!ok) Console.WriteLine("Неверный ввод!");
            } while (!ok);// конец проверки
            return (number);
        }
        static Head MadeHead(int N)
        {//заполняем исходный список
            Head list = new Head();
            Head beg = new Head();
            beg = list;
            for (int i = 0; i < N; i++)
            {
                beg.Info = Readint("Введите элемент:");
                beg.Next = new Head();
                beg = beg.Next;
            }
            return list;
        }

        static void WriteHead(Head list)
        {//функция вывода на экран списка типа исходного (инф поле - int)
            Head beg = new Head();
            beg = list;
            while (beg.Next != null)
            {
                Console.Write(beg);
                if (beg.Next.Next != null) Console.Write(" --> ");
                beg = beg.Next;
            }
        }

        static void WriteList(Point2 list)
        {//функция для вывода на экран искомых списков
            if (list.Info != null)
            {
                Point2 beg = new Point2();
                beg = list;
                while (beg.Next != null)
                {
                    Console.Write(beg.Info + "(");
                    WriteHead(beg.Info);
                    Console.Write(")");
                    if (beg.Next.Next != null) Console.Write(" --> ");
                    beg = beg.Next;
                }
                Console.WriteLine();
            }
            else Console.WriteLine("Список пустой");
        }

        static void MadeLists(Head head)
        {//процедура создания двух списков с информационными полями, ссылающимися на элементы списка head
            Point2 Pos = new Point2();
            Point2 PosBeg = new Point2();
            PosBeg = Pos;
            Point2 Neg = new Point2();
            Point2 NegBeg = new Point2();
            NegBeg = Neg;
            Head beg = new Head();
            beg = head;
            while (beg != null)
            {
                if (beg.Info > 0)
                {
                    PosBeg.Info = beg;
                    PosBeg.Next = new Point2();
                    PosBeg = PosBeg.Next;
                }
                if (beg.Info < 0)
                {
                    NegBeg.Info = beg;
                    NegBeg.Next = new Point2();
                    NegBeg = NegBeg.Next;
                }
                beg = beg.Next;

            }
            Console.WriteLine("Pos:");
            WriteList(Pos);
            Console.WriteLine("Neg:");
            WriteList(Neg);
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("В программе построен линейный список. Напишите процедуру, создающую два новых линейных списка: список, включающий все положительные значения из элементов исходного списка, и список, включающий все отрицательные значение из элементов исходного списка; при включении элементов в новые списки, они удаляются из исходного списка.");
            Console.ResetColor();
            do
            {
                int N;
                do
                {
                    N = Readint("Введите количество элементов в исходном списке: ");
                    if (N <= 0) Console.WriteLine("Неверный ввод!");
                } while (N <= 0);
                Head head = new Head();
                head = MadeHead(N);
                MadeLists(head);
                Console.ReadLine();
            } while (true);
        }
    }
}
