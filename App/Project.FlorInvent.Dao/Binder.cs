using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;

namespace Project.FlorInvent.Dao
{
    public static class Binder
    {
        public static List<TObjectToBind> Bind<TObjectToBind>(IBindable<TObjectToBind> binder, DataTable dt)
        {
            List<TObjectToBind> col = new List<TObjectToBind>();

            foreach (DataRow dr in dt.Rows)
            {
                TObjectToBind item = binder.Bind(dr);
                col.Add(item);
            }
            return col;
        }
    }
}
