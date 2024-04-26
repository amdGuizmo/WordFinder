using NuGet.Frameworks;
using WordFinderLib;

namespace WordFinderTests
{
    [TestFixture]
    public class FindTests
    {
        List<string> matrix { get; set; }
        List<string> wordsToFind { get; set; } = new List<string>();
        IEnumerable<string> findedWords { get; set; } = new List<string>();
        WordFinder wordFinder { get; set; }


        [SetUp]
        public void Setup()
        {
            #region Matrix
            matrix = new List<string>();
            matrix.Add("horizontalwordlefttoperipsumdiamnonumyzteshorizontalwordrighttop");
            matrix.Add("vsitseautjustohendreritetnostrudsitinviduntaliquyamsteteirmodalv");
            matrix.Add("etionutsitatstetmagnaillumsadipscingoptioneirmodaccumsanetvolute");
            matrix.Add("rlumeuismodinateratkasdinviduntloremipsumwisiutfacilisisametclir");
            matrix.Add("tvoluptuaseazzrilseddoloresdolorseddolorekasdeasedenimipsumnobit");
            matrix.Add("iloripsumeleifendatfacerassumveniametconseteturelitconsequatconi");
            matrix.Add("csumelitreulaborequisduisetvelsanctusveronoeratduoatsitloremlorc");
            matrix.Add("aconsectetuerdoloratsadipscingfacilisiloremrebumaliquipdoloresaa");
            matrix.Add("llormagnavoluptuaeadiamelitdoloreratetmagnaveroextemporrebumeral");
            matrix.Add("tdoloreipsumiriureveroaccusamestveroseaaccusamseaadetaliquyameos");
            matrix.Add("agnacommodoloremdoloresconsequataliquamerosiriureipsumrebumverov");
            matrix.Add("oloreslaborenoiustoameteossealoremduodiamutsitateirmoddoloreetno");
            matrix.Add("ccusamutveroeaelitrclitanibhkasddolorsanctustemporfacilisisguber");
            matrix.Add("asdduoeirmodeaexercicommodoexauguenostrudjustoettinciduntlaoreet");
            matrix.Add("npraesenttempordolorconsequatdoloresfacilisimagnaaliquyamtevelit");
            matrix.Add("onseteturtakimataeratvoluptuanisleuiriureiustoullamcorperdolorip");
            matrix.Add("litrsiteratestjustoeteumadimperdieteaduisfeugiatnislsadipscingla");
            matrix.Add("aelitrutjustoseddoloresseaautemametutlaboreeaaccusamipsumetconse");
            matrix.Add("tstetetjustoetmagnaetinloremdoloresessenislquiseleifendsadipscin");
            matrix.Add("metdolorvelatautemmagnaluptatumetfacilisisnislutjustonobislabore");
            matrix.Add("metsedidtemporeossiteumeratipsumveroverodoloresdolorestetaliquam");
            matrix.Add("olortemporduoluptatumdoloresametdiamtakimatadoloresjustoutdolord");
            matrix.Add("oloraliquyamametnoipsumduomolestierebumutinviduntloremessetempor");
            matrix.Add("iaminviduntametaugueexerciluptatumaliquamsedtemporsadipscingmole");
            matrix.Add("anctussittemporwisiutautemnullaipsumlaboreetmagnadolorlaboretemp");
            matrix.Add("ustoverodiamduoesttejustoattincidunthendreritsedquisutnonumyetei");
            matrix.Add("onumyelitoptionetdoloreateaveroametrebumdoloresednonumynogubergr");
            matrix.Add("psumettemporaliquipnullasanctusmolestiesadipscinggubergrenstetti");
            matrix.Add("secuenceonesecuencetwosecuencethreesecuencefoursecuencefivesecue");
            matrix.Add("wordtoponewordtoponewordtoponewordtoponewordtoponewordtoponeipsu");
            matrix.Add("wordtoponewordtoponewordtoponewordtoponewordtoponewordtoptwoipsu");
            matrix.Add("wordtoptwowordtoptwowordtoptwowordtoptwowordtoptwowordtoptwoipsu");
            matrix.Add("wordtoptwowordtoptwowordtoptwowordtopthreewordtopthreeipsumetsuf");
            matrix.Add("wordtopthreewordtopthreewordtopthreewordtopthreewordtopthreeipsu");
            matrix.Add("wordtopthreewordtopthreewordtopfourwordtopfourwordtopfouripsumet");
            matrix.Add("wordtopfourwordtopfourwordtopfourwordtopfourwordtopfouripsumetsu");
            matrix.Add("wordtopfivewordtopfivewordtopfivewordtopfivewordtopfiveipsumetsu");
            matrix.Add("wordtopfivewordtopfivewordtopsixwordtopsixwordtopsixwordtopsixip");
            matrix.Add("wordtopsixwordtopsixwordtopsevenwordtopsevenwordtopsevenipsumets");
            matrix.Add("wordtopsevenwordtopsevenwordtopeightwordtopeightwordtopeightipsu");
            matrix.Add("wordtopeightwordtopninewordtopninewordtopninewordtoptenipsumetsu");
            matrix.Add("wordtoptenwordtopelevenmeosfeugiatstetvoluptuasiteirmodipsumetsu");
            matrix.Add("edatnibhullamcorperipsumeosfeugiatstetvoluptuasiteirmodipsumetsu");
            matrix.Add("aoreetametconsequatealoremidtempordiameablanditametipsumerataliq");
            matrix.Add("meteratipsumliberduoeasitclitadelenitdiameleifendtakimatainvidun");
            matrix.Add("umfacilisiseadolorenostrudconseteturexerciaugueeaquiseoskasdeosd");
            matrix.Add("iteteagubergrenelitrluptatumfacerseaetestgubergrenetverotemporst");
            matrix.Add("nviduntduonamduotempornonumyloremettakimatasadipscingveniamnonum");
            matrix.Add("asdstetdoloreosseaetnonumysadipscingmolestiemagnasitatexercidele");
            matrix.Add("metealoremametmagnainviduntetnibhnoloremtemporelitrmagnaeleifend");
            matrix.Add("adipscingdoloreconseteturlobortiserateteroslaboresteteirmodwisia");
            matrix.Add("tveroametinstetdiamlaborenonumyseajustoipsumsitsitindolorcommodo");
            matrix.Add("ccumsaniriureconsequatconseteturametseddoloresseaautemgubergreni");
            matrix.Add("uisutgubergrenelitrinsitloremtakimataquiestclitaetlobortissanctu");
            matrix.Add("ovoluptuablanditverotakimatatakimataloremdignissimerattemporkasd");
            matrix.Add("vugaittemporexercizzrileosiriureconseteturutelitrlaboremolestiev");
            matrix.Add("eloreetnonumyeuismodlobortisutameteulaboreipsumenimametconsetete");
            matrix.Add("rdipscingetutsitseainviduntnibhametvoluptuaethendreritconsequatr");
            matrix.Add("tnummyseafacilisisatvoluptuaodioatetmagnadoloresaliquyamdolorejt");
            matrix.Add("iatuttakimataetseaverosedesseetenimutdolorejustoipsumsedsadipsci");
            matrix.Add("camutseadolorsitclitaaccusammagnaelitretsitvelkasdnoetlaboresitc");
            matrix.Add("aloreetsadipscingexestkasdsadipscingdolorsadipscingetimperdietda");
            matrix.Add("letutfacereratetfacilisisloremsittemporametloremautemeratteipsul");
            matrix.Add("horizontalwordleftbottomaboreenimirtesthorizontalwordrightbottom");
            #endregion

            wordFinder = new WordFinder(matrix);
        }

        [Test]
        public void HorizontalWordLeftTopTest()
        {
            wordsToFind = new List<string>();
            wordsToFind.Add("horizontalwordlefttop");
            findedWords = wordFinder.Find(wordsToFind);

            Assert.That(findedWords.Where(fw => fw == "horizontalwordlefttop").Count(), Is.EqualTo(1));
        }

        [Test]
        public void HorizontalWordRightTopTest()
        {
            wordsToFind = new List<string>();
            wordsToFind.Add("horizontalwordrighttop");
            findedWords = wordFinder.Find(wordsToFind);

            Assert.That(findedWords.Where(fw => fw == "horizontalwordrighttop").Count(), Is.EqualTo(1));
        }

        [Test]
        public void HorizontalWordLeftBottomTest()
        {
            wordsToFind = new List<string>();
            wordsToFind.Add("horizontalwordleftbottom");
            findedWords = wordFinder.Find(wordsToFind);

            Assert.That(findedWords.Where(fw => fw == "horizontalwordleftbottom").Count(), Is.EqualTo(1));
        }

        [Test]
        public void HorizontalWordRightBottomTest()
        {
            wordsToFind = new List<string>();
            wordsToFind.Add("horizontalwordrightbottom");
            findedWords = wordFinder.Find(wordsToFind);

            Assert.That(findedWords.Where(fw => fw == "horizontalwordrightbottom").Count(), Is.EqualTo(1));
        }

        [Test]
        public void VerticalWordLeftTopTest()
        {
            wordsToFind = new List<string>();
            wordsToFind.Add("hvertical");
            findedWords = wordFinder.Find(wordsToFind);

            Assert.That(findedWords.Where(fw => fw == "hvertical").Count(), Is.EqualTo(1));
        }

        [Test]
        public void VerticalWordRightTopTest()
        {
            wordsToFind = new List<string>();
            wordsToFind.Add("pvertical");
            findedWords = wordFinder.Find(wordsToFind);

            Assert.That(findedWords.Where(fw => fw == "pvertical").Count(), Is.EqualTo(1));
        }

        [Test]
        public void VerticalWordLeftBottomTest()
        {
            wordsToFind = new List<string>();
            wordsToFind.Add("verticalh");
            findedWords = wordFinder.Find(wordsToFind);

            Assert.That(findedWords.Where(fw => fw == "verticalh").Count(), Is.EqualTo(1));
        }

        [Test]
        public void VerticalWordRightBottomTest()
        {
            wordsToFind = new List<string>();
            wordsToFind.Add("verticalm");
            findedWords = wordFinder.Find(wordsToFind);

            Assert.That(findedWords.Where(fw => fw == "verticalm").Count(), Is.EqualTo(1));
        }

        [Test]
        public void SecuenceTest()
        {
            wordsToFind = new List<string>();
            wordsToFind.Add("secuenceone");
            wordsToFind.Add("secuencetwo");
            wordsToFind.Add("secuencethree");
            wordsToFind.Add("secuencefour");
            wordsToFind.Add("secuencefive");
            findedWords = wordFinder.Find(wordsToFind);

            Assert.That(findedWords.Where(fw => fw == "secuenceone").Count(), Is.EqualTo(1));
            Assert.That(findedWords.Where(fw => fw == "secuencetwo").Count(), Is.EqualTo(1));
            Assert.That(findedWords.Where(fw => fw == "secuencethree").Count(), Is.EqualTo(1));
            Assert.That(findedWords.Where(fw => fw == "secuencefour").Count(), Is.EqualTo(1));
            Assert.That(findedWords.Where(fw => fw == "secuencefive").Count(), Is.EqualTo(1));
        }

        [Test]
        public void TopTenTest()
        {
            wordsToFind = new List<string>();
            wordsToFind.Add("wordtopone");
            wordsToFind.Add("wordtoptwo");
            wordsToFind.Add("wordtopthree");
            wordsToFind.Add("wordtopfour");
            wordsToFind.Add("wordtopfive");
            wordsToFind.Add("wordtopsix");
            wordsToFind.Add("wordtopseven");
            wordsToFind.Add("wordtopeight");
            wordsToFind.Add("wordtopnine");
            wordsToFind.Add("wordtopten");
            wordsToFind.Add("wordtopeleven");
            findedWords = wordFinder.Find(wordsToFind);

            Assert.That(findedWords.Where(fw => fw == "wordtopone").Count(), Is.EqualTo(1));
            Assert.That(findedWords.Where(fw => fw == "wordtoptwo").Count(), Is.EqualTo(1));
            Assert.That(findedWords.Where(fw => fw == "wordtopthree").Count(), Is.EqualTo(1));
            Assert.That(findedWords.Where(fw => fw == "wordtopfour").Count(), Is.EqualTo(1));
            Assert.That(findedWords.Where(fw => fw == "wordtopfive").Count(), Is.EqualTo(1));
            Assert.That(findedWords.Where(fw => fw == "wordtopsix").Count(), Is.EqualTo(1));
            Assert.That(findedWords.Where(fw => fw == "wordtopseven").Count(), Is.EqualTo(1));
            Assert.That(findedWords.Where(fw => fw == "wordtopeight").Count(), Is.EqualTo(1));
            Assert.That(findedWords.Where(fw => fw == "wordtopnine").Count(), Is.EqualTo(1));
            Assert.That(findedWords.Where(fw => fw == "wordtopten").Count(), Is.EqualTo(1));
            Assert.That(findedWords.Where(fw => fw == "wordtopeleven").Count(), Is.EqualTo(0));
        }

        [Test]
        public void NoFindedWord()
        {
            wordsToFind = new List<string>();
            wordsToFind.Add("notfindedword");
            findedWords = wordFinder.Find(wordsToFind);

            Assert.IsNotNull(findedWords);
            Assert.That(findedWords.Count(), Is.EqualTo(0));
        }

        [Test]
        public void NoWordsToFind()
        {
            wordsToFind = new List<string>();
            findedWords = wordFinder.Find(wordsToFind);

            Assert.IsNotNull(findedWords);
            Assert.That(findedWords.Count(), Is.EqualTo(0));
        }

        [Test]
        public void MatrixTooBigHorizontaly()
        {
            #region Matrix too big horizontaly
            List<string> localMatrix = new List<string>();
            localMatrix.Add("horizontalwordlefttoperipsumdiamnonumyzteshorizontalwordrighttoph");
            localMatrix.Add("vsitseautjustohendreritetnostrudsitinviduntaliquyamsteteirmodalvh");
            localMatrix.Add("etionutsitatstetmagnaillumsadipscingoptioneirmodaccumsanetvoluteh");
            localMatrix.Add("rlumeuismodinateratkasdinviduntloremipsumwisiutfacilisisametclirh");
            localMatrix.Add("tvoluptuaseazzrilseddoloresdolorseddolorekasdeasedenimipsumnobith");
            localMatrix.Add("iloripsumeleifendatfacerassumveniametconseteturelitconsequatconih");
            localMatrix.Add("csumelitreulaborequisduisetvelsanctusveronoeratduoatsitloremlorch");
            localMatrix.Add("aconsectetuerdoloratsadipscingfacilisiloremrebumaliquipdoloresaah");
            localMatrix.Add("llormagnavoluptuaeadiamelitdoloreratetmagnaveroextemporrebumeralh");
            localMatrix.Add("tdoloreipsumiriureveroaccusamestveroseaaccusamseaadetaliquyameosh");
            localMatrix.Add("agnacommodoloremdoloresconsequataliquamerosiriureipsumrebumverovh");
            localMatrix.Add("oloreslaborenoiustoameteossealoremduodiamutsitateirmoddoloreetnoh");
            localMatrix.Add("ccusamutveroeaelitrclitanibhkasddolorsanctustemporfacilisisguberh");
            localMatrix.Add("asdduoeirmodeaexercicommodoexauguenostrudjustoettinciduntlaoreeth");
            localMatrix.Add("npraesenttempordolorconsequatdoloresfacilisimagnaaliquyamtevelith");
            localMatrix.Add("onseteturtakimataeratvoluptuanisleuiriureiustoullamcorperdoloriph");
            localMatrix.Add("litrsiteratestjustoeteumadimperdieteaduisfeugiatnislsadipscinglah");
            localMatrix.Add("aelitrutjustoseddoloresseaautemametutlaboreeaaccusamipsumetconseh");
            localMatrix.Add("tstetetjustoetmagnaetinloremdoloresessenislquiseleifendsadipscinh");
            localMatrix.Add("metdolorvelatautemmagnaluptatumetfacilisisnislutjustonobislaboreh");
            localMatrix.Add("metsedidtemporeossiteumeratipsumveroverodoloresdolorestetaliquamh");
            localMatrix.Add("olortemporduoluptatumdoloresametdiamtakimatadoloresjustoutdolordh");
            localMatrix.Add("oloraliquyamametnoipsumduomolestierebumutinviduntloremessetemporh");
            localMatrix.Add("iaminviduntametaugueexerciluptatumaliquamsedtemporsadipscingmoleh");
            localMatrix.Add("anctussittemporwisiutautemnullaipsumlaboreetmagnadolorlaboretemph");
            localMatrix.Add("ustoverodiamduoesttejustoattincidunthendreritsedquisutnonumyeteih");
            localMatrix.Add("onumyelitoptionetdoloreateaveroametrebumdoloresednonumynogubergrh");
            localMatrix.Add("psumettemporaliquipnullasanctusmolestiesadipscinggubergrenstettih");
            localMatrix.Add("secuenceonesecuencetwosecuencethreesecuencefoursecuencefivesecueh");
            localMatrix.Add("wordtoponewordtoponewordtoponewordtoponewordtoponewordtoponeipsuh");
            localMatrix.Add("wordtoponewordtoponewordtoponewordtoponewordtoponewordtoptwoipsuh");
            localMatrix.Add("wordtoptwowordtoptwowordtoptwowordtoptwowordtoptwowordtoptwoipsuh");
            localMatrix.Add("wordtoptwowordtoptwowordtoptwowordtopthreewordtopthreeipsumetsufh");
            localMatrix.Add("wordtopthreewordtopthreewordtopthreewordtopthreewordtopthreeipsuh");
            localMatrix.Add("wordtopthreewordtopthreewordtopfourwordtopfourwordtopfouripsumeth");
            localMatrix.Add("wordtopfourwordtopfourwordtopfourwordtopfourwordtopfouripsumetsuh");
            localMatrix.Add("wordtopfivewordtopfivewordtopfivewordtopfivewordtopfiveipsumetsuh");
            localMatrix.Add("wordtopfivewordtopfivewordtopsixwordtopsixwordtopsixwordtopsixiph");
            localMatrix.Add("wordtopsixwordtopsixwordtopsevenwordtopsevenwordtopsevenipsumetsh");
            localMatrix.Add("wordtopsevenwordtopsevenwordtopeightwordtopeightwordtopeightipsuh");
            localMatrix.Add("wordtopeightwordtopninewordtopninewordtopninewordtoptenipsumetsuh");
            localMatrix.Add("wordtoptenwordtopelevenmeosfeugiatstetvoluptuasiteirmodipsumetsuh");
            localMatrix.Add("edatnibhullamcorperipsumeosfeugiatstetvoluptuasiteirmodipsumetsuh");
            localMatrix.Add("aoreetametconsequatealoremidtempordiameablanditametipsumerataliqh");
            localMatrix.Add("meteratipsumliberduoeasitclitadelenitdiameleifendtakimatainvidunh");
            localMatrix.Add("umfacilisiseadolorenostrudconseteturexerciaugueeaquiseoskasdeosdh");
            localMatrix.Add("iteteagubergrenelitrluptatumfacerseaetestgubergrenetverotemporsth");
            localMatrix.Add("nviduntduonamduotempornonumyloremettakimatasadipscingveniamnonumh");
            localMatrix.Add("asdstetdoloreosseaetnonumysadipscingmolestiemagnasitatexercideleh");
            localMatrix.Add("metealoremametmagnainviduntetnibhnoloremtemporelitrmagnaeleifendh");
            localMatrix.Add("adipscingdoloreconseteturlobortiserateteroslaboresteteirmodwisiah");
            localMatrix.Add("tveroametinstetdiamlaborenonumyseajustoipsumsitsitindolorcommodoh");
            localMatrix.Add("ccumsaniriureconsequatconseteturametseddoloresseaautemgubergrenih");
            localMatrix.Add("uisutgubergrenelitrinsitloremtakimataquiestclitaetlobortissanctuh");
            localMatrix.Add("ovoluptuablanditverotakimatatakimataloremdignissimerattemporkasdh");
            localMatrix.Add("vugaittemporexercizzrileosiriureconseteturutelitrlaboremolestievh");
            localMatrix.Add("eloreetnonumyeuismodlobortisutameteulaboreipsumenimametconseteteh");
            localMatrix.Add("rdipscingetutsitseainviduntnibhametvoluptuaethendreritconsequatrh");
            localMatrix.Add("tnummyseafacilisisatvoluptuaodioatetmagnadoloresaliquyamdolorejth");
            localMatrix.Add("iatuttakimataetseaverosedesseetenimutdolorejustoipsumsedsadipscih");
            localMatrix.Add("camutseadolorsitclitaaccusammagnaelitretsitvelkasdnoetlaboresitch");
            localMatrix.Add("aloreetsadipscingexestkasdsadipscingdolorsadipscingetimperdietdah");
            localMatrix.Add("letutfacereratetfacilisisloremsittemporametloremautemeratteipsulh");
            localMatrix.Add("horizontalwordleftbottomaboreenimirtesthorizontalwordrightbottomh");
            #endregion

            try
            {
                WordFinder wordFinderLocaly = new WordFinder(localMatrix);
            }
            catch (Exception e)
            {
                Assert.That(e.Message, Is.EqualTo("The matrix must be 64x64"));
            }
        }

        [Test]
        public void MatrixTooBigVerticaly()
        {
            #region Matrix too big verticaly
            List<string> localMatrix = new List<string>();
            localMatrix.Add("horizontalwordlefttoperipsumdiamnonumyzteshorizontalwordrighttop");
            localMatrix.Add("vsitseautjustohendreritetnostrudsitinviduntaliquyamsteteirmodalv");
            localMatrix.Add("etionutsitatstetmagnaillumsadipscingoptioneirmodaccumsanetvolute");
            localMatrix.Add("rlumeuismodinateratkasdinviduntloremipsumwisiutfacilisisametclir");
            localMatrix.Add("tvoluptuaseazzrilseddoloresdolorseddolorekasdeasedenimipsumnobit");
            localMatrix.Add("iloripsumeleifendatfacerassumveniametconseteturelitconsequatconi");
            localMatrix.Add("csumelitreulaborequisduisetvelsanctusveronoeratduoatsitloremlorc");
            localMatrix.Add("aconsectetuerdoloratsadipscingfacilisiloremrebumaliquipdoloresaa");
            localMatrix.Add("llormagnavoluptuaeadiamelitdoloreratetmagnaveroextemporrebumeral");
            localMatrix.Add("tdoloreipsumiriureveroaccusamestveroseaaccusamseaadetaliquyameos");
            localMatrix.Add("agnacommodoloremdoloresconsequataliquamerosiriureipsumrebumverov");
            localMatrix.Add("oloreslaborenoiustoameteossealoremduodiamutsitateirmoddoloreetno");
            localMatrix.Add("ccusamutveroeaelitrclitanibhkasddolorsanctustemporfacilisisguber");
            localMatrix.Add("asdduoeirmodeaexercicommodoexauguenostrudjustoettinciduntlaoreet");
            localMatrix.Add("npraesenttempordolorconsequatdoloresfacilisimagnaaliquyamtevelit");
            localMatrix.Add("onseteturtakimataeratvoluptuanisleuiriureiustoullamcorperdolorip");
            localMatrix.Add("litrsiteratestjustoeteumadimperdieteaduisfeugiatnislsadipscingla");
            localMatrix.Add("aelitrutjustoseddoloresseaautemametutlaboreeaaccusamipsumetconse");
            localMatrix.Add("tstetetjustoetmagnaetinloremdoloresessenislquiseleifendsadipscin");
            localMatrix.Add("metdolorvelatautemmagnaluptatumetfacilisisnislutjustonobislabore");
            localMatrix.Add("metsedidtemporeossiteumeratipsumveroverodoloresdolorestetaliquam");
            localMatrix.Add("olortemporduoluptatumdoloresametdiamtakimatadoloresjustoutdolord");
            localMatrix.Add("oloraliquyamametnoipsumduomolestierebumutinviduntloremessetempor");
            localMatrix.Add("iaminviduntametaugueexerciluptatumaliquamsedtemporsadipscingmole");
            localMatrix.Add("anctussittemporwisiutautemnullaipsumlaboreetmagnadolorlaboretemp");
            localMatrix.Add("ustoverodiamduoesttejustoattincidunthendreritsedquisutnonumyetei");
            localMatrix.Add("onumyelitoptionetdoloreateaveroametrebumdoloresednonumynogubergr");
            localMatrix.Add("psumettemporaliquipnullasanctusmolestiesadipscinggubergrenstetti");
            localMatrix.Add("secuenceonesecuencetwosecuencethreesecuencefoursecuencefivesecue");
            localMatrix.Add("wordtoponewordtoponewordtoponewordtoponewordtoponewordtoponeipsu");
            localMatrix.Add("wordtoponewordtoponewordtoponewordtoponewordtoponewordtoptwoipsu");
            localMatrix.Add("wordtoptwowordtoptwowordtoptwowordtoptwowordtoptwowordtoptwoipsu");
            localMatrix.Add("wordtoptwowordtoptwowordtoptwowordtopthreewordtopthreeipsumetsuf");
            localMatrix.Add("wordtopthreewordtopthreewordtopthreewordtopthreewordtopthreeipsu");
            localMatrix.Add("wordtopthreewordtopthreewordtopfourwordtopfourwordtopfouripsumet");
            localMatrix.Add("wordtopfourwordtopfourwordtopfourwordtopfourwordtopfouripsumetsu");
            localMatrix.Add("wordtopfivewordtopfivewordtopfivewordtopfivewordtopfiveipsumetsu");
            localMatrix.Add("wordtopfivewordtopfivewordtopsixwordtopsixwordtopsixwordtopsixip");
            localMatrix.Add("wordtopsixwordtopsixwordtopsevenwordtopsevenwordtopsevenipsumets");
            localMatrix.Add("wordtopsevenwordtopsevenwordtopeightwordtopeightwordtopeightipsu");
            localMatrix.Add("wordtopeightwordtopninewordtopninewordtopninewordtoptenipsumetsu");
            localMatrix.Add("wordtoptenwordtopelevenmeosfeugiatstetvoluptuasiteirmodipsumetsu");
            localMatrix.Add("edatnibhullamcorperipsumeosfeugiatstetvoluptuasiteirmodipsumetsu");
            localMatrix.Add("aoreetametconsequatealoremidtempordiameablanditametipsumerataliq");
            localMatrix.Add("meteratipsumliberduoeasitclitadelenitdiameleifendtakimatainvidun");
            localMatrix.Add("umfacilisiseadolorenostrudconseteturexerciaugueeaquiseoskasdeosd");
            localMatrix.Add("iteteagubergrenelitrluptatumfacerseaetestgubergrenetverotemporst");
            localMatrix.Add("nviduntduonamduotempornonumyloremettakimatasadipscingveniamnonum");
            localMatrix.Add("asdstetdoloreosseaetnonumysadipscingmolestiemagnasitatexercidele");
            localMatrix.Add("metealoremametmagnainviduntetnibhnoloremtemporelitrmagnaeleifend");
            localMatrix.Add("adipscingdoloreconseteturlobortiserateteroslaboresteteirmodwisia");
            localMatrix.Add("tveroametinstetdiamlaborenonumyseajustoipsumsitsitindolorcommodo");
            localMatrix.Add("ccumsaniriureconsequatconseteturametseddoloresseaautemgubergreni");
            localMatrix.Add("uisutgubergrenelitrinsitloremtakimataquiestclitaetlobortissanctu");
            localMatrix.Add("ovoluptuablanditverotakimatatakimataloremdignissimerattemporkasd");
            localMatrix.Add("vugaittemporexercizzrileosiriureconseteturutelitrlaboremolestiev");
            localMatrix.Add("eloreetnonumyeuismodlobortisutameteulaboreipsumenimametconsetete");
            localMatrix.Add("rdipscingetutsitseainviduntnibhametvoluptuaethendreritconsequatr");
            localMatrix.Add("tnummyseafacilisisatvoluptuaodioatetmagnadoloresaliquyamdolorejt");
            localMatrix.Add("iatuttakimataetseaverosedesseetenimutdolorejustoipsumsedsadipsci");
            localMatrix.Add("camutseadolorsitclitaaccusammagnaelitretsitvelkasdnoetlaboresitc");
            localMatrix.Add("aloreetsadipscingexestkasdsadipscingdolorsadipscingetimperdietda");
            localMatrix.Add("letutfacereratetfacilisisloremsittemporametloremautemeratteipsul");
            localMatrix.Add("horizontalwordleftbottomaboreenimirtesthorizontalwordrightbottom");
            localMatrix.Add("horizontalwordleftbottomaboreenimirtesthorizontalwordrightbottom");
            #endregion

            try
            {
                WordFinder wordFinderLocaly = new WordFinder(localMatrix);
            }
            catch (Exception e)
            {
                Assert.That(e.Message, Is.EqualTo("The matrix must be 64x64"));
            }
        }

        [Test]
        public void MatrixTooSmallHorizontaly()
        {
            #region Matrix too small horizontaly
            List<string> localMatrix = new List<string>();
            localMatrix.Add("horizontalwordlefttoperipsumdiamnonumyzteshorizontalwordrightto");
            localMatrix.Add("vsitseautjustohendreritetnostrudsitinviduntaliquyamsteteirmodal");
            localMatrix.Add("etionutsitatstetmagnaillumsadipscingoptioneirmodaccumsanetvolut");
            localMatrix.Add("rlumeuismodinateratkasdinviduntloremipsumwisiutfacilisisametcli");
            localMatrix.Add("tvoluptuaseazzrilseddoloresdolorseddolorekasdeasedenimipsumnobi");
            localMatrix.Add("iloripsumeleifendatfacerassumveniametconseteturelitconsequatcon");
            localMatrix.Add("csumelitreulaborequisduisetvelsanctusveronoeratduoatsitloremlor");
            localMatrix.Add("aconsectetuerdoloratsadipscingfacilisiloremrebumaliquipdoloresa");
            localMatrix.Add("llormagnavoluptuaeadiamelitdoloreratetmagnaveroextemporrebumera");
            localMatrix.Add("tdoloreipsumiriureveroaccusamestveroseaaccusamseaadetaliquyameo");
            localMatrix.Add("agnacommodoloremdoloresconsequataliquamerosiriureipsumrebumvero");
            localMatrix.Add("oloreslaborenoiustoameteossealoremduodiamutsitateirmoddoloreetn");
            localMatrix.Add("ccusamutveroeaelitrclitanibhkasddolorsanctustemporfacilisisgube");
            localMatrix.Add("asdduoeirmodeaexercicommodoexauguenostrudjustoettinciduntlaoree");
            localMatrix.Add("npraesenttempordolorconsequatdoloresfacilisimagnaaliquyamteveli");
            localMatrix.Add("onseteturtakimataeratvoluptuanisleuiriureiustoullamcorperdolori");
            localMatrix.Add("litrsiteratestjustoeteumadimperdieteaduisfeugiatnislsadipscingl");
            localMatrix.Add("aelitrutjustoseddoloresseaautemametutlaboreeaaccusamipsumetcons");
            localMatrix.Add("tstetetjustoetmagnaetinloremdoloresessenislquiseleifendsadipsci");
            localMatrix.Add("metdolorvelatautemmagnaluptatumetfacilisisnislutjustonobislabor");
            localMatrix.Add("metsedidtemporeossiteumeratipsumveroverodoloresdolorestetaliqua");
            localMatrix.Add("olortemporduoluptatumdoloresametdiamtakimatadoloresjustoutdolor");
            localMatrix.Add("oloraliquyamametnoipsumduomolestierebumutinviduntloremessetempo");
            localMatrix.Add("iaminviduntametaugueexerciluptatumaliquamsedtemporsadipscingmol");
            localMatrix.Add("anctussittemporwisiutautemnullaipsumlaboreetmagnadolorlaboretem");
            localMatrix.Add("ustoverodiamduoesttejustoattincidunthendreritsedquisutnonumyete");
            localMatrix.Add("onumyelitoptionetdoloreateaveroametrebumdoloresednonumynoguberg");
            localMatrix.Add("psumettemporaliquipnullasanctusmolestiesadipscinggubergrenstett");
            localMatrix.Add("secuenceonesecuencetwosecuencethreesecuencefoursecuencefivesecu");
            localMatrix.Add("wordtoponewordtoponewordtoponewordtoponewordtoponewordtoponeips");
            localMatrix.Add("wordtoponewordtoponewordtoponewordtoponewordtoponewordtoptwoips");
            localMatrix.Add("wordtoptwowordtoptwowordtoptwowordtoptwowordtoptwowordtoptwoips");
            localMatrix.Add("wordtoptwowordtoptwowordtoptwowordtopthreewordtopthreeipsumetsu");
            localMatrix.Add("wordtopthreewordtopthreewordtopthreewordtopthreewordtopthreeips");
            localMatrix.Add("wordtopthreewordtopthreewordtopfourwordtopfourwordtopfouripsume");
            localMatrix.Add("wordtopfourwordtopfourwordtopfourwordtopfourwordtopfouripsumets");
            localMatrix.Add("wordtopfivewordtopfivewordtopfivewordtopfivewordtopfiveipsumets");
            localMatrix.Add("wordtopfivewordtopfivewordtopsixwordtopsixwordtopsixwordtopsixi");
            localMatrix.Add("wordtopsixwordtopsixwordtopsevenwordtopsevenwordtopsevenipsumet");
            localMatrix.Add("wordtopsevenwordtopsevenwordtopeightwordtopeightwordtopeightips");
            localMatrix.Add("wordtopeightwordtopninewordtopninewordtopninewordtoptenipsumets");
            localMatrix.Add("wordtoptenwordtopelevenmeosfeugiatstetvoluptuasiteirmodipsumets");
            localMatrix.Add("edatnibhullamcorperipsumeosfeugiatstetvoluptuasiteirmodipsumets");
            localMatrix.Add("aoreetametconsequatealoremidtempordiameablanditametipsumeratali");
            localMatrix.Add("meteratipsumliberduoeasitclitadelenitdiameleifendtakimatainvidu");
            localMatrix.Add("umfacilisiseadolorenostrudconseteturexerciaugueeaquiseoskasdeos");
            localMatrix.Add("iteteagubergrenelitrluptatumfacerseaetestgubergrenetverotempors");
            localMatrix.Add("nviduntduonamduotempornonumyloremettakimatasadipscingveniamnonu");
            localMatrix.Add("asdstetdoloreosseaetnonumysadipscingmolestiemagnasitatexercidel");
            localMatrix.Add("metealoremametmagnainviduntetnibhnoloremtemporelitrmagnaeleifen");
            localMatrix.Add("adipscingdoloreconseteturlobortiserateteroslaboresteteirmodwisi");
            localMatrix.Add("tveroametinstetdiamlaborenonumyseajustoipsumsitsitindolorcommod");
            localMatrix.Add("ccumsaniriureconsequatconseteturametseddoloresseaautemgubergren");
            localMatrix.Add("uisutgubergrenelitrinsitloremtakimataquiestclitaetlobortissanct");
            localMatrix.Add("ovoluptuablanditverotakimatatakimataloremdignissimerattemporkas");
            localMatrix.Add("vugaittemporexercizzrileosiriureconseteturutelitrlaboremolestie");
            localMatrix.Add("eloreetnonumyeuismodlobortisutameteulaboreipsumenimametconsetet");
            localMatrix.Add("rdipscingetutsitseainviduntnibhametvoluptuaethendreritconsequat");
            localMatrix.Add("tnummyseafacilisisatvoluptuaodioatetmagnadoloresaliquyamdolorej");
            localMatrix.Add("iatuttakimataetseaverosedesseetenimutdolorejustoipsumsedsadipsc");
            localMatrix.Add("camutseadolorsitclitaaccusammagnaelitretsitvelkasdnoetlaboresit");
            localMatrix.Add("aloreetsadipscingexestkasdsadipscingdolorsadipscingetimperdietd");
            localMatrix.Add("letutfacereratetfacilisisloremsittemporametloremautemeratteipsu");
            localMatrix.Add("horizontalwordleftbottomaboreenimirtesthorizontalwordrightbotto");
            #endregion

            try
            {
                WordFinder wordFinderLocaly = new WordFinder(localMatrix);
            }
            catch (Exception e)
            {
                Assert.That(e.Message, Is.EqualTo("The matrix must be 64x64"));
            }
        }

        [Test]
        public void MatrixTooSmallVerticaly()
        {
            #region Matrix too small verticaly
            List<string> localMatrix = new List<string>();
            localMatrix.Add("horizontalwordlefttoperipsumdiamnonumyzteshorizontalwordrighttop");
            localMatrix.Add("vsitseautjustohendreritetnostrudsitinviduntaliquyamsteteirmodalv");
            localMatrix.Add("etionutsitatstetmagnaillumsadipscingoptioneirmodaccumsanetvolute");
            localMatrix.Add("rlumeuismodinateratkasdinviduntloremipsumwisiutfacilisisametclir");
            localMatrix.Add("tvoluptuaseazzrilseddoloresdolorseddolorekasdeasedenimipsumnobit");
            localMatrix.Add("iloripsumeleifendatfacerassumveniametconseteturelitconsequatconi");
            localMatrix.Add("csumelitreulaborequisduisetvelsanctusveronoeratduoatsitloremlorc");
            localMatrix.Add("aconsectetuerdoloratsadipscingfacilisiloremrebumaliquipdoloresaa");
            localMatrix.Add("llormagnavoluptuaeadiamelitdoloreratetmagnaveroextemporrebumeral");
            localMatrix.Add("tdoloreipsumiriureveroaccusamestveroseaaccusamseaadetaliquyameos");
            localMatrix.Add("agnacommodoloremdoloresconsequataliquamerosiriureipsumrebumverov");
            localMatrix.Add("oloreslaborenoiustoameteossealoremduodiamutsitateirmoddoloreetno");
            localMatrix.Add("ccusamutveroeaelitrclitanibhkasddolorsanctustemporfacilisisguber");
            localMatrix.Add("asdduoeirmodeaexercicommodoexauguenostrudjustoettinciduntlaoreet");
            localMatrix.Add("npraesenttempordolorconsequatdoloresfacilisimagnaaliquyamtevelit");
            localMatrix.Add("onseteturtakimataeratvoluptuanisleuiriureiustoullamcorperdolorip");
            localMatrix.Add("litrsiteratestjustoeteumadimperdieteaduisfeugiatnislsadipscingla");
            localMatrix.Add("aelitrutjustoseddoloresseaautemametutlaboreeaaccusamipsumetconse");
            localMatrix.Add("tstetetjustoetmagnaetinloremdoloresessenislquiseleifendsadipscin");
            localMatrix.Add("metdolorvelatautemmagnaluptatumetfacilisisnislutjustonobislabore");
            localMatrix.Add("metsedidtemporeossiteumeratipsumveroverodoloresdolorestetaliquam");
            localMatrix.Add("olortemporduoluptatumdoloresametdiamtakimatadoloresjustoutdolord");
            localMatrix.Add("oloraliquyamametnoipsumduomolestierebumutinviduntloremessetempor");
            localMatrix.Add("iaminviduntametaugueexerciluptatumaliquamsedtemporsadipscingmole");
            localMatrix.Add("anctussittemporwisiutautemnullaipsumlaboreetmagnadolorlaboretemp");
            localMatrix.Add("ustoverodiamduoesttejustoattincidunthendreritsedquisutnonumyetei");
            localMatrix.Add("onumyelitoptionetdoloreateaveroametrebumdoloresednonumynogubergr");
            localMatrix.Add("psumettemporaliquipnullasanctusmolestiesadipscinggubergrenstetti");
            localMatrix.Add("secuenceonesecuencetwosecuencethreesecuencefoursecuencefivesecue");
            localMatrix.Add("wordtoponewordtoponewordtoponewordtoponewordtoponewordtoponeipsu");
            localMatrix.Add("wordtoponewordtoponewordtoponewordtoponewordtoponewordtoptwoipsu");
            localMatrix.Add("wordtoptwowordtoptwowordtoptwowordtoptwowordtoptwowordtoptwoipsu");
            localMatrix.Add("wordtoptwowordtoptwowordtoptwowordtopthreewordtopthreeipsumetsuf");
            localMatrix.Add("wordtopthreewordtopthreewordtopthreewordtopthreewordtopthreeipsu");
            localMatrix.Add("wordtopthreewordtopthreewordtopfourwordtopfourwordtopfouripsumet");
            localMatrix.Add("wordtopfourwordtopfourwordtopfourwordtopfourwordtopfouripsumetsu");
            localMatrix.Add("wordtopfivewordtopfivewordtopfivewordtopfivewordtopfiveipsumetsu");
            localMatrix.Add("wordtopfivewordtopfivewordtopsixwordtopsixwordtopsixwordtopsixip");
            localMatrix.Add("wordtopsixwordtopsixwordtopsevenwordtopsevenwordtopsevenipsumets");
            localMatrix.Add("wordtopsevenwordtopsevenwordtopeightwordtopeightwordtopeightipsu");
            localMatrix.Add("wordtopeightwordtopninewordtopninewordtopninewordtoptenipsumetsu");
            localMatrix.Add("wordtoptenwordtopelevenmeosfeugiatstetvoluptuasiteirmodipsumetsu");
            localMatrix.Add("edatnibhullamcorperipsumeosfeugiatstetvoluptuasiteirmodipsumetsu");
            localMatrix.Add("aoreetametconsequatealoremidtempordiameablanditametipsumerataliq");
            localMatrix.Add("meteratipsumliberduoeasitclitadelenitdiameleifendtakimatainvidun");
            localMatrix.Add("umfacilisiseadolorenostrudconseteturexerciaugueeaquiseoskasdeosd");
            localMatrix.Add("iteteagubergrenelitrluptatumfacerseaetestgubergrenetverotemporst");
            localMatrix.Add("nviduntduonamduotempornonumyloremettakimatasadipscingveniamnonum");
            localMatrix.Add("asdstetdoloreosseaetnonumysadipscingmolestiemagnasitatexercidele");
            localMatrix.Add("metealoremametmagnainviduntetnibhnoloremtemporelitrmagnaeleifend");
            localMatrix.Add("adipscingdoloreconseteturlobortiserateteroslaboresteteirmodwisia");
            localMatrix.Add("tveroametinstetdiamlaborenonumyseajustoipsumsitsitindolorcommodo");
            localMatrix.Add("ccumsaniriureconsequatconseteturametseddoloresseaautemgubergreni");
            localMatrix.Add("uisutgubergrenelitrinsitloremtakimataquiestclitaetlobortissanctu");
            localMatrix.Add("ovoluptuablanditverotakimatatakimataloremdignissimerattemporkasd");
            localMatrix.Add("vugaittemporexercizzrileosiriureconseteturutelitrlaboremolestiev");
            localMatrix.Add("eloreetnonumyeuismodlobortisutameteulaboreipsumenimametconsetete");
            localMatrix.Add("rdipscingetutsitseainviduntnibhametvoluptuaethendreritconsequatr");
            localMatrix.Add("tnummyseafacilisisatvoluptuaodioatetmagnadoloresaliquyamdolorejt");
            localMatrix.Add("iatuttakimataetseaverosedesseetenimutdolorejustoipsumsedsadipsci");
            localMatrix.Add("camutseadolorsitclitaaccusammagnaelitretsitvelkasdnoetlaboresitc");
            localMatrix.Add("aloreetsadipscingexestkasdsadipscingdolorsadipscingetimperdietda");
            localMatrix.Add("aloreetsadipscingexestkasdsadipscingdolorsadipscingetimperdietda");
            #endregion

            try
            {
                WordFinder wordFinderLocaly = new WordFinder(localMatrix);
            }
            catch (Exception e)
            {
                Assert.That(e.Message, Is.EqualTo("The matrix must be 64x64"));
            }
        }
    }
}