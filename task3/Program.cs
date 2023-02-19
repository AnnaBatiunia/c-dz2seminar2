// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void CheckingDW (int day) 
{
  if (day == 6 || day == 7) 
  {
  Console.WriteLine("это выходной день ");
  }
  else if (day < 1 || day > 7) 
  {
    Console.WriteLine("это вообще не день недели!");
  }
  else Console.WriteLine("это не выходной день");
}
CheckingDW (day);
