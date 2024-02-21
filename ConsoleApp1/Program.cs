// See https://aka.ms/new-console-template for more information


using System.Data;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("""
    *****************************************************************
    *****************************************************************
    ****                                                         ****
    ****    T.C. KİMLİK NO HESAPLAMA VE DOĞRULAMA PROGRAMI       ****
    ****                                              v1.0       ****
    *****************************************************************
    *****************************************************************
    """);

        static void islem()
        {

            Console.Write("""
Yapmak istediğiniz işlemi seçiniz.

1) Doğrulama
2) İlk 9 Haneyi Girerek Tamamını Bulma
3) Çıkış..

Tuşlayınız: 
""");


            char userChoice = Console.ReadKey().KeyChar;

            if (userChoice == '1')
            {
                Console.WriteLine("");
                Console.Write("TC Kimlik Numarasını Giriniz: ");
                string userTCtoConfirm = Console.ReadLine();
                if (userTCtoConfirm.Length != 11)
                {
                    Console.WriteLine("TCKN on bir (11) haneli olmalıdır");
                    islem();
                }
                else if (userTCtoConfirm[0] == 0)
                {
                    Console.WriteLine("TCKN sıfır (0) ile başlayamaz!");
                }
                else if (userTCtoConfirm.All(char.IsDigit) == false)
                {
                    Console.WriteLine("TCKN yalnızca rakamlardan oluşmalıdır!");
                }
                else
                {
                    int ilk9Toplam1 = 0,
                        ilk9Toplam2 = 0,
                        ilk10Toplam = 0,
                        karakter10,
                        karakter11;

                    for (int i = 0; i < 9; i += 2)
                    {
                        ilk9Toplam1 += Convert.ToInt32(userTCtoConfirm[i].ToString());
                    }

                    for (int i = 1; i < 9; i += 2)
                    {
                        ilk9Toplam2 += Convert.ToInt32(userTCtoConfirm[i].ToString());
                    }


                    for (int i = 0; i < 10; i++)
                    {
                        ilk10Toplam += Convert.ToInt32(userTCtoConfirm[i].ToString());
                    }

                    karakter10 = (ilk9Toplam1 * 7 - ilk9Toplam2) % 10;
                    karakter11 = ilk10Toplam % 10;

                    if (karakter10 == Convert.ToInt32(userTCtoConfirm[9].ToString()) && karakter11 == Convert.ToInt32(userTCtoConfirm[10].ToString()))
                    {
                        Console.WriteLine("*** Girdiğiniz T.C. Kimlik Numarası başarıyla doğrulanmıştır.***\n");
                        islem();

                    }
                    else
                    {
                        Console.WriteLine("*** Girdiğiniz T.C. Kimlik Numarası hatalıdır!! ***\n");
                        islem();

                    }


                }

            }

            else if (userChoice == '2')
            {
                Console.WriteLine("");
                Console.Write("TC Kimlik Numarasını Giriniz: ");
                string userTCtoConfirm = Console.ReadLine();
                if (userTCtoConfirm.Length != 9)
                {
                    Console.WriteLine("İlk 9 haneyi girmeniz gerekmektedir!/n");
                    islem();
                }
                else if (userTCtoConfirm[0] == 0)
                {
                    Console.WriteLine("TCKN sıfır (0) ile başlayamaz!");
                }
                else if (userTCtoConfirm.All(char.IsDigit) == false)
                {
                    Console.WriteLine("TCKN yalnızca rakamlardan oluşmalıdır!");
                }
                else
                {
                    int ilk9Toplam1 = 0,
                        ilk9Toplam2 = 0,
                        ilk10Toplam = 0,
                        karakter10,
                        karakter11;
                    string ilk10hane;

                    for (int i = 0; i < 9; i += 2)
                    {
                        ilk9Toplam1 += Convert.ToInt32(userTCtoConfirm[i].ToString());
                    }

                    for (int i = 1; i < 9; i += 2)
                    {
                        ilk9Toplam2 += Convert.ToInt32(userTCtoConfirm[i].ToString());
                    }

                    karakter10 = (ilk9Toplam1 * 7 - ilk9Toplam2) % 10;

                    ilk10hane = userTCtoConfirm + karakter10.ToString();

                    for (int i = 0; i < 10; i++)
                    {
                        ilk10Toplam += Convert.ToInt32(ilk10hane[i].ToString());
                    }

                    karakter11 = ilk10Toplam % 10;

                    Console.WriteLine("Girdiğiniz TC Kimlik Numarasının tamamı: " + userTCtoConfirm + karakter10.ToString() + karakter11.ToString() + "\n");
                    islem();
                }

                Environment.Exit(0);

            }
            else if (userChoice == '3')
            {
                Environment.Exit(0);
            }
            else
            {
                Environment.Exit(0);
            }

        }

        islem();
    }
}