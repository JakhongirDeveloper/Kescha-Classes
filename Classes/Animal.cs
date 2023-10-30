namespace KESCHA.Classes
{
    class Animal
    {
        public string Name;
        public int Age;
        public int yoshxisob;
        

        public Animal(string hayvonIsmi,int foydalanuvchiYoshi,int hayvonYoshi)
        {
            Name=hayvonIsmi;
            Age=hayvonYoshi;
            CalculateYoshXisoblama(foydalanuvchiYoshi, hayvonYoshi);
        }
        public void PrintyoshXisob()
        {
            System.Console.WriteLine($"\nSizning yoshingiz {Name}ning yoshidan {yoshxisob}-yoshga katta!");
        }
        public void Compair(int foydalanuvchiYoshi)
        {
            if (foydalanuvchiYoshi>Age)
            {
                System.Console.WriteLine($"\nSizning yoshi {Name}ning yoshidan katta!\n");
            }
            else if (foydalanuvchiYoshi==Age)
            {
                System.Console.WriteLine($"\nSiz va {Name} yoshlari teng!\n");
            }
            else 
            {
                System.Console.WriteLine($"\nSizning yoshingiz {Name}ning yoshidan kichik!\n");
            }
        }
        public void dhaqida(string foydalanuvchiIsmi,int foydalanuvchiYoshi)
        {
            System.Console.WriteLine("Keling sizga do'stlarim haqida aytib beraman.");
            string [] dIsmi = new string [3];
            dIsmi[0]="Xudoyberdi";
            dIsmi[1]="Egamberdi";
            dIsmi[2]=foydalanuvchiIsmi;

            int [] dyosh= {23,21,foydalanuvchiYoshi};

            for (int i=0;i<dyosh.Length;i++)
            {
                System.Console.WriteLine($"\n{dIsmi[i]} {dyosh[i]}-yoshda!");
            }
        }
        private int CalculateYoshXisobla(int foydalanuvchiYoshi,int hayvonYoshi)
        {
            return foydalanuvchiYoshi-hayvonYoshi;
        }
        private void CalculateYoshXisoblama(int foydalanuvchiYoshi,int hayvonYoshi)
        {
            yoshxisob=foydalanuvchiYoshi-hayvonYoshi;
        }
    }
}