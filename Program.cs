using System;
using System.Collections.Generic;
using System.Linq;

#if NET5_0 || NET6_0 || NET7_0
    Console.WriteLine("C# 9.0 veya üstü sürüm kullanılıyor.");
#else
Console.WriteLine("C# 8.0 veya altı sürüm kullanılıyor.");
#endif


Console.WriteLine("Linq Konu Anlatım");

List<int> numbers = new List<int>{1,2,3,4,5,6,7,8,9,10};

/*
 * string.Join kullanmamızın sebebi aralara ayırıcı koyup diziyi ayırıp tek string olarak yazdırır
 * sadece listenin ismini yazarsak listenin bellek adresini yazar.
 * string.Join(", ", ListeIsmi) bu şekil writeline parantezine ekleriz
 */

var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
//Listeyi filtrelemek için Where operatörü kullanılır.
//Mesela örnekteki gibi çift sayıları filtereler.
Console.WriteLine("evenNumbers: " + string.Join(",", evenNumbers));


var sortedEvenNumbers = numbers
    .Where(n => n % 2 == 0)
    .OrderByDescending(n => n);
//Hepsini yanyana da dizebilirsiniz fakat uzun ve karmaşık olduğundan böyle altalta yazdım siz de öyle yazabilirsiniz.
Console.WriteLine("sortedEvenNumbers: " + string.Join(",", sortedEvenNumbers));
//Sıralamayı değiştirmek için OrderByDescending kullanılır.
//Örnekte büyükten küçüğe olarak değiştirilmiştir.


List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David" };
//Select ile öğeyi yeni bir forma dönüştürebiliriz.
//Burdaki durumda isimlerin uzunluklarını alıp integer değer olarak yeni bir listeye yazılır.
var nameLenght = names.Select(name => name.Length).ToList();
Console.WriteLine("nameLenght: " + string.Join(",", nameLenght));


var filteredAndUppercaseNames = names
    .Where(name => name.Length > 4)
    .Select(name => name.ToUpper());
//Burda hem Where ve Select Operatörü kullanıp işlem yapıyoruz
//Where ile uzunluğu 4'ten büyük olanları filtreleyip diğer komuta yolluyor.
//Select ile harfleri büyük olarak döndürür ve gönderir.
Console.WriteLine("filteredAndUppercaseNames: " + string.Join(",", filteredAndUppercaseNames));


List<int> numbers2 = new List<int>{15, 2, 3, 6, 8, 12, 7, 9};
//Any operatörü kontrol için kullanılır.
//burdaki listede 10'dan yüksek sayı varsa true çevircektir.
bool anyGreaterThanTen = numbers2.Any(n => n > 10);

Console.WriteLine("anyGreaterThanTen: " + string.Join(",", anyGreaterThanTen));
//All operatörünü ise bütün listede geçerli olan şeyler için kullanırız.
//Örnek listedekilerin hepsi 0'dan büyükse True döndür.
bool allGreaterThanZero = numbers2.All(n => n > 0);
Console.WriteLine("allGreaterThanZero" + string.Join(",", allGreaterThanZero));


List<string> fruits = new List<string> { "Apple", "Orange", "Banana", "Pineapple", "Strawberry" , "Apricot"};
string firstStartingWithA = fruits.First(f => f.StartsWith("A"));
//First operatörünü StartsWith metodu ile ilk harfi kontrol eder
//StartsWith bir metot Firs ise bir operatördür
Console.WriteLine("FirstStartingWithA" + string.Join(",", firstStartingWithA));

string firstStartingWithG = fruits.FirstOrDefault(f => f.StartsWith("G"));
//FirstOrDefault'ta ise varsa elemanı alır yoksa null döner
Console.WriteLine("FirstStartingWithG" + string.Join(",", firstStartingWithG));


List<int> numbers3 = new List<int>{10, 7, 15, 9, 4, 14 ,5};
int countGreaterThanNine = numbers3.Count(n => n > 10);
//Count operatörü verilen koşulu sağlayanları sayar ve çıktı verir.

Console.WriteLine("countGreaterThanNine" + string.Join(",", countGreaterThanNine));


List<int> numbers4 = new List<int>{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23};
IEnumerable<int> SkipAndTakeNumbers = numbers4.Skip(3).Take(7);
//Skip ve Take operatörleri 
//Skip sıradaki integer'i atlamayı sağlar Take iste atladıktan sonraki X tanesini seçer ve çıktı olarak verir.
Console.WriteLine("SkipAndTakeNumbers" + string.Join(",", SkipAndTakeNumbers));


List<int> numbersMinMax = new List<int> { 3, 1, 4, 2, 5 };
int min = numbersMinMax.Min();
//Liste'nin minimum değerini yazdırır.
//Burda WriteLine'da direkt olarak min max vs. çalışmaktadır
Console.WriteLine("min: " + min);

int max = numbersMinMax.Max();
//Liste'nin maksimum değerini yazdırır.
Console.WriteLine("max: " + max);

List<int> numbersAverage = new List<int>{1,2,3,4,5,6,7,8,9,10};
// Average operatörü ortalama alırken kullanırız.
//İnteger değil double kullanırız çünkü küsüratlı çıkma ihtimali vardır.
double average = numbersAverage.Average();
Console.WriteLine("average: " + average);


/*
Kaynak ---> https://medium.com/@i.bzdgn/what-is-linq-and-what-are-the-most-used-linq-operators-4ed4beebd494
*/