package driver;
import java.io.*;
import java.util.*;

public class QuickSort
{
    public void qSort(Object array[], int left, int right)
    {
        if(array.getClass()==Integer[].class)
        {
            int pivot, lHold, rHold;
            lHold = left;
            rHold = right;
            pivot = (Integer)array[left];
            while (left < right)
            {
                while (((Integer)array[right] >= pivot) && (left < right))
                right--;
                if (left != right)
                {
                    array[left] = array[right];
                    left++;
                }
                while (((Integer)array[left] <= pivot) && (left < right))
                    left++;
                if (left != right)
                {
                    array[right] = array[left];
                    right--;
                }
            }
            array[left] = pivot;
            pivot = left;
            left = lHold;
            right = rHold;
            if (left < pivot)
                qSort(array, left, pivot-1);
            if (right > pivot)
                qSort(array, pivot+1, right);
        }
        else if(array.getClass()==Character[].class)
        {
            char pivot;
            int temp,lHold, rHold;
            lHold = left;
            rHold = right;
            pivot = (Character)array[left];
            while (left < right)
            {
                while (((Character)array[right] >= pivot) && (left < right))
                    right--;
                if (left != right)
                {
                    array[left] = array[right];
                    left++;
                }
                while (((Character)array[left] <= pivot) && (left < right))
                    left++;
                if (left != right)
                {
                    array[right] = array[left];
                    right--;
                }
            }
            array[left] = pivot;
            temp = left;
            left = lHold;
            right = rHold;
            if (left < temp)
                qSort(array, left, temp-1);
            if (right > temp)
                qSort(array, temp+1, right);
        }
    }
    public void display(Object[] array)
    {
        for(int i=0;i<array.length;i++)
            System.out.println (array[i]);
    }
}
