# SquareCalculator
1. SquareCalculator - библиотека с классом калькулятора, который содержащит внутри себя методы перегрузки для вычисления площади.
Это простой класс, поэтому очень легко расширяется, но мы должны держать в голове условное разделение, что под каждую фигуру должно быть разное количество параметров, что не удобно.
Я бы выбрал этот вариант если бы требовалось временное решение, но максимально простое.
Тесты для него - SquareCalculator.Tests
2. SquareCalculatorFactory - библиотека с классами фигур и калькулятора, который поддерживает вычисление площади только для экземпляров фигур соблюдающих контракт(интерфейс) IFigure.
Это более сложный класс, благодаря чему можно прописывать логику для каждой фигуры внутри нее(например вычисления для прямоугольного треугольника), что упрощает понимание кода, но увеличивает длительность его разработки. 
И реализация самого калькулятора через статический класс позволяет унифицировать процесс вычисления(конкретный алгоритм Проверяем->считаем).
Я бы выбрал этот вариант в большинстве случаев, т.к. затраченное время на разработку в дальнейшем окупиться более быстрым пониманием и поддержкой кода.
Тесты для этой библиотеки - SquareCalculatorFactory.Test
# SQL - products and categories
В данном задании необходимо вывести все продукты и их категории, даже если у продукта нет категории - используем LEFT JOIN.
Также мы делаем предположение, что существует третья таблица для объединения таблиц Продукты и Категории по их ID, т.к. иначе непонятно, как соотносятся категории и продукты (например, если продукту соответствует несколько категорий).
С учетом описанных замечаний итоговый запрос будет выглядеть следующим образом:
SELECT Products.Name, Categories.Name FROM Products 
LEFT JOIN ProductCategories ON Products.ID = ProductCategories.ProductID
LEFT JOIN Categories ON ProductCategories.CategoryID = Categories.ID;
