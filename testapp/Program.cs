using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__2
{
    internal class Program
    {
        int[] reza = new int[57];

        int n;

        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("enter the number of element in the array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n < 57))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 57 element.\n");
            }
            for (i= 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                reza[i] = Int32.Parse(s1);
            }
        }

        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun");
            Console.WriteLine("----------------------------------");
            for (int mr = 0; mr < n; mr++)
            {
                Console.WriteLine(reza[mr]);
            }
            Console.WriteLine("");
        }

        public void BubbleSortArray()
        {
            for (int i = 0; i < n; i++)
            {
                for (int mr = 0; mr < n - i; mr++)
                {
                    if (reza[mr] > reza[mr + 1]) //jika elemen tidak dalam urutan yang benar
                    {
                        //tukar elemen
                        int temp;
                        temp = reza[mr];
                        reza[mr] = reza[mr + 1];
                        reza[mr + 1] = temp;
                    }
                }
            }
        }

        public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[57];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];

        }

        public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
        }

        private void SortMerge()
        {
            throw new NotImplementedException();

        }

        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;
            do
            {

                do
                {
                    Console.WriteLine("Menu Option");
                    Console.WriteLine("=================");
                    Console.WriteLine("1. BubbleSort");
                    Console.WriteLine("2. MergeSort");
                    Console.WriteLine("3. Exit");
                    Console.WriteLine("Enter your choice (1,2,3) : ");
                    pilihanmenu = Convert.ToInt32(Console.ReadLine());
                    switch (pilihanmenu)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("................");
                            Console.WriteLine(" Bubble Sort ");
                            Console.WriteLine("................");
                            myList.input();
                            myList.display();
                            myList.BubbleSortArray();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("................");
                            Console.WriteLine(" Merge Sort ");
                            Console.WriteLine("................");
                            myList.input();
                            myList.display();
                            myList.SortMerge();
                            break;
                        case 3:
                            Console.WriteLine("Exit");
                            break;
                    }
                    Console.WriteLine("\nPilih menu lagi? (y/n): ");
                    ch = char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();
                } while (ch == 'y');

                Console.WriteLine("\n\nPress return to exit.");
                Console.ReadLine();
            } while (pilihanmenu != 3);
        }


    }
}
