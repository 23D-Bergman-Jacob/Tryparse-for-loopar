// using System.Security.Cryptography;
// int i = 0;
// while (i < 10)
// {
// 	System.Console.WriteLine("hej");
// 	i++;
// }
// for (int j = 0; j < 10; j++)
// {
// 	System.Console.WriteLine("hej");
// }
// Console.ReadLine();


// // System.Console.WriteLine("Skriv din ålder");
// // string age = Console.ReadLine();
// // // System.Console.WriteLine(age+age);
// // int ageNum = 0;


// // int.TryParse(age, out ageNum);
// // bool success = int.TryParse(age, out ageNum);
// // if (success==false){
// // 	System.Console.WriteLine("Number");
// // }
// // if (ageNum >= 18)
// // {
// // 	System.Console.WriteLine("Welcome");
// // }
// // Console.ReadLine();
int i = 0;
int k;
int money = 100;
string item;
int amountSum;
string amount;
int price;
while (true)
{
	k= 0;
	if (i == 1)
	{
		System.Console.WriteLine("Du har " + money + "kr kvar");
	}
	if (i == 0)
	{
	System.Console.WriteLine("Du kan köpa mellan 3 föremål du har 100 kr");
	i++;
	}
	while (true)
	{
	System.Console.WriteLine("vilket föremål vill du köpa?");
	System.Console.WriteLine("Cola 20kr, pepsi 15kr, korv 25kr");
	item = Console.ReadLine();
	if (item.ToLower() == "cola")
	{
		price = 20;
		break;
	}
	if (item.ToLower() == "pepsi")
	{
		price = 15;
		break;
	}
	if (item.ToLower() == "korv")
	{	
		price = 25;
		break;
	}
	}
	while (true)
	{
		if (k==0)
		{
		System.Console.WriteLine("Hur många vill du köpa?");
		k++;
		}
		amount = Console.ReadLine();
		bool success = int.TryParse(amount, out amountSum);
		if (success==false)
		{
			System.Console.WriteLine("Skriv hur många!");
		}
		else { break;}}
	money = money - price*amountSum;
	if (money<0){
		System.Console.WriteLine("du har inte råd");
			money = money + price*amountSum;
	} 
	if (money == 0)
	{break;}
}
System.Console.WriteLine("du har spenderat alla dine pengar hejdå.");
Console.ReadLine();