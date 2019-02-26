using System;
using System.Collections.Generic;


namespace Segunda_Fase
{
    public class Book : Publication, IVisualizable
    {
        private int id;
        private string isbn;
        private Boolean readed;
        private int timeReaded;

        public Book ()
        {

        }
        public Book (string title, DateTime edititidate, string editorial,string []authors)
        : base (title, edititidate, editorial)
        {
           this.Authors = authors;
        }

        public int Id
        {
            get{return id;}
            set{id = value;}
        }
        public string Isbn
        {
            get{return isbn;}
            set{isbn = value;}
        }
        public Boolean Readed
        {
            get{return readed;}
            set{readed = value;}
        }
        public int TimeReaded
        {
            get{return timeReaded;}
            set{timeReaded = value;}
        }

               
        public DateTime startToSee(DateTime dateI)
        {
            return dateI;
        }

        public void stopToSee(DateTime dateI, DateTime dateF)
        {
            this.TimeReaded = dateF.Second - dateI.Second;
        }

        public override string ToString()
        {
            return $"Book:{this.Isbn}{this.Title}";
        }
        public static List<Book> makeBookList()
        {
            return null;
        }
    }
}