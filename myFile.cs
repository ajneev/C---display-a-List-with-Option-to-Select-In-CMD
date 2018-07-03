using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3W3
{


    class Program
    {
        static void Main(string[] args)
        {
            //Create my Student List
            List<SstudentModel> myStudentList = new List<SstudentModel>();

            myStudentList.Add(new SstudentModel

            {
                Id = "1",
                FisrtName = "Min Chul",
                LastName = "Shin",
                DOB = new DateTime(2010,01,01),
                Gender = "Male"

            });
            myStudentList.Add(new SstudentModel

            {
                Id = "2",
                FisrtName = "Nicky",
                LastName = "Lauren",
                DOB = new DateTime(2009,01,01),
                Gender = "Female"

            });
            myStudentList.Add(new SstudentModel

            {
                Id = "3",
                FisrtName = "Amy",
                LastName = "Park",
                DOB = new DateTime(2008,01,01),
                Gender = "Female"

            });
            myStudentList.Add(new SstudentModel

            {
                Id = "4",
                FisrtName = "Aurelie",
                LastName = "Adair",
                DOB = new DateTime(2007,01,01),
                Gender = "Female"

            });

           // Codes to Print for Gathering User Info
            foreach (var myStd in myStudentList)
            {
                Console.WriteLine(myStd.Id + "\t" + myStd.FisrtName + "\t" + myStd.LastName + "\t" + myStd.DOB + "\t" + myStd.Gender);
            }
            Outer:
            Console.WriteLine("Please choose one of the options");
            Console.WriteLine("1) Search by  First Name ?");
            Console.WriteLine("2) Search by  Date Of Brith ?");
            
            var myNum = Console.ReadLine(); // User Option to enter the choices 
            Console.WriteLine("You have selected Option {0}", myNum);
           

            if (int.TryParse(myNum, out int number1))
            {

                if (number1 == 1) //Option 1 Name is Selected
                {
                    Console.WriteLine("1 is the option selected");
                    Console.WriteLine("Type the First Name");
                     var myFirstNam = Console.ReadLine(); // User Option to enter the First Name
                    Console.WriteLine("Type the Last Name");
                    var myLastNam = Console.ReadLine(); // User Option to enter the Last Name
                    Console.WriteLine("Fullname selected is {0} {1}", myFirstNam, myLastNam);
                    var resultUsnName = myStudentList.Where(X => X.FisrtName == myFirstNam && X.LastName == myLastNam);
                    if (resultUsnName.Count() > 0) // Checking for Name Query Database Result is not 0
                    {

                        foreach (var UsnName in resultUsnName)
                        {
                            Console.WriteLine("Name: {0} {1} DOB: {2} Gender: {3}", UsnName.FisrtName, UsnName.LastName, UsnName.DOB, UsnName.Gender);
                        }
                    }
                    else
                    { // Condition  for Name Query -NO Results found

                        Console.WriteLine("Please enter a correct name in the database");
                        goto Outer;
                    }
                    


                }
                else if (number1 == 2) //Option 2 DOB is Selected
                {

                    Console.WriteLine("2 is the option selected");
                  
                    Console.WriteLine("Please type the Date of Birth");
                    var myDateOfBrith = Console.ReadLine(); // User Option to enter the DOB
                   // Console.WriteLine(myDateOfBrith);
                    DateTime myDateOfBirth = DateTime.Parse(myDateOfBrith);
                    //Console.WriteLine(myDateOfBirth);
                   //Console.WriteLine("Fullnaam is {0} {1}", myFirstNam, myLastNam);
                   // Where(s => s.date_Closed.Date <= d.Date);
                   var resultUsnDOB = myStudentList.Where( X=> X.DOB == myDateOfBirth);
                    if (resultUsnDOB.Count() > 0) // Checking for DOB Query Database Result is not 0
                    {
                        foreach (var UsnDOB in resultUsnDOB)
                        {
                            Console.WriteLine("Name: {0} {1} DOB: {2} Gender: {3}", UsnDOB.FisrtName, UsnDOB.LastName, UsnDOB.DOB, UsnDOB.Gender);
                        }
                    }
                    else

                    {   // Condition  for DOB Query -NO Results found
                        Console.WriteLine("Please enter a correct date of birth in the database");
                        goto Outer;
                    }
                }
                else { // Condition for Another  Number Option 
                    Console.WriteLine($"{myNum} is not an option here");
                    goto Outer;
                }

            }
            else
            {   // Condition for Non- Number( character) Option ( Also for null)
                Console.WriteLine($"{myNum} is not an option here");
                goto Outer;
            }
           // Console.WriteLine($"The value of the variable {nameof(number1)} is {number1}");
          
            Console.ReadLine();

        }
    }


   


    public class SstudentModel
    {
        public string Id { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
    }




}
