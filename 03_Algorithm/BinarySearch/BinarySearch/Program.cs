using System;

namespace BinarySearch
{
    class Program
    {
        #region  thuat toan
        //Phạm vi tìm kiếm ban đầu của chúng ta là từ phần tử đầu tiên của dãy(First = 1) cho đến phần tử cuối cùng của dãy(Last = N). 
        //So sánh giá trị X với giá trị phần tử đứng ở giữa của dãy M là M[Mid]. 
        //Nếu X = M[Mid]: Tìm thấy
        //Nếu X<M[Mid]: Rút ngắn phạm vi tìm kiếm về nửa đầu của dãy M (Last = Mid - 1)
        //Nếu X > M[Mid]: Rút ngắn phạm vi tìm kiếm về nửa sau của dãy M(First = Mid + 1)
        //Lặp lại quá trình này cho đến khi tìm thấy phần tử có giá trị X hoặc phạm vi tìm
        //kiếm của chúng ta không còn nữa(First > Last).
        #endregion
        public static int binarySearch(int num, int[] arr)
        {
            int first = 0;
            int last = arr.Length - 1;

            while (first <= last)
            {
                int mid = (first + last) / 2;
                if (arr[mid] == num)
                {
                    return arr[mid];
                }
                else if (num < arr[mid])
                {
                    last = mid - 1;
                }
                else
                {
                    first = mid + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 25 };

            int flag = binarySearch(6, arr);
            if (flag != -1)
            {
                Console.WriteLine("tim thay ");
            }
            else Console.WriteLine("ko tim thay ");
        }
    }
}
