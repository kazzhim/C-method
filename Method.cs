int patron = 30;

while (true)
{
    Header();

    Console.Write("Reqem yazin :");

    int number = Convert.ToInt32(Console.ReadLine());

    switch (number)
    {
        case 1:
            patron--;
            break;

        case 2:
            patron = Two();
            break;

        case 3:
            patron = Three();
            break;

        case 4:
            Console.WriteLine("Oyundan cixilir...");
            break;

        case 5:

            if (patron >=0)
            {
               Console.WriteLine("*********************");
               Console.WriteLine("Mermi sayi: " + patron);
               Console.WriteLine("*********************"); 
            }
            else
            {
               Console.WriteLine("Patron yeteri qeder deyil");
            }
            

            break;

        default:
            Console.WriteLine("Xahis olunur duzgun reqem girin");
            break;
    }
    if (number == 4) break;
}

void Header()
{
    Console.WriteLine("1) Gulleni tek-tek at");
    Console.WriteLine("2) Gullenin hamısını at");
    Console.WriteLine("3) Mermini yeniden doldur");
    Console.WriteLine("4) Oyundan çıx");
    Console.WriteLine("5) Mermi sayını goster");
    Console.WriteLine("******************");
}
int Two() => 0;
int Three() => 30;

