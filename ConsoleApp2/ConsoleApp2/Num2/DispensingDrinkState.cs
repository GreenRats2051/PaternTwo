using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Num2
{
    public class DispensingDrinkState : ICoffeeMachineState
    {
        private CoffeeMachine _coffeeMachine;

        public DispensingDrinkState(CoffeeMachine coffeeMachine)
        {
            _coffeeMachine = coffeeMachine;
        }

        public void InsertCoin() => Console.WriteLine("Напиток уже готов.");
        public void SelectDrink() => Console.WriteLine("Напиток уже готов.");
        public void DispenseDrink()
        {
            Console.WriteLine("Напиток выдан.");
            _coffeeMachine.SetState(new WaitingForCoinState(_coffeeMachine));
        }
    }
}
