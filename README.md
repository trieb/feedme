# Dating app - <Namn>

## Idé 

Appen sätter upp en första dejt genom att matcha personer som vill gå på en speciell restaurang eller äta en viss typ av mat. 
I appen kan man se vilka förslag som lagts ut och när man hittar något som lockar kan man titta på personernas profil innan man visar sitt intresse. 
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
  * Baserat på statistiken 
* Restauranger ska kunna registrera sig. 
* Sätta upp dubbeldejt
* Söka dejt (typ av mat, plats, avstånd, ålder, kön) 
* Visa förslag
  * Hur? Kort, lista, karta.. ? 
* Skapa matchningar
* Chatta 
* Pushnotifieringar
* Föreslå dejter baserat på vad man har för inställningar


## Monetization - Intäkter

* Riktad reklam mot kunden för en viss restaurang. 
Restaurangen får betala för att visa sin meny eller specialerbjudande för kunderna direkt i appen. 
  ** Budgivning/auktion för att hamna högt upp i listan. 
* Betala notan direkt i appen (splitta/eller bestämma vem som ska betala) 
* Premiumtjänster
  * Ingen begränsning på dejtingfrekvens
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
* fk_profile_id (har skapat förslaget)
* restaurant
* interested (en lista av de som är intresserade)
* tags
* showInterest(profile_id_fk)

#### Tag

* id 
* tag: meat/fish/vegetarian/vegan/raw/fancy/budget/ 


#### Match 

* match_id
* date_creater (profile_id_fk)
* date_accepter (profile_id_fk)

  

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
* tags


## Tidsuppskattning 

* Basstruktur (1h) 
* Test  (2h) 
* Databaskoppling (1h)
* Säkerhet (1h)
* Design av UI (2h)

