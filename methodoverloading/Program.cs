using System;
using System.Runtime.InteropServices;

namespace methodoverloading{


class methodOverloading{


static void Main(String[] args){

// out parametreler

string sayi = "999";


bool sonuc = int.TryParse(sayi,out int outSayi);

if(sonuc){

Console.WriteLine("basarılı");
Console.WriteLine(outSayi);
}

else{

Console.WriteLine("basarısız");

}



Methodlar ornek = new Methodlar();

Methodlar.toplam(5,6,out int toplamSonucu);

Console.WriteLine(toplamSonucu);



/*

return ifadelerin yaptığı işlemleri
out parametreler kullanarak da bu 
şekilde yapabiliriz

*/


//method overloading

int ifade = 9;

Methodlar.ekranaYaz(ifade);


//Method imzası

//metot adı + parametre sayısı + parametre tipi 'nden oluşur

/* 

bunların 3 ü aynı olduğu zaman hata alırız ve bu
durumda method overloading e girmez
erişim belirteci method imzasına dahil değildir

*/

Methodlar.ekranaYaz("özge "," siyavus");







}
}

}


class Methodlar{

public static void toplam(int a,int b,out int toplam){

toplam = a+b;
}


public static void ekranaYaz(string veri){

Console.WriteLine(veri);

}


public static void ekranaYaz(int veri){

Console.WriteLine(veri);

}


public static void ekranaYaz(string veri1,string veri2){

Console.WriteLine(veri1+veri2);

}

}




//Method overloading - Method aşırı yükleme


/*
biz bir fonksiyonun imzasını değiştirerek birden fazla
şekilde o fonksiyonu kullanabiliriz


*/