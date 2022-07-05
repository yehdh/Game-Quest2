using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            Seva Seva = new Seva();
            Item Milk = new Item("milk");
            Item Bear = new Item("bear");

            Console.WriteLine("Распределите очки характеристик");
            Console.WriteLine();

            int chars = 5;
            while (chars > 0)
            {
                Console.WriteLine("Ваши характеристики:");
                Console.WriteLine();

                Console.WriteLine("1 Здоровье: " + Seva.hp);
                Console.WriteLine("2 Сила: " + Seva.strong);
                Console.WriteLine("3 Харизма: " + Seva.charisma);
                Console.WriteLine("4 Удача: " + Seva.luck);
                Console.WriteLine();
                Console.WriteLine("Оставшиеся очки: " + chars);
                Console.WriteLine();
                Char1(Seva);
                chars -=1;
            }

            Console.WriteLine();
            Console.WriteLine("Вы - Сева. Проснулись с бодуна и ваша жена послала вас за молоком. У вас есть 2 часа чтобы добраться до магазина и выполнить поручение вашей половинки");
            Console.WriteLine();


            Time(Seva);
            AM(Seva);

            Time(Seva);
            Console.WriteLine("Вы выходите из дома и встречаете бабок, сидящих возле подъезда");
            Console.WriteLine();

            B(Seva);
            Console.ReadLine();

            Time(Seva);
            Console.WriteLine("Вы выходите на улицу. Чтобы добраться до магазина осталось лишь перейти дорогу");
            Console.WriteLine();

            Road(Seva);
            Console.ReadLine();

            Time(Seva);
            Console.WriteLine("Вы добрались до магазина");
            Console.WriteLine();

            Shop(Seva, Milk, Bear);
            Console.ReadLine();

            Time(Seva);
            Console.WriteLine("Вы закончили дела в магазине снова направляетесь на свою улицу");
            Console.WriteLine();

            Road(Seva);
            Console.ReadLine();

            Time(Seva);
            Console.WriteLine("Вы встречаете своих друзьей собутыльников");
            Console.WriteLine();

            Friends(Seva);
            Console.ReadLine();

            Time(Seva);
            Console.WriteLine("Вы приближаетесь к своему дому и снова натыкаетесь на бабок");
            Console.WriteLine();

            B(Seva);
            Console.ReadLine();

            Time(Seva);
            Console.WriteLine("У входа в подъезд вас поджижают гопники");
            Console.WriteLine();

            Gop(Seva);
            Console.ReadLine();

            Time(Seva);
            Console.WriteLine("Вы приходите домой и находите там жену");
            Console.WriteLine();

            Fboss(Seva);
            Console.ReadLine();







            void AM(Seva seva)
            {
                Console.WriteLine("1 - Искать заначку (это займет некоторое время)");
                Console.WriteLine("2 - Выйти в подъезд");
                string st = Console.ReadLine();
                if (st == "1")
                {
                    seva.seek();
                    seva.time -= 15;
                    Console.ReadLine();
                    Console.WriteLine("Вы выходите в подъезд");
                    seva.time -= 5;
                }
                else if (st == "2")
                {
                    Console.WriteLine("Вы выходите в подъезд");
                    seva.time -= 5;
                    Console.ReadLine();
                }
                else
                {
                    AM(seva);
                }
            }




            void B(Seva seva)
            {
                Console.WriteLine("1 - Пообщаться (это займет некоторое время)");
                Console.WriteLine("2 - Проигнорировать");
                string st = Console.ReadLine();
                if (st == "1")
                {
                    seva.Say();
                    seva.time -= 15;
                    Console.ReadLine();
                    Console.WriteLine("Вы заканчиваете разговор и продолжаете идти");
                    seva.time -= 5;
                    Console.ReadLine();
                }
                else if (st == "2")
                {
                    Console.WriteLine("Вы игнориркете их и продолжаете идти");
                    seva.time -= 5;
                    Console.ReadLine();
                    Time(Seva);
                    Console.WriteLine("Вы натыкаетесь на гопников");
                    Gop(seva);
                }
                else
                {
                    B(seva);
                }
            }




            void Gop(Seva seva)
            {
                Opponent gop = new Opponent("gop", 2, 1, "подъезд");
                Console.WriteLine("1 - Драться");
                Console.WriteLine("2 - Пытаться договориться");
                string s = Console.ReadLine();
                if (s == "1")
                {
                    Fight(seva, gop);
                }
                else if (s == "2")
                {
                    if (seva.charisma >= 3)
                    {
                        Console.WriteLine("Вы смогли договорится с гопниками");
                        seva.time -= 5;
                    }

                    else
                    {
                        Console.WriteLine("Вы не смогли договорится с гопниками");
                        Console.ReadLine();
                        Console.WriteLine("Вы вступаете в бой с гопниками");
                        seva.time -= 5;
                        Fight(seva, gop);
                    }
                }
                else
                {
                    Gop(seva);
                }
            }




            void Road(Seva seva)
            {
                Console.WriteLine("1 - Перейти аккуратно (это займет некоторое время)");
                Console.WriteLine("2 - Перейти быстро");
                string s = Console.ReadLine();
                if (s == "1")
                {
                    Console.WriteLine("Вы переходите дорогу аккуратно");
                    seva.time -= 15;
                }
                else if (s == "2")
                {
                    if (seva.luck >= 3)
                    {
                        Console.WriteLine("Вы успешно перебегаете дорогу");
                        seva.time -= 5;
                    }
                    else
                    {
                        Console.WriteLine("У вас не получается перебежать дорогу и вам приходится аккуратно ее перейти");
                        seva.time -= 15;
                    }
                }
                else
                {
                    Road(seva);
                }
            }




            void Shop(Seva seva, Item milk, Item bear)
            {
                Console.WriteLine("1 - Купить молоко");
                Console.WriteLine("2 - Купить пиво");
                string s = Console.ReadLine();
                if (s == "1")
                {
                    seva.buy(milk);
                    Console.WriteLine("Вы купили молоко");
                    seva.time -= 5;
                }
                else if (s == "2")
                {
                    seva.buy(bear);
                    Console.WriteLine("Вы купили пиво");
                    Console.WriteLine();
                    Console.WriteLine("Вы пытаетесь купить молоко");
                    Console.WriteLine();
                    seva.buy(milk);
                    Console.WriteLine("Вы купили молоко");
                    seva.time -= 5;
                }
                else
                {
                    Shop(seva, milk, bear);
                }
            }




            void Friends(Seva seva)
            {
                Console.WriteLine("1 - Выпить с ними (это займет некоторое время)");
                Console.WriteLine("2 - Прокрасться мимо");
                Console.WriteLine("3 - Откупиться пивом");
                string s = Console.ReadLine();
                if (s == "1")
                {
                    Console.WriteLine("Вы останавливаетесь чтобы выпить сдрузьями");
                    seva.time -= 30;

                }
                else if (s == "2")
                {
                    if (seva.luck >= 4)
                    {
                        Console.WriteLine("Вам удается незаметно прокрасться мимо них");
                        seva.time -= 5;
                    }
                    else
                    {
                        Console.WriteLine("Вы пытаетесь незаметно прокрасться мимо них, но терпите неудачу. Вам ничего не остается кроме как выпить вместе с ними");
                        seva.time -= 30;
                    }
                }
                else if (s == "3")
                {
                    bool y = false;
                    foreach (Item i in seva.items)
                    {
                        if (i.name == "bear")
                        {
                            y = true;
                        }
                    }
                    if (y == true)
                    {
                        Console.WriteLine("Вам удается откупиться от них купленным пивом");
                        foreach (Item j in seva.items)
                        {
                            if (j.name == "bear")
                            {
                                seva.items.Remove(j);
                            }
                        }
                        seva.time -= 5;
                    }
                    else
                    {
                        Console.WriteLine("Вы пытаетесь откупиться от них купленным пивом, но терпите неудачу. Вам ничего не остается кроме как выпить вместе с ними");
                        seva.time -= 30;
                    }
                }
                else
                {
                    Friends(seva);
                }
            }




            void Fboss(Seva seva)
            {
                Opponent wife = new Opponent("wife", 4, 1, "дом");
                bool n = false;
                foreach (Item i in seva.items)
                {
                    if (i.name == "milk")
                    {
                        n = true;
                    }
                }
                if (seva.time >= 0 && n == true)
                {
                    Console.WriteLine("Вы пришли вовремя и пренесли молоко. Ваша жена довольна");
                    Console.WriteLine();
                    Console.WriteLine("Хорошая концовка");
                }

                else if (seva.time < 0)
                {
                    Console.WriteLine("Вы опоздали");
                    Console.WriteLine();
                    Console.WriteLine("Вы вступаете в бой с женой");
                    Console.WriteLine();
                    Fight(seva, wife);

                }

                else if (n != true)
                {
                    Console.WriteLine("Вы не принесли молоко");
                    Console.WriteLine();
                    Console.WriteLine("Вы вступаете в бой с женой");
                    Console.WriteLine();
                    Fight(seva, wife);
                    Console.WriteLine("Вы выиграли бой");
                    Console.WriteLine();
                    Console.WriteLine("Но концовка все равно плохая");
                    Console.WriteLine();
                    Environment.Exit(0);

                }

            }


            void Fight(Seva seva, Opponent npc)
            {
                while (npc.hp > 0 && seva.hp > 0)
                {
                    Console.WriteLine("Вы наносите удар");
                    Console.ReadLine();
                    seva.beat(npc);
                    Console.WriteLine("Вы: " + seva.hp + "hp");
                    Console.WriteLine("Оппонент: " + npc.hp + "hp");
                    Console.ReadLine();
                    npc.beat(seva);
                    Console.WriteLine("Оппонент наносите удар");
                    Console.ReadLine();
                }

                if (npc.hp <= 0)
                {
                    Console.WriteLine("Вы выиграли бой");
                }

                else
                {
                    Console.WriteLine("Вы проиграли бой");
                    Console.ReadLine();
                    Console.WriteLine("Плохая концовка");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

            }


            void Char1(Seva seva)
            {
                string s = Console.ReadLine();
                if (s == "1")
                {
                    seva.hp++;
                }

                else if (s == "2")
                {
                    seva.strong++;
                }

                else if (s == "3")
                {
                    seva.charisma++;
                }

                else if (s == "4")
                {
                    seva.luck++;
                }

                else
                {
                    Char1(seva);
                }
            }


            void Time(Seva seva)
            {
                if (seva.time <= 0)
                {
                    Console.WriteLine("Время вышло, вы опаздываете");
                }

                else
                {
                    Console.WriteLine("Оставшееся время: " + seva.time + " минут");
                }
            }


        }
    }
}
