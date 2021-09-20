namespace Module6Lecture
{
    public class Pet
    {
        private int age;
        private string petName;
        private int _age;
        private string _petName;
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


        /*
         * These getters amd setters need to use the " _variabel_name " fields
         * with the underscore. Properties will hide the private variables all together
         * this class correctly represents the getters, setters but NOT properties
         */
        public void SetPetName(string petName)
        {
            _petName = petName;
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
            _age = age;
        }
    }
}