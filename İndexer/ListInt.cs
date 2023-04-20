using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İndexer
{
    internal class ListInt
    {
        private int[] arr;

        public int this[int index] {
            get { 
                if (index < arr.Length) 
                { return arr[index]; }
                else
                {
                    return arr[arr.Length - 1];
                }
            } 
            set { arr[index] = value;  } }

        public int Length { get { return arr.Length; } }
        public ListInt()
        {
            arr = new int[0];
        }
        public ListInt(int length)
        {
            arr = new int[length];
        }
        public ListInt(params int[] nums)
        {
            arr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = nums[i];
            }
        }
        
        public void Add( int value)
        {
            
                

                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length -1] = value;
            

        }
       public void AddRange(params int[] nums)
        {
            int news = arr.Length;
            Array.Resize(ref arr, arr.Length + nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                

                arr[news + i] = nums[i];

            }

        }
        public bool Contains(int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {if (arr[i] == num)
                
                return true;
            }
            
            return false;   
        }

        public void Sum()
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                
            }
            Console.WriteLine(sum);
        }
        public override string ToString()
        {
            string a = "";
            for (int i = 0; i < arr.Length; i++)
            {
                a += arr[i];
                
                if (i < arr.Length - 1)
                {
                    a += ",";
                }
            }
            return a;
        }
        public void Remove(int num)
        {
            int[] newArray = new int[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==num)
                {
                    Array.Resize(ref newArray, newArray.Length +1);
                    newArray[newArray.Length-1] = i;

                }
                
            }
            newArray = arr;
            

        }
        public void RemoveRange(params int[] nums)
        {

        }

        
        


    }
}
