using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Sayı : ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //if(sayi1 == 0)
            //{
            //    Console.WriteLine("Nötr");
            //}
            //else if (sayi1 >= 0)
            //{
            //    Console.WriteLine("Sayı Pozitif");
            //}
            //else if(sayi1 <= 0)
            //{
            //    Console.WriteLine("Sayı Negatif");
            //}

            oyun();
        }



        static void oyun()
        {
            int[,] oyunalani = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };


            string ust1 = "-";
            string ust2 = "-";
            string ust3 = "-";

            string orta1 = "-";
            string orta2 = "-";
            string orta3 = "-";

            string alt1 = "-";
            string alt2 = "-";
            string alt3 = "-";



            string ust = ust1 + ust2 + ust3;
            string orta = orta1 + orta2 + orta3;
            string alt = alt1 + alt2 + alt3;

            string d = "dolu";

            string kullanilabilenyerler = "Kullanilabilen yerler = ";

            int oyunbitti = 0;

            int solustk = 0;
            int ortaustk = 0;
            int sagustk = 0;

            int solortak = 0;
            int ortak = 0;
            int sagortak = 0;

            int solaltk = 0;
            int ortaaltk = 0;
            int sagaltk = 0;

            int oyuncuxhamletekrar = 0;
            int oyuncuohamletekrar = 0;



            while (oyunbitti == 0)
            {
                if (solustk == 0)
                {
                    kullanilabilenyerler += "Sol Üst, ";
                }
                if (ortaustk == 0)
                {
                    kullanilabilenyerler += "Orta Üst, ";
                }
                if (sagustk == 0)
                {
                    kullanilabilenyerler += "Sağ Üst, ";
                }


                if (solortak == 0)
                {
                    kullanilabilenyerler += "Sol Orta, ";
                }
                if (ortak == 0)
                {
                    kullanilabilenyerler += "Orta, ";
                }
                if (sagortak == 0)
                {
                    kullanilabilenyerler += "Sağ Orta, ";
                }


                if (solaltk == 0)
                {
                    kullanilabilenyerler += "Sol Alt, ";
                }
                if (ortaaltk == 0)
                {
                    kullanilabilenyerler += "Orta Alt, ";
                }
                if (sagaltk == 0)
                {
                    kullanilabilenyerler += "Sağ Alt, ";
                }

                Console.WriteLine(kullanilabilenyerler);
                


                while (oyuncuxhamletekrar == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Oyuncu X hamle : ");
                    string oyuncuxhamle = Console.ReadLine();

                    if (oyuncuxhamle == "Sol Üst")
                    {
                        oyunalani[0, 0] = 1;
                        solustk = 1;
                        oyuncuxhamletekrar = 1;
                    }
                    else if (oyuncuxhamle == "Orta Üst")
                    {
                        oyunalani[0, 1] = 1;
                        ortaustk = 1;
                        oyuncuxhamletekrar = 1;
                    }
                    else if (oyuncuxhamle == "Sağ Üst")
                    {
                        oyunalani[0, 2] = 1;
                        sagustk = 1;
                        oyuncuxhamletekrar = 1;
                    }
                    else if (oyuncuxhamle == "Sol Orta")
                    {
                        oyunalani[1, 0] = 1;
                        solortak = 1;
                        oyuncuxhamletekrar = 1;
                    }
                    else if (oyuncuxhamle == "Orta")
                    {
                        oyunalani[1, 1] = 1;
                        ortak = 1;
                        oyuncuxhamletekrar = 1;
                    }
                    else if (oyuncuxhamle == "Sağ Orta")
                    {
                        oyunalani[1, 2] = 1;
                        sagortak = 1;
                        oyuncuxhamletekrar = 1;
                    }
                    else if (oyuncuxhamle == "Sol Alt")
                    {
                        oyunalani[2, 0] = 1;
                        solaltk = 1;
                        oyuncuxhamletekrar = 1;
                    }
                    else if (oyuncuxhamle == "Orta Alt")
                    {
                        oyunalani[2, 1] = 1;
                        ortaaltk = 1;
                        oyuncuxhamletekrar = 1;
                    }
                    else if (oyuncuxhamle == "Sağ Alt")
                    {
                        oyunalani[2, 2] = 1;
                        sagaltk = 1;
                        oyuncuxhamletekrar = 1;
                    }
                }
                oyuncuxhamletekrar = 0;

                while (oyuncuohamletekrar == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Oyuncu O hamle : ");
                    string oyuncuohamle = Console.ReadLine();

                    if (oyuncuohamle == "Sol Üst")
                    {
                        oyunalani[0, 0] = 2;
                        solustk = 1;
                        oyuncuohamletekrar = 1;
                    }
                    else if (oyuncuohamle == "Orta Üst")
                    {
                        oyunalani[0, 1] = 2;
                        ortaustk = 1;
                        oyuncuohamletekrar = 1;
                    }
                    else if (oyuncuohamle == "Sağ Üst")
                    {
                        oyunalani[0, 2] = 2;
                        sagustk = 1;
                        oyuncuohamletekrar = 1;
                    }
                    else if (oyuncuohamle == "Sol Orta")
                    {
                        oyunalani[1, 0] = 2;
                        solortak = 1;
                        oyuncuohamletekrar = 1;
                    }
                    else if (oyuncuohamle == "Orta")
                    {
                        oyunalani[1, 1] = 2;
                        ortak = 1;
                        oyuncuohamletekrar = 1;
                    }
                    else if (oyuncuohamle == "Sağ Orta")
                    {
                        oyunalani[1, 2] = 2;
                        sagortak = 1;
                        oyuncuohamletekrar = 1;
                    }
                    else if (oyuncuohamle == "Sol Alt")
                    {
                        oyunalani[2, 0] = 2;
                        solaltk = 1;
                        oyuncuohamletekrar = 1;
                    }
                    else if (oyuncuohamle == "Orta Alt")
                    {
                        oyunalani[2, 1] = 2;
                        ortaaltk = 1;
                        oyuncuohamletekrar = 1;
                    }
                    else if (oyuncuohamle == "Sağ Alt")
                    {
                        oyunalani[2, 2] = 2;
                        sagaltk = 1;
                        oyuncuohamletekrar = 1;
                    }
                }

                oyuncuohamletekrar = 0;

                kullanilabilenyerler = "Kullanilabilen yerler = ";
                //OYUN RESMİ

                //X
                if (oyunalani[0, 0] == 1)
                {
                    ust1 = "X";
                }
                else if (oyunalani[0, 1] == 1)
                {
                    ust2 = "X";
                }
                else if (oyunalani[0, 2] == 1)
                {
                    ust3 = "X";
                }
                //--
                if (oyunalani[1, 0] == 1)
                {
                    orta1 = "X";
                }
                else if (oyunalani[1, 1] == 1)
                {
                    orta2 = "X";
                }
                else if (oyunalani[1, 2] == 1)
                {
                    orta3 = "X";
                }
                //--
                if (oyunalani[2, 0] == 1)
                {
                    alt1 = "X";
                }
                else if (oyunalani[2, 1] == 1)
                {
                    alt2 = "X";
                }
                else if (oyunalani[2, 2] == 1)
                {
                    alt3 = "X";
                }
                //X

                //O
                if (oyunalani[0, 0] == 2)
                {
                    ust1 = "O";
                }
                else if (oyunalani[0, 1] == 2)
                {
                    ust2 = "O";
                }
                else if (oyunalani[0, 2] == 2)
                {
                    ust3 = "O";
                }
                //--
                if (oyunalani[1, 0] == 2)
                {
                    orta1 = "O";
                }
                else if (oyunalani[1, 1] == 2)
                {
                    orta2 = "O";
                }
                else if (oyunalani[1, 2] == 2)
                {
                    orta3 = "O";
                }
                //--
                if (oyunalani[2, 0] == 2)
                {
                    alt1 = "O";
                }
                else if (oyunalani[2, 1] == 2)
                {
                    alt2 = "O";
                }
                else if (oyunalani[2, 2] == 2)
                {
                    alt3 = "O";
                }
                //O
                //Oyun Resmi

                ust = ust1 + ust2 + ust3;
                orta = orta1 + orta2 + orta3;
                alt = alt1 + alt2 + alt3;

                Console.WriteLine("");
                Console.WriteLine(ust);
                Console.WriteLine(orta);
                Console.WriteLine(alt);


                //X İÇİN
                if (oyunalani[0, 0] == 1 && oyunalani[0, 1] == 1 && oyunalani[0, 2] == 1)
                {
                    Console.WriteLine("X Kazandı");
                    oyunbitti = 1;
                }
                else if (oyunalani[1, 0] == 1 && oyunalani[1, 1] == 1 && oyunalani[1, 2] == 1)
                {
                    Console.WriteLine("X Kazandı");
                    oyunbitti = 1;
                }
                else if (oyunalani[2, 0] == 1 && oyunalani[2, 1] == 1 && oyunalani[2, 2] == 1)
                {
                    Console.WriteLine("X Kazandı");
                    oyunbitti = 1;
                }
                //----------------------------------------------------------------------------------------
                else if (oyunalani[0, 0] == 1 && oyunalani[1, 0] == 1 && oyunalani[2, 0] == 1)
                {
                    Console.WriteLine("X Kazandı");
                    oyunbitti = 1;
                }
                else if (oyunalani[0, 1] == 1 && oyunalani[1, 1] == 1 && oyunalani[2, 1] == 1)
                {
                    Console.WriteLine("X Kazandı");
                    oyunbitti = 1;
                }
                else if (oyunalani[0, 2] == 1 && oyunalani[1, 2] == 1 && oyunalani[2, 2] == 1)
                {
                    Console.WriteLine("X Kazandı");
                    oyunbitti = 1;
                }
                //---------------------------------------------------------------------------------------
                else if (oyunalani[0, 0] == 1 && oyunalani[1, 1] == 1 && oyunalani[2, 2] == 1)
                {
                    Console.WriteLine("X Kazandı");
                    oyunbitti = 1;
                }
                else if (oyunalani[0, 2] == 1 && oyunalani[1, 1] == 1 && oyunalani[2, 0] == 1)
                {
                    Console.WriteLine("X Kazandı");
                    oyunbitti = 1;
                }
                // X bitti


                //O İÇİN
                if (oyunalani[0, 0] == 2 && oyunalani[0, 1] == 2 && oyunalani[0, 2] == 2)
                {
                    Console.WriteLine("O Kazandı");
                    oyunbitti = 1;
                }
                else if (oyunalani[1, 0] == 2 && oyunalani[1, 1] == 2 && oyunalani[1, 2] == 2)
                {
                    Console.WriteLine("O Kazandı");
                    oyunbitti = 1;
                }
                else if (oyunalani[2, 0] == 2 && oyunalani[2, 1] == 2 && oyunalani[2, 2] == 2)
                {
                    Console.WriteLine("O Kazandı");
                    oyunbitti = 1;
                }
                //----------------------------------------------------------------------------------------
                else if (oyunalani[0, 0] == 2 && oyunalani[1, 0] == 2 && oyunalani[2, 0] == 2)
                {
                    Console.WriteLine("O Kazandı");
                    oyunbitti = 1;
                }
                else if (oyunalani[0, 1] == 2 && oyunalani[1, 1] == 2 && oyunalani[2, 1] == 2)
                {
                    Console.WriteLine("O Kazandı");
                    oyunbitti = 1;
                }
                else if (oyunalani[0, 2] == 2 && oyunalani[1, 2] == 2 && oyunalani[2, 2] == 2)
                {
                    Console.WriteLine("O Kazandı");
                    oyunbitti = 1;
                }
                //---------------------------------------------------------------------------------------
                else if (oyunalani[0, 0] == 2 && oyunalani[1, 1] == 2 && oyunalani[2, 2] == 2)
                {
                    Console.WriteLine("O Kazandı");
                    oyunbitti = 1;
                }
                else if (oyunalani[0, 2] == 2 && oyunalani[1, 1] == 2 && oyunalani[2, 0] == 2)
                {
                    Console.WriteLine("O Kazandı");
                    oyunbitti = 1;
                }
                // O bitti

                //Hepsi dolu

                if (oyunalani[0, 0] != 0 && oyunalani[0, 1] != 0 && oyunalani[0, 2] != 0 && oyunalani[1, 0] != 0 && oyunalani[1, 1] != 0 && oyunalani[1, 2] != 0 && oyunalani[2, 0] != 0 && oyunalani[2, 1] != 0 && oyunalani[2, 2] != 0)
                {
                    Console.WriteLine("Tüm Alanlar Doldu");
                    oyunbitti = 1;
                }
            }
            Console.ReadLine();
        }
    }
}
