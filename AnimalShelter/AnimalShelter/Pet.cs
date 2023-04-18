using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public  class Pet
    {
        // private가 아닌 것들은 상속받을 수 있다.
        public int PatId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;

        public Pet(int petId, string name, string color, string gender)
        {
            this.PatId = petId;
            this.Name = name;
            this.Color = color;
            this.Gender = gender;
        }

        // virtual을 붙였을 경우 자식 클래스에서 재정의된 메소드가 존재하면 그 메소드를 호출한다.
        public virtual string MakeSound()
        {
            return "";
        }
    }
}
