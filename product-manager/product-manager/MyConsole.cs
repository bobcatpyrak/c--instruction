using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace product_manager
{
    class MyConsole
    {
        public static String GetString(String prompt)
        {
            Console.Write(prompt);
            String s = Console.ReadLine();  // read user entry
                                       // Console.ReadLine();  // discard any other data entered on the line
            return s;
        }

        public static String getChoiceString(String prompt, String s1, String s2)
        {
            String s = "";
            bool isValid = false;
            while (!isValid)
            {
                s = getRequiredString(prompt);

                if (!s.Equals(s1) && !s.Equals(s2))
                {
                    Console.WriteLine("Error! Entry must be '" + s1 + "' or '" +
                            s2 + "'. Try again.");
                }
                else
                {
                    isValid = true;
                }
            }
            return s;
        }

        public static String getChoiceString(String prompt, params String[] sa)
        {
            String s = "";
            bool isValid = false;
            while (!isValid)
            {
                s = getRequiredString(prompt);


                foreach (String s1 in sa)
                {
                    String s3 = s1.ToLower();
                    String s2 = s.ToLower();
                    if (s2.Equals(s3))
                        isValid = true;
                }

                if (!isValid)
                    Console.WriteLine("Error! Unrecognized entry!");
            }
            return s;
        }
        public static String getRequiredString(String prompt)
        {
            String s = "";
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                s = Console.ReadLine();
                if (s.Equals(""))
                {
                    Console.WriteLine("Error! This entry is required. Try again.");
                }
                else
                {
                    isValid = true;
                }
            }
            return s;
        }

        public static bool getbool(String prompt)
        {

            String check = getChoiceString(prompt, "true", "false");
            check = check.ToLower();
            if (check.Equals("true"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool getYesOrNo(String prompt)
        {
            
            String check = getChoiceString(prompt, "y", "n");
            check = check.ToLower();
            
            if (check.Equals("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int getInt(String prompt)
        {
            int i = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                try 
                {
                    i = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error! Invalid integer. Try again.");
                }
                Console.ReadLine();  // discard any other data entered on the line
            }
            return i;
        }

        public static int getInt(String prompt, int min, int max)
        {
            int i = 0;
            bool isValid = false;
            while (!isValid)
            {
                i = getInt(prompt);
                if (i < min)
                {
                    Console.WriteLine(
                            "Error! Number must be greater than or equal to " + min + ".");
                }
                else if (i > max)
                {
                    Console.WriteLine(
                            "Error! Number must be less than or equal to " + max + ".");
                }
                else
                {
                    isValid = true;
                }
            }
            return i;
        }

        public static double getDouble(String prompt)
        {
            double d = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                try 
                {
                    d = double.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error! Invalid number. Try again.");
                }
                Console.ReadLine();  // discard any other data entered on the line
            }
            return d;
        }

        public static double getDouble(String prompt, double min, double max)
        {
            double d = 0;
            bool isValid = false;
            while (!isValid)
            {
                d = getDouble(prompt);
                if (d < min)
                {
                    Console.WriteLine(
                            "Error! Number must be greater than or equal to " + min + ".");
                }
                else if (d > max)
                {
                    Console.WriteLine(
                            "Error! Number must be less than or equal to " + max + ".");
                }
                else
                {
                    isValid = true;
                }
            }
            return d;
        }

        public static void println(String s)
        {
            Console.WriteLine(s);
        }
    }
}
