using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShaipovMR_01_06
{
    public class CabelChild: Cabel
    {

        private static List<CabelChild> _spisok = new List<CabelChild>();
        public static List<CabelChild> Spisok
        {
            get => _spisok;
        }

        private double _width;

        public CabelChild (string type, double count, double d, double width) : base(type, count, d)
        {
            _width = width;

        }
        public override double Q ()
        {
            if (!IsValid())
            {
                return -1;
            }
            if(_width> 12 )
            {
                return base.Q() *2.11;
            }
           
                return base.Q() *0.72;
        }
        public override bool IsValid ()
        {
            if (base.IsValid() && _width >0)
            {
                return true;
            }
            return false;
        }


        public override string GetInfo ()
        {
            return $"Тип кабеля = {_type} количество жил = {_count} диаметр = {_d} ширина {_width}  качество {Q()}";
        }


        public static bool AddToChildList (CabelChild cch)
        {
            if (cch.IsValid())
            {
                _spisok.Add(cch);
                return true;
            }
            return false;
        }

        public static bool RemoveAt (int index)
        {
            if (index > 0 && index < _spisok.Count)
            {
                _spisok.RemoveAt(index);
            }
            return false;
        }

        public static bool RemoveAt (int indexsStart, int indexEnd)
        {
            if (indexsStart > 0 && indexsStart < _spisok.Count && indexEnd > 0 && indexEnd < _spisok.Count)
            {
                _spisok.RemoveRange(indexsStart, indexEnd);
                return true;
            }
            return false;
        }
        public static double Average ()
        {
            double q = 0;
            for (int i = 0; i < _spisok.Count; i++)
            {
                q += _spisok[i].Q();
            }
            q = q / _spisok.Count;
            return q;
        }
    }
}
