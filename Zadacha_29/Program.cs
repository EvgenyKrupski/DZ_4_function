//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
//Поправка: на семинаре дал добро на заволнение массива рандомными числами. В оригинале нужно пользователю ввести строку - ряд чисел через запятую, а программа превращает эту строку в полноценный массив и выводит. Рекомендую вторым вариантом)

Console.Write("Введите числа через запятую: ");
string numbers = Console.ReadLine();

int countNumbers = 1;

for(int i = 0; i < numbers.Length; i++){
    if(numbers[i] == ','){
        countNumbers++;
    }
}

int[] numersArr = new int[countNumbers];
int index = 0;

for(int i = 0; i < numbers.Length; i++){
    string tempString = "";
    
    while(numbers[i] != ','){
        if(i != numbers.Length - 1){
            tempString += numbers[i].ToString();
            i++;
        }
        else{
            tempString += numbers[i].ToString();
            break;
        }
    }
    numersArr[index] = Convert.ToInt32(tempString);
    index++;
}

for(int i = 0; i < numersArr.Length; i++){
    Console.Write(numersArr[i] + " ");
}