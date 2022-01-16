namespace CoffeeMachine
{
    class CoffeeMachine
    {
        int coffee;
        int water;
        int milk;
        int chocolate;
        void Coffeemachine(int water, int coffee, int chocolate, int milk)
        {
            this.water = water;
            this.coffee = coffee;
            this.chocolate = chocolate;
            this.milk = milk;
        }
        void buyBlackCoffee(int amountofwater, int amountofcoffee)
        {
            if (this.water > amountofwater)
            {
                this.water -= amountofwater;
            }
            if (this.coffee > amountofcoffee)
            {
                this.coffee -= amountofcoffee;
            }
            else
            {
                Console.WriteLine("Can't sale this amount");
            }
        }
        void buyMocha(int amountofwater, int amountofcoffee, int amountofchocolate)
        {
            if (this.water > amountofwater)
            {
                this.water -= amountofwater;
            }
            if (this.coffee > amountofcoffee)
            {
                this.coffee -= amountofcoffee;
            }
            if (this.chocolate > amountofchocolate)
            {
                this.chocolate -= amountofchocolate;
            }
            else
            {
                Console.WriteLine("Can't sale this amount");
            }
        }
        void buyLatte(int amountofwater, int amountofcoffee, int amountofmilk)
        {
            if (this.water > amountofwater)
            {
                this.water -= amountofwater;
            }
            if (this.coffee > amountofcoffee)
            {
                this.coffee -= amountofcoffee;
            }
            if (this.milk > amountofmilk)
            {
                this.milk -= amountofmilk;
            }
            else
            {
                Console.WriteLine("Can't sale this amount");
            }
        }
        void buyChocolate(int amountofwater, int amountofchocolate)
        {
            if (this.water > amountofwater)
            {
                this.water -= amountofwater;
            }
            if (this.chocolate > amountofchocolate)
            {
                this.chocolate -= amountofchocolate;
            }
            else
            {
                Console.WriteLine("Can't sale this amount");
            }
        }
        void AddBlackCoffeeMixture(int amountofwater, int amountofcoffee)
        {
            water += amountofwater;
            coffee += amountofcoffee;
        }
        void AddMochaMixture(int amountofwater, int amountofcoffee, int amountofchocolate)
        {
            water += amountofwater;
            coffee += amountofcoffee;
            chocolate += amountofchocolate;
        }
        void AddLatteMixture(int amountofwater, int amountofcoffee, int amountofmilk)
        {
            water += amountofwater;
            coffee += amountofcoffee;
            milk += amountofmilk;
        }
        void AddChocolateMixture(int amountofwater, int amountofchocolate)
        {
            water += amountofwater;
            chocolate += amountofchocolate;
        }
    }