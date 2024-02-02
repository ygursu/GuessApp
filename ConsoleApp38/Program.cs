class Program
{
    static void Main(string[] args)
    {
        string[] kelimeler = { "araba", "elma", "yazı", "eldiven" };
        string secilenKelime;
        int hak = 5;
        Random rnd = new Random();
        secilenKelime = kelimeler[rnd.Next(0, kelimeler.Length - 1)];
        char[] yertutucu = new char[secilenKelime.Length];

        for (int i = 0; i < yertutucu.Length; i++)
        {
            yertutucu[i] = '-';
            Console.Write('-');
        }
        Console.WriteLine();

        while (true)
        {

            Console.WriteLine("Kalan Hak:{0}", hak);
            Console.Write("Bir harf girin   :");
            char harf = Convert.ToChar(Console.ReadLine());

            bool bayrak = false;
            int kalanKelime = 0;
            for (int i = 0; i < secilenKelime.Length; i++)
            {
                if (secilenKelime[i] == harf)
                {
                    yertutucu[i] = harf;
                    bayrak = true;
                }
                if (yertutucu[i] == '-')
                {
                    kalanKelime++;
                }
                Console.Write(yertutucu[i]);
            }
            Console.WriteLine();

            if (kalanKelime == 0)
            {
                Console.WriteLine("Tebrikler...");
                break;
            }

            if (bayrak == false)
            {
                hak--;
            }

            if (hak == 0)
            {
                Console.WriteLine("Üzgünüm kaybettiniz.");
                break;
            }

            Console.WriteLine("******************");
        }

        Console.Write("Seçtiğim kelime << {0} >>", secilenKelime);
        Console.ReadLine();
    }
}

