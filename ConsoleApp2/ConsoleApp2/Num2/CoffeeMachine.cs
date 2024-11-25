using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Num2
{
    public class CoffeeMachine
    {
        private ICoffeeMachineState _currentState;

        public CoffeeMachine()
        {
            _currentState = new WaitingForCoinState(this);
        }

        public void SetState(ICoffeeMachineState state)
        {
            _currentState = state;
        }

        public void InsertCoin() => _currentState.InsertCoin();
        public void SelectDrink() => _currentState.SelectDrink();
        public void DispenseDrink() => _currentState.DispenseDrink();
    }
}
