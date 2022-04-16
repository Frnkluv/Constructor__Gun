namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun Kar98 = new Gun(false);
            Kar98.Shoot();
        }
    }
    class Gun
    {
        // С помощью  ctor создается быстро конструктор вида: public Gun { }. Это конструктор по дефолту. Может робить и без него.
        // То что ниже находится уже модифицировано мною, чтобы дать инфу заряжено или нет Оружие.
        public Gun(bool isLoaded)
        {
            _isLoaded = isLoaded;
        }

        private bool _isLoaded;
        private void Reload()
        {
            Console.WriteLine("Заряжаю...");
            _isLoaded = true;
            Console.WriteLine("Заряжено!!!");
        }

        public void Shoot()
        {
            if (!_isLoaded)
            {
                Console.WriteLine("Оружие не заряжено.");
                Reload();
            }
            Console.WriteLine("Пиу-пиу");
        }
    }
}