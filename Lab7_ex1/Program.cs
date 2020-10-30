using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab7_ex1
{
    public class Contact
    {
        public int contactno;
        String contactname;
        String cellno;

        public int ContactNo
        {
            set;

            get;
           
        }

        public String ContactName
        {
            set;

            get;
            
        }

        public String CellNumber
        {
            set;

            get;
           
        }

        

       


        public static void Main(string[] args)
        {
            List<Contact> c1 = new List<Contact>();
            String p = "true";
            while (p != "false")
            {

                Console.WriteLine("Enter the choice\n1 for add\n2 for display\n3 for edit\n4 for show all");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {

                            Console.Write("Enter number of contacts to be added:");
                            int num = int.Parse(Console.ReadLine());
                            for (int i = 0; i < num; i++)
                            {
                                Console.WriteLine("Enter details like contact no, contact name and cell number of contact {0}", i + 1);
                                c1.Add(
                                    new Contact()
                                    {
                                        contactno = int.Parse(Console.ReadLine()),
                                        contactname = Console.ReadLine(),
                                        
                                    }


                                );
                            }

                            break;
                        }

                    case 2:
                        {
                            Console.Write("Enter contact number of person to be displayed:");
                            int n = int.Parse(Console.ReadLine());
                            for (int i=0;i<c1.Count;i++)
                            {
                                if (c1[i].contactno == n)
                                {
                                    Console.WriteLine("Contact number is: {0}",c1[i].contactno);
                                    Console.WriteLine("Contact name is: {0}",c1[i].contactname);
                                    Console.WriteLine("Cell number is: {0}",c1[i].cellno);
                                }
                               
                               
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.Write("Enter contact no of person to be modified:");
                            int x = int.Parse(Console.ReadLine());
                            for(int i = 0; i < c1.Count; i++)
                            {
                                if (c1[i].contactno == x)
                                {
                                    Console.Write("Enter modified name:");
                                    String str = Console.ReadLine();
                                    Console.Write("Enter modified cell number:");
                                    String str1 = Console.ReadLine();
                                    c1[i].contactname = str;
                                    c1[i].cellno = str1;
                                }
                                
                            }

                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Contact details are:");
                            for(int i=0;i<c1.Count;i++)
                            {
                                Console.WriteLine("Contact number is: {0}", c1[i].contactno);
                                Console.WriteLine("Contact name is: {0}", c1[i].contactname);
                                Console.WriteLine("Cell number is: {0}", c1[i].cellno);
                            }
                            break;
                        }
                }
                Console.WriteLine("Change p value to false to terminate the program");
                Console.Write("p is:");
                p = Console.ReadLine();
            }

            Console.ReadLine();

        }
    }
}
