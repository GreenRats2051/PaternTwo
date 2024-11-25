using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Num2
{
    public class SelectingDrinkState : ICoffeeMachineState
    {
        private CoffeeMachine _coffeeMachine;

        public SelectingDrinkState(CoffeeMachine coffeeMachine)
        {
            _coffeeMachine = coffeeMachine;
        }

        public void InsertCoin() => Console.WriteLine("Вы уже внесли монету.");
        public void SelectDrink()
        {
            Console.WriteLine("Напиток выбран.");
            _coffeeMachine.SetState(new DispensingDrinkState(_coffeeMachine));
        }

        public void DispenseDrink() => Console.WriteLine("Сначала выберите напиток.");
    }
}
