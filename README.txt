
--> Controller
*InvoiceController:Apinin çalýþmasýný kontrol eden controller bulunur.
InvoiceController : "DataRepository" classýmýz ile data yüklenmesini
saðlýyoruz.
GetInvoiceID: fatura id si ile fatura bilgileri  "Price" class ýmýzda 
kontrolleri yapýlýr ve indirim oraný belirlenir.

--> Bussines
DataRepository:Data yüklenmesi yapýlýr
Price: Fatura bilgisinden dönen fatura bilgisine göre yapýlacak indirim þekli belirlenir.
PriceAccountDetail: "price" class inda indirim türü belirlendikten sonra yapýlacak indirim iþlemleri bu
class ýmýzda hesaplanýr,dönen tutar indirim uygulanan fatura tutarýdýr.

--> Models
Affiliate: Maðazaya Baðlý kurumlarýn bulunduðu modeldir.
Customer:Maðaza Müþterilerinin bulunduðu modeldir.
Employee:Maðaza Personel bilgilerinin bulunduðu modeldir.
Invoice:Fatura Bilgilerinin bulunduðu modeldir

--> class Affiliate(Baðlý kurumlar)
AffiliateId 	: Baðlý Kurum Id
Name 		: Kurum Adý
InsertDate 	: Kayýt tarihi
IsActive 	:Aktif mi

--> class Customer (Müþleriler)
CustomerId 	:Müþteri Id
Name 		:Müþteri Adý
Surname 	:Müþteri Soyadý
InsertDate 	:Kayýt tarihi
IsActive 	:Aktif mi

--> class Employee (Personeller)
EmployeeId 	:Personel Id
Name 		:Personel Adý
Surname 	:Personel Soyadý
InsertDate 	:Kayýt tarihi
IsActive 	:Aktif mi

--> class Invoice (Faturalar)
InvoiceId : Fatura Id
EmployeeId : Personel ID
AffiliateId : Baðlý Kurum Id
CustomerID : Müþteri ID
ShopStatus : Satýþ Durumu
price : Satýþ Tutarý
InsertDate : Kayýt tarihi
IsActive : Aktif mi

--> ShopsRUs.API.Tests
Test projesidir.xUnit test projemizde
InvoiceTests class altýnda 
EmployeeTest 	: Durum personel indirimi ise 
AffiliateTest 	: Durum Baðlý kurum indirimi ise
CustomerTest 	:Durum müþteri iki yýldan eski müþteri ise	
FivePercentTest : Durum her 100 tl ye 5 tl indirim saðlanacak ise
uygulanan indirimleri kapsamaktadýr .