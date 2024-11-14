namespace AbstractClassesApp.Model
{
    internal class Cat : AbstractAnimal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat says hello");
        }

        //public override void Eat()
        //{
        //    base.Eat();
        //    //Console.WriteLine("Cat is eating");
        //}

        public override string ToString()
        {
            return "Id: " + Id + ", Name: " + Name + ", Age: " + Age;
        }
    }
}
