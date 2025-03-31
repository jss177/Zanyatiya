namespace TypeOperationsWorkshop;

class Program
{
	static void Main(string[] args)
	{
		//double TransferBitesToKilobites(double bites)

		
		Console.WriteLine("Килобайты: " + TransferBitesToKilobites(3500));
		Console.WriteLine();
		Console.WriteLine("Килобайты: " + TransferBitesToKilobites(4300));
		Console.WriteLine();
		Console.WriteLine("Килобайты: " + TransferBitesToKilobites(900));
		Console.WriteLine();
		
		//void ShowHoursAndMinutesByTotalMinutes(double minutes)
		Console.WriteLine("Перевод часы в минуты");
		double minutes = 94;
		Console.WriteLine("Минуты: " + minutes);
		double hours = 94 / 60;
		Console.WriteLine("Часы: " + hours);
		minutes = minutes % 60;	
		Console.WriteLine("Минут: " + minutes);
		Console.WriteLine();
		
		//double CalculationAverage(double firstNumber, double secondNumber, double thirdNumber)
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
		
		//double CalculationSquarePerimetr(double squareSide)
		Console.WriteLine("Вычисление периметра квадрата");
		double squareSide = 5;
		Console.WriteLine("Сторона квадрата: " + squareSide);
		double squarePerimetr = 4 * squareSide;
		Console.WriteLine("Периметр квадрата: " + squarePerimetr);
		Console.WriteLine();
		
		//double TransferKilometersToMeters(double meters)
		Console.WriteLine("Перевод км в м");
		double kilometers = 10;
		Console.WriteLine("Километры: " + kilometers);
		double meters = kilometers * 1000;
		Console.WriteLine("Метры: " + meters);
		Console.WriteLine();
		
		//double SearchRectangleSquare(double a , double b)
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
		
		//double SearchSqareCircle(double radiusCircle)
		Console.WriteLine("Поиск площади круга");
		double radiusCircle = 9;
		Console.WriteLine("Радиус круга: " + radiusCircle);
		double squareCircle = Math.PI * radiusCircle * radiusCircle;
		Console.WriteLine("Площадь круга: " + squareCircle);
		Console.WriteLine();
		
		//double TransferCelsiusToFahrenheit(double celsius)
		Console.WriteLine("Перевод градусов цельсия в Фаренгейта");
		double celsius = 22.5;
		Console.WriteLine("Градусы по цельсию: " + celsius);
		double fahrenheit = celsius * 9.0 / 5.0 + 32;		
        Console.WriteLine("Температура по фаренгейту: " + fahrenheit);
		Console.WriteLine();
		
		//char GetNextSymbolAscii(char symbol)
		Console.WriteLine("Получение следующего символа в ASCII таблице по заданному");
		char symbol = 'Q';
		Console.WriteLine("Заданый символ: " + symbol);
		char nextSymbol = (char)(symbol + 1);
		Console.WriteLine("Следующий символ: " + nextSymbol);
		
		//void ShowAsciiSymbolByNumber(int charNumber)
		Console.WriteLine("Вывод символа по номеру из таблицы ASCII");
		int charNumber = 97;
		Console.WriteLine("Номер символа: " + charNumber);
		char charByNumber = (char) charNumber;
		Console.WriteLine("Символ: " + charByNumber);
		
		//double GetProductPriceWithDiscount(double price , int discount)
		Console.WriteLine("Расчет стоимости товара");
		double price = 1000;
		Console.WriteLine("Цена: " + price);
		int discount = 15;
		Console.WriteLine("Скидка: " + discount);
		double cost = price - price * discount / 100;
		Console.WriteLine("Итоговая стоимость: " + cost);
	}
	
	static double TransferBitesToKilobites(double bites)
	{
		Console.WriteLine("Перевод байтов в килобайты");
		Console.WriteLine("Байты: " + bites);
		double kilobites = bites / 1024;
		
		return kilobites;
	}
	
}
