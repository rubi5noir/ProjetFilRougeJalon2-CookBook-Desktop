CREATE TABLE Ingredients
(
    id serial PRIMARY KEY,
    nom varchar(50) UNIQUE NOT NULL
);

CREATE TABLE  Categories
(
    id serial PRIMARY KEY,
    nom varchar(50) UNIQUE NOT NULL
);

CREATE TABLE Utilisateurs
(
    id serial PRIMARY KEY,
    identifiant varchar(50) UNIQUE NOT NULL,
    nom varchar(50) NOT NULL,
    prenom varchar(50) NOT NULL,
    email varchar(70) UNIQUE NOT NULL,
    mot_de_passe varchar(50) NOT NULL
);

CREATE TABLE Recettes
(
    id serial PRIMARY KEY,
    nom varchar(150) NOT NULL,
    description TEXT NOT NULL,
    temps_preparation INTERVAL NOT NULL,
    temps_cuisson INTERVAL NOT NULL,
    difficulte int NOT NULL,
    id_utilisateur int NOT NULL, FOREIGN KEY (id_utilisateur) REFERENCES Utilisateurs(id)
);

CREATE TABLE Categories_Recettes
(
    id_categorie int NOT NULL, FOREIGN KEY (id_categorie) REFERENCES Categories(id),
    id_recette int NOT NULL, FOREIGN KEY (id_recette) REFERENCES Recettes(id),
    PRIMARY KEY (id_categorie, id_recette)
);

CREATE TABLE Ingredients_recettes
(
    id_ingredient int NOT NULL, FOREIGN KEY (id_ingredient) REFERENCES Ingredients(id),
    id_recette int NOT NULL, FOREIGN KEY (id_recette) REFERENCES Recettes(id),
    PRIMARY KEY (id_ingredient, id_recette),
    quantite varchar(40)
);

CREATE TABLE etapes
(
    numero int NOT NULL,
    id_recette int NOT NULL, FOREIGN KEY (id_recette) REFERENCES Recettes(id),
    PRIMARY KEY (numero, id_recette),
    texte TEXT NOT NULL
);

CREATE TABLE avis
(
    id_recette int NOT NULL, FOREIGN KEY (id_recette) REFERENCES Recettes(id),
    id_utilisateur int NOT NULL, FOREIGN KEY (id_utilisateur) REFERENCES Utilisateurs(id),
    PRIMARY KEY (id_recette, id_utilisateur),
    note int NOT NULL,
    commentaire varchar(555)
);

ALTER TABLE
RECETTES
ADD COLUMN img varchar(200);

ALTER TABLE utilisateurs
RENAME COLUMN mot_de_passe TO password;

ALTER TABLE utilisateurs
ALTER COLUMN password TYPE varchar(500);

ALTER TABLE
UTILISATEURS
ADD COLUMN admin bool;