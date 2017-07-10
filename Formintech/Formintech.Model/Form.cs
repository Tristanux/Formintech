using System;

namespace Formintech.Model
{
    public class Form
    {
        string _name;



        public Form(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
