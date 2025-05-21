using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day6classDemo1
{
    public class Person
    {
        //public int _age;
        //public string _gender;

        private int _age; //field
        public int Age  //property
        {
            get { return _age; }

            set {

                if (value < 0 || value >= 120)
                {
                    value = 20;  // set the default value=20
                }

                _age = value;



            }
        
        }


        private string _gender;

        public string Gender
        {
            get { return _gender; }

            set {
                if (value != "male" || value != "female")
                {
                    value = "male"; // set default value to male
                }

                _gender = value;
            
            
            
            }
        
        
        }



        public void Speak()
        {

            Console.WriteLine("I am talking");
        }


    }
}
