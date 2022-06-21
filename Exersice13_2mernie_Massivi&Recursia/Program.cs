string[,] table = new string[2,5];
// table[0,0]  table[0,1]  table[0,2]...  table[0,4]
// table[1,0]  table[1,1]  table[1,2]...  table[1,4]

table[1,2] = "слово";

for (int rows = 0; rows < 2; rows++) {
    for (int colums = 0; colums < 5; colums++) {
        Console.WriteLine($"-{table[rows, colums]}-");
    }
}
//_______________________________________________________________

int[,] matrix = new int [3,4];

for (int i = 0; i < matrix.GetLength(0); i++) {        // вместо 3
    for (int j = 0; j < matrix.GetLength(1); j++) {    // вместо 4
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}

//________________________________________________________________


void PrintArray(int[,] matr) {
    for (int i = 0; i < matr.GetLength(0); i++) {        // вместо 3
        for (int j = 0; j < matr.GetLength(1); j++) {    // вместо 4
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) {
    for (int i = 0; i < matr.GetLength(0); i++) {
        for (int j = 0; j < matr.GetLength(1); j++) {
            matr[i,j] = new Random().Next(1,10); // [1,10]
        }
    }
}
int[,] matrix = new int [3,4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

//_____________________________________________________________

//      Правило премещения! 
//      Против часовой стрелки!

//   x+1, y-1  x-1, y  x-1, y+1
//    x, y-1    x, y    x, y+1
//   x+1, y-1  x+1, y  x+1, y+1

//_______________________________________________________________


void PrintImage(int[,] image) {
    for (int i = 0; i < image.GetLength(0); i++) {
        for (int j = 0; j < image.GetLength(1); j++) {
            //Console.Write($"{image[i, j]} ");
            if(image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col) {
    if(pic[row, col] == 0) {
        pic[row, col] = 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row1, col+1);
    }
}
int[,] pic = new int [,]; // палец вверх!
PrintImage(pic); // Пустой палец
FillImage(13,13); // Произвольная точка
PrintImage(pic); // Закрашеный палец

//___________________________________________________________
//      Рекурсия

 double Factorial (int n) {
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
 }
 for (int i = 1; i < 40; i++) {
    Console.WriteLine($"{i}! = {Factorial(i)}");
 }

 //___________________________________________________________

 // f(1) = 1
 // f(2) = 1
 // f(n) = f(n-1) + f(n-2)

 double Fibonacci(int n) {
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
 }
 for (int i = 1; i < 50; i++) {
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
 }