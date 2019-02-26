using System;
using System.Collections.Generic;

namespace Segunda_Fase
{
    public class Magazine : Publication
    {
        
        private int id;

        public Magazine ()
        {

        }
        public Magazine (string title, DateTime date, string editorial) : 
        base (title, date, editorial)
        {
        }
        public static List<Magazine> makeMagazineList()
        {
            return null;
        }

        public override string ToString()
        {
            return $"Magazine:{this.Title}";
        }


    }
}