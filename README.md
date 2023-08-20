# Bank_Muhamed_Kaltak - SV
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

# Bank_Muhamed_Kaltak - ENG

This project is an application that offers various functionalities for user management and transaction handling. Users can register accounts, log in, and perform various actions related to user account management and wallet transactions. The application was developed using Windows Forms and utilizes a database to store related data, managed with the help of Entity Framework. The project also follows a 3-tier architecture to efficiently organize and structure the codebase.

Here is an overview of the features included in the project:

* Registration and Login: Users can register by creating an account with unique usernames and passwords. They can also log in to their accounts using their credentials. Passwords are hashed and utilize unique salts to ensure the security of user accounts.

* Username and Password Recovery: If a user forgets their username or password, they can request their username to be sent to their associated email address. For password recovery, they receive an email with a code. By entering the code, they can reset their password as long as the reset token has not expired.

* Wallet Account Management: Users can manage multiple wallet accounts. They can change the names of wallet accounts, add new accounts, and remove existing ones.

* Saving Wallet Accounts: Users can save wallet accounts from other users by referencing the connected user's email address and account code.

* Transactions: Users can perform transactions between their own accounts or other saved accounts. They can view an overview of transaction history and filter it by sent or received transactions.

* Transaction Details: For each transaction, users can view details showing which user sent the transaction and the connected accounts for both the sender and recipient.

* Account Details: Users can view details about their accounts, including an overview of all transactions related to each account.

* User Management: Users have the ability to change their usernames and passwords, as well as delete their account after logging in.

The architecture used is a 3-tier architecture, where the code is divided into three separate layers: Presentation, Business Layer, and Data Access Layer. This architecture offers several advantages, including:

* Separation of Concerns: Each layer has a specific task and responsibility, making the code more organized and maintainable.

* Reusability: Logic and data access can be reused in different parts of the application and even in future projects.

* Facilitated Development: Development teams can work in parallel on different layers without negatively impacting each other.

* Scalability: The architecture makes it easier to scale and adapt the application when new features or changes are needed.

Database Tables:

* User: Stores data related to users, including id, username, password, salt, email, first name, last name, password reset token, and password reset date.

* Account: Represents wallet accounts linked to specific users. Account data includes id, user id, account name, balance, account code, and whether the account has been deleted. There's a "one-to-many" relationship between User and Account, where each user can have multiple accounts.

* Transaction: Stores relevant data for all transactions performed in the system, including id, name, amount, and transaction date.

* AccountTransaction: Links Account and Transaction through a "many-to-many" relationship. This table contains accountID, transactionID, and a payload value of TransactionType, used to distinguish between sender and recipient in transactions.

* OtherUserAccount: Links User with Account in a "many-to-many" relationship. It's used to save data when a user saves an account from another user. Data includes user id and account id.

The project has been designed with security and database management in mind, following a structured architecture to ensure a robust and maintainable application.
