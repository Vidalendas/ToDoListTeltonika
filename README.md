# ToDoListTeltonika

connection string saugomas appsettings.json faile

Nepavyko padaryt, kad kiekvieną kartą pasileidžiant programai būtu sukuriami/perkuriami aplikacijos duomenys, tačiau yra parengtos migracijos: InitialMigration duomenų bazės ir lentelų sukūrimui
bei DataMigration pirminiams duomenis sukurti.

Autentifikacija vykdoma per /api/Name/authenticate, Nors JWT WEB TOKEN'as yra gaunamas, tačiau jį naudojant kituose API yra gaunama klaida, todėl ant API nėra uždėta būtina autentifikacija, kad būtu galima testuoti API veikimą.
Autentifikuojant nėra nustatoma vartotojų grupė(role1 ar role2).

Nepavyko įgyventinti šešto funkcinio reikalavimo punkto: Realizuoti vartotojo slaptažodžio keitimo funkcionalumą, kuris vartotojui (role2) išsiųstų elektroninį laišką
su nuoroda (API endpoint, į kurį reikia perduoti naują vartotojo slaptažodį), su kuria vartotojas galėtu
pasikeisti savo prisijungimo slaptažodį.
