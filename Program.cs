namespace LectureEx_InterfaceAndIEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - an interface is a blueprint for a class. it defines a set
            //of methods or properties that a class must implement

            //2 - interfaces are useful for abstraction and multiple inheritance

            //3 - you create an interface by using 'interface'
            //keyword followed by the name of the interface

            //4a - an interface feild must have implicity public, static and readonly

            //4b - and it must not have implementation 

            //5 - to call an interface field you need to use the
            //interface name followed by the field name

            //6 - IEnumerable works wiht foreach loop


            // Create a ClassRoster instance
            ClassRoster prog124 = new ClassRoster();

            // Add students to the class roster
            prog124.AddStudent(new Door());
            prog124.AddStudent(new Bottle());
            prog124.AddStudent(new Chest());

            // Using foreach to display student information
            foreach (var student in prog124)
            {
                // Assuming the student objects have an Open method
                (student as IOpen)?.Open();

            }



        }
            
    }
}