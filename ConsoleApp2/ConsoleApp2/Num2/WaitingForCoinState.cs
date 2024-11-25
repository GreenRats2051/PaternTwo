using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Num2
{
    public class WaitingForCoinState : ICoffeeMachineState
    {
        private CoffeeMachine _coffeeMachine;

        public WaitingForCoinState(CoffeeMachine coffeeMachine)
        {
            _coffeeMachine = coffeeMachine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("Монета внесена.");
            _coffeeMachine.SetState(new SelectingDrinkState(_coffeeMachine));
        }

        public void SelectDrink() => Console.WriteLine("Пожалуйста, внесите монету.");
        public void DispenseDrink() => Console.WriteLine("Пожалуйста, внесите монету.");
    }
}
