void FillArray(int[] collection)   //  void-метод ничего не возвращает
{
    int length = collection.Length;  // нужно получить длинну массива
    int index = 0;  // берем индек , по умолчанию - это "0"
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
  int count = col.Length;  //количество элементов
  int position = 0; //позиция элемента массива(индекс)
  while (position < count)
  {
    Console.WriteLine(col[position]); //конслоль печатает элементы перебирая индексы
    position++;  // перебираем все позиции от 0 до "count"
  }
}

int IndexOf(int[]collection, int find)
{
    int count = collection.Length; //определяем колличество элементов
    int index = 0; //задаем стартовый индекс "0"
    int position = -1; // если искомого элемента нет, то выдет  "-1", этой строкой заменили нижнюю строку, где был "0"
    // int position = 0;// эта переменная задается вперед, сюда мы будем сохранять элемент массива, который совпал с faid
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; //если нашелся нужный элемент, останавливаем работу
        }
        index++;
    }
    return  position; //после того как цикол отработал, нам возвращается позиция нужного элемента 
    //!!!ВНИМАНИЕ после RETURN только пробел
}

int[] array = new int[10];  //  new int[10]  дословно значит - создай новый массив в котором будет 10 элементов
FillArray(array);  //вызываем метод который создаем массив
array[4] = 4; //принудительно добавляем искомые элементы
array[7] = 4;
PrintArray(array);  //метод, который печатает массив
Console.WriteLine(); //выводим пустую строку

int pos = IndexOf(array, 4); //вызываем метод
Console.WriteLine(pos);
