using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Project1.Content;

namespace Project1
{
    internal class Program
    {
        public static int response;
        static void Main(string[] args)
        {

            Intro introduction = new Intro();

            introduction.intro();

            while (true)
            {

                mainMenu mMenu = new mainMenu();
                mMenu.menu();
                response = Convert.ToInt32(Console.ReadLine());

                if(response == 0)
                {
                    break;
                }


                switch (response)
                {
                    case 1:
                        experienceMenu eM = new experienceMenu();
                        eM.menu();
                        response = Convert.ToInt32(Console.ReadLine());
                      
                        switch (response)
                        {
                            case 1:
                                while (true)
                                {
                                    eM.electricianExp();
                                    response = Convert.ToInt32(Console.ReadLine());
                                    if (response == 0)
                                    {
                                        break;
                                    }
                                    Console.WriteLine("Invalid input");
                                }
                                break;
                            case 2:
                                while (true)
                                {
                                    eM.ceridianExperience();
                                    response = Convert.ToInt32(Console.ReadLine());
                                    if (response == 0)
                                    {
                                        break;
                                    }
                                    Console.WriteLine("Invalid input");
                                }
                                break;
                            case 0:
                                break;
                            default:
                                Console.WriteLine("Invalid input");
                                break;

                        }
                        break;

                    case 2:
                        education e = new education();
                        e.menu();
                         response = Convert.ToInt32(Console.ReadLine());

                        switch (response)
                        {
                            case 1:
                                while (true)
                                {
                                    e.FY();
                                    response = Convert.ToInt32(Console.ReadLine());
                                    if(response == 0)
                                    {
                                        break;
                                    }
                                    Console.WriteLine("Invalid input");
                                }

                                break;
                            case 2:
                                while (true)
                                {
                                    e.SY();
                                    response = Convert.ToInt32(Console.ReadLine());
                                    if (response == 0)
                                    {
                                        break;
                                    }
                                    Console.WriteLine("Invalid input");
                                }
                                break;
                            case 0:
                                break;
                            default :
                                Console.WriteLine("Invalid input");
                                break;

                        }
                        break;

                    case 3:
                        while (true)
                        {
                            Skills s = new Skills();
                            s.displaySkills();
                            response = Convert.ToInt32(Console.ReadLine());
                            if (response == 0)
                            {
                                break;
                            }
                            Console.WriteLine("Invalid input");
                        }

                        break;

                    case 4:
                        while (true)
                        {
                            Tskills tskills = new Tskills();
                            tskills.displayTechnologicalSkills();
                            response = Convert.ToInt32(Console.ReadLine());
                            if (response == 0)
                            {
                                break;
                            }
                            Console.WriteLine("Invalid input");
                        }
                        break;

                    case 5:
                        while (true)
                        {
                            contactDetails cD = new contactDetails();
                            cD.displayContact();
                            response = Convert.ToInt32(Console.ReadLine());
                            if (response == 0)
                            {
                                break;
                            }
                            Console.WriteLine("Invalid input");
                        }
                        break;

                    default:

                        Console.WriteLine("Invalid input");
                        break;





                }
                


            }
            Console.WriteLine("Program terminated");



        }
    }
}
