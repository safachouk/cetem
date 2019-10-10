-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  jeu. 10 oct. 2019 à 21:45
-- Version du serveur :  5.7.26
-- Version de PHP :  7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `ctm_bh_application`
--

-- --------------------------------------------------------

--
-- Structure de la table `demandes`
--

DROP TABLE IF EXISTS `demandes`;
CREATE TABLE IF NOT EXISTS `demandes` (
  `Nombre_Respirateur_anesthesie` int(11) NOT NULL,
  `Date_Demande` date NOT NULL,
  `ID_DEMANDE` int(11) NOT NULL AUTO_INCREMENT,
  `Etat_demande` varchar(30) NOT NULL,
  `Numéro_demande` varchar(30) NOT NULL,
  `region_demande` varchar(20) NOT NULL,
  `Hopital_demande` varchar(25) NOT NULL,
  `Nombre_respirateur_réanimation` int(11) NOT NULL,
  `nombre_pousse_seringe` int(11) NOT NULL,
  `nombre_defibrillateur` int(11) NOT NULL,
  `Nombre_respirateur_transport` int(11) NOT NULL,
  `Nombre_bistouri` int(11) NOT NULL,
  PRIMARY KEY (`ID_DEMANDE`),
  KEY `Numéro_demande` (`Numéro_demande`),
  KEY `region_demande` (`region_demande`),
  KEY `Hopital_demande` (`Hopital_demande`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `demandes`
--

INSERT INTO `demandes` (`Nombre_Respirateur_anesthesie`, `Date_Demande`, `ID_DEMANDE`, `Etat_demande`, `Numéro_demande`, `region_demande`, `Hopital_demande`, `Nombre_respirateur_réanimation`, `nombre_pousse_seringe`, `nombre_defibrillateur`, `Nombre_respirateur_transport`, `Nombre_bistouri`) VALUES
(1, '2019-09-15', 1, 'En instance', 'gget', 'Sousse', 'Sahloul ', 0, 0, 0, 5, 0),
(0, '2019-01-12', 2, 'En cours', 'fqdg', 'Mahdia', 'Sahloul ', 1, 0, 0, 2, 0);

-- --------------------------------------------------------

--
-- Structure de la table `equipements`
--

DROP TABLE IF EXISTS `equipements`;
CREATE TABLE IF NOT EXISTS `equipements` (
  `ID_EQUIPEMENT` int(11) NOT NULL AUTO_INCREMENT,
  `MARQUE` varchar(25) NOT NULL,
  `TYPE` varchar(25) NOT NULL,
  `Modéle` varchar(30) NOT NULL,
  `NUM_SERIE` varchar(25) NOT NULL,
  `nom_de_hopital` varchar(25) NOT NULL,
  `Nom_de_service` varchar(200) NOT NULL,
  `Nom_region` varchar(20) NOT NULL,
  PRIMARY KEY (`ID_EQUIPEMENT`),
  KEY `nom_de_hopital` (`nom_de_hopital`),
  KEY `Nom_de_service` (`Nom_de_service`),
  KEY `Nom_region` (`Nom_region`),
  KEY `NUM_SERIE` (`NUM_SERIE`),
  KEY `TYPE` (`TYPE`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `equipements`
--

INSERT INTO `equipements` (`ID_EQUIPEMENT`, `MARQUE`, `TYPE`, `Modéle`, `NUM_SERIE`, `nom_de_hopital`, `Nom_de_service`, `Nom_region`) VALUES
(1, 'Leon_plus ', 'Respirateur d’anesthésie ', '', '0983567456', 'Bekalta', 'Hématologie ', 'kairouan '),
(2, 'aaaaa', 'Respirateur d’anesthésie', 'ttttt', 'yyyyy', 'Ibn jazar ', 'Service de cardiologie', 'Monastir ');

-- --------------------------------------------------------

--
-- Structure de la table `hopitaux`
--

DROP TABLE IF EXISTS `hopitaux`;
CREATE TABLE IF NOT EXISTS `hopitaux` (
  `ID_hopital` int(11) NOT NULL AUTO_INCREMENT,
  `NOM_HOPITAL` varchar(25) NOT NULL DEFAULT '',
  `NOM_REGION` varchar(20) NOT NULL,
  PRIMARY KEY (`ID_hopital`),
  KEY `NOM_REGION` (`NOM_REGION`),
  KEY `NOM_HOPITAL` (`NOM_HOPITAL`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `hopitaux`
--

INSERT INTO `hopitaux` (`ID_hopital`, `NOM_HOPITAL`, `NOM_REGION`) VALUES
(1, 'Fahrat Hachad ', 'sousse  '),
(2, 'SAHLOUL', 'sousse  '),
(3, 'Fattouma bourguiba', 'Monastir '),
(4, 'Ibn el jazzar ', 'kairouan '),
(5, 'Les aghlabites', 'kairouan '),
(7, '7 novembre 1987 de msaken', 'sousse  '),
(8, 'Haj ali soua ksar hellal ', 'Monastir '),
(9, 'Moknine', 'Monastir '),
(10, 'Kalaa sghira', 'sousse  '),
(15, 'Enfidha ', 'sousse  '),
(16, 'Habib bayar  kalaa kebira', 'sousse  '),
(17, 'kalaa kebira', 'sousse  '),
(18, 'Sidi bou ali ', 'sousse  '),
(19, 'Bouficha', 'sousse  '),
(20, 'Bekalta', 'Monastir '),
(21, 'Bouhjar ', 'Monastir '),
(22, 'Jemmal ', 'Monastir '),
(23, 'Ksibet el mediouni ', 'Monastir '),
(24, 'Ouardanine', 'Monastir '),
(25, 'Sahline', 'Monastir '),
(26, 'Teboulba', 'Monastir '),
(27, 'Zeramdine', 'Monastir '),
(28, 'Bembla', 'Monastir '),
(29, 'Chebba', 'Mahdia '),
(30, 'Chorbane', 'Mahdia '),
(31, 'Ejem', 'Mahdia '),
(32, 'Hbira', 'Mahdia '),
(33, 'Ksour_essaf', 'Mahdia '),
(34, 'Melloulech', 'Mahdia '),
(35, 'Ouled_chamekh ', 'Mahdia '),
(36, 'Sidi_Alouane', 'Mahdia '),
(37, 'Souassi', 'Mahdia '),
(38, 'Boumerdes', 'Mahdia '),
(39, 'Bouhajla', 'kairouan '),
(40, 'Chebika', 'kairouan '),
(41, 'El_Ala', 'kairouan '),
(42, 'Haffouz', 'kairouan '),
(43, 'Hajeb_El_Ayoun', 'kairouan '),
(44, 'Nasrallah', 'kairouan '),
(45, 'Oueslatia', 'kairouan '),
(46, 'Sbikha', 'kairouan '),
(48, 'safa', 'Sousse'),
(49, 'SAFA', 'Sousse'),
(50, 'SAFA', 'Sousse');

-- --------------------------------------------------------

--
-- Structure de la table `intermédiaire`
--

DROP TABLE IF EXISTS `intermédiaire`;
CREATE TABLE IF NOT EXISTS `intermédiaire` (
  `intermédiaire` int(11) NOT NULL AUTO_INCREMENT,
  `ID_Demande` int(11) NOT NULL,
  `Id_équipement` int(11) NOT NULL,
  PRIMARY KEY (`intermédiaire`),
  KEY `ID_Demande` (`ID_Demande`),
  KEY `Id_équipement` (`Id_équipement`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `intervention_bistouri`
--

DROP TABLE IF EXISTS `intervention_bistouri`;
CREATE TABLE IF NOT EXISTS `intervention_bistouri` (
  `id_intervention` int(11) NOT NULL AUTO_INCREMENT,
  `Numero_intervention` varchar(30) NOT NULL,
  `Date_intervention` date NOT NULL,
  `Etat_intervention` varchar(30) NOT NULL,
  `Intervenant` varchar(30) NOT NULL,
  `typ_equipement` varchar(25) NOT NULL,
  `Test_securit_electrique` varchar(30) NOT NULL,
  `Test_des_modes` varchar(30) NOT NULL,
  `Commentaire` text NOT NULL,
  `Numero_demande` varchar(30) NOT NULL,
  `test_fuite_partie_active` varchar(30) NOT NULL,
  `test_fuite_partie_neutre` varchar(30) NOT NULL,
  `etat_equip` varchar(30) NOT NULL,
  PRIMARY KEY (`id_intervention`),
  KEY `Intervenant` (`Intervenant`),
  KEY `id_equipement` (`typ_equipement`),
  KEY `Numero_demande` (`Numero_demande`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `intervention_bistouri`
--

INSERT INTO `intervention_bistouri` (`id_intervention`, `Numero_intervention`, `Date_intervention`, `Etat_intervention`, `Intervenant`, `typ_equipement`, `Test_securit_electrique`, `Test_des_modes`, `Commentaire`, `Numero_demande`, `test_fuite_partie_active`, `test_fuite_partie_neutre`, `etat_equip`) VALUES
(1, 'fgtry/0056', '2019-05-12', 'En cours ', 'safa', 'btyu', 'Bon', 'Bon', 'ghytuo', 'gget', 'Mauvais', 'Bon', 'Mauvaise ');

-- --------------------------------------------------------

--
-- Structure de la table `intervention_defibrillateur`
--

DROP TABLE IF EXISTS `intervention_defibrillateur`;
CREATE TABLE IF NOT EXISTS `intervention_defibrillateur` (
  `id_defib` int(11) NOT NULL AUTO_INCREMENT,
  `Numero_intervention6` varchar(30) NOT NULL,
  `Date_intervention` date NOT NULL,
  `Etat_intervention` varchar(30) NOT NULL,
  `Intervenant` varchar(30) NOT NULL,
  `Test_securit_electrique` varchar(30) NOT NULL,
  `Test_indicateur_mode_synchro` varchar(30) NOT NULL,
  `Test_indicateur_mode_normale` varchar(30) NOT NULL,
  `Test_temps_charge` varchar(30) NOT NULL,
  `Testmesureenergie` varchar(100) NOT NULL,
  `Test_taux_de_perte` varchar(30) NOT NULL,
  `Testmoniteurecg` varchar(100) NOT NULL,
  `Testenregistrementpapier` varchar(30) NOT NULL,
  `Commentaire` text NOT NULL,
  `Numero_demande10` varchar(30) NOT NULL,
  `type_equip2` varchar(30) NOT NULL,
  `etat_equip25` varchar(30) NOT NULL,
  PRIMARY KEY (`id_defib`),
  KEY `intervention_défibrillateur_ibfk_2` (`Numero_demande10`),
  KEY `intervention_défibrillateur_ibfk_3` (`Intervenant`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `intervention_defibrillateur`
--

INSERT INTO `intervention_defibrillateur` (`id_defib`, `Numero_intervention6`, `Date_intervention`, `Etat_intervention`, `Intervenant`, `Test_securit_electrique`, `Test_indicateur_mode_synchro`, `Test_indicateur_mode_normale`, `Test_temps_charge`, `Testmesureenergie`, `Test_taux_de_perte`, `Testmoniteurecg`, `Testenregistrementpapier`, `Commentaire`, `Numero_demande10`, `type_equip2`, `etat_equip25`) VALUES
(1, '0000', '2019-10-05', 'En cours ', 'safa', 'Mauvais ', 'Bon', 'Bon', 'Bon', 'Mauvais ', 'Bon', 'Bon', 'Mauvais ', 'dgdgdg', 'gget', 'ee', 'Bonne ');

-- --------------------------------------------------------

--
-- Structure de la table `intervention_pousse_seringe`
--

DROP TABLE IF EXISTS `intervention_pousse_seringe`;
CREATE TABLE IF NOT EXISTS `intervention_pousse_seringe` (
  `id_pousse` int(11) NOT NULL AUTO_INCREMENT,
  `numéro_intervention` varchar(30) NOT NULL,
  `date_intervention` date NOT NULL,
  `Etat_intervention` varchar(30) NOT NULL,
  `Intervenant` varchar(30) NOT NULL,
  `Test_sécurit_électrique` varchar(30) NOT NULL,
  `Test_performance_prémiere_voie` varchar(30) NOT NULL,
  `Test_performance_déuxieme_voie` varchar(30) NOT NULL,
  `Commentaire` text NOT NULL,
  `Numero_demande` varchar(30) NOT NULL,
  `etat_equip` varchar(30) NOT NULL,
  `num_ser_equip` varchar(30) NOT NULL,
  PRIMARY KEY (`id_pousse`),
  KEY `Intervenant` (`Intervenant`),
  KEY `Numero_demande` (`Numero_demande`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `intervention_pousse_seringe`
--

INSERT INTO `intervention_pousse_seringe` (`id_pousse`, `numéro_intervention`, `date_intervention`, `Etat_intervention`, `Intervenant`, `Test_sécurit_électrique`, `Test_performance_prémiere_voie`, `Test_performance_déuxieme_voie`, `Commentaire`, `Numero_demande`, `etat_equip`, `num_ser_equip`) VALUES
(5, 'jojfdl', '2019-08-12', 'en cour', 'anoir', 'bon', 'bon', 'bon', 'aaaaaa', 'gget', 'bon', '08975/ss'),
(6, 'jojfdl', '2019-08-12', 'En cours ', 'safa', 'Bonne ', 'Mauvais ', 'Bon ', 'gdnfg', 'gget', 'Mauvaise ', '08975/ss'),
(8, 'ggr', '2020-08-10', 'En cours ', 'anoir', 'Bonne ', 'Mauvais ', 'Mauvais ', 'gddjlmmjhhff', 'gget', 'Mauvaise ', '08975/11zz'),
(13, 'ze1001/44ss', '2019-08-25', 'En cours ', 'safa', 'Mauvaise ', 'Bon ', 'Mauvais ', 'dhjdf,qd', 'gget', 'Bonne ', '152/ss01');

-- --------------------------------------------------------

--
-- Structure de la table `intervention_respirateur`
--

DROP TABLE IF EXISTS `intervention_respirateur`;
CREATE TABLE IF NOT EXISTS `intervention_respirateur` (
  `ID_intervention_resp` int(11) NOT NULL AUTO_INCREMENT,
  `Numero_intervention` varchar(30) NOT NULL,
  `Date_intervention` date NOT NULL,
  `Intervenant` varchar(30) NOT NULL,
  `Numero_demande` varchar(30) NOT NULL,
  `type_equip` varchar(50) NOT NULL,
  `num_ser_interv` varchar(25) NOT NULL,
  `Etat_intervention` varchar(30) NOT NULL,
  `test_securite_electrique` varchar(30) NOT NULL,
  `test_vc` varchar(30) NOT NULL,
  `Etat_equip` varchar(30) NOT NULL,
  `test_oxygene` varchar(30) NOT NULL,
  `test_pc` varchar(30) NOT NULL,
  `test_vac` varchar(30) NOT NULL,
  `Commentaire` text NOT NULL,
  PRIMARY KEY (`ID_intervention_resp`),
  KEY `Intervenant` (`Intervenant`),
  KEY `Numero_demande` (`Numero_demande`),
  KEY `type_equip` (`type_equip`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `intervention_respirateur`
--

INSERT INTO `intervention_respirateur` (`ID_intervention_resp`, `Numero_intervention`, `Date_intervention`, `Intervenant`, `Numero_demande`, `type_equip`, `num_ser_interv`, `Etat_intervention`, `test_securite_electrique`, `test_vc`, `Etat_equip`, `test_oxygene`, `test_pc`, `test_vac`, `Commentaire`) VALUES
(1, '258/00s', '2019-09-10', 'anoir', 'gget', 'Respirateur d’anesthésie', 'jfjdysl', 'bonne', 'bon', 'bon', '', 'bon', 'bon', 'bon', 'jfhjdk'),
(4, 'hbjn,', '2019-09-10', 'anoir', 'gget', 'Respirateur d\'anesthèsie', 'ghhh/007', 'En cours ', 'Bon ', 'N\'existe pas ', 'Mauvaise ', 'Mauvais ', 'Bon ', 'Mauvais ', 'ghhikollk'),
(5, '123895/005a', '2019-08-12', 'anoir', 'gget', 'Respirateur de réanimation ', '08975/ss', 'En cours ', 'Mauvais ', 'Mauvais ', 'Mauvaise ', 'Mauvais ', 'Mauvais ', 'Bon ', 'gfhtekltu');

-- --------------------------------------------------------

--
-- Structure de la table `region`
--

DROP TABLE IF EXISTS `region`;
CREATE TABLE IF NOT EXISTS `region` (
  `ID_region` int(11) NOT NULL AUTO_INCREMENT,
  `NOM_REGION` varchar(20) NOT NULL DEFAULT 'Sousse ',
  PRIMARY KEY (`ID_region`),
  KEY `NOM_REGION` (`NOM_REGION`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `region`
--

INSERT INTO `region` (`ID_region`, `NOM_REGION`) VALUES
(3, 'kairouan '),
(2, 'Mahdia '),
(1, 'Monastir '),
(4, 'sousse  ');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `ID_SERVICE` int(11) NOT NULL AUTO_INCREMENT,
  `Nom_service` varchar(60) NOT NULL,
  PRIMARY KEY (`ID_SERVICE`),
  KEY `Nom_service` (`Nom_service`)
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`ID_SERVICE`, `Nom_service`) VALUES
(48, 'Anesthésie  réanimation '),
(46, 'Cardiologie'),
(32, 'Chirurgie cardio-vasculaire et thoracique '),
(35, 'Chirurgie viscérale et chirurgie générale '),
(58, 'd\'hématologie '),
(55, 'Dermatologie '),
(52, 'endocrinologie'),
(47, 'Gastro_entérologie '),
(42, 'Gynécologie obstétrique '),
(33, 'Hématologie '),
(51, 'Hémodialyse et rein artificiel '),
(45, 'Maladies infectieuses '),
(43, 'Médecine et chirurgie dentaire '),
(44, 'médecine interne '),
(57, 'Néonatologie '),
(50, 'Néphrologie '),
(41, 'Neurologie '),
(40, 'Ophtalmologie'),
(36, 'Orthopédie et de traumatologie '),
(39, 'Oto-rhino-laryngologie et de chirurgie maxillo-faciale'),
(56, 'Pédiatrie'),
(49, 'Pneumo_allergologie '),
(54, 'Psychiatrie'),
(53, 'Rhumatologie '),
(38, 'Urologie');

-- --------------------------------------------------------

--
-- Structure de la table `techniciens`
--

DROP TABLE IF EXISTS `techniciens`;
CREATE TABLE IF NOT EXISTS `techniciens` (
  `ID_Tech` int(11) NOT NULL AUTO_INCREMENT,
  `Nom_technicien` varchar(30) NOT NULL,
  `prenom_technicen` varchar(30) NOT NULL,
  `e_mail` varchar(30) NOT NULL,
  `password` varchar(40) NOT NULL,
  PRIMARY KEY (`ID_Tech`),
  KEY `Nom_technicien` (`Nom_technicien`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `techniciens`
--

INSERT INTO `techniciens` (`ID_Tech`, `Nom_technicien`, `prenom_technicen`, `e_mail`, `password`) VALUES
(2, 'anoir', 'anoir', 'aaa@eee.tt', 'anoir'),
(3, 'safa', 'chouk', 'choukk.safa@gmail.com', '123456789'),
(4, 'salah', 'ben salem', 'ch.sg@gmail.com', '1254389'),
(5, 'hilali', 'wissame', 'xx.zz@gmail.com', 'wissem123'),
(6, 'gtr', 'ghjhl', 'khe', 'jhr');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `demandes`
--
ALTER TABLE `demandes`
  ADD CONSTRAINT `demandes_ibfk_1` FOREIGN KEY (`region_demande`) REFERENCES `hopitaux` (`NOM_REGION`),
  ADD CONSTRAINT `demandes_ibfk_2` FOREIGN KEY (`Hopital_demande`) REFERENCES `hopitaux` (`NOM_HOPITAL`);

--
-- Contraintes pour la table `hopitaux`
--
ALTER TABLE `hopitaux`
  ADD CONSTRAINT `hopitaux_ibfk_1` FOREIGN KEY (`NOM_REGION`) REFERENCES `region` (`NOM_REGION`);

--
-- Contraintes pour la table `intermédiaire`
--
ALTER TABLE `intermédiaire`
  ADD CONSTRAINT `intermédiaire_ibfk_1` FOREIGN KEY (`ID_Demande`) REFERENCES `demandes` (`ID_DEMANDE`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `interventions_ibfk_2` FOREIGN KEY (`Id_équipement`) REFERENCES `equipements` (`ID_EQUIPEMENT`);

--
-- Contraintes pour la table `intervention_bistouri`
--
ALTER TABLE `intervention_bistouri`
  ADD CONSTRAINT `intervention_bistouri_ibfk_1` FOREIGN KEY (`Intervenant`) REFERENCES `techniciens` (`Nom_technicien`),
  ADD CONSTRAINT `intervention_bistouri_ibfk_3` FOREIGN KEY (`Numero_demande`) REFERENCES `demandes` (`Numéro_demande`);

--
-- Contraintes pour la table `intervention_defibrillateur`
--
ALTER TABLE `intervention_defibrillateur`
  ADD CONSTRAINT `intervention_defibrillateur_ibfk_2` FOREIGN KEY (`Numero_demande10`) REFERENCES `demandes` (`Numéro_demande`),
  ADD CONSTRAINT `intervention_defibrillateur_ibfk_3` FOREIGN KEY (`Intervenant`) REFERENCES `techniciens` (`Nom_technicien`);

--
-- Contraintes pour la table `intervention_pousse_seringe`
--
ALTER TABLE `intervention_pousse_seringe`
  ADD CONSTRAINT `intervention_pousse_seringe_ibfk_2` FOREIGN KEY (`Intervenant`) REFERENCES `techniciens` (`Nom_technicien`),
  ADD CONSTRAINT `intervention_pousse_seringe_ibfk_3` FOREIGN KEY (`Numero_demande`) REFERENCES `demandes` (`Numéro_demande`);

--
-- Contraintes pour la table `intervention_respirateur`
--
ALTER TABLE `intervention_respirateur`
  ADD CONSTRAINT `intervention_respirateur_ibfk_2` FOREIGN KEY (`Intervenant`) REFERENCES `techniciens` (`Nom_technicien`),
  ADD CONSTRAINT `intervention_respirateur_ibfk_3` FOREIGN KEY (`Numero_demande`) REFERENCES `demandes` (`Numéro_demande`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
