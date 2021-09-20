namespace Module6Lecture
{
    public class Pet
    {
        private int age;
        private string petName;

        public Pet(string petName, int age)
        {
            this.petName = petName;
            this.age = age;
        }

        public string PetName
        {
            get => petName;
            set => petName = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }
        
    }
}