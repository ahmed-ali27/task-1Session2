namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region MyVaribels

            string nameStudent = "AHmed_Ali";
            int age = 22;
            double gpa = 3.8;
            Console.WriteLine($"Name: {nameStudent} Age: {age} Gpa: {gpa}");
            #endregion

            //Student std01 = new Student();
            //std01.Id = 22;
            //std01.Name = "Ali";
            //Console.WriteLine(std01.Id);
            //Console.WriteLine(std01.Name);


            //#region Try Catch
            //try
            //{

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //#endregion
            int[] arryStudents = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(arryStudents.Length);


        }
    }
}
