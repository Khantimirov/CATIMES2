using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATIMES2
{
    class Strana
    {
        public string Nazvannya;
        public string Stol;
        public Strana(String Nazvannya, String Stol)
        {
            this.Nazvannya = Nazvannya;
            this.Stol = Stol;
        }
        public Strana()
        {
        }
    }
    class Otel
    {
        public String ImyaOtelya;
        public int Zvezdy;
        public String Opisanie;
        public Strana NazvannyaStrany;
        public Otel(String ImyaOtelya, int Zvezdy, String Opisanie, Strana NazvannyaStrany)
        {
            this.ImyaOtelya = ImyaOtelya;
            this.Zvezdy = Zvezdy;
            this.Opisanie = Opisanie;
            this.NazvannyaStrany = NazvannyaStrany;
        }
        public Otel()
        { }
    }
    class Program
    {
            static void ProsmotrOtele(List<Otel> listOteli, List<Strana> listStran)
            {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                   Просмотр Отелей                  ");
            foreach (Otel a in listOteli)
                {
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Имя: " + a.ImyaOtelya);
                    Console.WriteLine("Количество звёзд: " + a.Zvezdy);
                    Console.WriteLine("Описание: " + a.Opisanie);
                    Console.WriteLine("Страна: " + a.NazvannyaStrany.Nazvannya);
                }
        }
        static void ProsmotrStran(List<Strana> listStran)
            {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                   Просмотр Стран                   ");
            foreach (Strana b in listStran)
                {
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Название: " + b.Nazvannya);
                    Console.WriteLine("Столица: " + b.Stol);
                }
        }
        static void DobavOtele(List<Otel> listOteli, List<Strana> listStran)
            {
            Console.WriteLine("");
            Console.WriteLine("                 Добавление Отелей                  ");
            Console.WriteLine("----------------------------------------------------");
            
            Console.WriteLine("");
            String ImaOtela, Opis, Stran;
                int Zvozdy;
                Strana VybranaStrana = null;
                Console.Write("Введите название отеля: ");
                ImaOtela = Console.ReadLine();
                Console.Write("Количество звёзд: ");
                Zvozdy = Convert.ToInt32(Console.ReadLine());
                Console.Write("Описание: ");
                Opis = Console.ReadLine();
                Console.Write("Страна: ");
                Stran = Console.ReadLine();
                foreach (Strana c in listStran)
                {
                    if (Stran == c.Nazvannya)
                    {
                        VybranaStrana = c;
                        break;
                    }
                }
                if (VybranaStrana == null)
                {
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine(" Неправильно введена страна! Отель не был создан =( ");
                    return;
                }
                listOteli.Add(new Otel(ImaOtela, Zvozdy, Opis, VybranaStrana));
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("                   Успешный успех                   ");
                Console.WriteLine("");
            }
        static void DobavStran(List<Strana> listStran)
        {
            Console.WriteLine("");
            Console.WriteLine("                  Добавление Страны                 ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");
            String Nazva, Stola;
            Console.Write("Введите название страны: ");
            Nazva = Console.ReadLine();
            Console.Write("Введите название столицы: ");
            Stola = Console.ReadLine();
            listStran.Add(new Strana(Nazva, Stola));
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("            Успешный успех, и тут, и там            ");
            Console.WriteLine("");
        }
        static void UdalOtel(List<Otel> listOteli)
        {
            Console.WriteLine("");
            Console.WriteLine("                  Удаление Отелей                   ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("0. Выйти");
            Console.Write("1. Введите номер, который хотите удалить: ");
            int Del = Convert.ToInt32(Console.ReadLine());
            if (Del == 0)
            {
                return;
            }
            else
            {
                Del = Del - 1;
                listOteli.RemoveAt(Del);
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("                  Отель был удалён                  ");
            }
        }
        static void UdalStrany(List<Strana> listStran)
        {
            Console.WriteLine("");
            Console.WriteLine("                  Удаление Страны                   ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("0. Выйти");
            Console.Write("1. Введите номер, который хотите удалить: ");
            int Del = Convert.ToInt32(Console.ReadLine());
            if (Del == 0)
            {
                return;
            }
            else
            {
                Del = Del - 1;
                listStran.RemoveAt(Del);
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("                Страна была удалёна                ");
            }
        }
        static void Main(string[] args)
                {

                    List<Strana> listStran = new List<Strana>();
                    listStran.Add(new Strana("Раиссия", "Москоу"));
                    listStran.Add(new Strana("ЮАР", "Препавывакп"));
                    listStran.Add(new Strana("Индия", "Дели"));
                    List<Otel> listOteli = new List<Otel>();
                    listOteli.Add(new Otel("Регина", 3, "Если вы оказались в нашем городе, и вам негде переночевать, тогда <<Регина>> - это ваш выбор!", listStran[0]));

                    while (true)
                    {
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("1. Просмотреть oтелей");
                        Console.WriteLine("2. Просмотреть стран");
                        Console.WriteLine("3. Добавить отеля");
                        Console.WriteLine("4. Добавить страны");
                        Console.WriteLine("5. Удалить отелей");
                        Console.WriteLine("6. Удалить страны");
                        Console.WriteLine("0. Выйти отсюда (либо ввести не int-овое значение)");
                        Console.WriteLine("");
                        Console.Write("A. Выберите, что вы хотите сделать: ");
                int Vybor = Convert.ToInt32(Console.ReadLine());
                        if (Vybor == 1)
                        {
                            ProsmotrOtele(listOteli, listStran);
                        }
                        else if (Vybor == 2)
                        {
                            ProsmotrStran(listStran);
                        }
                        else if (Vybor == 3)
                        {
                            DobavOtele(listOteli, listStran);
                        }
                        else if (Vybor == 4)
                        {
                            DobavStran(listStran);
                        }
                        else if (Vybor == 5)
                        {
                            UdalOtel(listOteli);
                        }
                        else if (Vybor == 6)
                        {
                            UdalStrany(listStran);
                        }
                        else if (Vybor == 0)
                        {
                            break;
                        }
                    }
                }

            }
        }
