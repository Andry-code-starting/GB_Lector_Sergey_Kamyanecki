//Console.clear();
//Console.SetCursorPosition(10,4); //курсор на позиции 10 отступ 4 строка
//Console.WriteLine("+"); //пишем в консоле +

int xa = 40; //int xa = 40, ya = 1,
int ya = 1; //     xb = 1, yb = 30,
int xb = 1; //     xc = 80, yc = 30;
int yb = 30;
int xc = 80;
int yc = 30;

Console.SetCursorPosition(xa, ya); //курсор на позиции 10 отступ 4 строка
Console.WriteLine("+"); //пишем в консоле +

Console.SetCursorPosition(xb, yb); //курсор на позиции 10 отступ 4 строка
Console.WriteLine("+"); //пишем в консоле +

Console.SetCursorPosition(xc, yc); //курсор на позиции 10 отступ 4 строка
Console.WriteLine("+"); //пишем в консоле +

int x = xa, y = xb; //точка для определённости

int count = 0; //нахождение отрезка

while(count < 1000)
{
    int what = new Random().Next(0, 3); //(0; 3) 0 1 2 Случайное число от 0 до 2
    if(what== 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
        if(what== 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
        if(what== 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; //[count+=1;] или [count++;] 
}