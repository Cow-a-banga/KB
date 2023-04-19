using System.ComponentModel;

public static class BindingListExtension
{
    public static void ReverseInPlace<T>(this BindingList<T> list)
    {
        for (int i = 0; i < list.Count/2; i++)
        {
            (list[i], list[^(i+1)]) = (list[^(i+1)], list[i]);
        }
    }
}