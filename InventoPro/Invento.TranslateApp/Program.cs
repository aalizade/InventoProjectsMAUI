// See https://aka.ms/new-console-template for more information

string tercumeEdilecekDosyasi = @"C:\\Users\\agha_\\Desktop\\Invento\\InventoProjectsMAUI\\InventoPro\\core.json";
Console.WriteLine("Hello, World!");

TercumeyiBaslat();

void TercumeyiBaslat()
{
    Console.WriteLine("Merhaba");
}

/*
 * Her reguestten sonra 2 saniye beklenecek. Tercüme edemediği kısımlarda boş geçececek. Sonuçları json olarak dosyaya yazacak.
 https://web-api.itranslateapp.com/v3/texts/translate
{"source": {"dialect": "tr", "text": "Ben öğrenciyim", "with": ["synonyms"]}, "target": {"dialect": "en-UK"}}

 */
Console.ReadLine();

