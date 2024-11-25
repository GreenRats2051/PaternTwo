using ConsoleApp2.Num1;
using ConsoleApp2.Num2;
using ConsoleApp2.Num3;
using ConsoleApp2.Num4;

Console.WriteLine("Задание 1");
Sphere originalSphere = new Sphere("Красный", (0, 0, 0));
Sphere clone1 = (Sphere)originalSphere.Clone();
Sphere clone2 = (Sphere)originalSphere.Clone();
clone1.Position = (1, 1, 1);
clone2.Position = (2, 2, 2);
Console.WriteLine(originalSphere);
Console.WriteLine(clone1);
Console.WriteLine(clone2);

Console.WriteLine("Задание 2");
CoffeeMachine coffeeMachine = new CoffeeMachine();
coffeeMachine.InsertCoin();
coffeeMachine.SelectDrink();
coffeeMachine.DispenseDrink();

Console.WriteLine("Задание 3");
ChatMediator mediator = new ChatMediator();
ChatMember alice = new ChatMember("Alice", mediator);
ChatMember bob = new ChatMember("Bob", mediator);
alice.SendMessage("Привет, Боб!");
bob.SendMessage("Привет, Элис!");

Console.WriteLine("Задание 4");
IOrder order = new BaseOrder();
order = new ExpressDelivery(order);
order = new GiftWrapping(order);
Console.WriteLine($"Итоговая цена: {order.GetPrice()}");
Console.WriteLine($"Описание заказа: {order.GetDescription()}");