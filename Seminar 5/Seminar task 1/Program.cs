// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]/ 
// Найдите сумму отрицательных и положительных элеметов 
 
 int[] array = new int [12];

//Заполнение массива
 for ( int i = 0; i < array.Length; i++ ) {
    array[i] = new Random().Next(-9, 10);

    Console.Write(array[i] + "  "); 
 }



 //Подсчёт суммы отрицательных и положительных элементов 
    int sumPossitive = 0; 
    int sumNegative = 0; 

     for ( int i = 0; i < array.Length; i++ ) {
     if (array[i] > 0) {
        sumPossitive =  sumPossitive+ array[i];
     }
     

     if (array[i] < 0)  {
         sumNegative = sumNegative + array[i];    
         }
    

 }
//Вывод значений в новых строках
 Console.WriteLine ($"\nSum Positive: {sumPossitive}." + 
 $"\nSum Pisitive: {sumNegative}."); 