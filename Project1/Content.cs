using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Content
    {

        public class Intro
        {  
            public void intro()
            {
                  Console.WriteLine("Hi, my name is Ashfaaq Muaaz Jowaheer, \n" +
                               "I am currently a level 2 software engineering student \n" +
                               "at the university of Mauritius, this is my C# console \n"
                               +"application of my CV");
                
            }
            
        }

        public interface Menu
        {
             void menu();
            
           
        }

        public class mainMenu : Menu    
        {
           
           
            public void menu()
            {
                
                 
                Console.WriteLine("******CV MENU*******");
                Console.WriteLine("1.Display experience\n" 
                                 +"2.Display education\n"
                                 +"3.Display skills\n"
                                 +"4.Display technological skills\n"
                                 +"5.Contact details\n"
                                 +"0.Exit");
                Console.WriteLine("Please input your choice(1-5): ");

            }
        }

        public class experienceMenu : Menu
        {
            public void menu()
            {
                Console.WriteLine("******EXPERIENCE MENU*******");
                Console.WriteLine("1.Display trainee electrician experience\n"
                                 +"2.Display intern experience at Ceridian\n"
                                 +"0.Back");
                Console.WriteLine("Please input your choice(1-2): ");

            }

            public void electricianExp()
            {
                Console.WriteLine("******ELECTRICIAN EXPERIENCE*******");
                Console.WriteLine();
                Console.WriteLine(".Worked as a trainee electricain at TEZ \n"
                                 +"(Sept 2019 - June 2020)");
                Console.WriteLine();
                Console.WriteLine("0.Back");
            }

            public void ceridianExperience()
            {
                Console.WriteLine("******CERIDIAN INTERN EXPERIENCE*******");
                Console.WriteLine();
                Console.WriteLine(".Performed an internship training at Ceridian,\n"
                                 +"whereby I followed a training program called \n"
                                 +"JEDI training for 1 month and then a process \n "
                                 +"imersion program to get familiar with \n"
                                 +"the various tools and framework used by Ceridian\n"
                                 +"(05/09/22 - 11/11/22)");
                Console.WriteLine();
                Console.WriteLine("0.Back");
            }
        }

        public class education : Menu
        {
            public void menu()
            {
                Console.WriteLine("******EDUCATION MENU*******");
                Console.WriteLine("1.First year of Bsc Software Engineering\n"
                                 +"2.Second year of Bsc Software Engineering\n"
                                 +"0.Back");
                                 
                Console.WriteLine("Please input your choice(1-2): ");

            }

            public void FY()
            {

                Console.WriteLine("******FIRST YEAR SOFTWARE ENGINEERING*******");
                Console.WriteLine();
                Console.WriteLine("1.Discrete Structures\n"
                                 + "2.Database System\n"
                                 + "3.Software Engineering principle\n"
                                 + "4.Software Analysis and Modelling\n"
                                 + "5.Programming\n"
                                 + "Projects worked on:\n"
                                 + "1.C# game using unity\n"
                                 + "2.SRS\n"
                                 + "3.Implementing Dikjstra's Algo\n"
                                 + "4.Implementing Finite State Machine\n");
                Console.WriteLine();
                Console.WriteLine("0.Back");
            }
            public void SY()
            {

                Console.WriteLine("******SECOND YEAR SOFTWARE ENGINEERING*******");
                Console.WriteLine();
                Console.WriteLine("1.Data Structures and Algorithm\n"
                                 +"2.Object Oriented Software Development\n"
                                 +"3.Software Project Management\n"
                                 +"4.Software Verification and Validation\n"
                                 +"5.Web Application Development\n"
                                 +"6.Interactive System Design\n"
                                 + "Projects worked on:\n"
                                 + "1.Archery website\n"
                                 + "2.MoMetro(Mobile App) \n"
                                 + "3.Black Box testing\n"
                                 + "4.White Box testing\n"
                                 + "5.Java gui with database connection");
                Console.WriteLine();
                Console.WriteLine("0.Back");
            }
           
        }

        public class Skills
        {

            public void displaySkills()
            {
                Console.WriteLine("******SKILLS*******");
                Console.WriteLine();
                Console.WriteLine("1.Team player\n"
                                 + "2.Problem solving\n"
                                 + "3.Creative thinking\n"
                                 + "4.Team management\n"
                                 + "5.Design thinking");
                Console.WriteLine();
                Console.WriteLine("0.Back");
            }

        }

        public class Tskills
        {
            public void displayTechnologicalSkills()
            {
                Console.WriteLine("******TECHNOLOGICAL SKILLS*******");
                Console.WriteLine();
                Console.WriteLine("1.Skilled in OOP\n"
                                 + "2.C++, java, html, css, javascript, php, XML, XSD, XSLT, Kotlin \n"
                                 + "3.3D modeling\n"
                                 + "4.UI design with Figma");
                Console.WriteLine();
                Console.WriteLine("0.Back");
            }
        }

        public class contactDetails
        {
            public void displayContact()
            {
                Console.WriteLine("******CONTACT DETAILS*******");
                Console.WriteLine();
                Console.WriteLine("1.Phone number:59143722\n"
                                 + "2.Mail:Ashfaaqmuaaz29@gmail.com");
                Console.WriteLine();
                Console.WriteLine("0.Back");
            }
        }
        




    }
}
