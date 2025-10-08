-- Script PostgreSQL lisible pour créer le schéma `public` (structure uniquement, sans données)
DROP SCHEMA IF EXISTS public CASCADE;
CREATE SCHEMA public;
SET search_path TO public;

-- Séquences pour les colonnes id (comme dans ton dump)
CREATE SEQUENCE public.categories_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;

CREATE SEQUENCE public.ingredients_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;

CREATE SEQUENCE public.recettes_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;

CREATE SEQUENCE public.utilisateurs_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;

-- Tables
CREATE TABLE public.categories (
    id integer NOT NULL,
    nom character varying(50) NOT NULL,
    CONSTRAINT categories_pkey PRIMARY KEY (id),
    CONSTRAINT categories_nom_key UNIQUE (nom)
);

CREATE TABLE public.ingredients (
    id integer NOT NULL,
    nom character varying(50) NOT NULL,
    CONSTRAINT ingredients_pkey PRIMARY KEY (id),
    CONSTRAINT ingredients_nom_key UNIQUE (nom)
);

CREATE TABLE public.utilisateurs (
    id integer NOT NULL,
    identifiant character varying(50) NOT NULL,
    nom character varying(50) NOT NULL,
    prenom character varying(50) NOT NULL,
    email character varying(70) NOT NULL,
    password character varying(500) NOT NULL,
    admin boolean NOT NULL DEFAULT false,
    CONSTRAINT utilisateurs_pkey PRIMARY KEY (id),
    CONSTRAINT utilisateurs_identifiant_key UNIQUE (identifiant),
    CONSTRAINT utilisateurs_email_key UNIQUE (email)
);

CREATE TABLE public.recettes (
    id integer NOT NULL,
    nom character varying(150) NOT NULL,
    description text NOT NULL,
    temps_preparation interval NOT NULL,
    temps_cuisson interval NOT NULL,
    difficulte integer NOT NULL,
    id_utilisateur integer NOT NULL,
    img character varying(200) NOT NULL,
    CONSTRAINT recettes_pkey PRIMARY KEY (id)
);

CREATE TABLE public.avis (
    id_recette integer NOT NULL,
    id_utilisateur integer NOT NULL,
    note integer NOT NULL,
    commentaire character varying(555) NOT NULL,
    CONSTRAINT avis_pkey PRIMARY KEY (id_recette, id_utilisateur)
);

CREATE TABLE public.categories_recettes (
    id_categorie integer NOT NULL,
    id_recette integer NOT NULL,
    CONSTRAINT categories_recettes_pkey PRIMARY KEY (id_categorie, id_recette)
);

CREATE TABLE public.etapes (
    numero integer NOT NULL,
    id_recette integer NOT NULL,
    texte text NOT NULL,
    CONSTRAINT etapes_pkey PRIMARY KEY (numero, id_recette)
);

CREATE TABLE public.ingredients_recettes (
    id_ingredient integer NOT NULL,
    id_recette integer NOT NULL,
    quantite character varying(40) NOT NULL,
    CONSTRAINT ingredients_recettes_pkey PRIMARY KEY (id_ingredient, id_recette)
);

-- Lier les sequences aux colonnes id et définir les valeurs par défaut
ALTER TABLE ONLY public.categories ALTER COLUMN id SET DEFAULT nextval('public.categories_id_seq'::regclass);
ALTER SEQUENCE public.categories_id_seq OWNED BY public.categories.id;

ALTER TABLE ONLY public.ingredients ALTER COLUMN id SET DEFAULT nextval('public.ingredients_id_seq'::regclass);
ALTER SEQUENCE public.ingredients_id_seq OWNED BY public.ingredients.id;

ALTER TABLE ONLY public.recettes ALTER COLUMN id SET DEFAULT nextval('public.recettes_id_seq'::regclass);
ALTER SEQUENCE public.recettes_id_seq OWNED BY public.recettes.id;

ALTER TABLE ONLY public.utilisateurs ALTER COLUMN id SET DEFAULT nextval('public.utilisateurs_id_seq'::regclass);
ALTER SEQUENCE public.utilisateurs_id_seq OWNED BY public.utilisateurs.id;

-- Contraintes de clefs étrangères
ALTER TABLE ONLY public.avis
    ADD CONSTRAINT avis_id_recette_fkey FOREIGN KEY (id_recette) REFERENCES public.recettes(id),
    ADD CONSTRAINT avis_id_utilisateur_fkey FOREIGN KEY (id_utilisateur) REFERENCES public.utilisateurs(id);

ALTER TABLE ONLY public.categories_recettes
    ADD CONSTRAINT categories_recettes_id_categorie_fkey FOREIGN KEY (id_categorie) REFERENCES public.categories(id),
    ADD CONSTRAINT categories_recettes_id_recette_fkey FOREIGN KEY (id_recette) REFERENCES public.recettes(id);

ALTER TABLE ONLY public.etapes
    ADD CONSTRAINT etapes_id_recette_fkey FOREIGN KEY (id_recette) REFERENCES public.recettes(id);

ALTER TABLE ONLY public.ingredients_recettes
    ADD CONSTRAINT ingredients_recettes_id_ingredient_fkey FOREIGN KEY (id_ingredient) REFERENCES public.ingredients(id),
    ADD CONSTRAINT ingredients_recettes_id_recette_fkey FOREIGN KEY (id_recette) REFERENCES public.recettes(id);

ALTER TABLE ONLY public.recettes
    ADD CONSTRAINT recettes_id_utilisateur_fkey FOREIGN KEY (id_utilisateur) REFERENCES public.utilisateurs(id);

-- FIN du script



BEGIN;

-- Utilisateurs
INSERT INTO public.utilisateurs VALUES (1, 'rubisnoir', 'rubis', 'noir', 'pl.dauge@gmail.com', '$2a$11$ds3SychRh/SiuxaFZ5BaZ.xtvRId4IaznRly27JEL7J4sJxD1Sqv.', true);
INSERT INTO public.utilisateurs VALUES (2, 'delphinus', 'dauge', 'delphine', 'delphinus@gmail.com', '$2a$11$f1X2nDTBp0V1RwYyz/4IjeL.VNoFSQocre.Dp509IrQR2kySgw26m', false);
INSERT INTO public.utilisateurs VALUES (3, 'Kellotuk', 'dauge', 'clovis', 'kellotek@gmail.com', '$2a$11$cn61wj1X4YAFsZgnXnWsqePHiDClOCS99Pmftc/RkcmVKuinTgg6K', false);
INSERT INTO public.utilisateurs VALUES (4, 'User', 'Lambda', 'user', 'User@gmail.com', '$2a$11$38sFzdShSgwezV3nEXVGvu3.RA5kbhwq2IufVlrdrg7zcaN5J/nzW', false);

-- Recettes
INSERT INTO public.recettes VALUES (3, 'Scones à la cannelle et aux raisins secs', 'De délicieux scones a la cannelle fourré aux raisins secs.', '00:30:00', '00:15:00', 2, 2, '/Img/Recettes/chi2latp.jfif');
INSERT INTO public.recettes VALUES (4, 'Gaufres de teff au chocolat', 't', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/qx0jr5al.jfif');
INSERT INTO public.recettes VALUES (5, 'Craquelins de quinoa au cheddar, au thym, et au sel de mer', 't', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/xdbyqdrn.jfif');
INSERT INTO public.recettes VALUES (6, 'Craquelins de quinoa au cheddar, au thym, et au sel de mer', 't', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/o5wwxrwy.jfif');
INSERT INTO public.recettes VALUES (7, 'Craquelins de quinoa et sésame grillé', 't', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/olojh0ue.jfif');
INSERT INTO public.recettes VALUES (8, 'Craquelins de quinoa aux six grains et a l''oignon', 'Craquelins de quinoa aux six grains et a l''oignon', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/am04iemm.jfif');
INSERT INTO public.recettes VALUES (1, 'Pain Nordique', 'Pain généreusement garni en graines de tournesol et de sarrasin, idéal pour le petit-déjeuner.', '15:30:00', '01:45:00', 1, 2, '/Img/Recettes/gdlfzm2y.jpg');
INSERT INTO public.recettes VALUES (9, 'Tourte au chocolat et aux grains anciens avec sauce aux framboises et au chia', 'Tourte au chocolat et aux grains anciens avec sauce aux framboises et au chia', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/epnlqwgk.jfif');
INSERT INTO public.recettes VALUES (10, 'Pain aux bananes aux grains anciens, aux noix de Grenoble et à la cassonade', 'Pain aux bananes aux grains anciens, aux noix de Grenoble et à la cassonade', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/vfkqioks.jfif');
INSERT INTO public.recettes VALUES (11, 'Pain aux bananes double chocolat aux grains anciens', 'Pain aux bananes double chocolat aux grains anciens', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/yk0xevkm.jfif');
INSERT INTO public.recettes VALUES (16, 'Gâteau quatre-quarts aux grains anciens, au citron et aux bleuets', 'Gâteau quatre-quarts aux grains anciens, au citron et aux bleuets', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/u4tgtexx.jfif');
INSERT INTO public.recettes VALUES (17, 'Muffins aux grains anciens, aux carottes et aux ananas', 'Muffins aux grains anciens, aux carottes et aux ananas', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/0sv3obax.jfif');
INSERT INTO public.recettes VALUES (18, 'Brownies au chia et au beurre d''arachide', 'Brownies au chia et au beurre d''arachide', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/xfztm4sl.jfif');
INSERT INTO public.recettes VALUES (19, 'Carrés gourmands à l''amarante et au chia', 'Carrés gourmands à l''amarante et au chia', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/xin3x3sl.jfif');
INSERT INTO public.recettes VALUES (20, 'Barres-collations au millet, au quinoa, aux bleuets et aux pacanes', 'Barres-collations au millet, au quinoa, aux bleuets et aux pacanes', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/gnv3j5yd.jfif');
INSERT INTO public.recettes VALUES (21, 'Biscuits au sucre au sorgho et à l''amarante', 'Biscuits au sucre au sorgho et à l''amarante', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/pxy31fa2.jfif');
INSERT INTO public.recettes VALUES (22, 'Barres à l''avoine et a l''érable', 'Barres à l''avoine et a l''érable', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/xnoylhot.jfif');
INSERT INTO public.recettes VALUES (23, 'Biscuits au citron et aux grains anciens', 'Biscuits au citron et aux grains anciens', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/n0tw40f5.jfif');
INSERT INTO public.recettes VALUES (24, 'Macarons au chocolat, à la noix de coco et au quinoa', 'Macarons au chocolat, à la noix de coco et au quinoa', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/tog30c1o.jfif');
INSERT INTO public.recettes VALUES (25, 'Biscuits au chia, au chocolat, aux raisins secs et aux noix de Grenoble', 'Biscuits au chia, au chocolat, aux raisins secs et aux noix de Grenoble', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/ocsa0pmh.jfif');
INSERT INTO public.recettes VALUES (26, 'Biscuits au chia et aux grains de chocolat', 'Biscuits au chia et aux grains de chocolat', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/v0whzbx3.jfif');
INSERT INTO public.recettes VALUES (35, 'Granola aux grains anciens avec citron, cajous et gingembre', 'Granola aux grains anciens avec citron, cajous et gingembre', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/sy3v2viv.jfif');
INSERT INTO public.recettes VALUES (27, 'Moelleux aux noix', 'Gâteau fondant aux noix.', '00:30:00', '00:40:00', 2, 1, '/Img/Recettes/1sb1ozdm.jfif');
INSERT INTO public.recettes VALUES (28, 'Cœurs fondant au chocolat blanc', 'Cœurs fondant au chocolat blanc', '00:00:00', '00:00:00', 1, 3, '/Img/Recettes/p10hikgo.jfif');
INSERT INTO public.recettes VALUES (29, 'Tarte aux framboises et ganache au chocolat blanc', 'Tarte aux framboises et ganache au chocolat blanc', '00:00:00', '00:00:00', 1, 3, '/Img/Recettes/ndsr05zt.jfif');
INSERT INTO public.recettes VALUES (30, 'Fondant au chocolat caramel', 'Fondant au chocolat caramel', '00:00:00', '00:00:00', 1, 3, '/Img/Recettes/vt103ke2.jfif');
INSERT INTO public.recettes VALUES (31, 'Fondant praliné et pommes poêlées', 'Fondant praliné et pommes poêlées', '00:00:00', '00:00:00', 1, 3, '/Img/Recettes/iv040wbp.jfif');
INSERT INTO public.recettes VALUES (32, 'Panacotta au chocolat et coulis de framboises', 'Panacotta au chocolat et coulis de framboises', '00:00:00', '00:00:00', 1, 3, '/Img/Recettes/i3gdlqfd.jfif');
INSERT INTO public.recettes VALUES (33, 'Petit sablés au cacao intense', 'Petit sablés au cacao intense', '00:00:00', '00:00:00', 1, 3, '/Img/Recettes/k144ivgf.jfif');
INSERT INTO public.recettes VALUES (34, 'Granola épicé aux pommes et aux raisins secs', 'Granola épicé aux pommes et aux raisins secs', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/p1kuwbti.jfif');
INSERT INTO public.recettes VALUES (36, 'Granola moelleux au chocolat avec cerises et sarrasin', 'Granola moelleux au chocolat avec cerises et sarrasin', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/xzqgxfvz.jfif');
INSERT INTO public.recettes VALUES (37, 'Granola épicé a la mélasse avec graines de citrouille et canneberges', 'Granola épicé a la mélasse avec graines de citrouille et canneberges', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/umpcpvrr.jfif');
INSERT INTO public.recettes VALUES (38, 'Cake a la butternut', 'Cake a la butternut', '00:00:00', '00:00:00', 1, 2, '/Img/Recettes/ke1owlnh.jfif');
INSERT INTO public.recettes VALUES (39, 'string', 'string', '00:00:00', '00:00:00', 0, 1, 'string');

-- Avis
INSERT INTO public.avis VALUES (1, 1, 5, 'Idéal pour le petit-déjeuner!');
INSERT INTO public.avis VALUES (1, 3, 3, 'Super!!!');

-- Catégories
INSERT INTO public.categories VALUES (1, 'sans gluten');
INSERT INTO public.categories VALUES (2, 'végétale');
INSERT INTO public.categories VALUES (3, 'naturel');
INSERT INTO public.categories VALUES (4, 'dessert');
INSERT INTO public.categories VALUES (5, 'plats');
INSERT INTO public.categories VALUES (6, 'entrée');
INSERT INTO public.categories VALUES (7, 'snack');
INSERT INTO public.categories VALUES (8, 'légume');
INSERT INTO public.categories VALUES (9, 'fruit');
INSERT INTO public.categories VALUES (10, 'fromage');
INSERT INTO public.categories VALUES (11, 'viande');
INSERT INTO public.categories VALUES (12, 'chocolat');
INSERT INTO public.categories VALUES (13, 'sucré');

-- Categories_recettes
INSERT INTO public.categories_recettes VALUES (1, 3);
INSERT INTO public.categories_recettes VALUES (4, 3);
INSERT INTO public.categories_recettes VALUES (1, 4);
INSERT INTO public.categories_recettes VALUES (7, 5);
INSERT INTO public.categories_recettes VALUES (7, 6);
INSERT INTO public.categories_recettes VALUES (7, 7);
INSERT INTO public.categories_recettes VALUES (7, 8);
INSERT INTO public.categories_recettes VALUES (1, 1);
INSERT INTO public.categories_recettes VALUES (7, 1);
INSERT INTO public.categories_recettes VALUES (12, 9);
INSERT INTO public.categories_recettes VALUES (1, 10);
INSERT INTO public.categories_recettes VALUES (12, 11);
INSERT INTO public.categories_recettes VALUES (11, 16);
INSERT INTO public.categories_recettes VALUES (11, 17);
INSERT INTO public.categories_recettes VALUES (11, 18);
INSERT INTO public.categories_recettes VALUES (11, 19);
INSERT INTO public.categories_recettes VALUES (11, 20);
INSERT INTO public.categories_recettes VALUES (11, 21);
INSERT INTO public.categories_recettes VALUES (11, 22);
INSERT INTO public.categories_recettes VALUES (11, 23);
INSERT INTO public.categories_recettes VALUES (11, 24);
INSERT INTO public.categories_recettes VALUES (11, 25);
INSERT INTO public.categories_recettes VALUES (11, 26);
INSERT INTO public.categories_recettes VALUES (1, 27);
INSERT INTO public.categories_recettes VALUES (4, 27);
INSERT INTO public.categories_recettes VALUES (12, 28);
INSERT INTO public.categories_recettes VALUES (12, 29);
INSERT INTO public.categories_recettes VALUES (12, 30);
INSERT INTO public.categories_recettes VALUES (12, 31);
INSERT INTO public.categories_recettes VALUES (12, 32);
INSERT INTO public.categories_recettes VALUES (12, 33);
INSERT INTO public.categories_recettes VALUES (7, 34);
INSERT INTO public.categories_recettes VALUES (7, 35);
INSERT INTO public.categories_recettes VALUES (12, 36);
INSERT INTO public.categories_recettes VALUES (7, 37);
INSERT INTO public.categories_recettes VALUES (2, 38);
INSERT INTO public.categories_recettes VALUES (1, 39);
INSERT INTO public.categories_recettes VALUES (2, 39);
INSERT INTO public.categories_recettes VALUES (1, 5);
INSERT INTO public.categories_recettes VALUES (1, 17);

-- Etapes
INSERT INTO public.etapes VALUES (4, 1, ' Le lendemain, dans un bol, mélangez le psyllium et 33.8cl d''eau afin de créer un gel.');
INSERT INTO public.etapes VALUES (5, 1, ' Egouter les graines de tournesol et de sarrasin et les mettres dans un saladier.');
INSERT INTO public.etapes VALUES (6, 1, ' Ajouter la farine de sorgho, la farine de sarrasin, la fécule de tapioca, la mélasse, le sel, le levain de l''étape 1 et le gel de psyllium.');
INSERT INTO public.etapes VALUES (7, 1, ' Pate a pain terminée.
Enfourner pendant 1h45mins.');
INSERT INTO public.etapes VALUES (3, 27, 'Montez les blancs en neige bien ferme avec le reste de sucre. Incorporez-les dans la pâte à l''aide d''une spatule.');
INSERT INTO public.etapes VALUES (4, 27, 'Préchauffez le four a 180°C');
INSERT INTO public.etapes VALUES (5, 27, 'Beurrez généreusement le moule, farinez-le et versez-y la pâte. Enfourner pour 30 à 40mins. Vérifiez la cuisson a l''aide de la pointe d''un couteau (elle doit ressortir sèche). Démoulez le gâteau et laissez-le refroidir sur une grille.');
INSERT INTO public.etapes VALUES (6, 27, ' Saupoudrez de sucre glace et décorez de quelques cerneaux de noix.');
INSERT INTO public.etapes VALUES (2, 27, 'string1');
INSERT INTO public.etapes VALUES (2, 39, 'string1');
INSERT INTO public.etapes VALUES (1, 3, 'std');
INSERT INTO public.etapes VALUES (1, 4, 'std');
INSERT INTO public.etapes VALUES (1, 6, 'std');
INSERT INTO public.etapes VALUES (1, 7, 'std');
INSERT INTO public.etapes VALUES (1, 8, 'std');
INSERT INTO public.etapes VALUES (1, 9, 'std');
INSERT INTO public.etapes VALUES (1, 10, 'std');
INSERT INTO public.etapes VALUES (1, 11, 'std');
INSERT INTO public.etapes VALUES (1, 16, 'std');
INSERT INTO public.etapes VALUES (1, 17, 'std');
INSERT INTO public.etapes VALUES (1, 18, 'std');
INSERT INTO public.etapes VALUES (1, 19, 'std');
INSERT INTO public.etapes VALUES (1, 20, 'std');
INSERT INTO public.etapes VALUES (1, 21, 'std');
INSERT INTO public.etapes VALUES (1, 22, 'std');
INSERT INTO public.etapes VALUES (1, 23, 'std');
INSERT INTO public.etapes VALUES (1, 24, 'std');
INSERT INTO public.etapes VALUES (1, 25, 'std');
INSERT INTO public.etapes VALUES (1, 26, 'std');
INSERT INTO public.etapes VALUES (1, 27, 'std');
INSERT INTO public.etapes VALUES (1, 28, 'std');
INSERT INTO public.etapes VALUES (1, 29, 'std');
INSERT INTO public.etapes VALUES (1, 30, 'std');
INSERT INTO public.etapes VALUES (1, 31, 'std');
INSERT INTO public.etapes VALUES (1, 32, 'std');
INSERT INTO public.etapes VALUES (1, 33, 'std');
INSERT INTO public.etapes VALUES (1, 34, 'std');
INSERT INTO public.etapes VALUES (1, 35, 'std');
INSERT INTO public.etapes VALUES (1, 36, 'std');
INSERT INTO public.etapes VALUES (1, 37, 'std');
INSERT INTO public.etapes VALUES (1, 38, 'std');
INSERT INTO public.etapes VALUES (1, 39, 'std');
INSERT INTO public.etapes VALUES (1, 1, 'Ajouter 140g de farine de riz complet et 19cl eau dans le saladier qui été sorti du frigo. Mélanger, couvrer avec une autre assiette et laisser quelques heures a température ambiante avant de le replacer au frais jusqu''à prochain usage.');
INSERT INTO public.etapes VALUES (2, 9, 'ghg');

-- Ingredients
INSERT INTO public.ingredients VALUES (1, 'Graines de tournesol');
INSERT INTO public.ingredients VALUES (2, 'graines de sarrasin');
INSERT INTO public.ingredients VALUES (3, 'eau');
INSERT INTO public.ingredients VALUES (4, 'levain');
INSERT INTO public.ingredients VALUES (5, 'levain sans gluten');
INSERT INTO public.ingredients VALUES (6, 'farine de riz complet');
INSERT INTO public.ingredients VALUES (7, 'farine de riz');
INSERT INTO public.ingredients VALUES (8, 'psyllium');
INSERT INTO public.ingredients VALUES (9, 'farine de sorgho');
INSERT INTO public.ingredients VALUES (10, 'farine de sarrasin');
INSERT INTO public.ingredients VALUES (11, 'fécule de tapioca');
INSERT INTO public.ingredients VALUES (12, 'mélasse');
INSERT INTO public.ingredients VALUES (13, 'sel gris de mer');
INSERT INTO public.ingredients VALUES (14, 'huile d''olive');
INSERT INTO public.ingredients VALUES (15, 'pommes');
INSERT INTO public.ingredients VALUES (16, 'levure');
INSERT INTO public.ingredients VALUES (17, 'sucre vanillé');
INSERT INTO public.ingredients VALUES (18, 'oeuf');
INSERT INTO public.ingredients VALUES (19, 'huile');
INSERT INTO public.ingredients VALUES (20, 'jus de pomme');
INSERT INTO public.ingredients VALUES (21, 'rhum ambré');
INSERT INTO public.ingredients VALUES (22, 'sel');
INSERT INTO public.ingredients VALUES (23, 'beurre demi-sel');
INSERT INTO public.ingredients VALUES (24, 'sucre roux');
INSERT INTO public.ingredients VALUES (25, 'sucre de coco');
INSERT INTO public.ingredients VALUES (26, 'yaourt');
INSERT INTO public.ingredients VALUES (27, 'arôme d''amande');
INSERT INTO public.ingredients VALUES (28, 'citron');
INSERT INTO public.ingredients VALUES (29, 'huile de tournesol');
INSERT INTO public.ingredients VALUES (30, 'amandes');
INSERT INTO public.ingredients VALUES (31, 'noisettes');
INSERT INTO public.ingredients VALUES (33, 'raisins secs');
INSERT INTO public.ingredients VALUES (32, 'cranberries');
INSERT INTO public.ingredients VALUES (34, 'lait d''avoine');
INSERT INTO public.ingredients VALUES (35, 'agar-agar');
INSERT INTO public.ingredients VALUES (36, 'crème de coco liquide');
INSERT INTO public.ingredients VALUES (37, 'sirop d''agave');
INSERT INTO public.ingredients VALUES (38, 'huile essentielle de lemongrass');
INSERT INTO public.ingredients VALUES (39, 'gousse de vanille');
INSERT INTO public.ingredients VALUES (40, 'lait de soja-vanille');
INSERT INTO public.ingredients VALUES (41, 'lait de noisette');
INSERT INTO public.ingredients VALUES (42, 'purée de noisette toastée');
INSERT INTO public.ingredients VALUES (43, 'fleur de sel');
INSERT INTO public.ingredients VALUES (44, 'cacao');
INSERT INTO public.ingredients VALUES (45, 'arôme de caramel');
INSERT INTO public.ingredients VALUES (46, 'extrait de vanille liquide');
INSERT INTO public.ingredients VALUES (47, 'beurre');
INSERT INTO public.ingredients VALUES (48, 'ghee');
INSERT INTO public.ingredients VALUES (49, 'poire');
INSERT INTO public.ingredients VALUES (50, 'cerneaux de noix');
INSERT INTO public.ingredients VALUES (51, 'beurre mou');
INSERT INTO public.ingredients VALUES (52, 'sucre glace');
INSERT INTO public.ingredients VALUES (53, 'crème liquide entière');
INSERT INTO public.ingredients VALUES (54, 'cacao en poudre');
INSERT INTO public.ingredients VALUES (55, 'feuilles de gélatine');
INSERT INTO public.ingredients VALUES (56, 'framboises');
INSERT INTO public.ingredients VALUES (57, 'chocolat blanc');
INSERT INTO public.ingredients VALUES (58, 'noix');
INSERT INTO public.ingredients VALUES (59, 'café');
INSERT INTO public.ingredients VALUES (60, 'pâte brisée');
INSERT INTO public.ingredients VALUES (61, 'chocolat praliné');
INSERT INTO public.ingredients VALUES (62, 'miel');
INSERT INTO public.ingredients VALUES (63, 'amandes effilées');
INSERT INTO public.ingredients VALUES (64, 'chocolat caramel');
INSERT INTO public.ingredients VALUES (65, 'avoine à cuisson rapide');
INSERT INTO public.ingredients VALUES (66, 'flocons de quinoa');
INSERT INTO public.ingredients VALUES (67, 'gruau de sarrasin');
INSERT INTO public.ingredients VALUES (68, 'noix de coco râpée');
INSERT INTO public.ingredients VALUES (69, 'huile de pépins de raisin');
INSERT INTO public.ingredients VALUES (70, 'poudre de cacao');
INSERT INTO public.ingredients VALUES (71, 'bicarbonnate de soude');
INSERT INTO public.ingredients VALUES (72, 'extrait de vanille pure');
INSERT INTO public.ingredients VALUES (73, 'cerises séchées');
INSERT INTO public.ingredients VALUES (74, 'graines de citrouille crues non salées');
INSERT INTO public.ingredients VALUES (75, 'graines de millet');
INSERT INTO public.ingredients VALUES (76, 'Graines de tournesol non salées');
INSERT INTO public.ingredients VALUES (77, 'graines d''amarante');
INSERT INTO public.ingredients VALUES (78, 'sirop d''érable pur');
INSERT INTO public.ingredients VALUES (79, 'mélasse de fantaisie');
INSERT INTO public.ingredients VALUES (80, 'graines de chia');
INSERT INTO public.ingredients VALUES (81, 'cannelle');
INSERT INTO public.ingredients VALUES (82, 'gingembre moulu');
INSERT INTO public.ingredients VALUES (83, 'muscade');
INSERT INTO public.ingredients VALUES (84, 'canneberges séchées');
INSERT INTO public.ingredients VALUES (85, 'zeste de citron');
INSERT INTO public.ingredients VALUES (86, 'graines de quinoa');
INSERT INTO public.ingredients VALUES (87, 'grains de teff');
INSERT INTO public.ingredients VALUES (88, 'avoine en gros flocons');
INSERT INTO public.ingredients VALUES (89, 'cajous');
INSERT INTO public.ingredients VALUES (90, 'ananas séché');
INSERT INTO public.ingredients VALUES (91, 'mangue séchée');
INSERT INTO public.ingredients VALUES (92, 'pommes séchées');
INSERT INTO public.ingredients VALUES (93, 'farine de teff');
INSERT INTO public.ingredients VALUES (94, 'sucre de canne');
INSERT INTO public.ingredients VALUES (95, 'lait');
INSERT INTO public.ingredients VALUES (96, 'huile végétale');
INSERT INTO public.ingredients VALUES (98, 'gomme xanthane');
INSERT INTO public.ingredients VALUES (99, 'babeurre faible en gras');
INSERT INTO public.ingredients VALUES (100, 'cassonade');
INSERT INTO public.ingredients VALUES (101, 'cheddar');
INSERT INTO public.ingredients VALUES (102, 'gouda');
INSERT INTO public.ingredients VALUES (103, 'thym');
INSERT INTO public.ingredients VALUES (104, 'piment chipotle moulu');
INSERT INTO public.ingredients VALUES (105, 'poivre de cayenne');
INSERT INTO public.ingredients VALUES (106, 'miel liquide');
INSERT INTO public.ingredients VALUES (107, 'farine de riz blanc');
INSERT INTO public.ingredients VALUES (108, 'farine de pomme de terre');
INSERT INTO public.ingredients VALUES (109, 'graines de sésame');
INSERT INTO public.ingredients VALUES (110, 'graines de pavot');
INSERT INTO public.ingredients VALUES (111, 'sel d''oignon');
INSERT INTO public.ingredients VALUES (112, 'huile de sésame grillé');
INSERT INTO public.ingredients VALUES (113, 'farine de millet');
INSERT INTO public.ingredients VALUES (114, 'grains de chocolat mi-sucré');
INSERT INTO public.ingredients VALUES (115, 'farine d''amarante');
INSERT INTO public.ingredients VALUES (116, 'farine de noix de coco');
INSERT INTO public.ingredients VALUES (117, 'jus de citron');
INSERT INTO public.ingredients VALUES (118, 'noix de Grenoble');
INSERT INTO public.ingredients VALUES (119, 'graines de chia blanches');
INSERT INTO public.ingredients VALUES (121, 'pacanes hachées');
INSERT INTO public.ingredients VALUES (122, 'quinoa soufflé');
INSERT INTO public.ingredients VALUES (123, 'millet soullfé');
INSERT INTO public.ingredients VALUES (124, 'bleuets séchés');
INSERT INTO public.ingredients VALUES (125, 'farine de kaniwa');
INSERT INTO public.ingredients VALUES (126, 'beurre d''arachide crémeux');
INSERT INTO public.ingredients VALUES (127, 'arachides');
INSERT INTO public.ingredients VALUES (128, 'dattes');
INSERT INTO public.ingredients VALUES (129, 'poudre de cacao non sucrée');
INSERT INTO public.ingredients VALUES (130, 'ananas broyés');
INSERT INTO public.ingredients VALUES (131, 'carottes');
INSERT INTO public.ingredients VALUES (141, 'farine de sarrasin pâle');
INSERT INTO public.ingredients VALUES (142, 'bleuets');
INSERT INTO public.ingredients VALUES (143, 'compote de pommes');
INSERT INTO public.ingredients VALUES (144, 'banane');
INSERT INTO public.ingredients VALUES (145, 'chair de butternut');
INSERT INTO public.ingredients VALUES (146, 'farine de pois chiches');
INSERT INTO public.ingredients VALUES (147, 'tomates séchées');
INSERT INTO public.ingredients VALUES (148, 'graines de courge');
INSERT INTO public.ingredients VALUES (120, 'flocons d''avoine');
INSERT INTO public.ingredients VALUES (149, 'farine d''avoine');

-- Ingredients_recettes
INSERT INTO public.ingredients_recettes VALUES (80, 3, '5ml');
INSERT INTO public.ingredients_recettes VALUES (3, 3, '22ml');
INSERT INTO public.ingredients_recettes VALUES (9, 3, '250ml');
INSERT INTO public.ingredients_recettes VALUES (149, 3, '175ml');
INSERT INTO public.ingredients_recettes VALUES (16, 3, '20ml');
INSERT INTO public.ingredients_recettes VALUES (98, 3, '5ml');
INSERT INTO public.ingredients_recettes VALUES (94, 3, '45ml');
INSERT INTO public.ingredients_recettes VALUES (81, 3, '2ml');
INSERT INTO public.ingredients_recettes VALUES (22, 3, '1 pincée');
INSERT INTO public.ingredients_recettes VALUES (47, 3, '75ml');
INSERT INTO public.ingredients_recettes VALUES (33, 3, '175ml');
INSERT INTO public.ingredients_recettes VALUES (99, 3, '125ml');
INSERT INTO public.ingredients_recettes VALUES (26, 3, '60ml');
INSERT INTO public.ingredients_recettes VALUES (100, 3, '30');
INSERT INTO public.ingredients_recettes VALUES (93, 4, '500ml');
INSERT INTO public.ingredients_recettes VALUES (66, 5, '250ml');
INSERT INTO public.ingredients_recettes VALUES (66, 6, '250ml');
INSERT INTO public.ingredients_recettes VALUES (66, 7, '250ml');
INSERT INTO public.ingredients_recettes VALUES (66, 8, '250ml');
INSERT INTO public.ingredients_recettes VALUES (1, 1, '140g');
INSERT INTO public.ingredients_recettes VALUES (2, 1, '90g');
INSERT INTO public.ingredients_recettes VALUES (3, 1, '1,09l');
INSERT INTO public.ingredients_recettes VALUES (5, 1, '200g');
INSERT INTO public.ingredients_recettes VALUES (6, 1, '230g');
INSERT INTO public.ingredients_recettes VALUES (8, 1, '30g');
INSERT INTO public.ingredients_recettes VALUES (9, 1, '140g');
INSERT INTO public.ingredients_recettes VALUES (10, 1, '140g');
INSERT INTO public.ingredients_recettes VALUES (11, 1, '30g');
INSERT INTO public.ingredients_recettes VALUES (12, 1, '2c. à soupe');
INSERT INTO public.ingredients_recettes VALUES (13, 1, '2c. à café');
INSERT INTO public.ingredients_recettes VALUES (14, 1, 'selon convenance');
INSERT INTO public.ingredients_recettes VALUES (54, 9, 'a');
INSERT INTO public.ingredients_recettes VALUES (35, 10, 'a');
INSERT INTO public.ingredients_recettes VALUES (57, 11, '5');
INSERT INTO public.ingredients_recettes VALUES (35, 16, '0');
INSERT INTO public.ingredients_recettes VALUES (35, 17, '5');
INSERT INTO public.ingredients_recettes VALUES (35, 18, '5');
INSERT INTO public.ingredients_recettes VALUES (35, 19, '5');
INSERT INTO public.ingredients_recettes VALUES (35, 20, '5');
INSERT INTO public.ingredients_recettes VALUES (35, 21, '5');
INSERT INTO public.ingredients_recettes VALUES (35, 22, '5');
INSERT INTO public.ingredients_recettes VALUES (35, 23, '5');
INSERT INTO public.ingredients_recettes VALUES (35, 24, '5');
INSERT INTO public.ingredients_recettes VALUES (35, 25, '5');
INSERT INTO public.ingredients_recettes VALUES (35, 26, '5');
INSERT INTO public.ingredients_recettes VALUES (10, 27, '100g');
INSERT INTO public.ingredients_recettes VALUES (16, 27, '6g');
INSERT INTO public.ingredients_recettes VALUES (18, 27, '3');
INSERT INTO public.ingredients_recettes VALUES (49, 27, '1');
INSERT INTO public.ingredients_recettes VALUES (50, 27, '100g');
INSERT INTO public.ingredients_recettes VALUES (51, 27, '100g');
INSERT INTO public.ingredients_recettes VALUES (52, 27, 'a convenance');
INSERT INTO public.ingredients_recettes VALUES (85, 27, '1');
INSERT INTO public.ingredients_recettes VALUES (94, 27, '120g');
INSERT INTO public.ingredients_recettes VALUES (1, 28, '5');
INSERT INTO public.ingredients_recettes VALUES (1, 29, '5');
INSERT INTO public.ingredients_recettes VALUES (1, 30, '5');
INSERT INTO public.ingredients_recettes VALUES (1, 31, '5');
INSERT INTO public.ingredients_recettes VALUES (1, 32, '5');
INSERT INTO public.ingredients_recettes VALUES (1, 33, '5');
INSERT INTO public.ingredients_recettes VALUES (1, 34, '5');
INSERT INTO public.ingredients_recettes VALUES (1, 35, '5');
INSERT INTO public.ingredients_recettes VALUES (1, 36, '5');
INSERT INTO public.ingredients_recettes VALUES (1, 37, '5');
INSERT INTO public.ingredients_recettes VALUES (1, 38, '5');
INSERT INTO public.ingredients_recettes VALUES (2, 39, '5g');

-- Réalignement des séquences après insertions manuelles
SELECT setval('public.categories_id_seq', (SELECT MAX(id) FROM public.categories));
SELECT setval('public.ingredients_id_seq', (SELECT MAX(id) FROM public.ingredients));
SELECT setval('public.recettes_id_seq', (SELECT MAX(id) FROM public.recettes));
SELECT setval('public.utilisateurs_id_seq', (SELECT MAX(id) FROM public.utilisateurs));


COMMIT;