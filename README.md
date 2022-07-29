#  Вывод элементов массива, не превышающих 3 символа
## Описание решения программы (C#)

### **Задача**

_Из имеющегося массива строк сформировать массив строк, длина которых меньше либо равна 3 символам._

_Первоначальный массив вводится с клавиатуры_

### **Алгоритм с использованием трех методов**
1. Метод. Формирует первоначальный массив

       * Размер массива задается пользователем
       * Элементы массива пользователь вводит вручную  

2. Метод. Выводит массив в консоль

3. Метод. Преобразует первоначальный массив в новый и выводит новый в консоль
    
        1 Подзадача.
       * Подсчитать количество элементов в массиве, не превышающих 3 символа
        Если таких элементов не найдено, завершить программу выводом в консоль сообщения о том, что таких элементов нет

        2 Подзадача.
       * Для нового массива задать размер, равный подсчитанному количеству элементов
       * Пройтись по каждому индексу первоначального массива и, если текущий элемент в нем не превышает 3 символа, записать его в новый массив
       * Отобразить новый массив (для отображения массива используется метод № 2)


