using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.AdapterPattern;
using DesignPatterns.Chain_of_Responsibility_Pattern;
using DesignPatterns.CommandPattern;
using DesignPatterns.CompositePattern;
using DesignPatterns.Decoratory_Pattern;
using DesignPatterns.FacadePattern;
using DesignPatterns.FactoryPattern;
using DesignPatterns.MediatorPattern;
using DesignPatterns.ObserverPattern;
using DesignPatterns.Proxy_Pattern;
using DesignPatterns.Singleton;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton
            /*
            SingletonExample singletonExample = SingletonExample.GetInstance();
            */
            //--------------------------------------------------------------------------------

            //FactoryPattern

            /*
            CardFactory cardFactory = null;
            Console.Write("Enter the card type you would like to visit: ");
            string card = Console.ReadLine();
            switch (card.ToLower())
            {
                case "moneyback":
                    cardFactory = new MoneyBackFactory(50000, 0);
                    break;
                case "titanium":
                    cardFactory = new TitaniumFactory(100000, 500);
                    break;
                case "platinum":
                    cardFactory = new PlatinumFactory(500000, 1000);
                    break;
                default:
                    break;
            }

            CreditCard creditCard = cardFactory.GetCreditCard();
            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            Console.ReadKey();
          */
            //--------------------------------------------------------------------------------
            //Facade Pattern

            /*
            // Creating the Order/Product details
            OrderDetails orderDetails = new OrderDetails("C# Design Pattern Book",
                                                         "Simplified book on design patterns in C#",
                                                         500,
                                                         10,
                                                         "Street No 1",
                                                         "Educational Area",
                                                         1212,
                                                         "4156213754"
                                                         );

            // Using Facade
            OnlineShoppingFacade facade = new OnlineShoppingFacade();
            facade.FinalizeOrder(orderDetails);

            Console.ReadLine();
            */
            //----------------------------------------------------------------------------------
            //Adapter Pattern
            /*
            ITarget target = new EmployeeAdapter();
            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(target);
            client.ShowEmployeeList();
            Console.ReadLine();
            */
            //----------------------------------------------------------------------------------
            //Composite Pattern

            /*
            Employee Rahul = new Employee { EmpID = 1, Name = "Rahul" };

            Employee Amit = new Employee { EmpID = 2, Name = "Amit" };
            Employee Mohan = new Employee { EmpID = 3, Name = "Mohan" };

            Rahul.AddSubordinate(Amit);
            Rahul.AddSubordinate(Mohan);

            Employee Rita = new Employee { EmpID = 4, Name = "Rita" };
            Employee Hari = new Employee { EmpID = 5, Name = "Hari" };

            Amit.AddSubordinate(Rita);
            Amit.AddSubordinate(Hari);

            Employee Kamal = new Employee { EmpID = 6, Name = "Kamal" };
            Employee Raj = new Employee { EmpID = 7, Name = "Raj" };

            Contractor Sam = new Contractor { EmpID = 8, Name = "Sam" };
            Contractor tim = new Contractor { EmpID = 9, Name = "Tim" };

            Mohan.AddSubordinate(Kamal);
            Mohan.AddSubordinate(Raj);
            Mohan.AddSubordinate(Sam);
            Mohan.AddSubordinate(tim);

            Console.WriteLine("EmpID={0}, Name={1}", Rahul.EmpID, Rahul.Name);

            foreach (Employee manager in Rahul)
            {
                Console.WriteLine("\n EmpID={0}, Name={1}", manager.EmpID, manager.Name);

                foreach (var employee in manager)
                {
                    Console.WriteLine(" \t EmpID={0}, Name={1}", employee.EmpID, employee.Name);
                }
            }
            Console.ReadKey();
            */
            //----------------------------------------------------------------------------------
            //Proxy Pattern

            /*
            var imgProxy = new ImageProxy();
            var image = imgProxy.GetImage();
            Console.ReadKey();
            */
            //----------------------------------------------------------------------------------
            //Decorator Pattern

            /*
            // Basic vehicle
            HondaCity car = new HondaCity();

            Console.WriteLine("Honda City base price are : {0}", car.Price);

            // Special offer
            SpecialOffer offer = new SpecialOffer(car);
            offer.DiscountPercentage = 25;
            offer.Offer = "25 % discount";

            Console.WriteLine("{1} @ Diwali Special Offer and price are : {0} ", offer.Price, offer.Offer);

            Console.ReadKey();
            */

            //----------------------------------------------------------------------------------
            //Chain of responsibilty 

            /*
            TeamLeader tl = new TeamLeader();
            ProjectLeader pl = new ProjectLeader();
            HR hr = new HR();

            // Now lets set the hierarchy of employees
            tl.Supervisor = pl;
            pl.Supervisor = hr;

            // Now lets apply 5 day leave my TL
            tl.ApplyLeave(new Leave(Guid.NewGuid(), 5));

            // Now lets apply 15 day leave my TL
            tl.ApplyLeave(new Leave(Guid.NewGuid(), 15));

            // Now lets apply 25 day leave my TL
            tl.ApplyLeave(new Leave(Guid.NewGuid(), 25));

            // Now lets apply 35 day leave my TL
            tl.ApplyLeave(new Leave(Guid.NewGuid(), 35));

            Console.ReadLine();
            */

            //----------------------------------------------------------------------------------
            //Command Pattern
            /*
            Console.WriteLine("Enter Commands (ON/OFF) : ");
            string cmd = Console.ReadLine();

            Light lamp = new Light();
            ICommand switchUp = new FlipUpCommand(lamp);
            ICommand switchDown = new FlipDownCommand(lamp);

            Switch s = new Switch();

            if (cmd == "ON")
            {
                s.StoreAndExecute(switchUp);
            }
            else if (cmd == "OFF")
            {
                s.StoreAndExecute(switchDown);
            }
            else
            {
                Console.WriteLine("Command \"ON\" or \"OFF\" is required.");
            }

            Console.ReadKey();
            */

            //----------------------------------------------------------------------------------

            //Mediator Pattern

            /*
            // Create chatroom

            Chatroom chatroom = new Chatroom();

            // Create participants and register them

            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            // Chatting participants

            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");

            // Wait for user

            Console.ReadKey();
            */
            //----------------------------------------------------------------------------------
           //Observer Pattern

            DummyProduct product = new DummyProduct();

            // We have four shops wanting to keep updated price set by product owner
            Shop shop1 = new Shop("Shop 1");
            Shop shop2 = new Shop("Shop 2");

            Shop shop3 = new Shop("Shop 3");
            Shop shop4 = new Shop("Shop 4");

            //Lets use WAY_1 for first two shops
            product.Attach(shop1);
            product.Attach(shop2);

            //Lets use WAY_2 for other two shops
            product.Attach2(shop3);
            product.Attach2(shop4);

            //Now lets try changing the products price, this should update the shops automatically
            product.ChangePrice(23.0f);

            //Now shop2 and shop 4 are not interested in new prices so they unsubscribe
            product.Detach(shop2);
            product.Detach2(shop4);

            //Now lets try changing the products price again
            product.ChangePrice(26.0f);

            Console.Read();

        }
    }
}
