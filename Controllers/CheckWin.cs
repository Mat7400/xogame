using System;
using System.Collections.Generic;
using System.Text;
using XO_WebApp.Models;

namespace XO_WebApp.Controllers
{
    public class CheckWin
    {
        public static bool checkWin(MainModel model)
        {
            //проверка выигрыша
            //1) проходим по всем строкам и ищем три Х или три О подряд
            //2) и то же самое оп всем столбцам
            //3) проверка диагоналей
            int initial = (int)'a';
            string[,] arr = new string[model.size, model.size];
            //вот это поменять если захотим больше Символов подряд для выигрыша
            //число 2 потому что счетчики идут с нуля (0,1,2)
            int maxV = 3;
            if (model.size >= 9)
                maxV = 4;
            //
            foreach (var keyPair in model.Field)
            {
                string cellname = keyPair.Key;
                int row = (int)(cellname[0]) - initial;
                int column = Convert.ToInt32(cellname[1].ToString());
                string value = keyPair.Value;
                arr[column, row] = value;
            }
            //проверим по строкам
            //29.05.2022 edit
            for (int i = 0; i < model.size; i++)
            {
                int xcounter = 0;
                int ocounter = 0;
                int tcounter = 0;
                //если счетчик набрал три то его не надо обнулдять
                //потому что если пустая клетка после 3 в кноце строки счетчик обнулится
                //это ошибка
                for (int j = 0; j < model.size; j++)
                {
                    if (arr[i, j] == "X") xcounter++;
                    else if (xcounter < maxV) xcounter = 0;

                    if (arr[i, j] == "O") ocounter++;
                    else if (ocounter < maxV) ocounter = 0;

                    if (arr[i, j] == "✓") tcounter++;
                    else if (tcounter < maxV) tcounter = 0;
                }

                if (xcounter >= maxV)
                {
                    model.xo = "X str"; return true;
                }
                if (ocounter >= maxV)
                {
                    model.xo = "O str"; return true;
                }
                if (tcounter >= maxV)
                {
                    model.xo = "✓ str"; return true;
                }
            }
            //проверим по столбцам
            for (int i = 0; i < model.size; i++)
            {
                int xcounter = 0;
                int ocounter = 0;
                int tcounter = 0;
                for (int j = 0; j < model.size; j++)
                {
                    if (arr[j, i] == "X") xcounter++;
                    else if (xcounter < maxV) xcounter = 0;

                    if (arr[j, i] == "O") ocounter++;
                    else if (ocounter < maxV) ocounter = 0;

                    if (arr[j, i] == "✓") tcounter++;
                    else if (tcounter < maxV) tcounter = 0;
                }

                if (xcounter >= maxV)
                {
                    model.xo = "X stlb"; return true;
                }
                if (ocounter >= maxV)
                {
                    model.xo = "O stlb"; return true;
                }
                if (tcounter >= maxV)
                {
                    model.xo = "✓ stlb"; return true;
                }
            }
            //проверка выигрыша чтоб прервать циклы
            bool win = false;
            //ПРОВЕРИМ ПО ДИАГОНАЛЯМ
            //02.06.2022 надо сбрасывать счетчиким тоже
            //если мы переходим на следующий элемент в строке
            for (int i = 0; i < model.size && !win; i++)
            {
                string tocheck = "";
                //символ слева сверху
                int counterUpLeft = 0;
                //справа сверху
                int counterUpRight = 0;
                //снизу справа
                int counterDownRight = 0;
                //снизу слева
                int counterDownLeft = 0;
                //цикл по строке слева направо
                for (int j = 0; j < model.size && !win; j++)
                {
                    if (arr[i, j] == "X")
                    {
                        tocheck = "X";
                    }
                    else if (arr[i, j] == "O")
                    {
                        tocheck = "O";
                    }
                    else if (arr[i, j] == "✓")
                    {
                        tocheck = "✓";
                    }
                    else tocheck = "";

                    if (tocheck != "")
                    {
                        //проверим можем ли пойти вверх-влево
                        if ((i - 1) >= 0 && (j - 1) >= 0)
                        {
                            //проверяем что есть сверху слева
                            if (arr[i - 1, j - 1] == tocheck) counterUpLeft++;
                        }
                        //проверим можем ли пойти вверх-вправо
                        if ((i + 1) < model.size && (j - 1) >= 0)
                        {
                            //проверяем что ест
                            if (arr[i + 1, j - 1] == tocheck) counterUpRight++;
                        }
                        //проверим можем ли пойти вниз-вправо
                        if ((i + 1) < model.size && (j + 1) < model.size)
                        {
                            //проверяем что есть 
                            if (arr[i + 1, j + 1] == tocheck) counterDownRight++;
                        }
                        //проверим можем ли пойти вниз-влево
                        if ((i - 1) >= 0 && (j + 1) < model.size)
                        {
                            //проверяем что есть
                            if (arr[i - 1, j + 1] == tocheck) counterDownLeft++;
                        }
                        //проверяем счетчики. их сумма должна быть 2
                        //02/06 - возможно ошибка что массив не с теми индексами
                        //то есть i j перепутаны местами! надо проверить
                        if (counterUpLeft + counterDownRight == 2 ||
                            counterUpRight + counterDownLeft == 2)
                        {
                            win = true;
                            model.xo = tocheck + " diag";
                            return true;
                        }
                        //обнуляем счетчеги после проверки
                        counterUpLeft = 0;
                        //справа сверху
                        counterUpRight = 0;
                        //снизу справа
                        counterDownRight = 0;
                        //снизу слева
                        counterDownLeft = 0;
                    }
                }//конец цикла по строке

            }//конец проверки диагоналей

            return false;
        }
    }
}
