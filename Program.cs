using KESCHA.Classes;

System.Console.Write("\nIsmingizni kiritng: ");
string foydalanuvchiIsmi=Console.ReadLine();

System.Console.WriteLine($"\nXush kelibsiz {foydalanuvchiIsmi}");

System.Console.Write($"\n{foydalanuvchiIsmi} tug'ulgan yilingizni kiriting: ");
int tyil=Convert.ToInt32(Console.ReadLine());

int foydalanuvchiYoshi= 2023-tyil;

System.Console.WriteLine($"\n{foydalanuvchiIsmi} yoshingizni sinxronlayabman...");
System.Console.WriteLine($"\nIsmingiz : {foydalanuvchiIsmi} va Yoshingiz : {foydalanuvchiYoshi} sinxronlandi!");

Animal kescha =new Animal(hayvonIsmi:"Kescha",foydalanuvchiYoshi,hayvonYoshi:3);

kescha.Age=3;

int yoshxisob=foydalanuvchiYoshi-kescha.Age;

System.Console.WriteLine($"\nHayvon ismi : {kescha.Name}");
System.Console.WriteLine($"\nHayvon yoshi : {kescha.Age}");

kescha.PrintyoshXisob();
kescha.Compair(foydalanuvchiYoshi);
kescha.dhaqida(foydalanuvchiIsmi,foydalanuvchiYoshi);
