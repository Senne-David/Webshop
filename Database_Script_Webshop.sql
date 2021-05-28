-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema webshop_database
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema webshop_database
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `webshop_database` DEFAULT CHARACTER SET utf8 ;
USE `webshop_database` ;

-- -----------------------------------------------------
-- Table `webshop_database`.`klant`
-- -----------------------------------------------------
DROP TABLE IF EXISTS webshop_database.klant;
CREATE TABLE IF NOT EXISTS `webshop_database`.`klant` (
  `IDKlant` INT NOT NULL AUTO_INCREMENT,
  `Gebruikersnaam` VARCHAR(45) NOT NULL,
  `Paswoord` VARCHAR(45) NOT NULL,
  `Voornaam` VARCHAR(45) NOT NULL,
  `Achternaam` VARCHAR(45) NOT NULL,
  `Geboortedatum` VARCHAR(45) NULL DEFAULT NULL,
  `Postcode` INT NOT NULL,
  `Straat` VARCHAR(45) NOT NULL,
  `Huisnummer` INT NOT NULL,
  `E-mail` VARCHAR(45) NULL DEFAULT NULL,
  `Telefoonnummer` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`IDKlant`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;
INSERT INTO `webshop_database`.`klant` (`Gebruikersnaam`, `Paswoord`, `Voornaam`, `Achternaam`, `Geboortedatum`, `Postcode`, `Straat`, `Huisnummer`, `E-mail`, `Telefoonnummer`)
VALUES 
('david10', 'david123', 'senne', 'david', '04/09/2003', '2200', 'wuytsbergen', '8', 'senne.david@telenet.be', '0468/27.62.57'),
('verslype14', 'verslype123', 'robbe', 'verslype', '02/06/2003', '2222', 'wiekevorstplein', '8', 'robbe.verslype@telenet.be', '0468/30.42.96'),
('smeyers8', 'smeyers123', 'tom', 'smeyers', '08/08/2003', '2462', 'de bergen', '41', 'tom.smeyers@telenet.be', '0465/65.12.78');

-- -----------------------------------------------------
-- Table `webshop_database`.`product`
-- -----------------------------------------------------
DROP TABLE IF EXISTS webshop_database.product;
CREATE TABLE IF NOT EXISTS `webshop_database`.`product` (
  `IDProduct` INT NOT NULL AUTO_INCREMENT,
  `Productnaam` VARCHAR(45) NOT NULL,
  `ProductCategorie` VARCHAR(45) NOT NULL,
  `Omschrijving` VARCHAR(45) NULL DEFAULT NULL,
  `Prijs` DOUBLE NOT NULL,
  PRIMARY KEY (`IDProduct`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;
INSERT INTO `webshop_database`.`product` (`Productnaam`, `ProductCategorie`, `Omschrijving`, `Prijs`)
VALUES
('Jas', 'kleding', 'warme jas', '90'),
('bak stella', 'drank', 'bak met 24 flesjes stella', '16'),
('lasagne', 'voeding', 'opwarmlasagne', '5'),
('auto', 'speelgoed', 'speelgoedauto', '23'),
('iphone', 'electronica', 'iphone 8', '562');

-- -----------------------------------------------------
-- Table `webshop_database`.`verlanglijstje`
-- -----------------------------------------------------
DROP TABLE IF EXISTS webshop_database.verlanglijstje;
CREATE TABLE IF NOT EXISTS `webshop_database`.`verlanglijstje` (
  `IDVerlanglijstje` INT NOT NULL AUTO_INCREMENT,
  `FK_Product` INT NOT NULL,
  `FK_Klant` INT NOT NULL,
  PRIMARY KEY (`IDVerlanglijstje`),
  INDEX `fk_Verlanglijstje_Producten1_idx` (`FK_Product` ASC) VISIBLE,
  INDEX `fk_Verlanglijstje_Klanten1_idx` (`FK_Klant` ASC) VISIBLE,
  CONSTRAINT `fk_Verlanglijstje_Klanten1`
    FOREIGN KEY (`FK_Klant`)
    REFERENCES `webshop_database`.`klant` (`IDKlant`),
  CONSTRAINT `fk_Verlanglijstje_Producten1`
    FOREIGN KEY (`FK_Product`)
    REFERENCES `webshop_database`.`product` (`IDProduct`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;
INSERT INTO `webshop_database`.`verlanglijstje` (`FK_Product`, `FK_Klant`)
VALUES
('1', '1'),
('2', '1'),
('4', '3'),
('5', '2');

-- -----------------------------------------------------
-- Table `webshop_database`.`winkelwagen`
-- -----------------------------------------------------
DROP TABLE IF EXISTS webshop_database.winkelwagen;
CREATE TABLE IF NOT EXISTS `webshop_database`.`winkelwagen` (
  `IDWinkelwagen` INT NOT NULL AUTO_INCREMENT,
  `Datum` VARCHAR(45) NOT NULL,
  `Verzendkosten` VARCHAR(45) NOT NULL,
  `Kaartnummer` VARCHAR(45) NOT NULL,
  `Verzendmethode` VARCHAR(45) NOT NULL,
  `FK_Klant` INT NOT NULL,
  `afgerekend` INT NOT NULL DEFAULT '0',
  PRIMARY KEY (`IDWinkelwagen`),
  INDEX `fk_winkelwagen_klanten1_idx` (`FK_Klant` ASC) VISIBLE,
  CONSTRAINT `fk_winkelwagen_klanten1`
    FOREIGN KEY (`FK_Klant`)
    REFERENCES `webshop_database`.`klant` (`IDKlant`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;
INSERT INTO `webshop_database`.`winkelwagen` (`Datum`, `Verzendkosten`, `Kaartnummer`, `Verzendmethode`, `FK_Klant`, `afgerekend`) 
VALUES 
('28/02/2021', '5', 'BE123456789', 'bezorgen', '1', '1'),
('28/02/2021', '5', 'B145687235', 'bezorgen', '1', '0'),
('28/02/2021', '0', 'BE156892347', 'afhalen', '3', '1'),
('28/02/2021', '5', 'BE956324578', 'bezorgen', '2', '0'),
('28/02/2021', '0', 'BE546632989', 'afhalen', '1', '0');


-- -----------------------------------------------------
-- Table `webshop_database`.`winkelwagen_has_producten`
-- -----------------------------------------------------
DROP TABLE IF EXISTS webshop_database.winkelwagen_has_producten;
CREATE TABLE IF NOT EXISTS `webshop_database`.`winkelwagen_has_producten` (
  `IDProduct_In_Winkelwagen` INT NOT NULL AUTO_INCREMENT,
  `Aantal` INT NOT NULL,
  `FK_Product` INT NOT NULL,
  `FK_Winkelwagen` INT NOT NULL,
  PRIMARY KEY (`IDProduct_In_Winkelwagen`),
  INDEX `fk_Winkelwagen_has_Producten_Producten1_idx` (`FK_Product` ASC) VISIBLE,
  INDEX `fk_Winkelwagen_has_Producten_Winkelwagen1_idx` (`FK_Winkelwagen` ASC) VISIBLE,
  CONSTRAINT `fk_Winkelwagen_has_Producten_Producten1`
    FOREIGN KEY (`FK_Product`)
    REFERENCES `webshop_database`.`product` (`IDProduct`),
  CONSTRAINT `fk_Winkelwagen_has_Producten_Winkelwagen1`
    FOREIGN KEY (`FK_Winkelwagen`)
    REFERENCES `webshop_database`.`winkelwagen` (`IDWinkelwagen`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8;
INSERT INTO `webshop_database`.`winkelwagen_has_producten` (`Aantal`, `FK_Product`, `FK_Winkelwagen`)
VALUES
('2', '2', '1'),
('10', '3', '1'),
('5', '1', '3'),
('1', '5', '1'),
('1', '4', '4');

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
