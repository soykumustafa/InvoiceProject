
--> Controller
*InvoiceController:Apinin �al��mas�n� kontrol eden controller bulunur.
InvoiceController : "DataRepository" class�m�z ile data y�klenmesini
sa�l�yoruz.
GetInvoiceID: fatura id si ile fatura bilgileri  "Price" class �m�zda 
kontrolleri yap�l�r ve indirim oran� belirlenir.

--> Bussines
DataRepository:Data y�klenmesi yap�l�r
Price: Fatura bilgisinden d�nen fatura bilgisine g�re yap�lacak indirim �ekli belirlenir.
PriceAccountDetail: "price" class inda indirim t�r� belirlendikten sonra yap�lacak indirim i�lemleri bu
class �m�zda hesaplan�r,d�nen tutar indirim uygulanan fatura tutar�d�r.

--> Models
Affiliate: Ma�azaya Ba�l� kurumlar�n bulundu�u modeldir.
Customer:Ma�aza M��terilerinin bulundu�u modeldir.
Employee:Ma�aza Personel bilgilerinin bulundu�u modeldir.
Invoice:Fatura Bilgilerinin bulundu�u modeldir

--> class Affiliate(Ba�l� kurumlar)
AffiliateId 	: Ba�l� Kurum Id
Name 		: Kurum Ad�
InsertDate 	: Kay�t tarihi
IsActive 	:Aktif mi

--> class Customer (M��leriler)
CustomerId 	:M��teri Id
Name 		:M��teri Ad�
Surname 	:M��teri Soyad�
InsertDate 	:Kay�t tarihi
IsActive 	:Aktif mi

--> class Employee (Personeller)
EmployeeId 	:Personel Id
Name 		:Personel Ad�
Surname 	:Personel Soyad�
InsertDate 	:Kay�t tarihi
IsActive 	:Aktif mi

--> class Invoice (Faturalar)
InvoiceId : Fatura Id
EmployeeId : Personel ID
AffiliateId : Ba�l� Kurum Id
CustomerID : M��teri ID
ShopStatus : Sat�� Durumu
price : Sat�� Tutar�
InsertDate : Kay�t tarihi
IsActive : Aktif mi

--> ShopsRUs.API.Tests
Test projesidir.xUnit test projemizde
InvoiceTests class alt�nda 
EmployeeTest 	: Durum personel indirimi ise 
AffiliateTest 	: Durum Ba�l� kurum indirimi ise
CustomerTest 	:Durum m��teri iki y�ldan eski m��teri ise	
FivePercentTest : Durum her 100 tl ye 5 tl indirim sa�lanacak ise
uygulanan indirimleri kapsamaktad�r .