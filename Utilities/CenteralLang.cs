﻿using System.Collections.Generic;
using KitchenData;

namespace AussieClassics.Utilies
{
    public static class CenteralLang
    {
        public static class Unlocks
        {
            public static List<(Locale, UnlockInfo)> VegemiteToast => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Vegemite Toast", Description = "Adds Vegemite Toast as a Main", FlavourText = "Marmite? Never heard of her." }),
                (Locale.English, new UnlockInfo { Name = "Vegemite Toast", Description = "Adds Vegemite Toast as a Main", FlavourText = "Marmite? Never heard of her." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Toast au Vegemite", Description = "Ajoute le toast Vegemite comme plat principal", FlavourText = "Marmite ? Je n'ai jamais entendu parler d'elle." }),
                (Locale.German, new UnlockInfo { Name = "Vegemite-Toast", Description = "Fügt Vegemite-Toast als Hauptgericht hinzu", FlavourText = "Marmite? Nie von ihr gehört." }),
                (Locale.Spanish, new UnlockInfo { Name = "Tostadas de Vegemite", Description = "Añade tostadas de Vegemite como plato principal", FlavourText = "¿Marmite? Nunca he oído hablar de ella." }),
                (Locale.Polish, new UnlockInfo { Name = "Vegemite Toast", Description = "Dodaje Vegemite Toast jako danie główne", FlavourText = "Marmite? Nigdy o niej nie słyszałem." }),
                (Locale.Russian, new UnlockInfo { Name = "Тосты с вегемайтом", Description = "Добавляет тост Vegemite в качестве основного блюда", FlavourText = "Мармит? Никогда о ней не слышал." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Torrada de Vegemite", Description = "Adiciona torrada Vegemite como prato principal", FlavourText = "Marmite? Nunca ouvi falar dela." }),
                (Locale.Japanese, new UnlockInfo { Name = "ベジマイト・トースト", Description = "メインにベジマイト・トーストを追加", FlavourText = "マーマイト？聞いたことがない。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "素麦吐司", Description = "添加素麦吐司作为主食", FlavourText = "马米特？没听说过" }),
                (Locale.Korean, new UnlockInfo { Name = "베지마이트 토스트", Description = "베지마이트 토스트를 메인으로 추가합니다.", FlavourText = "마마이트? 들어본 적도 없는 이름입니다." }),
                (Locale.Turkish, new UnlockInfo { Name = "Vegemite Tost", Description = "Vegemite Tostu Ana Yemek Olarak Ekler", FlavourText = "Marmite mi? Onu hiç duymadım." }),
            };

            public static List<(Locale, UnlockInfo)> VegemiteToastCheese => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Vegemite Toast - Cheese", Description = "Add chopped cheese to Vegemite Toast", FlavourText = "A cheesy twist on a classic spread." }),
                (Locale.English, new UnlockInfo { Name = "Vegemite Toast - Cheese", Description = "Add chopped cheese to Vegemite Toast", FlavourText = "A cheesy twist on a classic spread." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Toast au Vegemite - Fromage", Description = "Ajouter du fromage haché aux toasts Vegemite", FlavourText = "Une variante au fromage d'une pâte à tartiner classique." }),
                (Locale.German, new UnlockInfo { Name = "Vegemite-Toast - Käse", Description = "Gehackten Käse auf Vegemite-Toast geben", FlavourText = "Eine käsige Variante eines klassischen Brotaufstrichs." }),
                (Locale.Spanish, new UnlockInfo { Name = "Tostada Vegemite - Queso", Description = "Añade queso picado a las tostadas de Vegemite", FlavourText = "Un toque de queso en un clásico para untar." }),
                (Locale.Polish, new UnlockInfo { Name = "Tosty Vegemite z serem", Description = "Dodaj posiekany ser do tostów Vegemite", FlavourText = "Tandetna wariacja na temat klasycznej pasty do smarowania." }),
                (Locale.Russian, new UnlockInfo { Name = "Тост \"Вегемайт\" с сыром", Description = "Добавьте измельченный сыр в тосты Vegemite.", FlavourText = "Сырная изюминка классического спреда." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Torrada de Vegemite - Queijo", Description = "Adicione queijo picado à torrada Vegemite", FlavourText = "Um toque de queijo em uma pasta clássica." }),
                (Locale.Japanese, new UnlockInfo { Name = "ベジマイト・トースト - チーズ", Description = "ベジマイト・トーストに刻んだチーズを加える", FlavourText = "クラシックなスプレッドに安っぽいひねりを加えた。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "素麦吐司 - 奶酪", Description = "在 Vegemite 吐司中加入切碎的奶酪", FlavourText = "经典涂抹中的芝士风味" }),
                (Locale.Korean, new UnlockInfo { Name = "베지마이트 토스트 - 치즈", Description = "베지마이트 토스트에 다진 치즈 추가하기", FlavourText = "클래식한 스프레드에 치즈맛을 더했습니다." }),
                (Locale.Turkish, new UnlockInfo { Name = "Vegemite Tost - Peynirli", Description = "Vegemite Tostuna doğranmış peynir ekleyin", FlavourText = "Klasik bir sürüme peynirli bir dokunuş." }),
            };

            public static List<(Locale, UnlockInfo)> FairyBread => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Fairy Bread", Description = "Adds Fairy Bread as a Main", FlavourText = "Childhood nostalgia, one slice at a time." }),
                (Locale.English, new UnlockInfo { Name = "Fairy Bread", Description = "Adds Fairy Bread as a Main", FlavourText = "Childhood nostalgia, one slice at a time." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Pain de fée", Description = "Ajoute le pain des fées comme aliment principal", FlavourText = "La nostalgie de l'enfance, une tranche à la fois." }),
                (Locale.German, new UnlockInfo { Name = "Feenbrot", Description = "Fügt Feenbrot als Hauptgericht hinzu", FlavourText = "Nostalgie aus der Kindheit, ein Stückchen nach dem anderen." }),
                (Locale.Spanish, new UnlockInfo { Name = "Pan de hadas", Description = "Añade pan de hadas como principal", FlavourText = "La nostalgia de la infancia, trozo a trozo." }),
                (Locale.Polish, new UnlockInfo { Name = "Wróżkowy chleb", Description = "Dodaje Fairy Bread jako danie główne", FlavourText = "Nostalgia za dzieciństwem, jeden kawałek na raz." }),
                (Locale.Russian, new UnlockInfo { Name = "Хлеб феи", Description = "Добавляет хлеб феи в качестве основного блюда", FlavourText = "Ностальгия по детству, один кусочек за раз." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Pão de fada", Description = "Adiciona o Fairy Bread como principal", FlavourText = "Nostalgia da infância, uma fatia de cada vez." }),
                (Locale.Japanese, new UnlockInfo { Name = "妖精のパン", Description = "メインにフェアリーブレッドを追加", FlavourText = "子供時代のノスタルジアを一切れずつ。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "仙女面包", Description = "添加仙女面包作为主食", FlavourText = "童年怀旧，一次一片。" }),
                (Locale.Korean, new UnlockInfo { Name = "요정 빵", Description = "요정 빵을 메인으로 추가", FlavourText = "어린 시절의 향수, 한 번에 한 조각씩." }),
                (Locale.Turkish, new UnlockInfo { Name = "Peri Ekmeği", Description = "Peri Ekmeğini Ana Ekmek Olarak Ekler", FlavourText = "Çocukluk nostaljisi, her seferinde bir dilim." }),
            };

            public static List<(Locale, UnlockInfo)> Pavlova => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Pavlova", Description = "Adds Pavlova as a Dessert", FlavourText = "Crunchy, creamy, and oh-so-dreamy." }),
                (Locale.English, new UnlockInfo { Name = "Pavlova", Description = "Adds Pavlova as a Dessert", FlavourText = "Crunchy, creamy, and oh-so-dreamy." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Pavlova", Description = "Ajoute la Pavlova comme dessert", FlavourText = "Croustillant, crémeux et tellement rêveur." }),
                (Locale.German, new UnlockInfo { Name = "Pavlova", Description = "Fügt Pavlova als Dessert hinzu", FlavourText = "Knusprig, cremig und einfach traumhaft." }),
                (Locale.Spanish, new UnlockInfo { Name = "Pavlova", Description = "Añade Pavlova como postre", FlavourText = "Crujiente, cremoso y delicioso." }),
                (Locale.Polish, new UnlockInfo { Name = "Pavlova", Description = "Dodaje Pavlova jako deser", FlavourText = "Chrupiące, kremowe i przepyszne." }),
                (Locale.Russian, new UnlockInfo { Name = "Павлова", Description = "Добавляет Павлову в качестве десерта", FlavourText = "Хрустящий, сливочный и просто мечтательный." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Pavlova", Description = "Adiciona Pavlova como sobremesa", FlavourText = "Crocante, cremoso e muito delicioso." }),
                (Locale.Japanese, new UnlockInfo { Name = "パブロワ", Description = "デザートとしてパブロワを追加", FlavourText = "サクサクで、クリーミーで、とてもドリーミー。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "帕夫洛娃", Description = "添加帕夫洛娃甜点", FlavourText = "脆脆的、奶香浓郁的，非常梦幻。" }),
                (Locale.Korean, new UnlockInfo { Name = "파블로바", Description = "파블로바를 디저트로 추가합니다.", FlavourText = "바삭하고 크리미하며 꿈결 같은 맛입니다." }),
                (Locale.Turkish, new UnlockInfo { Name = "Pavlova", Description = "Pavlova'yı Tatlı Olarak Ekliyor", FlavourText = "Çıtır çıtır, kremsi ve rüya gibi." }),
            };

            public static List<(Locale, UnlockInfo)> PavlovaToppings => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Pavlova - Extra Toppings", Description = "Adds Strawberries and Kiwi Fruit to Pavlova", FlavourText = "More fruit, more fun, more fabulous!" }),
                (Locale.English, new UnlockInfo { Name = "Pavlova - Extra Toppings", Description = "Adds Strawberries and Kiwi Fruit to Pavlova", FlavourText = "More fruit, more fun, more fabulous!" }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Pavlova - Garnitures supplémentaires", Description = "Ajoute des fraises et des kiwis à la pavlova", FlavourText = "Plus de fruits, plus de plaisir, plus de fabuleux !" }),
                (Locale.German, new UnlockInfo { Name = "Pavlova - Extra Belag", Description = "Fügt Erdbeeren und Kiwis zur Pavlova hinzu", FlavourText = "Mehr Obst, mehr Spaß, mehr Fabelhaftes!" }),
                (Locale.Spanish, new UnlockInfo { Name = "Pavlova - Extra Toppings", Description = "Añade fresas y kiwi a la pavlova", FlavourText = "Más fruta, más diversión, ¡más fabuloso!" }),
                (Locale.Polish, new UnlockInfo { Name = "Pavlova - dodatkowe dodatki", Description = "Dodaje truskawki i kiwi do Pavlovej", FlavourText = "Więcej owoców, więcej zabawy, więcej bajek!" }),
                (Locale.Russian, new UnlockInfo { Name = "Павлова - дополнительные начинки", Description = "Добавление клубники и киви в Павлову", FlavourText = "Больше фруктов, больше веселья, больше сказочности!" }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Pavlova - Coberturas extras", Description = "Adiciona morangos e kiwis à pavlova", FlavourText = "Mais frutas, mais diversão, mais fabulosas!" }),
                (Locale.Japanese, new UnlockInfo { Name = "パブロバ - 追加トッピング", Description = "パブロバにイチゴとキウイを加える", FlavourText = "もっとフルーツを、もっと楽しく、もっと素敵に！" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "帕夫洛娃 - 额外配料", Description = "在帕夫洛娃中加入草莓和奇异果", FlavourText = "更多水果，更多乐趣，更多精彩！" }),
                (Locale.Korean, new UnlockInfo { Name = "파블로바 - 추가 토핑", Description = "파블로바에 딸기와 키위 과일을 추가합니다.", FlavourText = "더 많은 과일, 더 많은 재미, 더 멋진!" }),
                (Locale.Turkish, new UnlockInfo { Name = "Pavlova - Ekstra Malzemeler", Description = "Pavlova'ya Çilek ve Kivi Meyvesi Ekliyor", FlavourText = "Daha çok meyve, daha çok eğlence, daha muhteşem!" }),
            };

            public static List<(Locale, UnlockInfo)> PizzaEgg => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Pizza - Egg", Description = "Adds egg as a pizza topping", FlavourText = "Crack it, bake it, love it." }),
                (Locale.English, new UnlockInfo { Name = "Pizza - Egg", Description = "Adds egg as a pizza topping", FlavourText = "Crack it, bake it, love it." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Pizza - Œuf", Description = "Ajouter un œuf comme garniture de pizza", FlavourText = "Craquez-le, faites-le cuire, aimez-le." }),
                (Locale.German, new UnlockInfo { Name = "Pizza - Ei", Description = "Fügt Ei als Pizzabelag hinzu", FlavourText = "Knacken, backen, lieben." }),
                (Locale.Spanish, new UnlockInfo { Name = "Pizza - Huevo", Description = "Añade huevo como ingrediente de la pizza", FlavourText = "Rómpelo, hornéalo, ámalo." }),
                (Locale.Polish, new UnlockInfo { Name = "Pizza - Jajko", Description = "Dodaje jajko jako dodatek do pizzy", FlavourText = "Pęknij, upiecz, pokochaj." }),
                (Locale.Russian, new UnlockInfo { Name = "Пицца - яйцо", Description = "Добавляет яйцо в качестве начинки для пиццы", FlavourText = "Раскалывайте, запекайте, любите." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Pizza - Ovo", Description = "Adiciona ovo como cobertura de pizza", FlavourText = "Quebre-o, asse-o, ame-o." }),
                (Locale.Japanese, new UnlockInfo { Name = "ピザ - 卵", Description = "ピザのトッピングに卵を加える", FlavourText = "割って、焼いて、愛して。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "比萨 - 鸡蛋", Description = "添加鸡蛋作为披萨配料", FlavourText = "敲碎它，烘烤它，爱上它。" }),
                (Locale.Korean, new UnlockInfo { Name = "피자 - 계란", Description = "피자 토핑으로 달걀을 추가합니다.", FlavourText = "깨고, 굽고, 사랑하세요." }),
                (Locale.Turkish, new UnlockInfo { Name = "Pizza - Yumurta", Description = "Yumurtayı pizza malzemesi olarak ekler", FlavourText = "Kır, pişir, sev." }),
            };

            public static List<(Locale, UnlockInfo)> TimTams => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "TimTams", Description = "Adds TimTams as a Side", FlavourText = "Australia’s sweetest secret weapon." }),
                (Locale.English, new UnlockInfo { Name = "TimTams", Description = "Adds TimTams as a Side", FlavourText = "Australia’s sweetest secret weapon." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "TimTams", Description = "Ajoute les TimTams en accompagnement", FlavourText = "L'arme secrète la plus douce d'Australie." }),
                (Locale.German, new UnlockInfo { Name = "TimTams", Description = "Fügt TimTams als Beilage hinzu", FlavourText = "Australiens süßeste Geheimwaffe." }),
                (Locale.Spanish, new UnlockInfo { Name = "TimTams", Description = "Añade TimTams como complemento", FlavourText = "El arma secreta más dulce de Australia." }),
                (Locale.Polish, new UnlockInfo { Name = "TimTams", Description = "Dodaje TimTams jako dodatek", FlavourText = "Najsłodsza tajna broń Australii." }),
                (Locale.Russian, new UnlockInfo { Name = "ТимТамс", Description = "Добавляет ТимТамс в качестве гарнира", FlavourText = "Самое сладкое секретное оружие Австралии." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "TimTams", Description = "Adiciona TimTams como acompanhamento", FlavourText = "A arma secreta mais doce da Austrália." }),
                (Locale.Japanese, new UnlockInfo { Name = "ティムタム", Description = "サイドメニューにティムタムを追加", FlavourText = "オーストラリアの甘い秘密兵器" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "TimTams", Description = "添加 TimTams 作为配菜", FlavourText = "澳大利亚最甜蜜的秘密武器" }),
                (Locale.Korean, new UnlockInfo { Name = "팀탐스", Description = "팀탐스를 사이드 메뉴로 추가", FlavourText = "호주에서 가장 달콤한 비밀병기." }),
                (Locale.Turkish, new UnlockInfo { Name = "TimTams", Description = "TimTams'ı Yan Ürün Olarak Ekler", FlavourText = "Avustralya'nın en tatlı gizli silahı." }),
            };

            public static List<(Locale, UnlockInfo)> Shoey => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Shoey", Description = "Adds Shoeys as a Side", FlavourText = "When a cup just isn’t Aussie enough." }),
                (Locale.English, new UnlockInfo { Name = "Shoey", Description = "Adds Shoeys as a Side", FlavourText = "When a cup just isn’t Aussie enough." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Shoey", Description = "Ajoute Shoeys comme côté", FlavourText = "Quand une tasse n'est pas assez australienne." }),
                (Locale.German, new UnlockInfo { Name = "Shoey", Description = "Fügt Shoeys als Seite hinzu", FlavourText = "Wenn eine Tasse einfach nicht australisch genug ist." }),
                (Locale.Spanish, new UnlockInfo { Name = "Shoey", Description = "Añade Shoeys como bando", FlavourText = "Cuando una taza no es lo suficientemente australiana." }),
                (Locale.Polish, new UnlockInfo { Name = "Shoey", Description = "Dodaje Shoeys jako stronę poboczną", FlavourText = "Kiedy kubek nie jest wystarczająco australijski." }),
                (Locale.Russian, new UnlockInfo { Name = "Shoey", Description = "Добавляет Шойса в качестве сайда", FlavourText = "Когда чашка просто недостаточно австралийская." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Sapato", Description = "Adiciona Shoeys como um lado", FlavourText = "Quando uma xícara não é suficientemente australiana." }),
                (Locale.Japanese, new UnlockInfo { Name = "シューイ", Description = "サイドにショーイを加える", FlavourText = "カップだけではオージーらしくないとき。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "Shoey", Description = "添加 Shoeys 为副队", FlavourText = "当杯子不够澳式时" }),
                (Locale.Korean, new UnlockInfo { Name = "Shoey", Description = "슈즈를 측면으로 추가", FlavourText = "한 잔으로 충분하지 않을 때." }),
                (Locale.Turkish, new UnlockInfo { Name = "Shoey", Description = "Shoeys'i Taraf Olarak Ekliyor", FlavourText = "Bir fincan yeterince Avustralyalı olmadığında." }),
            };
        }


        public static class Recipes
        {
            public static Dictionary<Locale, string> VegemiteToast => new Dictionary<Locale, string>
            {
                { Locale.Default, "Knead flour to make dough then cook to make bread cut a slice and cook to make toast then add Vegemite Spread" },
                { Locale.English, "Knead flour to make dough then cook to make bread cut a slice and cook to make toast then add Vegemite Spread" },
                { Locale.BlankText, "" },
                { Locale.French, "Pétrir la farine pour faire la pâte, puis cuire pour faire le pain, couper une tranche et cuire pour faire du pain grillé, puis ajouter de la pâte à tartiner Vegemite." },
                { Locale.German, "Mehl kneten, um einen Teig zu machen, dann kochen, um Brot zu machen, eine Scheibe abschneiden und kochen, um Toast zu machen, dann Vegemite-Aufstrich hinzufügen" },
                { Locale.Spanish, "Amasar la harina para hacer la masa y luego cocinar para hacer el pan cortar una rebanada y cocinar para hacer tostadas y luego añadir Vegemite Spread" },
                { Locale.Polish, "Zagnieść mąkę, aby zrobić ciasto, a następnie ugotować, aby zrobić chleb, pokroić kromkę i ugotować, aby zrobić tosty, a następnie dodać Vegemite Spread." },
                { Locale.Russian, "Замесите тесто из муки, затем приготовьте хлеб, отрезав кусочек, и приготовьте тосты, затем добавьте Vegemite Spread" },
                { Locale.PortugueseBrazil, "Amasse a farinha para fazer a massa e cozinhe para fazer o pão, corte uma fatia e cozinhe para fazer a torrada e adicione Vegemite Spread" },
                { Locale.Japanese, "小麦粉をこねて生地を作り、焼いてパンを作り、スライスしてトーストにし、ベジマイトスプレッドを加える。" },
                { Locale.ChineseSimplified, "将面粉揉成面团，然后煮熟做成面包，切一片再煮熟做成吐司，然后加入 Vegemite 涂料" },
                { Locale.Korean, "밀가루를 반죽하여 반죽을 만든 다음 빵을 얇게 썰어 조리하여 토스트를 만든 다음 베지마이트 스프레드를 추가합니다." },
                { Locale.Turkish, "Hamur yapmak için unu yoğurun, ardından ekmek yapmak için pişirin, bir dilim kesin ve tost yapmak için pişirin, ardından Vegemite Spread ekleyin" },
            };

            public static Dictionary<Locale, string> VegemiteToastCheese => new Dictionary<Locale, string>
            {
                { Locale.Default, "Chop cheese, then add to Vegemite Toast" },
                { Locale.English, "Chop cheese, then add to Vegemite Toast" },
                { Locale.BlankText, "" },
                { Locale.French, "Hacher le fromage, puis l'ajouter aux toasts Vegemite." },
                { Locale.German, "Käse hacken, dann zum Vegemite-Toast geben" },
                { Locale.Spanish, "Pica el queso y añádelo a la tostada de Vegemite" },
                { Locale.Polish, "Posiekaj ser, a następnie dodaj do tostów Vegemite." },
                { Locale.Russian, "Нарежьте сыр, затем добавьте в тосты Vegemite." },
                { Locale.PortugueseBrazil, "Pique o queijo e adicione-o à torrada Vegemite" },
                { Locale.Japanese, "チーズを刻み、ベジマイト・トーストに加える。" },
                { Locale.ChineseSimplified, "切碎奶酪，然后加入 Vegemite 吐司中" },
                { Locale.Korean, "치즈를 다진 후 베지마이트 토스트에 추가합니다." },
                { Locale.Turkish, "Peyniri doğrayın, ardından Vegemite Tost'a ekleyin" },
            };

            public static Dictionary<Locale, string> FairyBread => new Dictionary<Locale, string>
            {
                { Locale.Default, "Knead flour to make dough then cook to make bread, cut a slice, add butter and sprinkles, cut and plate." },
                { Locale.English, "Knead flour to make dough then cook to make bread, cut a slice, add butter and sprinkles, cut and plate." },
                { Locale.BlankText, "" },
                { Locale.French, "Pétrir la farine pour faire de la pâte, puis cuire pour faire du pain, couper une tranche, ajouter du beurre et des paillettes, couper et servir." },
                { Locale.German, "Mehl kneten, um einen Teig zu machen, dann kochen, um ein Brot zu machen, eine Scheibe abschneiden, Butter und Streusel hinzufügen, schneiden und plattieren." },
                { Locale.Spanish, "Amasar la harina para hacer la masa y luego cocer para hacer el pan, cortar una rebanada, añadir mantequilla y chispitas, cortar y emplatar." },
                { Locale.Polish, "Zagnieść mąkę na ciasto, a następnie ugotować chleb, pokroić kromkę, dodać masło i posypkę, pokroić i ułożyć na talerzu." },
                { Locale.Russian, "Замесите тесто из муки, затем приготовьте хлеб, отрежьте ломтик, добавьте масло и посыпку, нарежьте и выложите на тарелку." },
                { Locale.PortugueseBrazil, "Amasse a farinha para fazer a massa e cozinhe para fazer o pão, corte uma fatia, adicione manteiga e granulado, corte e sirva." },
                { Locale.Japanese, "小麦粉をこねて生地を作り、焼いてパンを作り、スライスしてバターとふりかけを加え、カットして皿に盛る。" },
                { Locale.ChineseSimplified, "将面粉揉成面团，然后煮熟做成面包，切一片，加入黄油和撒花，切好装盘。" },
                { Locale.Korean, "밀가루를 반죽하여 반죽을 만든 다음 익혀서 빵을 만들고, 조각을 자르고, 버터와 뿌리를 넣고, 자르고, 접시에 담습니다." },
                { Locale.Turkish, "Hamur yapmak için unu yoğurun, sonra ekmek yapmak için pişirin, bir dilim kesin, tereyağı ve serpme ekleyin, kesin ve tabaklayın." },
            };

            public static Dictionary<Locale, string> Pavlova => new Dictionary<Locale, string>
            {
                { Locale.Default, "Add Meringue to a Cake Tin and Cook. Remove from Tin, Chop Passion Fruit twice and add, Slice and Serve." },
                { Locale.English, "Add Meringue to a Cake Tin and Cook. Remove from Tin, Chop Passion Fruit twice and add, Slice and Serve." },
                { Locale.BlankText, "" },
                { Locale.French, "Mettre la meringue dans un moule à gâteau et faire cuire. Retirer du moule, hacher deux fois le fruit de la passion et l'ajouter, couper en tranches et servir." },
                { Locale.German, "Meringue in eine Kuchenform geben und backen. Aus der Form nehmen, Passionsfrüchte zweimal hacken und hinzufügen, in Scheiben schneiden und servieren." },
                { Locale.Spanish, "Poner el merengue en un molde y cocer. Sáquelo del molde, pique la fruta de la pasión dos veces y añádala, córtela en rodajas y sírvala." },
                { Locale.Polish, "Dodać bezę do tortownicy i upiec. Wyjąć z formy, posiekać marakuję dwukrotnie, dodać, pokroić i podawać." },
                { Locale.Russian, "Добавьте безе в форму для торта и приготовьте. Выньте из банки, дважды нарежьте маракуйю и добавьте, нарежьте и подавайте." },
                { Locale.PortugueseBrazil, "Coloque o merengue em uma forma de bolo e cozinhe. Retire da forma, pique o maracujá duas vezes e adicione-o, corte em fatias e sirva." },
                { Locale.Japanese, "メレンゲをケーキ型に入れて焼く。型から取り出し、パッションフルーツを2回刻んで加え、スライスして盛り付ける。" },
                { Locale.ChineseSimplified, "将蛋白霜放入蛋糕罐中烹煮。从锡罐中取出，将百香果切碎两次后加入，切片后即可食用。" },
                { Locale.Korean, "케이크 틀에 머랭을 넣고 조리합니다. 케이크 틀에서 꺼내 열정 과일을 두 번 자른 후 슬라이스하여 제공합니다." },
                { Locale.Turkish, "Bir Kek Kalıbına Beze Ekleyin ve Pişirin. Kalaydan çıkarın, Çarkıfelek Meyvesini iki kez doğrayın ve ekleyin, Dilimleyin ve Servis Edin." },
            };

            public static Dictionary<Locale, string> PavlovaToppings => new Dictionary<Locale, string>
            {
                { Locale.Default, "Chop Strawberries and Add to Pavlova when requested. Chop Kiwi Fruit and Add to Pavlova when requested." },
                { Locale.English, "Chop Strawberries and Add to Pavlova when requested. Chop Kiwi Fruit and Add to Pavlova when requested." },
                { Locale.BlankText, "" },
                { Locale.French, "Hacher les fraises et les ajouter à la Pavlova sur demande. Hacher les kiwis et les ajouter à la Pavlova sur demande." },
                { Locale.German, "Erdbeeren hacken und auf Wunsch in die Pavlova geben. Kiwi klein schneiden und auf Wunsch zur Pavlova geben." },
                { Locale.Spanish, "Trocee las fresas y añádalas a la pavlova cuando se solicite. Picar Kiwi y añadir a la Pavlova cuando se solicite." },
                { Locale.Polish, "Posiekać truskawki i dodać do Pavlovej na życzenie. Pokroić owoce kiwi i dodać do Pavlovej na życzenie." },
                { Locale.Russian, "Нарежьте клубнику и добавьте в Павлову по желанию. Нарежьте киви и добавьте в \"Павлову\" по желанию." },
                { Locale.PortugueseBrazil, "Pique os morangos e adicione à pavlova quando solicitado. Pique o kiwi e adicione-o à pavlova quando solicitado." },
                { Locale.Japanese, "イチゴを刻んでパブロバに加える。キウイを刻んでパブロバに加える。" },
                { Locale.ChineseSimplified, "切碎草莓，根据要求加入到 Pavlova 中。切碎奇异果，根据要求加入帕夫洛娃。" },
                { Locale.Korean, "딸기를 잘게 썰어 파블로바에 넣고 요청하면 추가합니다. 키위 과일을 잘게 썰어 요청 시 파블로바에 추가합니다." },
                { Locale.Turkish, "Çilekleri doğrayın ve istenildiğinde Pavlova'ya ekleyin. Kivi doğranır ve istenildiğinde Pavlova'ya eklenir." },
            };

            public static Dictionary<Locale, string> Meringue => new Dictionary<Locale, string>
            {
                { Locale.Default, "Separate Egg Whites from Yolks, Whisk Whites in a Mixer, add Sugar, Whisk Whites again" },
                { Locale.English, "Separate Egg Whites from Yolks, Whisk Whites in a Mixer, add Sugar, Whisk Whites again" },
                { Locale.BlankText, "" },
                { Locale.French, "Séparer les blancs des jaunes d'œufs, battre les blancs au mixeur, ajouter le sucre, battre à nouveau les blancs." },
                { Locale.German, "Eiweiß vom Eigelb trennen, Eiweiß in einem Mixer aufschlagen, Zucker hinzufügen, Eiweiß erneut aufschlagen" },
                { Locale.Spanish, "Separe las claras de las yemas, bata las claras en la batidora, añada el azúcar y vuelva a batir las claras." },
                { Locale.Polish, "Oddziel białka od żółtek, ubij białka w mikserze, dodaj cukier, ponownie ubij białka." },
                { Locale.Russian, "Отделите яичные белки от желтков, взбейте белки в миксере, добавьте сахар, снова взбейте белки." },
                { Locale.PortugueseBrazil, "Separe as claras das gemas, bata as claras em uma batedeira, adicione o açúcar e bata as claras novamente" },
                { Locale.Japanese, "卵黄と卵白を分け、卵白をミキサーで泡立て、砂糖を加え、再び卵白を泡立てる。" },
                { Locale.ChineseSimplified, "将蛋白与蛋黄分离，在搅拌机中搅打蛋白，加入糖，再次搅打蛋白" },
                { Locale.Korean, "달걀 흰자와 노른자를 분리하고 믹서에서 흰자를 휘저은 다음 설탕을 넣고 다시 휘저어줍니다." },
                { Locale.Turkish, "Yumurta Aklarını Sarılarından Ayırın, Akları Mikserde Çırpın, Şeker Ekleyin, Akları Tekrar Çırpın" },
            };

            public static Dictionary<Locale, string> PizzaEgg => new Dictionary<Locale, string>
            {
                { Locale.Default, "Chop egg and add to pizza before cooking" },
                { Locale.English, "Chop egg and add to pizza before cooking" },
                { Locale.BlankText, "" },
                { Locale.French, "Hacher l'œuf et l'ajouter à la pizza avant la cuisson" },
                { Locale.German, "Ei hacken und vor dem Backen auf die Pizza geben" },
                { Locale.Spanish, "Picar el huevo y añadirlo a la pizza antes de cocinarla" },
                { Locale.Polish, "Posiekaj jajko i dodaj do pizzy przed gotowaniem" },
                { Locale.Russian, "Порубите яйцо и добавьте в пиццу перед приготовлением" },
                { Locale.PortugueseBrazil, "Pique o ovo e adicione-o à pizza antes do cozimento" },
                { Locale.Japanese, "卵を刻んでピザに加える。" },
                { Locale.ChineseSimplified, "鸡蛋切碎，在烹饪前加入比萨中" },
                { Locale.Korean, "요리하기 전에 계란을 잘게 썰어 피자에 넣습니다." },
                { Locale.Turkish, "Yumurtayı doğrayın ve pişirmeden önce pizzaya ekleyin" },
            };

            public static Dictionary<Locale, string> TimTams => new Dictionary<Locale, string>
            {
                { Locale.Default, "Chop Wafer Sheets, melt and add Chocolate, and portion." },
                { Locale.English, "Chop Wafer Sheets, melt and add Chocolate, and portion." },
                { Locale.BlankText, "" },
                { Locale.French, "Hacher les gaufrettes, les faire fondre et ajouter le chocolat, puis les répartir." },
                { Locale.German, "Waffelblätter zerkleinern, Schokolade schmelzen, dazugeben und portionieren." },
                { Locale.Spanish, "Picar las Hojas de Oblea, derretir y añadir el Chocolate, y porcionar." },
                { Locale.Polish, "Pokroić wafelki, roztopić, dodać czekoladę i porcjować." },
                { Locale.Russian, "Нарежьте вафельные листы, растопите и добавьте шоколад, разделите на порции." },
                { Locale.PortugueseBrazil, "Pique as folhas de wafer, derreta e acrescente o chocolate e distribua." },
                { Locale.Japanese, "ウエハースシートを刻み、チョコレートを溶かして加える。" },
                { Locale.ChineseSimplified, "将威化片切碎，融化并加入巧克力，然后分装。" },
                { Locale.Korean, "웨이퍼 시트를 잘게 자르고 초콜릿을 녹여 추가한 후 나누어줍니다." },
                { Locale.Turkish, "Gofret Yapraklarını doğrayın, eritin ve Çikolata ekleyin ve porsiyonlayın." },
            };

            public static Dictionary<Locale, string> Shoey => new Dictionary<Locale, string>
            {
                { Locale.Default, "Crack open a can of VB and put it in a shoe." },
                { Locale.English, "Crack open a can of VB and put it in a shoe." },
                { Locale.BlankText, "" },
                { Locale.French, "Ouvrez une boîte de VB et mettez-la dans une chaussure." },
                { Locale.German, "Öffnen Sie eine Dose VB und stecken Sie sie in einen Schuh." },
                { Locale.Spanish, "Abre una lata de VB y métela en un zapato." },
                { Locale.Polish, "Otwórz puszkę VB i włóż ją do buta." },
                { Locale.Russian, "Вскройте банку VB и положите ее в ботинок." },
                { Locale.PortugueseBrazil, "Abra uma lata de VB e coloque-a em um sapato." },
                { Locale.Japanese, "VBの缶を割って靴に入れる。" },
                { Locale.ChineseSimplified, "打开一罐 VB，把它放进鞋子里。" },
                { Locale.Korean, "VB 캔을 뜯어 신발에 넣습니다." },
                { Locale.Turkish, "Bir kutu VB aç ve ayakkabının içine koy." },
            };
        }

        public static class Appliances
        {
            public static List<(Locale, ApplianceInfo)> VegemiteProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Vegemite", Description = "Provides Vegemite" }),
                (Locale.English, new ApplianceInfo { Name = "Vegemite", Description = "Provides Vegemite" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Vegemite", Description = "Fournit du Vegemite" }),
                (Locale.German, new ApplianceInfo { Name = "Vegemite", Description = "Bietet Vegemite" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Vegemite", Description = "Proporciona Vegemite" }),
                (Locale.Polish, new ApplianceInfo { Name = "Vegemite", Description = "Zapewnia Vegemite" }),
                (Locale.Russian, new ApplianceInfo { Name = "Вегемайт", Description = "Предоставляет Vegemite" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Vegemite", Description = "Fornece Vegemite" }),
                (Locale.Japanese, new ApplianceInfo { Name = "ベジマイト", Description = "ベジマイトを提供" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "Vegemite", Description = "提供 Vegemite" }),
                (Locale.Korean, new ApplianceInfo { Name = "베지마이트", Description = "베지마이트 제공" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Vegemite", Description = "Vegemite sağlar" }),
            };

            public static List<(Locale, ApplianceInfo)> SprinklesProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Sprinkles", Description = "Provides Sprinkles" }),
                (Locale.English, new ApplianceInfo { Name = "Sprinkles", Description = "Provides Sprinkles" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Saupoudrage", Description = "Fournit des saupoudrages" }),
                (Locale.German, new ApplianceInfo { Name = "Sprinkles", Description = "Bietet Streusel" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Sprinkles", Description = "Proporciona Sprinkles" }),
                (Locale.Polish, new ApplianceInfo { Name = "Posypka", Description = "Zapewnia posypkę" }),
                (Locale.Russian, new ApplianceInfo { Name = "Брызги", Description = "Предоставляет спринцовки" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Granulado", Description = "Fornece granulados" }),
                (Locale.Japanese, new ApplianceInfo { Name = "スプリンクルズ", Description = "スプリンクルを提供" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "Sprinkles", Description = "提供 Sprinkles" }),
                (Locale.Korean, new ApplianceInfo { Name = "스프링스", Description = "스프링클 제공" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Sprinkles", Description = "Sprinkles Sağlar" }),
            };

            public static List<(Locale, ApplianceInfo)> KiwiFruitProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Passion Fruit", Description = "Provides Passion Fruit" }),
                (Locale.English, new ApplianceInfo { Name = "Passion Fruit", Description = "Provides Passion Fruit" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Fruit de la passion", Description = "Fournit le fruit de la passion" }),
                (Locale.German, new ApplianceInfo { Name = "Passionsfrucht", Description = "Bietet Passionsfrucht" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Fruta de la pasión", Description = "Proporciona fruta de la pasión" }),
                (Locale.Polish, new ApplianceInfo { Name = "Owoc męczennicy", Description = "Zapewnia owoce męczennicy" }),
                (Locale.Russian, new ApplianceInfo { Name = "Маракуйя", Description = "Предоставляет маракуйю" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Maracujá", Description = "Fornece maracujá" }),
                (Locale.Japanese, new ApplianceInfo { Name = "パッションフルーツ", Description = "パッションフルーツ" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "百香果", Description = "提供百香果" }),
                (Locale.Korean, new ApplianceInfo { Name = "열정 과일", Description = "열정 열매 제공" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Çarkıfelek Meyvesi", Description = "Çarkıfelek Meyvesi Sağlar" }),
            };

            public static List<(Locale, ApplianceInfo)> PassionFruitProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Kiwi Fruit", Description = "Provides Kiwi Fruit" }),
                (Locale.English, new ApplianceInfo { Name = "Kiwi Fruit", Description = "Provides Kiwi Fruit" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Kiwi", Description = "Apporte le kiwi" }),
                (Locale.German, new ApplianceInfo { Name = "Kiwi-Frucht", Description = "Liefert Kiwi-Früchte" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Kiwi", Description = "Proporciona Kiwi" }),
                (Locale.Polish, new ApplianceInfo { Name = "Owoce kiwi", Description = "Zapewnia owoce kiwi" }),
                (Locale.Russian, new ApplianceInfo { Name = "Фрукты киви", Description = "Фрукты киви" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Kiwi", Description = "Fornece Kiwi" }),
                (Locale.Japanese, new ApplianceInfo { Name = "キウイフルーツ", Description = "キウイフルーツ" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "猕猴桃", Description = "提供猕猴桃" }),
                (Locale.Korean, new ApplianceInfo { Name = "키위 과일", Description = "키위 과일 제공" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Kivi Meyvesi", Description = "Kivi Meyvesi Sağlar" }),
            };

            public static List<(Locale, ApplianceInfo)> WaferProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Wafers", Description = "Provides Wafers" }),
                (Locale.English, new ApplianceInfo { Name = "Wafers", Description = "Provides Wafers" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Plaquettes", Description = "Fournit des gaufres" }),
                (Locale.German, new ApplianceInfo { Name = "Waffeln", Description = "Bietet Waffeln" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Obleas", Description = "Proporciona barquillos" }),
                (Locale.Polish, new ApplianceInfo { Name = "Wafle", Description = "Zapewnia Wafle" }),
                (Locale.Russian, new ApplianceInfo { Name = "Пластины", Description = "Предоставляет пластины" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Wafers", Description = "Fornece wafers" }),
                (Locale.Japanese, new ApplianceInfo { Name = "ウエハース", Description = "ウェハーを提供" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "晶圆", Description = "提供晶片" }),
                (Locale.Korean, new ApplianceInfo { Name = "웨이퍼", Description = "웨이퍼 제공" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Gofretler", Description = "Gofret Sağlar" }),
            };

            public static List<(Locale, ApplianceInfo)> KangarooSign => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Kangaroo Sign", Description = "They were here before roads were." }),
                (Locale.English, new ApplianceInfo { Name = "Kangaroo Sign", Description = "They were here before roads were." }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Panneau Kangourou", Description = "Ils étaient là avant que les routes n'existent." }),
                (Locale.German, new ApplianceInfo { Name = "Känguru-Schild", Description = "Sie waren schon da, bevor es Straßen gab." }),
                (Locale.Spanish, new ApplianceInfo { Name = "Señal de canguro", Description = "Estaban aquí antes que las carreteras." }),
                (Locale.Polish, new ApplianceInfo { Name = "Znak kangura", Description = "Były tu wcześniej niż drogi." }),
                (Locale.Russian, new ApplianceInfo { Name = "Знак кенгуру", Description = "Они появились здесь раньше, чем дороги." }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Sinal de Canguru", Description = "Eles já estavam aqui antes das estradas." }),
                (Locale.Japanese, new ApplianceInfo { Name = "カンガルー・サイン", Description = "道路ができる前からここにあった。" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "袋鼠标志", Description = "在公路出现之前，它们就已经在这里了。" }),
                (Locale.Korean, new ApplianceInfo { Name = "캥거루 사인", Description = "그들은 도로가 생기기 전부터 이곳에 있었습니다." }),
                (Locale.Turkish, new ApplianceInfo { Name = "Kanguru İşareti", Description = "Yollar olmadan önce buradaydılar." }),
            };

            public static List<(Locale, ApplianceInfo)> SurfBoardRack => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Surf Boards", Description = "Not recommended for use on dry land." }),
                (Locale.English, new ApplianceInfo { Name = "Surf Boards", Description = "Not recommended for use on dry land." }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Planches de surf", Description = "Il n'est pas recommandé de l'utiliser sur la terre ferme." }),
                (Locale.German, new ApplianceInfo { Name = "Surfbretter", Description = "Nicht für die Verwendung auf dem Land empfohlen." }),
                (Locale.Spanish, new ApplianceInfo { Name = "Tablas de surf", Description = "No se recomienda su uso en tierra firme." }),
                (Locale.Polish, new ApplianceInfo { Name = "Deski surfingowe", Description = "Nie zaleca się używania na suchym lądzie." }),
                (Locale.Russian, new ApplianceInfo { Name = "Доски для серфинга", Description = "Не рекомендуется использовать на суше." }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Pranchas de surfe", Description = "Não recomendado para uso em terra firme." }),
                (Locale.Japanese, new ApplianceInfo { Name = "サーフボード", Description = "陸上での使用は推奨しない。" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "冲浪板", Description = "不建议在陆地上使用。" }),
                (Locale.Korean, new ApplianceInfo { Name = "서핑 보드", Description = "마른 땅에서는 사용하지 않는 것이 좋습니다." }),
                (Locale.Turkish, new ApplianceInfo { Name = "Sörf Tahtaları", Description = "Kuru zeminde kullanılması tavsiye edilmez." }),
            };

            public static List<(Locale, ApplianceInfo)> CrocodileSign => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Crocodile Sign", Description = "Enter at your own risk… or as a snack." }),
                (Locale.English, new ApplianceInfo { Name = "Crocodile Sign", Description = "Enter at your own risk… or as a snack." }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Signe du crocodile", Description = "Participez à vos risques et périls... ou en guise de goûter." }),
                (Locale.German, new ApplianceInfo { Name = "Krokodil-Schild", Description = "Eintritt auf eigene Gefahr... oder als Snack." }),
                (Locale.Spanish, new ApplianceInfo { Name = "Señal de cocodrilo", Description = "Entre por su cuenta y riesgo... o como aperitivo." }),
                (Locale.Polish, new ApplianceInfo { Name = "Znak krokodyla", Description = "Wejście na własne ryzyko... lub jako przekąska." }),
                (Locale.Russian, new ApplianceInfo { Name = "Знак крокодила", Description = "Входите на свой страх и риск... или в качестве закуски." }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Sinal de crocodilo", Description = "Entre por sua própria conta e risco... ou como um lanche." }),
                (Locale.Japanese, new ApplianceInfo { Name = "クロコダイルサイン", Description = "入場は自己責任で...あるいはおやつとして。" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "鳄鱼标志", Description = "请自担风险......或作为点心入场。" }),
                (Locale.Korean, new ApplianceInfo { Name = "악어 기호", Description = "본인 책임 하에 입장하거나 간식으로 즐기세요." }),
                (Locale.Turkish, new ApplianceInfo { Name = "Timsah İşareti", Description = "Riski size ait olmak üzere girin... ya da atıştırmalık olarak." }),
            };

            public static List<(Locale, ApplianceInfo)> ShoeProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Shoes", Description = "Provides Shoes" }),
                (Locale.English, new ApplianceInfo { Name = "Shoes", Description = "Provides Shoes" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Chaussures", Description = "Fournit des chaussures" }),
                (Locale.German, new ApplianceInfo { Name = "Schuhe", Description = "Bietet Schuhe" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Zapatos", Description = "Proporciona calzado" }),
                (Locale.Polish, new ApplianceInfo { Name = "Buty", Description = "Zapewnia buty" }),
                (Locale.Russian, new ApplianceInfo { Name = "Обувь", Description = "Предоставляет обувь" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Calçados", Description = "Fornece calçados" }),
                (Locale.Japanese, new ApplianceInfo { Name = "シューズ", Description = "シューズ" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "鞋类", Description = "提供鞋子" }),
                (Locale.Korean, new ApplianceInfo { Name = "신발", Description = "신발 제공" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Ayakkabılar", Description = "Ayakkabı Sağlar" }),
            };

            public static List<(Locale, ApplianceInfo)> VBProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "VB", Description = "Provides VB" }),
                (Locale.English, new ApplianceInfo { Name = "VB", Description = "Provides VB" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "VB", Description = "Fournit VB" }),
                (Locale.German, new ApplianceInfo { Name = "VB", Description = "Bietet VB" }),
                (Locale.Spanish, new ApplianceInfo { Name = "VB", Description = "Proporciona VB" }),
                (Locale.Polish, new ApplianceInfo { Name = "VB", Description = "Zapewnia VB" }),
                (Locale.Russian, new ApplianceInfo { Name = "VB", Description = "Предоставляет VB" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "VB", Description = "Fornece VB" }),
                (Locale.Japanese, new ApplianceInfo { Name = "ブイビー", Description = "VBを提供" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "VB", Description = "提供 VB" }),
                (Locale.Korean, new ApplianceInfo { Name = "VB", Description = "VB" }),
                (Locale.Turkish, new ApplianceInfo { Name = "VB", Description = "VB sağlar" }),
            };

            public static List<(Locale, ApplianceInfo)> KoalaBranch => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Koala Branch", Description = "Cuteness level: Unbearably high." }),
                (Locale.English, new ApplianceInfo { Name = "Koala Branch", Description = "Cuteness level: Unbearably high." }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Branche Koala", Description = "Niveau de mignonnerie : Insupportablement élevé." }),
                (Locale.German, new ApplianceInfo { Name = "Koala-Zweig", Description = "Niedlichkeitsgrad: Unerträglich hoch." }),
                (Locale.Spanish, new ApplianceInfo { Name = "Sucursal Koala", Description = "Nivel de ternura: Insoportablemente alto." }),
                (Locale.Polish, new ApplianceInfo { Name = "Oddział Koala", Description = "Poziom słodkości: Nieznośnie wysoki." }),
                (Locale.Russian, new ApplianceInfo { Name = "Филиал Коала", Description = "Уровень миловидности: Невыносимо высокий." }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Filial Koala", Description = "Nível de fofura: Insuportavelmente alto." }),
                (Locale.Japanese, new ApplianceInfo { Name = "コアラ支店", Description = "かわいさレベル：耐えられないほど高い。" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "考拉分部", Description = "可爱程度：高到无法忍受" }),
                (Locale.Korean, new ApplianceInfo { Name = "코알라 지점", Description = "귀여움 수준: 참을 수 없을 정도로 높음." }),
                (Locale.Turkish, new ApplianceInfo { Name = "Koala Şubesi", Description = "Sevimlilik seviyesi: Dayanılmaz derecede yüksek." }),
            };

            public static List<(Locale, ApplianceInfo)> BoomerangBoard => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Mounted Boomerang", Description = "You threw it away, but it still came back." }),
                (Locale.English, new ApplianceInfo { Name = "Mounted Boomerang", Description = "You threw it away, but it still came back." }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Boomerang monté", Description = "Vous l'avez jeté, mais il est revenu." }),
                (Locale.German, new ApplianceInfo { Name = "Montierter Bumerang", Description = "Du hast es weggeworfen, aber es kam trotzdem zurück." }),
                (Locale.Spanish, new ApplianceInfo { Name = "Boomerang montado", Description = "Lo tiraste, pero aún así volvió." }),
                (Locale.Polish, new ApplianceInfo { Name = "Zamontowany bumerang", Description = "Wyrzuciłeś go, ale i tak wrócił." }),
                (Locale.Russian, new ApplianceInfo { Name = "Установленный бумеранг", Description = "Вы выбросили его, но он все равно вернулся." }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Bumerangue montado", Description = "Você o jogou fora, mas ele ainda voltou." }),
                (Locale.Japanese, new ApplianceInfo { Name = "マウント・ブーメラン", Description = "捨ててもまた戻ってくる。" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "安装回旋镖", Description = "你把它扔掉了，但它还是回来了。" }),
                (Locale.Korean, new ApplianceInfo { Name = "장착 부메랑", Description = "버렸지만 여전히 돌아왔습니다." }),
                (Locale.Turkish, new ApplianceInfo { Name = "Monteli Bumerang", Description = "Onu attın ama yine de geri geldi." }),
            };
        }

        public static class RestaurantSettings
        {
            public static List<(Locale, BasicInfo)> Outback => new List<(Locale, BasicInfo)>
            {
                (Locale.Default, new BasicInfo { Name = "Outback", Description = "" }),
                (Locale.English, new BasicInfo { Name = "Outback", Description = "" }),
                (Locale.BlankText, new BasicInfo { Name = "", Description = "" }),
                (Locale.French, new BasicInfo { Name = "La cambrousse", Description = "" }),
                (Locale.German, new BasicInfo { Name = "Outback", Description = "" }),
                (Locale.Spanish, new BasicInfo { Name = "Outback", Description = "" }),
                (Locale.Polish, new BasicInfo { Name = "Outback", Description = "" }),
                (Locale.Russian, new BasicInfo { Name = "Outback", Description = "" }),
                (Locale.PortugueseBrazil, new BasicInfo { Name = "Outback", Description = "" }),
                (Locale.Japanese, new BasicInfo { Name = "アウトバック", Description = "" }),
                (Locale.ChineseSimplified, new BasicInfo { Name = "内陆", Description = "" }),
                (Locale.Korean, new BasicInfo { Name = "아웃백", Description = "" }),
                (Locale.Turkish, new BasicInfo { Name = "Outback", Description = "" }),
            };
        }

        public static class Processes
        {
            public static List<(Locale, ProcessInfo)> Whisk => new List<(Locale, ProcessInfo)>
            {
                (Locale.Default, new ProcessInfo { Name = "Roll", Icon = "<sprite name=\"Whisk\">", }),
                (Locale.English, new ProcessInfo { Name = "Roll", Icon = "<sprite name=\"Whisk\">", }),
                (Locale.BlankText, new ProcessInfo { Name = "", Icon = "", }),
                (Locale.French, new ProcessInfo { Name = "Rouleau", Icon = "<sprite name=\"roll\">", }),
                (Locale.German, new ProcessInfo { Name = "Rolle", Icon = "<sprite name=\"roll\">", }),
                (Locale.Spanish, new ProcessInfo { Name = "Rollo", Icon = "<sprite name=\"roll\">", }),
                (Locale.Polish, new ProcessInfo { Name = "Rolka", Icon = "<sprite name=\"roll\">", }),
                (Locale.Russian, new ProcessInfo { Name = "Рулон", Icon = "<sprite name=\"roll\">", }),
                (Locale.PortugueseBrazil, new ProcessInfo { Name = "Rolo", Icon = "<sprite name=\"roll\">", }),
                (Locale.Japanese, new ProcessInfo { Name = "ロール", Icon = "<sprite name=\"roll\">", }),
                (Locale.ChineseSimplified, new ProcessInfo { Name = "卷轴", Icon = "<sprite name=\"roll\">", }),
                (Locale.Korean, new ProcessInfo { Name = "롤", Icon = "<sprite name=\"roll\">", }),
                (Locale.Turkish, new ProcessInfo { Name = "Rulo", Icon = "<sprite name=\"roll\">", }),
            };
        }
    }
}