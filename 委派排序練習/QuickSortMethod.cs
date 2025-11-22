using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace 委派排序練習
{
    internal static class QuickSortMethod
    {
        public static List<Village> QuickSort(this List<Village> list, Func<Village, Village, bool> callback)
        {
            QuickBoxNumber(list, 0, list.Count - 1, callback);
            return list;
        }

        static void QuickBoxNumber(List<Village> list, int left, int right, Func<Village, Village, bool> callback)
        {
            int start = left;
            int end = right;
            int box = left;

            while (start != end)
            {
                while (callback(list[end], list[box]))
                {
                    end--;
                }
                if (callback(list[box], list[end]))
                {
                    (list[end], list[start]) = (list[start], list[end]);
                }
                while (callback(list[box], list[start]))
                {
                    start++;
                }
                if (callback(list[start], list[box]))
                {
                    (list[start], list[end]) = (list[end], list[start]);
                }
            }
            if (start != left)
            {
                QuickBoxNumber(list, left, start - 1, callback);
            }
            if (right != end)
            {
                QuickBoxNumber(list, end + 1, right, callback);
            }
        }
    }
}
