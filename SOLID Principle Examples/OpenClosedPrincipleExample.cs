using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string SavePath = string.Empty;


            // Without OCP Example
            WithoutOCP_Document _WithoutOCP_Document = new WithoutOCP_Document();
            SavePath = _WithoutOCP_Document.DocumentSavePath(DocumentType.Word);
            Console.WriteLine(SavePath);
            SavePath = _WithoutOCP_Document.DocumentSavePath(DocumentType.PDF);
            Console.WriteLine(SavePath);
            //Console.ReadLine();

            // With OCP Example
            WithOCP_Document _WithOCP_Document;

            _WithOCP_Document = new WordDocument();
            SavePath = _WithOCP_Document.DocumentSavePath(DocumentType.Word);
            Console.WriteLine(SavePath);

            _WithOCP_Document = new PDFDocument();
            SavePath = _WithOCP_Document.DocumentSavePath(DocumentType.PDF);
            Console.WriteLine(SavePath);

            // With OCP Example with abstract class
            WithOCP_DocumentAbs _WithOCP_DocumentAbs;

            _WithOCP_DocumentAbs = new WordDocument2();
            SavePath = _WithOCP_DocumentAbs.DocumentSavePath(DocumentType.Word);
            Console.WriteLine(SavePath);

            Console.ReadLine();
        }
    }

    public enum DocumentType
    {
        PDF,
        Word
    }


    public abstract class WithOCP_DocumentAbs
    {
        public virtual string DocumentSavePath(DocumentType _DocumentType)
        {
            return string.Empty;
        }
    }

    public class WordDocument2 : WithOCP_DocumentAbs
    {
        public override string DocumentSavePath(DocumentType _DocumentType)
        {
            return @"Files/MSWord";
        }
    }

    public class PDFDocument2 : WithOCP_DocumentAbs
    {
        public override string DocumentSavePath(DocumentType _DocumentType)
        {
            return @"Files/PDF";
        }
    }


    public class WithOCP_Document
    {
        public virtual string DocumentSavePath(DocumentType _DocumentType)
        {
            return string.Empty;
        }
    }

    public class WordDocument : WithOCP_Document
    {
        public override string DocumentSavePath(DocumentType _DocumentType)
        {
            return @"Files/MSWord";
        }
    }

    public class PDFDocument : WithOCP_Document
    {
        public override string DocumentSavePath(DocumentType _DocumentType)
        {
            return @"Files/PDF";
        }
    }

    public class WithoutOCP_Document
    {
        public string DocumentSavePath(DocumentType _DocumentType)
        {
            string SavePath = string.Empty;
            if (_DocumentType == DocumentType.PDF)
            {
                SavePath = @"Files/PDF";
            }
            else if (_DocumentType == DocumentType.Word)
            {
                SavePath = @"Files/MSWord";
            }
            return SavePath;
        }
    }
}
