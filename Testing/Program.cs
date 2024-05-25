using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch
            Console.WriteLine("Enter The indicated number For Project");

            int ProjectType = int.Parse(Console.ReadLine());
            switch (ProjectType)
            {
                case 1:
                    Console.WriteLine("Residential");
                    break;
                case 2:
                    Console.WriteLine("Commercial");
                    break;
                case 3:
                    Console.WriteLine("Industrial");
                    break;
                default:
                    Console.WriteLine("Infrastructure");
                    break;


            }
            #endregion
            #region List
            List<string> ProjectList = new List<string>();
            string ProjectNames = "Concrete,Structural,Industrial";
            string[] texts = ProjectNames.Split(',');
            foreach (string text in texts)
            {
                Console.WriteLine(ProjectList);
                ProjectList.Add(text);

            }
            #endregion
            Console.WriteLine("Enter The Budget OF Project");
           int ProjectBudget = Convert.ToInt32(Console.ReadLine());
            if (ProjectBudget < 500000)
            {
                Console.WriteLine("Small Project");
            }
                if (ProjectBudget >= 500000 && ProjectBudget < 1000000)
                {
                    Console.WriteLine("medium Project");
                }
                   
                else
                {
                    Console.WriteLine("Large Project");
                        }
            }


        }
    }

