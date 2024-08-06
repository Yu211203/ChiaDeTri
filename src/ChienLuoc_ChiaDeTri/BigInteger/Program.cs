using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigInteger
{
    public class Program
    {
        static int[] Multiply(string num1, string num2)
        {
            int n1 = num1.Length;
            int n2 = num2.Length;

            // Kết quả có thể có độ dài tối đa là n1 + n2
            int[] result = new int[n1 + n2];

            // Lật ngược các chuỗi để dễ dàng nhân từng chữ số
            char[] num1Arr = num1.ToCharArray();
            Array.Reverse(num1Arr);
            char[] num2Arr = num2.ToCharArray();
            Array.Reverse(num2Arr);

            // Nhân từng chữ số của hai số
            for (int i = 0; i < n1; i++)
            {
                int carry = 0;
                int n1Digit = num1Arr[i] - '0';

                for (int j = 0; j < n2; j++)
                {
                    int n2Digit = num2Arr[j] - '0';

                    // Tính toán tích số và thêm vào kết quả hiện tại
                    int sum = n1Digit * n2Digit + result[i + j] + carry;
                    carry = sum / 10;
                    result[i + j] = sum % 10;
                }

                // Nếu còn phần dư, thêm vào kết quả
                if (carry > 0)
                {
                    result[i + n2] += carry;
                }
            }

            // Lật ngược lại mảng kết quả
            Array.Reverse(result);
            return result;
        }
        static void Main(string[] args)
        {
            string num1 = "1247137421";
            string num2 = "9571341257";
            Console.WriteLine("First Integer string: "+num1);
            Console.WriteLine("Second Integer string: " + num2);

            int[] result = Multiply(num1, num2);
            Console.WriteLine("Result: " + string.Join("", result).TrimStart('0'));
            Console.ReadLine();
        }
    }
}
