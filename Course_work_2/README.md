## Задача
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Алгоритм решения
Решение задачи делится условно на 4 блока
***в программе на C# блоки выделены в отдельные методы!***

#### 1 блок
Производится создание исходного массива строчных элементов.
Вариант 1 - прямое задание этих элементов путем их перечисления,
Вариант 2 - консольный ввод данных с клавиатуры
* Для решения данной задачи в программе на C# использован второй вариант.
Для этого предварительно запрашивается кол-во вводимых строк.
* В случае, если заданный или введеный массив пустые - то программа выводит соответстующее уведомление и завершает работу.

#### 2 блок
Производится вычисление кол-ва элементов исходного массива удовлетворяющих условиям задачи. Реализация - использование цикла FOR (проход по исходному массиву).
* Кол-во найденных элементов, удовлетворяющих условиям задачи аккумулируется в счетчике (sizeArray2).
* В случае, если элементов по условию задачи не найдено - то программа выводит соответстующее уведомление и завершает работу.

#### 3 блок
1. Создается второй массив строк с количеством элементов найденных в предыдущем блоке (sizeArray2).
2. Производится поиск элементов исходного массива удовлетворяющих условиям задачи. Реализация - использование цикла FOR (проход по исходному массиву), также как и в блоке 2. Найденные элементы записываются во второй массив с использованием отдельного счетчика (count).
По итогу получаем второй массив со строками удовлетворяющих условиям задачи.

#### 4 блок
Вывод результата - вывод элементов второго массива на экран.