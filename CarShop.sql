CREATE TABLE Fournisseur(
   FournisseurID INT,
   NomEntreprise VARCHAR(50),
   NomContact VARCHAR(50),
   FonctionContact VARCHAR(50),
   Adresse VARCHAR(50),
   Ville VARCHAR(50),
   CodePostal VARCHAR(50),
   Pays VARCHAR(50),
   Telephone VARCHAR(24),
   Fax VARCHAR(24),
   PRIMARY KEY(FournisseurID)
);

CREATE TABLE Transporteur(
   TransporteurID INT,
   Nom VARCHAR(50),
   Telephone VARCHAR(24),
   PRIMARY KEY(TransporteurID)
);

CREATE TABLE Commande(
   CommandeID INT,
   DateCommande DATE,
   DateLivraison DATE,
   Frais DECIMAL(15,2),
   NomLivraison VARCHAR(50),
   AdresseLivraison VARCHAR(60),
   VilleLivraison VARCHAR(20),
   CodePostalLivraison VARCHAR(10),
   PaysLivraison VARCHAR(20),
   UserName TEXT,
   TransporteurID INT NOT NULL,
   PRIMARY KEY(CommandeID),
   FOREIGN KEY(TransporteurID) REFERENCES Transporteur(TransporteurID)
);

CREATE TABLE Voiture(
   VoitureID INT,
   Marque VARCHAR(50),
   Modele VARCHAR(50),
   Categorie VARCHAR(50),
   Description VARCHAR(255),
   Image VARCHAR(255),
   DateAjout DATE,
   Prix DECIMAL(15,2),
   FournisseurID INT NOT NULL,
   CommandeID INT NOT NULL,
   PRIMARY KEY(VoitureID),
   FOREIGN KEY(FournisseurID) REFERENCES Fournisseur(FournisseurID),
   FOREIGN KEY(CommandeID) REFERENCES Commande(CommandeID)
);

INSERT INTO "Transporteur"("TransporteurID","Nom","Telephone") VALUES(1,'UPS','0 821 23 38 77');
INSERT INTO "Transporteur"("TransporteurID","Nom","Telephone") VALUES(2,'Chronopost','09 69 39 13 91');
INSERT INTO "Transporteur"("TransporteurID","Nom","Telephone") VALUES(3,'DPD','09 70 80 85 66');

INSERT INTO "Fournisseur" VALUES (1, "Mercedes", "Dupont Pierre", "Commercial", "3 Boulevard Pierre Lefaucheux", "Le Mans", "72100", "France", "03 43 72 72 33", "");
INSERT INTO "Fournisseur" VALUES (2, "Audi", "Durant Yves", "Responsable Vente", "302 boulevard des Hunaudières", "Ruaudin", "72230", "France", "02 43 78 50 66", "03 43 78 50 66");
INSERT INTO "Fournisseur" VALUES (3, "BMW", "Dubois Maurice", "Directeur commercial", "2 Boulevard René Cassin", "Le Mans", "72000", "France", "02 43 85 00 11", "03 43 85 00 11");