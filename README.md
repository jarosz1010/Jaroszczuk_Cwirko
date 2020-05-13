# Jaroszczuk_Cwirko

WebApplication7

Uzyte technologie: EntityFramework, oraz Web Application ASP.NET Core

Uzyte Biblioteki: 
 - Microsoft.AspNetCore.App
 - Microsoft.AspNetCore.Razor.Design
 - Microsoft.Extensions.Logging.Log4Net.AspNetCore
 - Microsoft.VisualStudio.Web.CodeGeneration.Design
 - bootstrap
 - jquery
 - googleapi
 - log4net
 - coverlet.collector
 - Microsoft.AspNetCore.TestHost
 - Microsoft.EntityFrameworkCore
 - Microsoft.EntityFrameworkCore.InMemory
 - Microsoft.Extensions.DependencyInjection
 - Microsoft.NET.Test.Sdk
 - Moq
 - xunit
 - xunit.runner.visualstudio


Wtym zadaniu projektowym realizowany bedzie model bazy danych internetowego systemu sprzedazy
biletów kolejowych.

Opis zasobów ludzkich:
 - Administrator systemu
 - Dyrektor centrum sprzedazy
 - Kierownik zmiany
 - Kasjerzy

Scenariusze Administratora:
 - Dodaj pracownika
 - Usun pracownika
 - Skasuj najstarsze informacje
 - Dodaj pociag
 - Usun pociag
 - Zmiana godzin odjazdów

Scenariusze Dyrektora
 - Zmien wynagrodzenie
 - Przyznaj premie

Scenariusze Kierownika zmiany
 - Anuluj bilet
 - Zmien termin przejazdu

Scenariusze kasjera
 - Sprawdz dostepnosc
 - Kup bilet

Analiza uzycia identyfikujaca podstawowe rodzaje transakcji
1. Wstawianie
Jest to podstawowa funkcjonalnosc przedstawionej bazy danych. Kazdy zakup biletu bedzie wiazał
sie z wstawieniem nowego klienta, czyli nowego rekordu w bazie. Do wstawiania uprawnienia posiadac
beda kasjer, kierownik zmiany oraz dyrektor.
2. Usuwanie
Usunac dana transakcje moze kierownik zmiany podczas anulacji biletu. Posiada on wtedy uprawnienia
do usuniecia tylko jednego rekordu. Usuwanie okresowe przeprowadzane bedzie przez Administratora
bazy danych. Nie przewiduje sie automatycznego usuwania danych z bazy.
3. Modyfikacja
Do modyfikacji uprawniony sa jedynie kierownik zmiany oraz dyrektor. Moga oni zmieniac terminy
wyjazdów lub pociagi.
4. Wyszukiwanie
Wyszukiwanie bedzie polegało na znalezieniu pociagu, który przejezdza przez miejscowosci w danym
dniu. Zwróci ono godziny odjazdów oraz ilosc wolnych miejsc. Kierownik zmiany bedzie mógł równiez
wyszukac klienta po jego nazwisku w celu anulowania rezerwacji lub jej zmiany.


Opis encji
1. Pociagi
Tabela słuzy do przechowywania informacji na temat pociagów i dat ich wyjazdu. Pola znajdujace
sie w tabeli informuja o nazwie pociagu, numerze identyfikacyjnym pociagu i dacie wyjazdu. Pociagi w
tabeli sa powiazane z tabela Stacje.
2. Stacje
Tabela istnieje dla kazdego z pociagów. Informuje ona o stacjach przez które przejezdza pociag,
o godzinach odjazdu z poszczególnych stacji oraz o tym ile jest dostepnych miejsc pomiedzy danymi
stacjami.
3. Klienci
Tabela zawiera dane klientów, takie jak Imie, Nazwisko czy Data urodzenia. Moze tez zawierac dodatkowe
informacje, które klienci podali dobrowolnie, czyli adres i telefon kontaktowy. W tabeli znajduje
sie tez kolumna informujaca na jaki pociag klient kupił bilet.
4. Pracownicy
Tabela zawiera informacje o pracownikach. Kazdy z nich posiada unikalny numer id, którym jest
numer PESEL. W tabeli znajduja sie kolumny informujace o dacie zatrudnienia, stanowisku, pensji i
ilosci sprzedanych biletów.
