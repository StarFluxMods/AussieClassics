using System.Collections.Generic;
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
                { Locale.Default, "Knead flour to make dough then cook to make bread, cut a slice, add butter and sprinkles." },
                { Locale.English, "Knead flour to make dough then cook to make bread, cut a slice, add butter and sprinkles." },
                { Locale.BlankText, "" },
                { Locale.French, "Pétrir la farine pour faire de la pâte, puis cuire pour faire du pain, couper une tranche, ajouter du beurre et des paillettes." },
                { Locale.German, "Mehl kneten, um einen Teig zu machen, dann kochen, um Brot zu machen, eine Scheibe abschneiden, Butter und Streusel hinzufügen." },
                { Locale.Spanish, "Amasar la harina para hacer la masa y luego cocer para hacer el pan, cortar una rebanada, añadir mantequilla y espolvorear." },
                { Locale.Polish, "Zagnieść mąkę na ciasto, a następnie ugotować chleb, pokroić kromkę, dodać masło i posypkę." },
                { Locale.Russian, "Замесите тесто из муки, затем приготовьте хлеб, отрежьте ломтик, добавьте масло и посыпку." },
                { Locale.PortugueseBrazil, "Amasse a farinha para fazer a massa e cozinhe para fazer o pão, corte uma fatia, adicione manteiga e polvilhe." },
                { Locale.Japanese, "小麦粉をこねて生地を作り、焼いてパンを作る。" },
                { Locale.ChineseSimplified, "将面粉揉成面团，然后煮成面包，切成薄片，加入黄油和糖。" },
                { Locale.Korean, "밀가루를 반죽하여 반죽을 만든 다음 요리하여 빵을 만들고 조각을 자르고 버터를 넣고 뿌립니다." },
                { Locale.Turkish, "Hamur yapmak için unu yoğurun, ardından ekmek yapmak için pişirin, bir dilim kesin, tereyağı ve serpme ekleyin." },
            };

            public static Dictionary<Locale, string> Pavlova => new Dictionary<Locale, string>
            {
                { Locale.Default, "Separate Egg Whites from Yolks, Whisk Whites, add Sugar, Whisk Whites again, Add Meringue to a Cake Tin and Cook. Remove from Tin, Add Mashed Passion Fruit, Slice and Serve." },
                { Locale.English, "Separate Egg Whites from Yolks, Whisk Whites, add Sugar, Whisk Whites again, Add Meringue to a Cake Tin and Cook. Remove from Tin, Add Mashed Passion Fruit, Slice and Serve." },
                { Locale.BlankText, "" },
                { Locale.French, "Séparer les blancs des jaunes d'œufs, fouetter les blancs, ajouter le sucre, fouetter à nouveau les blancs, ajouter la meringue dans un moule à gâteau et faire cuire. Retirer du moule, ajouter la purée de fruits de la passion, couper en tranches et servir." },
                { Locale.German, "Das Eiweiß vom Eigelb trennen, das Eiweiß verquirlen, den Zucker hinzufügen, das Eiweiß erneut verquirlen, die Baisermasse in eine Tortenform geben und backen. Aus der Form nehmen, pürierte Passionsfrüchte hinzufügen, in Scheiben schneiden und servieren." },
                { Locale.Spanish, "Separar las claras de las yemas, batir las claras, añadir el azúcar, batir las claras de nuevo, añadir el merengue a un molde y cocer. Sacar del molde, añadir el puré de fruta de la pasión, cortar y servir." },
                { Locale.Polish, "Oddzielić białka od żółtek, ubić białka, dodać cukier, ponownie ubić białka, dodać bezę do formy i gotować. Wyjąć z formy, dodać puree z marakui, pokroić i podawać." },
                { Locale.Russian, "Отделите яичные белки от желтков, взбейте белки, добавьте сахар, снова взбейте белки, выложите безе в форму для торта и приготовьте. Выньте из формы, добавьте пюре маракуйи, нарежьте и подавайте." },
                { Locale.PortugueseBrazil, "Separe as claras das gemas, bata as claras, adicione o açúcar, bata as claras novamente, coloque o merengue em uma forma de bolo e cozinhe. Retire da forma, acrescente o purê de maracujá, corte em fatias e sirva." },
                { Locale.Japanese, "卵黄と卵白を分け、卵白を泡立て、砂糖を加えて再び泡立て、メレンゲをケーキ型に入れて焼く。型から取り出し、マッシュしたパッションフルーツを加え、スライスして盛り付ける。" },
                { Locale.ChineseSimplified, "将蛋白与蛋黄分开，打发蛋白，加入糖，再次打发蛋白，将蛋白霜放入蛋糕罐中煮熟。从蛋糕模中取出，加入百香果泥，切片，上桌。" },
                { Locale.Korean, "달걀 흰자와 노른자를 분리하고, 흰자를 휘저어 설탕을 넣고, 다시 휘저은 다음 머랭을 케이크 틀에 넣고 조리합니다. 케이크 틀에서 꺼내 으깬 패션후르츠를 넣고 슬라이스하여 제공합니다." },
                { Locale.Turkish, "Yumurta Aklarını Sarılarından Ayırın, Akları Çırpın, Şeker Ekleyin, Akları Tekrar Çırpın, Kek Kalıbına Beze Ekleyin ve Pişirin. Kalıptan çıkarın, Çarkıfelek Meyvesi Püresi ekleyin, dilimleyin ve servis edin." },
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
                (Locale.Default, new ApplianceInfo{Name = "Passion Fruit", Description = "Provides Passion Fruit"}),
                (Locale.English, new ApplianceInfo{Name = "Passion Fruit", Description = "Provides Passion Fruit"}),
                (Locale.BlankText, new ApplianceInfo{Name = "", Description = ""}),
                (Locale.French, new ApplianceInfo{Name = "Fruit de la passion", Description = "Fournit le fruit de la passion"}),
                (Locale.German, new ApplianceInfo{Name = "Passionsfrucht", Description = "Bietet Passionsfrucht"}),
                (Locale.Spanish, new ApplianceInfo{Name = "Fruta de la pasión", Description = "Proporciona fruta de la pasión"}),
                (Locale.Polish, new ApplianceInfo{Name = "Owoc męczennicy", Description = "Zapewnia owoce męczennicy"}),
                (Locale.Russian, new ApplianceInfo{Name = "Маракуйя", Description = "Предоставляет маракуйю"}),
                (Locale.PortugueseBrazil, new ApplianceInfo{Name = "Maracujá", Description = "Fornece maracujá"}),
                (Locale.Japanese, new ApplianceInfo{Name = "パッションフルーツ", Description = "パッションフルーツ"}),
                (Locale.ChineseSimplified, new ApplianceInfo{Name = "百香果", Description = "提供百香果"}),
                (Locale.Korean, new ApplianceInfo{Name = "열정 과일", Description = "열정 열매 제공"}),
                (Locale.Turkish, new ApplianceInfo{Name = "Çarkıfelek Meyvesi", Description = "Çarkıfelek Meyvesi Sağlar"}),
            };
            
            public static List<(Locale, ApplianceInfo)> PassionFruitProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo{Name = "Kiwi Fruit", Description = "Provides Kiwi Fruit"}),
                (Locale.English, new ApplianceInfo{Name = "Kiwi Fruit", Description = "Provides Kiwi Fruit"}),
                (Locale.BlankText, new ApplianceInfo{Name = "", Description = ""}),
                (Locale.French, new ApplianceInfo{Name = "Kiwi", Description = "Apporte le kiwi"}),
                (Locale.German, new ApplianceInfo{Name = "Kiwi-Frucht", Description = "Liefert Kiwi-Früchte"}),
                (Locale.Spanish, new ApplianceInfo{Name = "Kiwi", Description = "Proporciona Kiwi"}),
                (Locale.Polish, new ApplianceInfo{Name = "Owoce kiwi", Description = "Zapewnia owoce kiwi"}),
                (Locale.Russian, new ApplianceInfo{Name = "Фрукты киви", Description = "Фрукты киви"}),
                (Locale.PortugueseBrazil, new ApplianceInfo{Name = "Kiwi", Description = "Fornece Kiwi"}),
                (Locale.Japanese, new ApplianceInfo{Name = "キウイフルーツ", Description = "キウイフルーツ"}),
                (Locale.ChineseSimplified, new ApplianceInfo{Name = "猕猴桃", Description = "提供猕猴桃"}),
                (Locale.Korean, new ApplianceInfo{Name = "키위 과일", Description = "키위 과일 제공"}),
                (Locale.Turkish, new ApplianceInfo{Name = "Kivi Meyvesi", Description = "Kivi Meyvesi Sağlar"}),
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