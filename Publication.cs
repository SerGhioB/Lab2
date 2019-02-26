using System;
using System.Collections.Generic;

namespace Segunda_Fase
{
    public  abstract class Publication
    {
     
        private string title;
        private DateTime edititidate;
        private string editorial;
        private string [] authors;        
        

        public Publication ()
        {

        }
        public Publication (string title, DateTime edititidate, string editorial)
        {
            this.Title = title;
            this.Edititidate = edititidate;
            this.Editorial = editorial;
            
        }
        
        public string Title
        {
            get {return title;}
            set{title = value;}
        }
        public DateTime Edititidate
        {
            get {return edititidate;}
            set{edititidate = value;}
        }
        public string Editorial
        {
            get {return editorial;}
            set{editorial = value;}
        }

        public string [] Authors
        {
            get {return authors;}
            set{authors = value;}
        }

    }
}