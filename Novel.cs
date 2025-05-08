namespace Novel
{
    class Program
    {
        
        static void Main()
        {
            Console.WriteLine("Создатель: Сегеда Даниил из группы ИПО-21.23");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            StartNovel();
        }

        static void StartNovel()
        {
            Console.Clear();
            Console.WriteLine("Добро пожаловать в консольную новелу!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Game();
        }

        static void Game()
        {
            try
            {
                Console.WriteLine(
                    "Однажды летним вечером, когда солнце уже начало клониться к закату, маленькая девочка по имени Аня сидела на берегу реки.");
                Console.WriteLine("Она смотрела на воду, которая плавно текла мимо, отражая золотые отблески неба.");
                Console.WriteLine("Вдруг она заметила что-то блестящее в воде...");

                Console.WriteLine("\nЧто Аня сделает?");
                Console.WriteLine("1. Попытается достать блестящий предмет.");
                Console.WriteLine("2. Решит, что это просто игра света, и останется на берегу.");
                Console.WriteLine("3. Позовёт на помощь друга, чтобы вместе посмотреть, что это.");
                Console.WriteLine("4. Решит вернуться домой и рассказать о находке родителям.");
                Console.WriteLine("5. Попробует бросить камень в воду, чтобы посмотреть, что произойдёт.");

                int choice1 = Convert.ToInt32(Console.ReadLine());

                if (choice1 == 1)
                {
                    Console.WriteLine(
                        "\nАня подошла к воде и попыталась достать блестящий предмет. Это оказалась маленькая золотая рыбка!");
                    Console.WriteLine(
                        "Рыбка заговорила с ней: 'Спасибо, что спасла меня! Я исполню одно твое желание.'");

                    Console.WriteLine("\nЧто Аня пожелает?");
                    Console.WriteLine("1. Чтобы все её мечты сбылись.");
                    Console.WriteLine("2. Чтобы её семья была всегда счастлива.");
                    Console.WriteLine("3. Чтобы она могла разговаривать с животными.");
                    Console.WriteLine("4. Чтобы она стала самой умной в школе.");
                    Console.WriteLine("5. Чтобы она могла летать.");

                    int choice2 = Convert.ToInt32(Console.ReadLine());

                    if (choice2 == 1)
                    {
                        Console.WriteLine(
                            "\nРыбка улыбнулась и сказала: 'Твои мечты сбудутся, но помни, что счастье — в простых вещах.'");
                        Console.WriteLine("Аня вернулась домой, и с тех пор её жизнь наполнилась радостью и чудесами.");
                        Varible.end = "Концовка: Мечты сбываются.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice2 == 2)
                    {
                        Console.WriteLine("\nРыбка кивнула: 'Твоя семья будет счастлива, ведь ты думаешь о других.'");
                        Console.WriteLine("Аня вернулась домой, и её семья стала жить в гармонии и радости.");
                        Varible.end = "Концовка: Семейное счастье.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice2 == 3)
                    {
                        Console.WriteLine(
                            "\nРыбка махнула хвостом: 'Теперь ты сможешь понимать язык животных. Используй этот дар с умом.'");
                        Console.WriteLine(
                            "Аня вернулась домой и начала разговаривать с птицами, кошками и даже муравьями.");
                        Varible.end = "Концовка: Дар общения с природой.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice2 == 4)
                    {
                        Console.WriteLine(
                            "\nРыбка подмигнула: 'Теперь ты будешь самой умной в школе, но не забывай, что знания — это ответственность.'");
                        Console.WriteLine(
                            "Аня вернулась домой и начала учиться с невероятной лёгкостью, но всегда помогала одноклассникам.");
                        Varible.end = "Концовка: Ум и доброта.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice2 == 5)
                    {
                        Console.WriteLine(
                            "\nРыбка взмахнула плавниками: 'Теперь ты можешь летать, но помни, что с великой силой приходит великая ответственность.'");
                        Console.WriteLine("Аня взлетела в небо и начала исследовать мир с высоты птичьего полёта.");
                        Varible.end = "Концовка: Свобода полёта.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                }
                else if (choice1 == 2)
                {
                    Console.WriteLine(
                        "\nАня осталась на берегу, наблюдая за закатом. Она чувствовала себя спокойно и умиротворённо.");
                    Console.WriteLine("Вдруг она услышала тихий голос: 'Ты выбрала покой, и это твоё счастье.'");
                    Console.WriteLine("Аня улыбнулась и поняла, что иногда лучше просто наслаждаться моментом.");
                    Varible.end = "Концовка: Спокойствие и гармония.";
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Final();
                }
                else if (choice1 == 3)
                {
                    Console.WriteLine("\nАня позвала своего друга Петю, чтобы он помог ей разобраться.");
                    Console.WriteLine(
                        "Вместе они подошли к воде и увидели, что блестящий предмет — это старинный ключ.");
                    Console.WriteLine("Петя предложил: 'Давай поищем, куда он подходит!'");

                    Console.WriteLine("\nЧто они сделают?");
                    Console.WriteLine("1. Отправятся на поиски замка, который откроет этот ключ.");
                    Console.WriteLine("2. Решат, что это просто старая вещь, и оставят ключ на месте.");
                    Console.WriteLine("3. Отнесут ключ взрослым, чтобы они помогли разобраться.");
                    Console.WriteLine("4. Спрячут ключ и решат вернуться за ним завтра.");
                    Console.WriteLine("5. Попробуют бросить ключ в воду, чтобы посмотреть, что произойдёт.");

                    int choice3 = Convert.ToInt32(Console.ReadLine());

                    if (choice3 == 1)
                    {
                        Console.WriteLine(
                            "\nАня и Петя отправились на поиски замка. После долгих приключений они нашли старую шкатулку в лесу.");
                        Console.WriteLine(
                            "В шкатулке оказались письма и фотографии, которые рассказали им историю их деревни.");
                        Varible.end = "Концовка: Историческое открытие.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice3 == 2)
                    {
                        Console.WriteLine("\nАня и Петя решили, что это просто старая вещь, и оставили ключ на месте.");
                        Console.WriteLine(
                            "Но через несколько дней они узнали, что ключ был частью важного артефакта, который теперь потерян.");
                        Varible.end = "Концовка: Упущенная возможность.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice3 == 3)
                    {
                        Console.WriteLine(
                            "\nАня и Петя отнесли ключ взрослым. Оказалось, что это ключ от старого сундука, который хранил семейные реликвии.");
                        Console.WriteLine("Благодаря этому, семья Ани узнала много нового о своих предках.");
                        Varible.end = "Концовка: Семейное наследие.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice3 == 4)
                    {
                        Console.WriteLine("\nАня и Петя спрятали ключ и решили вернуться за ним завтра.");
                        Console.WriteLine("Но на следующий день ключ исчез. Они так и не узнали, куда он пропал.");
                        Varible.end = "Концовка: Тайна потерянного ключа.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice3 == 5)
                    {
                        Console.WriteLine(
                            "\nАня и Петя бросили ключ в воду. Внезапно вода начала светиться, и появилась золотая рыбка.");
                        Console.WriteLine("Рыбка сказала: 'Вы освободили меня! Теперь я исполню одно ваше желание.'");
                        Varible.end = "Концовка: Неожиданная встреча.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                }
                else if (choice1 == 4)
                {
                    Console.WriteLine("\nАня решила вернуться домой и рассказать о находке родителям.");
                    Console.WriteLine("Родители похвалили её за осторожность и вместе с ней отправились к реке.");
                    Console.WriteLine(
                        "Оказалось, что блестящий предмет — это старинная монета, которая может быть частью клада.");

                    Console.WriteLine("\nЧто они сделают?");
                    Console.WriteLine("1. Начнут искать клад вместе.");
                    Console.WriteLine("2. Решат передать монету в музей.");
                    Console.WriteLine("3. Оставят монету на месте, чтобы не нарушать покой природы.");
                    Console.WriteLine("4. Попробуют бросить монету в воду, чтобы посмотреть, что произойдёт.");

                    int choice4 = Convert.ToInt32(Console.ReadLine());

                    if (choice4 == 1)
                    {
                        Console.WriteLine(
                            "\nСемья Ани начала искать клад. После долгих поисков они нашли старый сундук с сокровищами!");
                        Console.WriteLine(
                            "Теперь они могли жить безбедно, но всегда помнили, что главное — это семья.");
                        Varible.end = "Концовка: Семейное сокровище.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice4 == 2)
                    {
                        Console.WriteLine(
                            "\nСемья Ани передала монету в музей. Оказалось, что это редкий артефакт, который помог историкам узнать много нового.");
                        Console.WriteLine("Аня стала местной героиней, и её семья гордилась ею.");
                        Varible.end = "Концовка: Героиня истории.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice4 == 3)
                    {
                        Console.WriteLine(
                            "\nСемья Ани решила оставить монету на месте, чтобы не нарушать покой природы.");
                        Console.WriteLine(
                            "Аня поняла, что иногда лучше оставить всё как есть, чтобы сохранить гармонию.");
                        Varible.end = "Концовка: Уважение к природе.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice4 == 4)
                    {
                        Console.WriteLine(
                            "\nСемья Ани бросила монету в воду. Внезапно вода начала светиться, и появилась золотая рыбка.");
                        Console.WriteLine("Рыбка сказала: 'Вы освободили меня! Теперь я исполню одно ваше желание.'");
                        Varible.end = "Концовка: Волшебная встреча.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                }
                else if (choice1 == 5)
                {
                    Console.WriteLine(
                        "\nАня бросила камень в воду. Внезапно вода начала светиться, и появилась золотая рыбка.");
                    Console.WriteLine("Рыбка сказала: 'Ты разбудила меня! Теперь я исполню одно твоё желание.'");

                    Console.WriteLine("\nЧто Аня пожелает?");
                    Console.WriteLine("1. Чтобы все её мечты сбылись.");
                    Console.WriteLine("2. Чтобы её семья была всегда счастлива.");
                    Console.WriteLine("3. Чтобы она могла разговаривать с животными.");
                    Console.WriteLine("4. Чтобы она стала самой умной в школе.");
                    Console.WriteLine("5. Чтобы она могла летать.");

                    int choice5 = Convert.ToInt32(Console.ReadLine());

                    if (choice5 == 1)
                    {
                        Console.WriteLine(
                            "\nРыбка улыбнулась и сказала: 'Твои мечты сбудутся, но помни, что счастье — в простых вещах.'");
                        Console.WriteLine("Аня вернулась домой, и с тех пор её жизнь наполнилась радостью и чудесами.");
                        Varible.end = "Концовка: Мечты сбываются.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice5 == 2)
                    {
                        Console.WriteLine("\nРыбка кивнула: 'Твоя семья будет счастлива, ведь ты думаешь о других.'");
                        Console.WriteLine("Аня вернулась домой, и её семья стала жить в гармонии и радости.");
                        Varible.end = "Концовка: Семейное счастье.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice5 == 3)
                    {
                        Console.WriteLine(
                            "\nРыбка махнула хвостом: 'Теперь ты сможешь понимать язык животных. Используй этот дар с умом.'");
                        Console.WriteLine(
                            "Аня вернулась домой и начала разговаривать с птицами, кошками и даже муравьями.");
                        Varible.end = "Концовка: Дар общения с природой.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice5 == 4)
                    {
                        Console.WriteLine(
                            "\nРыбка подмигнула: 'Теперь ты будешь самой умной в школе, но не забывай, что знания — это ответственность.'");
                        Console.WriteLine(
                            "Аня вернулась домой и начала учиться с невероятной лёгкостью, но всегда помогала одноклассникам.");
                        Varible.end = "Концовка: Ум и доброта.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                    else if (choice5 == 5)
                    {
                        Console.WriteLine(
                            "\nРыбка взмахнула плавниками: 'Теперь ты можешь летать, но помни, что с великой силой приходит великая ответственность.'");
                        Console.WriteLine("Аня взлетела в небо и начала исследовать мир с высоты птичьего полёта.");
                        Varible.end = "Концовка: Свобода полёта.";
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Final();
                    }
                }
                else
                {
                    Console.WriteLine(
                        "\nАня так и не решилась сделать выбор. Она осталась на берегу, размышляя о жизни.");
                    Varible.end = "Концовка: Неопределенность.";
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Final();
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Restart();
            }
        }

        static void Final()
        {
            Console.Clear();
            Console.WriteLine(Varible.end);
            Console.WriteLine("\nВпишите 1, чтобы продолжить игру:");
            try
            {
                int choice1 = Convert.ToInt32(Console.ReadLine());
                if (choice1 == 1)
                {
                    Restart();
                }
                else
                {
                    Console.WriteLine("\nСпасибо за игру! Будем с нетерпением ждать вас снова!");
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Спасибо за игру! Будем с нетерпением ждать вас снова!");
            }
                
        }

        static void Restart()
        {
            StartNovel();
        }

    }

    class Varible
    {
        public static String end;
    }
    
}