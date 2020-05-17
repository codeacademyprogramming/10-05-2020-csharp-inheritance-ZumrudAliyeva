using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_second
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the keyword");
            string str = Console.ReadLine();
            DocumentProgram docprogram = new DocumentProgram();
            switch (str)
            {
                case "basic":
                    docprogram = new DocumentProgram();
                    docprogram.OpenDocument();
                    docprogram.EditDocument();
                    docprogram.SaveDocument();
                    break;
                case "pro":
                    docprogram = new ProDocument();
                    docprogram.OpenDocument();
                    docprogram.EditDocument();
                    docprogram.SaveDocument();
                    break;
                case "expert":
                    docprogram = new ExpertDocument();
                    docprogram.OpenDocument();
                    docprogram.EditDocument();
                    docprogram.SaveDocument();
                    break;
                default:
                    Console.WriteLine("Invalid keyword");
                    break;
            }

        }
    }

    class DocumentProgram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert version");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert version");
        }
    }

    class ProDocument : DocumentProgram
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }
    }
    class ExpertDocument : ProDocument
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }

}
