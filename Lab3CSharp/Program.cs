//Task 1

using System;

// Перерахування для представлення кольорів ромбів
public enum RombColor
{
    Red = 1,    // Числове значення червоного кольору
    Blue = 2,   // Числове значення синього кольору
    Green = 3,  // Числове значення зеленого кольору
    Yellow = 4  // Числове значення жовтого кольору
}

class Program
{
    static void Main()
    {
        // Створення масиву ромбів з використанням конструктора
        Romb[] rombs = new Romb[]
        {
            new Romb(5, 8, RombColor.Red),     // Створення ромба зі стороною 5, діагоналлю 8 та червоним кольором
            new Romb(7, 10, RombColor.Blue),   // Створення ромба зі стороною 7, діагоналлю 10 та синім кольором
            new Romb(6, 6, RombColor.Green),   // Створення ромба зі стороною 6, діагоналлю 6 та зеленим кольором
            new Romb(8, 8, RombColor.Yellow)   // Створення ромба зі стороною 8, діагоналлю 8 та жовтим кольором
        };

        int squareCount = 0; // Лічильник кількості квадратних ромбів

        // Цикл для ітерації через всі ромби в масиві
        foreach (var romb in rombs)
        {
            // Виведення інформації про ромб з використанням властивостей та методів класу Romb
            Console.WriteLine($"Ромб зі стороною {romb.Side}, діагоналлю {romb.Diagonal}, кольором {romb.Color} ({(int)romb.Color}):");

            // Виведення периметру ромба
            Console.WriteLine($"Периметр: {romb.CalculatePerimeter()}");

            // Виведення площі ромба
            Console.WriteLine($"Площа: {romb.CalculateArea()}");

            // Перевірка, чи ромб є квадратом
            if (romb.IsSquare())
            {
                squareCount++;
                Console.WriteLine("Цей ромб - квадрат.");
            }
            else
            {
                Console.WriteLine("Цей ромб - не квадрат.");
            }

            Console.WriteLine(); // Порожній рядок для відокремлення інформації про різні ромби
        }

        // Виведення загальної кількості квадратних ромбів
        Console.WriteLine($"Загальна кількість квадратів: {squareCount}");
    }
}

class Romb
{
    protected int side;         // Довжина сторони ромба
    protected int diagonal;     // Довжина діагоналі ромба
    protected RombColor color;  // Колір ромба

    // Властивості для отримання та встановлення значень сторін, діагоналі та кольору
    public int Side
    {
        get { return side; }
        set { side = value; }
    }

    public int Diagonal
    {
        get { return diagonal; }
        set { diagonal = value; }
    }

    public RombColor Color
    {
        get { return color; }
    }

    // Конструктор для створення екземпляру класу з заданими значеннями
    public Romb(int side, int diagonal, RombColor color)
    {
        this.side = side;
        this.diagonal = diagonal;
        this.color = color;
    }

    // Метод для виведення довжин сторін та діагоналі на консоль
    public void DisplayLengths()
    {
        Console.WriteLine($"Сторона: {side}, Діагональ: {diagonal}");
    }

    // Метод для розрахунку периметру ромба
    public int CalculatePerimeter()
    {
        return 4 * side;
    }

    // Метод для розрахунку площі ромба
    public int CalculateArea()
    {
        return (side * diagonal) / 2;
    }

    // Метод для перевірки, чи ромб є квадратом
    public bool IsSquare()
    {
        return side == diagonal;
    }
}





