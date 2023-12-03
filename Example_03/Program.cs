int [] array = {11, 12, 31, 4, 18, 55, 61, 7, 18};

int n = array.Length; // .Length - возвращает длинну массива
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {   
        Console.WriteLine(index);
        break; // при нахождении нужного элемента программа завершает работу, дажн если есть еще такой элемент
    }
    index++;  //  index = index + 1;
}
