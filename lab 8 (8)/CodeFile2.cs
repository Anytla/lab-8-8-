using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

class Box<T> where T : IComparable<T>
{
    public List<T> Arr;
    public List<T> newArr;

    public Box()
    {
        Arr = new List<T>(); // створюємо новий список для масиву
        newArr = new List<T>();
    }

    public override string ToString()
    {
        StringBuilder SB = new StringBuilder(); // конструктор

        foreach (T element in newArr)
        {
            SB.AppendLine($"{element}");// додає рядок
        }
            

        foreach (T element in Arr)
        {
            SB.AppendLine($"{element}");// додає рядок
        }

        return SB.ToString();
    }

    public void Add(T element)
    {
        Arr.Add(element); // додати новий елемент
    }

    public void Print(Box<T> arr)
    {
        Console.Write(arr); //виводить на екран масив
    }

    public T Max()// шукає максимальний елемент в масиві
    {
        T max = Arr[0];

        foreach (T t in Arr)
        {
            if (t.CompareTo(max) > 0) //
            { max = t; }
        }
        newArr.Add(max);
        return max;
    }

    public T Min() // шукає мінімальний елемент в масиві
    {
        T min = Arr[0];

        foreach (T t in Arr)
        {
            if (t.CompareTo(min) < 0)
            { min = t; }
        }
        newArr.Add(min);
        return min;
    }

    public void Remove(int index) // видаляє елемент з зазначеним індексом
    {
        Arr.RemoveAt(index);
    }

    public bool Contains(T element) // виводить якщо список містить вказаний елемент
    {
        if (Arr.Contains(element))
        {
            return true;
        }
        return false;
    }

    public void Swap(int index1, int index2) // міняє місьцями два елементи індекси яких вказані 
    {
        T temp = Arr[index1];
        Arr[index1] = Arr[index2];
        Arr[index2] = temp;
    }

    public int Greater(T element) // підраховує кількість елементів , які перевищують заданий та виводить їх кількість
    {
        int num = 0;

        foreach (T t in Arr)
        {
            if (t.CompareTo(element) > 0) // Порівнює поточний екземпляр з іншим об'єктом того ж типу і повертає ціле число, яке показує, чи 
            {                              // розташований поточний екземпляр перед, після або на тій самій позиції в порядку сортування, що й інший об'єкт
                num++; 
            }
        }
        return num;
    }
}