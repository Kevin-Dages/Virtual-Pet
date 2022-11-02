using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class RoboPet : Pet
    {
        public int OilLevel { get; set; }  // // bordem 
        public int batteryLevel { get; set; } // hunger
        public int Maintenance { get; set; } //heath

        public RoboPet()
        {
            batteryLevel = 60;
            OilLevel = 60;
            Maintenance = 60;
        }
        public override void Feed()
        {
            batteryLevel -= 10;
        }

        public override void SeeDoctor()
        {
            Maintenance += 30;
        }

        public override void Play()
        {
            Maintenance += 10;
            OilLevel -= 20;
            batteryLevel += 10;
        }

        public override void Tick()
        {
            Maintenance -= 5;
            OilLevel += 5;
            batteryLevel += 5;
        }

        public override string ToStringRepresention()
        {
            return $"Pets Name: {Name}\nPets Battery Level: {batteryLevel} \nPets Oil Level: {OilLevel}\nPets Maintenance: {Maintenance} \n";
        }
    }
}
