
namespace MacoApp
{
    internal class SqlRequests
    {
        public int System;
        public string Side;
        public int FFH;
        public int FFB;
        public string Lower_loop;
        public string Micro_ventilation;
        public string queryString;
        public int quantityBar = 0;


        public string QueryString(int System, string Side, int FFH, int FFB, string Lower_loop, string Micro_ventilation)
        {
            //Варианты запросов в БД с разными параметрами, выбранными в форме

            //(высота до 900, ширина до 431)
            if (FFH >= 601 && FFH <= 900 && FFB <= 430 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH >= 601 && FFH <= 900 && FFB <= 430 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH >= 601 && FFH <= 900 && FFB <= 430 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH >= 601 && FFH <= 900 && FFB <= 430 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH >= 601 && FFH <= 900 && FFB <= 430 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH >= 601 && FFH <= 900 && FFB <= 430 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH >= 601 && FFH <= 900 && FFB <= 430 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH >= 601 && FFH <= 900 && FFB <= 430 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 2;
                return queryString;
            }

            //*********************

            //Высота до 1300, ширина до 431
            else if (FFH >= 901 && FFH <= 1300 && FFB <= 430 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB <= 430 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB <= 430 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB <= 430 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB <= 430 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB <= 430 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 3;
                return queryString;
            }

            else if (FFH >= 901 && FFH <= 1300 && FFB <= 430 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB <= 430 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет' and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 3;
                return queryString;
            }
            //*********************

            //Высота от1301 до 1800, ширина до 431
            else if (FFH >= 1301 && FFH <= 1800 && FFB <= 430 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB <= 430 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB <= 430 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения'1 or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB <= 430 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB <= 430 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like ‘Нет’ or Micro_ventilation like '2');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB <= 430 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB <= 430 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB <= 430 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 5;
                return queryString;
            }
            //*********************

            //Высота от 1801 до 2350, ширина до 431
            else if (FFH >= 1801 && FFH <= 2350 && FFB <= 430 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB <= 430 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB <= 430 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB <= 430 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB <= 430 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB <= 430 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB <= 430 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB <= 430 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '2');";
                quantityBar = 6;
                return queryString;

            }
            //*********************

            //(высота до 900, ширина до 600)
            else if (FFH <= 900 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like ‘Нет’ or Micro_ventilation like 'Да');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like ‘Нет’ or Micro_ventilation like 'Да');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like ‘Нет’ or Micro_ventilation like 'Да');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like ‘Нет’ or Micro_ventilation like 'Да');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 2;
                return queryString;
            }
            //*********************

            //Высота до 1300, ширина до 600
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600)and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600)and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";//
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like ‘Нет’ or Micro_ventilation like '1');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 3;
                return queryString;
            }
            //*********************

            //Высота от1301 до 1800, ширина до 600
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            //*********************

            //Высота от 1801 до 2350, ширина до 600
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 431 && FFB <= 600 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 6;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 431 && FFB <= 600 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 6;
                return queryString;
            }
            //*********************

            //ШИРИНА 601-800
            //Высота до 900, ширина 601-800

            else if (FFH <= 900 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 2;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 431600) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 2;
                return queryString;
            }
            //*********************

            //Высота до 1300, ширина 601-800
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 3;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 3;
                return queryString;
            }
            //*********************

            //Высота от1301 до 1800, ширина 601-800
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like ‘Да’);";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            //*********************

            //Высота от 1801 до 2350, ширина до 600
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 601800) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 601 && FFB <= 800 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 601 && FFB <= 800 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 601800) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 7;
                return queryString;
            }
            //*********************

            //ШИРИНА 801-1050
            //Высота до 900, ширина 801-1050
            else if (FFH <= 900 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 4;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 4;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 4;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 4;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 4;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 4;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 4;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 4;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 4;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 4;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 4;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 4;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 4;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 4;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 4;
                return queryString;
            }
            else if (FFH <= 900 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 601900) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 4;
                return queryString;
            }
            //*********************

            //Высота до 1300, ширина 801-1050
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            else if (FFH >= 901 && FFH <= 1300 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 9011300) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 5;
                return queryString;
            }
            //*********************

            //Высота от1301 до 1800, ширина 801-1050
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 7;
                return queryString;
            }
            else if (FFH >= 1301 && FFH <= 1800 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 13011800) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 7;
                return queryString;
            }
            //*********************

            //Высота от 1801 до 2350, ширина 801-1050
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 8;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 8;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 8;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 8;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 8;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 8;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 8;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Да")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like 'Да');";
                quantityBar = 8;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 8;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Правое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 8;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 8;
                return queryString;
            }

            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Левое" && Lower_loop == "Да" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 8011050) and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 8;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 8;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Правое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Правая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 8;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 801 && FFB <= 1050 && System == 13 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 13) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 8;
                return queryString;
            }
            else if (FFH >= 1801 && FFH <= 2350 && FFB >= 801 && FFB <= 1050 && System == 9 && Side == "Левое" && Lower_loop == "Нет" && Micro_ventilation == "Нет")
            {
                queryString = $"Select * from Elements where (System  = 'Не имеет значения' or System  = 9) and (Side like 'Не имеет значения' or Side like 'Левая') and (FFH = 0 or FFH = 18012350) and (FFB = 0 or FFB = 8011050) and (Lower_loop like 'Нет') and (Micro_ventilation like 'Нет' or Micro_ventilation like '1');";
                quantityBar = 8;
                return queryString;
            }
            else
            {
                queryString = "";
                return queryString;
            }
        }
        public int Que()
        {
            //Возвращаем количество ответных планок в зависимости от запроса           
            return quantityBar;
        }
    }
}

