namespace TypeOperationsWorkshop;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Перевод байтов в килобайты");
		double bites = 3500;
		Console.WriteLine("Байты: " + bites);
		double kilobites = bites / 1024;
		Console.WriteLine("Килобайты: " + kilobites);
		Console.WriteLine();
		
		Console.WriteLine("Перевод часы в минуты");
		double minutes = 94;
		Console.WriteLine("Минуты: " + minutes);
		double hours = 94 / 60;
		Console.WriteLine("Часы: " + hours);
		minutes = minutes % 60;	
		Console.WriteLine("Минут: " + minutes);
		Console.WriteLine();
		
		Console.WriteLine("Вычисление среднеарифмитического");
		double firstNumber = 3;
		Console.WriteLine("Первое число: " + firstNumber);
		double secondNumber = 7;
		Console.WriteLine("Второе число: " + secondNumber);
		double thirdNumber = 13;
		Console.WriteLine("Третие число: " + thirdNumber);
		double average = (firstNumber + secondNumber + thirdNumber) / 3;
		Console.WriteLine("Среднеарифмитическое: " + average);
		Console.WriteLine();
		
		Console.WriteLine("Вычисление периметра квадрата");
		double squareSide = 5;
		Console.WriteLine("Сторона квадрата: " + squareSide);
		double squarePerimetr = 4 * squareSide;
		Console.WriteLine("Периметр квадрата: " + squarePerimetr);
		Console.WriteLine();
		
		Console.WriteLine("Перевод км в м");
		double kilometers = 10;
		Console.WriteLine("Километры: " + kilometers);
		double meters = kilometers * 1000;
		Console.WriteLine("Метры: " + meters);
		Console.WriteLine();
		
		Console.WriteLine("Поиск площади прямоугольника");
		double a = 2;
		Console.WriteLine("a: " + a);
		double b = 6;
		Console.WriteLine("b: " + b);
		double perimetr = 2 * (a + b);
		Console.WriteLine("Периметр прямоугольника: " + perimetr);
		double rectangleSquare = a * b ;
		Console.WriteLine("Площадь прямоугольника: " + rectangleSquare);
		Console.WriteLine();
		
		Console.WriteLine("Поиск площади");
		double radius = 9;
		Console.WriteLine("Радиус: " + radius);
		double square = Math.PI * radius * radius;
		Console.WriteLine("Площадь: " + square);
		Console.WriteLine();
		
		Console.WriteLine("Перевод градусов цельсия в Фаренгейта");
		double celsius = 22.5;
		Console.WriteLine("Градусы по цельсию: " + celsius);
		double fahrenheit = celsius * 9.0 / 5.0 + 32;		
        Console.WriteLine("Температура по фаренгейту: " + fahrenheit);
		Console.WriteLine();
		
		Console.WriteLine("Получение следующего символа в ASCII таблице по заданному");
		char symbol = 'Q';
		Console.WriteLine("Заданый символ: " + symbol);
		char nextSymbol = (char)(symbol + 1);
		Console.WriteLine("Следующий символ: " + nextSymbol);
		
		Console.WriteLine("Вывод символа по номеру из таблицы ASCII");
		int charNumber = 97;
		Console.WriteLine("Номер символа: " + charNumber);
		char charByNumber = (char) charNumber;
		Console.WriteLine("Символ: " + charByNumber);
		
		Console.WriteLine("Расчет стоимости товара");
		double price = 1000;
		Console.WriteLine("Цена: " + price);
		int discount = 15;
		Console.WriteLine("Скидка: " + discount);
		double cost = price - price * discount / 100;
		Console.WriteLine("Итоговая стоимость: " + cost);
	}
	
}
