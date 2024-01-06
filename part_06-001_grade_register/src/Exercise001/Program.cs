namespace Exercise001
{
    public class Program
    {
        public static void Main(string[] args)
        {
             //Section 01
            GradeRegister register = new GradeRegister();

            // register.AddGradeBasedOnPoints(93);
            // register.AddGradeBasedOnPoints(91);
            // register.AddGradeBasedOnPoints(92);
            // register.AddGradeBasedOnPoints(88);

            // Console.WriteLine(register.AverageOfGrades());

            // //Section 02
            // register.AddGradeBasedOnPoints(93);
            // register.AddGradeBasedOnPoints(91);
            // register.AddGradeBasedOnPoints(92);

            // Console.WriteLine(register.AverageOfPoints());


            //Section 03
            UserInterface ui = new UserInterface(register);
            ui.Start();
        }
    }
}