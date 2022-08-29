SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `final_inventory_system` DEFAULT CHARACTER SET utf8 ;
USE `final_inventory_system` ;

-- -----------------------------------------------------
-- Table `final_inventory_system`.`customer`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `final_inventory_system`.`customer` (
  `cus_id` INT(11) NOT NULL AUTO_INCREMENT ,
  `cus_amount_paid` INT(11) NOT NULL ,
  `cus_date` DATE NOT NULL ,
  PRIMARY KEY (`cus_id`) )
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `final_inventory_system`.`items`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `final_inventory_system`.`items` (
  `item_id` INT(11) NOT NULL AUTO_INCREMENT ,
  `item_name` VARCHAR(45) NOT NULL ,
  `item_unit` VARCHAR(45) NOT NULL ,
  `item_cost_in_unit` INT(11) NOT NULL ,
  `item_pc_per_pack` VARCHAR(45) NOT NULL ,
  `item_cost_per_pc` INT(11) NOT NULL ,
  `item_quantity` INT(11) NOT NULL ,
  `item_selling_cost` INT(11) NOT NULL ,
  PRIMARY KEY (`item_id`) )
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `final_inventory_system`.`supplier`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `final_inventory_system`.`supplier` (
  `sup_id` INT(11) NOT NULL AUTO_INCREMENT ,
  `sup_name` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`sup_id`) )
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `final_inventory_system`.`item_supplier`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `final_inventory_system`.`item_supplier` (
  `is_id` INT(11) NOT NULL AUTO_INCREMENT ,
  `item_id` INT(11) NOT NULL ,
  `sup_id` INT(11) NOT NULL ,
  `quantity` INT(11) NOT NULL ,
  `date_purchased` DATE NOT NULL ,
  PRIMARY KEY (`is_id`, `item_id`, `sup_id`) ,
  INDEX `fk_item_supplier_items1_idx` (`item_id` ASC) ,
  INDEX `fk_item_supplier_supplier1_idx` (`sup_id` ASC) ,
  CONSTRAINT `fk_item_supplier_items1`
    FOREIGN KEY (`item_id` )
    REFERENCES `final_inventory_system`.`items` (`item_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_item_supplier_supplier1`
    FOREIGN KEY (`sup_id` )
    REFERENCES `final_inventory_system`.`supplier` (`sup_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `final_inventory_system`.`manager_login`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `final_inventory_system`.`manager_login` (
  `man_id` INT(11) NOT NULL AUTO_INCREMENT ,
  `username` VARCHAR(45) NOT NULL ,
  `password` VARCHAR(45) BINARY NOT NULL ,
  PRIMARY KEY (`man_id`) )
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `final_inventory_system`.`manager_monitoring`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `final_inventory_system`.`manager_monitoring` (
  `mm_id` INT(11) NOT NULL AUTO_INCREMENT ,
  `show_date` DATE NOT NULL ,
  `total_expense` INT(11) NOT NULL ,
  `total_revenue` INT(11) NOT NULL ,
  `man_id` INT(11) NOT NULL ,
  PRIMARY KEY (`mm_id`, `man_id`) ,
  INDEX `fk_manager_monitoring_manager_login_idx` (`man_id` ASC) ,
  CONSTRAINT `fk_manager_monitoring_manager_login`
    FOREIGN KEY (`man_id` )
    REFERENCES `final_inventory_system`.`manager_login` (`man_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `final_inventory_system`.`manager_supplier`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `final_inventory_system`.`manager_supplier` (
  `ms_id` INT(11) NOT NULL AUTO_INCREMENT ,
  `man_id` INT(11) NOT NULL ,
  `sup_id` INT(11) NOT NULL ,
  `item` VARCHAR(45) NOT NULL ,
  `purchase_date` DATE NOT NULL ,
  `quantity` INT(11) NOT NULL ,
  `total_amount` INT(11) NOT NULL ,
  PRIMARY KEY (`ms_id`, `man_id`, `sup_id`) ,
  INDEX `fk_manager_supplier_manager_login1_idx` (`man_id` ASC) ,
  INDEX `fk_manager_supplier_supplier1_idx` (`sup_id` ASC) ,
  CONSTRAINT `fk_manager_supplier_manager_login1`
    FOREIGN KEY (`man_id` )
    REFERENCES `final_inventory_system`.`manager_login` (`man_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_manager_supplier_supplier1`
    FOREIGN KEY (`sup_id` )
    REFERENCES `final_inventory_system`.`supplier` (`sup_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `final_inventory_system`.`product`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `final_inventory_system`.`product` (
  `prod_id` INT(11) NOT NULL AUTO_INCREMENT ,
  `prod_name` VARCHAR(45) NOT NULL ,
  `prod_quantity` VARCHAR(45) NOT NULL ,
  `prod_date` DATE NOT NULL ,
  PRIMARY KEY (`prod_id`) )
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `final_inventory_system`.`prod_cus`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `final_inventory_system`.`prod_cus` (
  `prod_cus_id` INT(11) NOT NULL AUTO_INCREMENT ,
  `prod_id` INT(11) NOT NULL ,
  `cus_id` INT(11) NOT NULL ,
  `prod_name` VARCHAR(45) NOT NULL ,
  `prod_quantity` INT NOT NULL ,
  `cus_amount_paid` INT NOT NULL ,
  `date_purchased` DATE NOT NULL ,
  PRIMARY KEY (`prod_cus_id`, `prod_id`, `cus_id`) ,
  INDEX `fk_prod_cus_product1_idx` (`prod_id` ASC) ,
  INDEX `fk_prod_cus_customer1_idx` (`cus_id` ASC) ,
  CONSTRAINT `fk_prod_cus_customer1`
    FOREIGN KEY (`cus_id` )
    REFERENCES `final_inventory_system`.`customer` (`cus_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_prod_cus_product1`
    FOREIGN KEY (`prod_id` )
    REFERENCES `final_inventory_system`.`product` (`prod_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `final_inventory_system`.`product_items`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `final_inventory_system`.`product_items` (
  `pi_id` INT(11) NOT NULL AUTO_INCREMENT ,
  `prod_id` INT(11) NOT NULL ,
  `item_id` INT(11) NOT NULL ,
  PRIMARY KEY (`pi_id`, `prod_id`, `item_id`) ,
  INDEX `fk_product_items_product1_idx` (`prod_id` ASC) ,
  INDEX `fk_product_items_items1_idx` (`item_id` ASC) ,
  CONSTRAINT `fk_product_items_items1`
    FOREIGN KEY (`item_id` )
    REFERENCES `final_inventory_system`.`items` (`item_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_product_items_product1`
    FOREIGN KEY (`prod_id` )
    REFERENCES `final_inventory_system`.`product` (`prod_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `final_inventory_system`.`storekeeper_login`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `final_inventory_system`.`storekeeper_login` (
  `sk_id` INT(11) NOT NULL AUTO_INCREMENT ,
  `username` VARCHAR(45) NOT NULL ,
  `password` VARCHAR(45) BINARY NOT NULL ,
  `man_id` INT(11) NOT NULL ,
  PRIMARY KEY (`sk_id`, `man_id`) ,
  INDEX `fk_storekeeper_login_manager_login1_idx` (`man_id` ASC) ,
  CONSTRAINT `fk_storekeeper_login_manager_login1`
    FOREIGN KEY (`man_id` )
    REFERENCES `final_inventory_system`.`manager_login` (`man_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `final_inventory_system`.`sk_product`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `final_inventory_system`.`sk_product` (
  `skp_id` INT(11) NOT NULL AUTO_INCREMENT ,
  `sk_id` INT(11) NOT NULL ,
  `prod_id` INT(11) NOT NULL ,
  `prod_name` VARCHAR(45) NOT NULL ,
  `prod_quantity` INT NOT NULL ,
  `prod_date` DATE NOT NULL ,
  PRIMARY KEY (`skp_id`, `sk_id`, `prod_id`) ,
  INDEX `fk_sk_product_storekeeper_login1_idx` (`sk_id` ASC) ,
  INDEX `fk_sk_product_product1_idx` (`prod_id` ASC) ,
  CONSTRAINT `fk_sk_product_product1`
    FOREIGN KEY (`prod_id` )
    REFERENCES `final_inventory_system`.`product` (`prod_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_sk_product_storekeeper_login1`
    FOREIGN KEY (`sk_id` )
    REFERENCES `final_inventory_system`.`storekeeper_login` (`sk_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `final_inventory_system`.`sk_items`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `final_inventory_system`.`sk_items` (
  `ski_id` INT NOT NULL AUTO_INCREMENT ,
  `sk_id` INT(11) NOT NULL ,
  `item_id` INT(11) NOT NULL ,
  `item_name` VARCHAR(45) NOT NULL ,
  `used_for` VARCHAR(45) NOT NULL ,
  `quantity_used` INT NOT NULL ,
  `date_used` DATE NOT NULL ,
  PRIMARY KEY (`ski_id`, `sk_id`, `item_id`) ,
  INDEX `fk_sk_items_storekeeper_login1_idx` (`sk_id` ASC) ,
  INDEX `fk_sk_items_items1_idx` (`item_id` ASC) ,
  CONSTRAINT `fk_sk_items_storekeeper_login1`
    FOREIGN KEY (`sk_id` )
    REFERENCES `final_inventory_system`.`storekeeper_login` (`sk_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_sk_items_items1`
    FOREIGN KEY (`item_id` )
    REFERENCES `final_inventory_system`.`items` (`item_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `final_inventory_system` ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
