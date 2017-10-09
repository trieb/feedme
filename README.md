# Dating app - <Namn>

## Idé 

Appen sätter upp en första dejt genom att matcha personer som vill gå på en speciell restaunga eller äta en vill typ av mat. 
I appen kan man se vilja förslag som lagts ut och när man hitta något som lockar kan man titta på personerns profil innan man visar sitt intresse. 
Personen som lagt ut förslaget får notifiering om att det finns någon som är intresserad. Om det finns flera som är intresserade får hon/han välja någon varvid en matchning skapas. 

## Funktioner

* Skapa konto/registrera sin profil
  * email, name, ålder, bild/bilder 
  * matpreferenser 
* Inloggning
* Sätta upp ett "dejtförslag" (restaurang, tid, plats)
* Rating
  * Restaurangen 
  * Date
* Statistik
  * Rating
  * Antal besök
* Topplista
  * Baserat på statestiken 
* Restauranger ska kunna registrera sig. 
* Sätta upp dubbeldejt
* Sök dejt (typ av mat, plats, avstånd, ålder, kön) 
* Visa förslag
  * Hur? Kort, lista, karta.. ? 
* Skapa matchningar
* Chatta 
* Pushnotifiering
* Föreslå dejter baserat på vad man har för inställningar


## Monetization

* Riktad reklam mot kunden för en viss restaurang. 
Restaurangen får betala för att visa sin meny eller specialerbjudande för kunderna direkt i appen. 
  ** Budgivning/auktion på att hamna högt upp i listan. 
* Betala notan direkt i appen (splitta/eller bestämma vem som ska betala) 
* Premiumtjänster
  * Ingen begränsning på dejtingfrekvens
  * 
* Restaurangen får betala en liten summa för varje genererat besök. Vi får en liten del av totala summan. 
* Restaurangen får betala för att visa sin meny i appen. 



## Systemdesign

### Klasser

#### User

Användardatabas för inloggning

* user_id
* email 
* password
* phone number

#### Profile : User

Användarprofil

* profile_id
* fk_user_id 
* name
* age
* image/images
* bio

#### RestaurangOwner : User

* restaurant_owner_id
* org_number
* restaurant_id_fk

#### DejtProposal

* date_id
* fk_profile_id (har skapat försaget)
* restaurant
* intresents (en lista av de som är intresserade)

#### Match 

* match_id
* date_creater (profile_id_fk)
* date_accepter (profile_id_fk)
*  

#### Chat

* chat_id
* timestamp
* match_id_fk
* profile_id
* message

#### Restaurant

* restaurant_id
* name
* location
* menu




