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


        public void SetPetName(string petName)
        {
            this.petName = petName;
        }

        public string GetPetName()
        {
            return this.petName;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
    }
}