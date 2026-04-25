using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaipovMR_01_06
{
    public class Cabel
    {

        private static List<Cabel> _spisok = new List<Cabel>();
        public static List<Cabel> Spisok
        {
            get => _spisok;
        }
        protected string _type;



        protected double _count;


        protected double _d;
        public Cabel(string type, double count, double d)
        {

            _type = type;
            _count= count;
            _d = d;
        }

        public virtual double Q()
        {
            if (!IsValid())
            {
                return -1;
            }
            return _d/_count;
        }
        public virtual bool IsValid()
        {
            if(_count > 0&& _d >0  )
            {
                return true;
            }
            return false;
        }


        public virtual string GetInfo()
        {
            return $"Тип кабеля = {_type} количество жил = {_count} диаметр = {_d}  качество {Q()}";
        }

        public static bool AddToBaseList(Cabel c)
        {
            if(c.IsValid())
            {
                _spisok.Add(c);
                return true;
            }
            return false;
        }

        public static bool RemoveAt(int index)
        {
            if(index> 0 && index <_spisok.Count)
            {
                _spisok.RemoveAt(index);
            }
            return false;
        }

        public static bool RemoveAt (int indexsStart, int indexEnd)
        {
            if(indexsStart>0 && indexsStart< _spisok.Count && indexEnd > 0 && indexEnd < _spisok.Count )
            {
                _spisok.RemoveRange(indexsStart, indexEnd);
                return true;
            }
            return false;
        }
        public static double Average()
        {
            double q = 0;
           for(int i =0; i< _spisok.Count; i++)
            {
                q += _spisok[i].Q();
            }
           q = q/_spisok.Count;
            return q;
        }
    }        
}
