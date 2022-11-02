using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public  Pet()
        {
         
        }
        public abstract void Feed();


        public abstract string ToStringRepresention();

        public abstract void SeeDoctor();


        public abstract void Play();


        public abstract void Tick();
        

    }
}
