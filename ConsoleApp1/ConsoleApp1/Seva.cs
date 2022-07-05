using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Seva : Person
	{

		public List<Item> items;
		public int luck;
		public int strong;
		public int charisma;
		public int time;
		Random random = new Random();
		public Seva()
		{
			Item item = new Item("Деньги");
			items = new List<Item>();
			this.name = "Сева";
			this.hp = 1;
			this.Location = "Квартира";
			luck = 1;
			strong = 1;
			charisma = 1;
			time = 120;
			this.items.Add(item);
		}
		public void beat(Person person)
		{
			person.hp -= strong;
		}
		public void Say() // договориться с кем нибудь
		{
			double chance = 0.2 * charisma;
			double risk = random.NextDouble();
			if (chance > risk)
			{
				Console.WriteLine("Успешно");
			}
			else
			{
				Console.WriteLine("Провал");
			}
		}
		public void buy(Item item)
		{
			for (int i = 0; i < items.Count; i++)
			{
				if (items[i].name == "Деньги")
				{
					items.Remove(items[i]);
					this.items.Add(item);
					break;
				}
				else
				{
					Console.WriteLine("У тебя нет деняг, вали отсюда");
				}
			}
		}
		public void seek()  //поиск заначки
		{
			if (this.luck >= 4)
			{
				Console.WriteLine("Успешно, ты нашел еще деняг");
				Item item = new Item("Деньги");
				this.items.Add(item);
			}
			else
			{
				Console.WriteLine("Провал");
			}
		}
		public void final()
		{
			if (time >= 0)
			{
				for (int i = 0; i < items.Count; i++)
				{
					if (items[i].name == "Молоко")
					{
						items.Remove(items[i]);
						Console.WriteLine("Спасибо, дорогой"); // Победа, конец
						break;
					}
					else
					{
						Console.WriteLine("Печалька"); // после этого будет файт
					}
				}
			}
			else
			{

			}
		}
		public void status()
		{
			if (hp <= 0)
			{
				Console.WriteLine("Мужик, да ты помер");
			}

		}

	}
}
