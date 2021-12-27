# InvoiceProject
Shosps

Proje ASP.Net Core Web API ile Oluşturulmuştur.Test projesi de xUnit Test ile oluşturulmuştur. 

--> Controller
*InvoiceController:Apinin çalışmasını kontrol eden controller bulunur.
InvoiceController : "DataRepository" classımız ile data yüklenmesini
sağlıyoruz.
GetInvoiceID: fatura id si ile fatura bilgileri  "Price" class ımızda 
kontrolleri yapılır ve indirim oranı belirlenir.

--> Bussines
DataRepository:Data yüklenmesi yapılır
Price: Fatura bilgisinden dönen fatura bilgisine göre yapılacak indirim şekli belirlenir.
PriceAccountDetail: "price" class inda indirim türü belirlendikten sonra yapılacak indirim işlemleri bu
class ımızda hesaplanır,dönen tutar indirim uygulanan fatura tutarıdır.

--> Models
Affiliate: Mağazaya Bağlı kurumların bulunduğu modeldir.
Customer:Mağaza Müşterilerinin bulunduğu modeldir.
Employee:Mağaza Personel bilgilerinin bulunduğu modeldir.
Invoice:Fatura Bilgilerinin bulunduğu modeldir

--> class Affiliate(Bağlı kurumlar)
AffiliateId 	: Bağlı Kurum Id
Name 		: Kurum Adı
InsertDate 	: Kayıt tarihi
IsActive 	:Aktif mi

--> class Customer (Müşleriler)
CustomerId 	:Müşteri Id
Name 		:Müşteri Adı
Surname 	:Müşteri Soyadı
InsertDate 	:Kayıt tarihi
IsActive 	:Aktif mi

--> class Employee (Personeller)
EmployeeId 	:Personel Id
Name 		:Personel Adı
Surname 	:Personel Soyadı
InsertDate 	:Kayıt tarihi
IsActive 	:Aktif mi

--> class Invoice (Faturalar)
InvoiceId : Fatura Id
EmployeeId : Personel ID
AffiliateId : Bağlı Kurum Id
CustomerID : Müşteri ID
ShopStatus : Satış Durumu
price : Satış Tutarı
InsertDate : Kayıt tarihi
IsActive : Aktif mi

--> ShopsRUs.API.Tests
Test projesidir.xUnit test projemizde
InvoiceTests class altında 
EmployeeTest 	: Durum personel indirimi ise 
AffiliateTest 	: Durum Bağlı kurum indirimi ise
CustomerTest 	:Durum müşteri iki yıldan eski müşteri ise	
FivePercentTest : Durum her 100 tl ye 5 tl indirim sağlanacak ise
uygulanan indirimleri kapsamaktadır .
