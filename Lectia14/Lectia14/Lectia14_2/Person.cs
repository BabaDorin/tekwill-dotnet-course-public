namespace Lectia14_2
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name 
        { 
            get 
            { 
                return name;
            } 
            set 
            {
                if (value == null)
                {
                    throw new Exception();
                }

                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }

                age = value;
            }
        }
    }
}
