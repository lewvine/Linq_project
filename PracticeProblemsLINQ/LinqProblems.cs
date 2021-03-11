using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    public static class LinqProblems
    {
        //Weighted project points: /10
        //Project points: /25
       
        #region Problem 1 
        //(5 points) Problem 1
        //Using LINQ, write a method that takes in a list of strings and returns 
        //all words that contain the substring “th” from a list.
        public static List<string> RunProblem1(List<string> words)
        {
            //code
            List<string> result = words.FindAll(w => w.Contains("th"));

            foreach (var word in result)
            {
                Console.WriteLine(word);
                Console.ReadLine();
            }
            return result;
            //return

        }
        #endregion

        #region Problem 2 
        ////(5 points) Problem 2
        ////Using LINQ, write a method that takes in a list of strings and returns a copy of the list without duplicates.
        public static List<string> RunProblem2(List<string> names)
        {
            //code
            var result = names.Distinct().ToList();

            foreach(var name in result)
            {
                Console.WriteLine("Problem #2: " + name);
                Console.ReadLine();
            }

            return result;

        }
        #endregion

        #region Problem 3
        ////(5 points) Problem 3
        ////Using LINQ, write a method that takes in a list of customers and returns the lone customer who has the name of Mike. 
        public static Customer RunProblem3(List<Customer> customers)
        {
            //code
            Customer result = customers.Find(cust => cust.FirstName == "Mike");

            //Double checking functionality
            Console.WriteLine("Problem #3: " + result.FirstName);

            //Returning a Customer object
            return result;
        }
        #endregion

        #region Problem 4
        //////(5 points) Problem 4
        //////Using LINQ, write a method that takes in a list of customers and returns the customer who has an id of 3. 
        //////Then, update that customer's first name and last name to completely different names and return the newly updated customer from the method.
        public static Customer RunProblem4(List<Customer> customers)
        {
            var result = customers.Find(cust => cust.Id == 3);

            result.FirstName = "Billy";
            result.LastName = "Joel";

            //Double checking functionality
            Console.WriteLine("Problem #4: " + result.LastName + result.FirstName);
            Console.ReadLine();

            //Returning a Customer object.
            return result;

        }
        #endregion

        #region Problem 5
        ////(5 points) Problem 5
        ////Using LINQ, write a method that calculates the class grade average after dropping the lowest grade for each student.
        ////The method should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), 
        ////drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
        ////Expected output: 86.125
        public static double RunProblem5(List<string> classGrades)
        {
            double[] classGradesAverage = new double[classGrades.Count];

            for (var i = 0; i < classGrades.Count; i++)
            {
                //Convert each string of numbers into a new string array split by ,
                string[] classGradesSep = classGrades[i].Split(',');
                double[] classGradesArray = new double[classGradesSep.Length];
                double count = 0;
                double total = 0;

                //Iterate through each number in the new int array.
                for(var j = 0; j < classGradesArray.Length; j++) 
                {
                    //First convert each string number to an integer.
                    classGradesArray[j] = Convert.ToInt32(classGradesSep[j]);
                    //Then add the total to the total.
                    total += classGradesArray[j];
                    //Then increment count.
                    count += 1;
                }
                //Find the minimum value of the new int array.
                var min = classGradesArray.Min();

                //Subtract the minimum value from the total.
                total -= min;

                //Subtract one from the count.
                count -= 1;

                //This average should now not factor in the value of the minumum integer.
                double average = total / count;

                //Make the average for this specific int array as the the value for classGradesAverage[i];
                classGradesAverage[i] = average;
            }

            double totalTotal = 0;

            //Once each string array has been converted to an int, the min value of it is removed, and it's average has been factored,
            //Find the average of averages.

            for (
                var i = 0; i < classGrades.Count; i++)
            {
                totalTotal += classGradesAverage[i];
            }
            double answer = totalTotal / classGrades.Count;
            Console.WriteLine("Problem #5: " + answer);
            Console.ReadLine();
            return answer;
            
            //return

        }
        #endregion

        //#region Bonus Problem 1
        ////(5 points) Bonus Problem 1
        ////Write a method that takes in a string of letters(i.e. “Terrill”) 
        ////and returns an alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1")
        //public static string RunBonusProblem1(string word)
        //{
        //    //code

        //    //return

        //}
        //#endregion
    }
}
