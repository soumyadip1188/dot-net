using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("hello world");
            string name = "Soumyadip";
            int age = 21;
            double d1 = age;
            char c = 'a';
            double d = 23.45;
            int i = (int) d;
            bool b1 = true;
            Console.WriteLine(name + "Das");
            Console.WriteLine(age);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(d1);
            Console.WriteLine(b1);
            Console.WriteLine(i);
            Console.WriteLine(Convert.ToString(b1));
             */

            /* Console.WriteLine("enter your name");
             String user=Console.ReadLine();
             Console.WriteLine("hii " + user);
             Console.ReadLine();
             * */

            /* Console.WriteLine("enter your age");
             int age = Convert.ToInt32(Console.ReadLine()); //everything will be taken as a string in c# so, we need to typecasting the string to int
             Console.WriteLine("hii " + age);
             Console.ReadLine();
             * */

            /* Console.WriteLine("enter two number");
             int a = Convert.ToInt32(Console.ReadLine());
             int b = Convert.ToInt32(Console.ReadLine());
             int c = a + b;
             Console.WriteLine("The addition is " + c);
             Console.ReadLine();*/

            /*Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");
            Console.ReadLine();
             * */

            /*  Console.WriteLine("enter the two variable");
              int a = Convert.ToInt32(Console.ReadLine());
              int b = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Before swapping the values are" + a +" "+ b);
              a = a + b;
              b = a - b;
              a = a - b;
              Console.WriteLine("after Swapping the values are" + a +" "+ b);
              Console.ReadLine();
             */

            /*Console.WriteLine("enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 100 != 0 && year % 4 == 0 )|| year % 400 == 0)
                Console.WriteLine("leap year");
            else
                Console.WriteLine("not leap year");
            Console.ReadLine();
             * */

            /* Console.WriteLine("enter two number");
             int a = Convert.ToInt32(Console.ReadLine());
             int b = Convert.ToInt32(Console.ReadLine());
             int c = Math.Max(a, b);
             int d = Math.Min(a, b);
             Console.WriteLine(c);
             Console.WriteLine(d);
             Console.ReadLine();
             */

            /* string a = "soumyadip";
             string b = "das";
             string c = string.Concat(a,b);
             Console.WriteLine(c);
             Console.ReadLine();
             */

            /* DateTime dt = DateTime.Now;
             Console.WriteLine(dt);
             Console.ReadLine();
            */

            /* string str = "fghjkmllshvhvsc,shcbasj";
            Console.WriteLine(str.Length);
            Console.ReadLine();
             */

            /*string str = "fghjkmllshvhvscshcbasj";
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.ReadLine();
            */

            /*string firstName = "Soumyadip";
            string lastName = "Das";
            string name = firstName + lastName ;
            string name1 = firstName.Substring(3);
            Console.WriteLine(name[0]);
            Console.WriteLine(name.IndexOf("D"));
            Console.WriteLine(name1);
            Console.ReadLine();
            */

            /*int x = 10;
            Console.WriteLine(x == 10);
            Console.ReadLine();
             */

            //string str1 = "rup"; 
            //string a=$"hello : {str1}";
            //Console.WriteLine(a);
            //Console.ReadLine();
             

            //sum of natural numbers
            /*Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum=0;
            for (int i = 0; i <= n; i++)
                sum = sum + i; 
            Console.WriteLine(sum);
            Console.ReadLine();
             * */

            /*Console.WriteLine("Enter the number between 1 to 7");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("invalid number");
                    break;
            }
            Console.ReadLine();   
        }
         * */

            //diplay number 1 to n
           /* Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while(i<=a)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();
            **/

            //factorial of a number
            /*int fact = 1;
            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=a;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            Console.ReadLine();
             * */

            //factors of a number
           /* Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
                if (a % i == 0)
                    Console.WriteLine(i);
            Console.ReadLine();
            * */

            //perfect numbers
            //console.writeline("enter the number");
            //int n = convert.toint32(console.readline());
            //int sum=0;
            //for(int i=1;i<=n;i++)
            //{
            //    if (n == i)
            //        break;
            //    else if (n % i == 0)
            //        sum = sum + i;
            //}
            //if (n == sum)
            //    console.writeline("perfect number");
            //else
            //    console.writeline("not");
            //console.readline();

            //prime numbers
            //Console.WriteLine("enter the number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count=0;
            //for(int i=1;i<=n;i++)
            //{
            //    if (n % i == 0)
            //        count++;
            //}
            //if (count == 2)
            //    Console.WriteLine("prime");
            //else
            //    Console.WriteLine("not");
            //Console.ReadLine();

            //armstrong number
            //Console.WriteLine("enter the number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = n;
            //int arm=0;
            //while(n>0)
            //{
            //    int i = n % 10;
            //    n = n / 10;
            //    arm = arm + (i * i * i);
            //}
            //if (arm == m)
            //    Console.WriteLine("arm");
            //else
            //    Console.WriteLine("not");
            //Console.ReadLine();
            
            //reverse of a number
            //Console.WriteLine("enter the number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int rev = 0;
            //while(n>0)
            //{
            //    int i = n % 10;
            //    n = n / 10;
            //    rev = rev*10 + i;
            //}
            //Console.WriteLine(rev);
            //Console.ReadLine();

            //palindrome number
            //Console.WriteLine("enter the number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int rev=0;
            //int m = n;
            //while(n>0)
            //{
            //    int i = n % 10;
            //    n = n / 10;
            //    rev = rev * 10 + i;
            //}
            //if (rev == m)
            //    Console.WriteLine("palindrome");
            //else
            //    Console.WriteLine("not plaindrome");

            //gcd of two number
            //Console.WriteLine("enter two number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());
            //while(m!=n)
            //{
            //    if (m > n)
            //        m = m - n;
            //    else if (n > m)
            //        n = n - m;
            //}
            //Console.WriteLine(m);

            
             //declaring array
            //int[] arr = { 3, 4, 5, 6, 7, 8 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //user input array
            //Console.WriteLine("enter the size of array");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the elements");
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] =Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("The elements are"+ arr[i]);
            //}

            //sum of array elements
            //Console.WriteLine("enter the size of array");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the elements");
            //int[] arr = new int[n];
            //int sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] =Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    sum = sum + arr[i];
            //}
            //Console.WriteLine(sum);

            //maximum element in array
            //int[] arr = { 1, 5, 7 };
            //int max = arr[0];
            //for (int i = 0; i < arr.Length;i++ )
            //{
            //    if (arr[i] > max)
            //        max = arr[i];
            //}
            //Console.WriteLine(max);

            //binary search
            //Console.WriteLine("enter the size of array");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the elements in sorted order");
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] =Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("enter the key");
            //int key=Convert.ToInt32(Console.ReadLine());
            //int l=0;
            //int h=n-1;
            //int mid;
            //while(l<=h)
            //{
            //    mid = (l + h) / 2;
            //    if (key == arr[mid])
            //    {
            //        Console.WriteLine("found at " + mid);
            //        break;
            //    }
            //    else if (key < arr[mid])
            //        h = mid - 1;
            //    else
            //        l = mid + 1;
            //}
            //Console.WriteLine("not found");
            Console.ReadLine();
        }
    }
}
