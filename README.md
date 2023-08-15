# Bank_Muhamed_Kaltak
Det här projektet är en applikation som erbjuder olika funktioner för användarhantering och transaktionshantering. Användarna kan registrera konton, logga in och utföra olika åtgärder relaterade till hantering av användarkonton och plånbokstransaktioner. Applikationen utvecklades med hjälp av Windows Forms och använder en databas för att lagra relaterade data, som hanteras med hjälp av Entity Framework. Projektet följer också en 3-lagers arkitektur för att organisera och strukturera kodbasen på ett effektivt sätt.

Här är en översikt över de funktioner som ingår i projektet:

* Registrering och Inloggning: Användare kan registrera sig genom att skapa ett konto med unika användarnamn och lösenord. De kan också logga in på sina konton med sina inloggningsuppgifter. Lösenorden är hashade och använder sig av unika salt för att säkerställa att användar kontonen är säkra.

* Återställning av Användarnamn och Lösenord: Om en användare har glömt sitt användarnamn eller lösenord, kan de begära att få sitt användarnamn skickat till sin anslutna e-postadress. För lösenordsåterställning får de en e-post med en kod. Genom att ange koden kan de återställa sitt lösenord så länge som token för återställningen inte har gått ut.

* Hantering av Plånbokskonton: Användare kan hantera flera olika plånbokskonton. De kan ändra namnet på plånbokskonton, lägga till nya konton och ta bort befintliga konton.

* Spara Plånbokskonton: Användare kan spara plånbokskonton från andra användare genom att hänvisa till den anslutna användarens e-postadress och kontokod.

* Transaktioner: Användare kan genomföra transaktioner mellan sina egna konton eller andra sparade konton. De kan se en översikt över transaktionshistoriken och filtrera den efter skickade eller mottagna transaktioner.

* Transaktionsdetaljer: För varje transaktion kan användare se detaljer som visar vilken användare som har skickat transaktionen och de anslutna kontona för både avsändaren och mottagaren.

* Kontodetaljer: Användare kan se detaljer om sina konton, inklusive en översikt över alla transaktioner som är relaterade till varje konto.

* Användarhantering: Användare har möjlighet att ändra sina användarnamn och lösenord samt att ta bort sitt konto efter att de har loggat in.

Arkitekturen som användes är 3-lagers arkitektur, vilket innebär att koden är uppdelad i tre separata lager: Presentation, Affärslager och Dataåtkomstlager. Denna arkitektur har flera fördelar, inklusive:

* Separation av Ansvar: Varje lager har en specifik uppgift och ansvar, vilket gör koden mer organiserad och underhållbar.

* Återanvändbarhet: Logik och dataåtkomst kan återanvändas på olika ställen inom applikationen och även i framtida projekt.

* Underlättad Utveckling: Utvecklingsteam kan arbeta parallellt på olika lager utan att påverka varandra negativt.

* Skalbarhet: Arkitekturen gör det enklare att skalera och anpassa applikationen när nya funktioner eller ändringar behövs.

Tabeller i Databasen:

* User (Användare): Lagrar data relaterad till användare, inklusive id, användarnamn, lösenord, salt, e-post, namn, efternamn, återställningstoken för lösenord, och datum för återställning av lösenord.

* Account (Konto): Representerar plånbokskonton kopplade till specifika användare. Data för kontot inkluderar id, användar-id, kontonamn, saldo, kontokod, och om kontot har raderats. Det finns en "one-to-many" relation mellan User och Account, där varje användare kan ha flera konton.

* Transaction (Transaktion): Lagrar relevant data för alla transaktioner som utförs i systemet, inklusive id, namn, belopp och transaktionsdatum.

* AccountTransaction (KontoTransaktion): Kopplar samman Account och Transaction genom en "many-to-many" relation. Denna tabell innehåller accountID, transactionID och en payload-värde av TransactionType, som används för att särskilja mellan avsändare och mottagare i transaktioner.

* OtherUserAccount (AndraAnvändarKonto): Kopplar samman User med Account i en "many-to-many" relation. Den används för att spara data när en användare sparar ett konto från en annan användare. Data inkluderar användar-id och konto-id.

Projektet har designats med säkerhet och databashantering i åtanke, och följer en strukturerad arkitektur för att säkerställa en robust och underhållbar applikation.
