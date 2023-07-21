namespace Lectia16_2_class_library
{
    public class Persoana
    {
        public string Public { get; set; }

        private string Private { get; set; }

        protected string Protected { get; set; }

        internal string Internal { get; set; }

        protected internal string ProtectedInternal { get; set; }

        public void Info()
        {
            Console.WriteLine(Public);
            Console.WriteLine(Private);
            Console.WriteLine(Protected);
            Console.WriteLine(Internal);
            Console.WriteLine(ProtectedInternal);
        }
    }

    public class Student : Persoana
    {
        public void InfoStudent()
        {
            Console.WriteLine(Public);
            Console.WriteLine(Private);
            Console.WriteLine(Protected);
            Console.WriteLine(Internal);
            Console.WriteLine(ProtectedInternal);
        }
    }
}