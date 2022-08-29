SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';


-- -----------------------------------------------------
-- Table `inventory_system`.`manager_monitoring`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `inventory_system`.`manager_monitoring` (
  `ID` INT NOT NULL AUTO_INCREMENT ,
  `show_date` DATE NOT NULL ,
  `total_expense` INT NOT NULL ,
  `total_revenue` INT NOT NULL ,
  PRIMARY KEY (`ID`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `inventory_system`.`manager_login`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `inventory_system`.`manager_login` (
  `man_id` INT NOT NULL AUTO_INCREMENT ,
  `username` VARCHAR(45) BINARY NULL ,
  `password` VARCHAR(45) BINARY NULL ,
  `manager_monitoring_ID` INT NOT NULL ,
  PRIMARY KEY (`man_id`, `manager_monitoring_ID`) ,
  INDEX `fk_manager_login_manager_monitoring1_idx` (`manager_monitoring_ID` ASC) ,
  CONSTRAINT `fk_manager_login_manager_monitoring1`
    FOREIGN KEY (`manager_monitoring_ID` )
    REFERENCES `inventory_system`.`manager_monitoring` (`ID` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `inventory_system`.`storekeeper_login`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `inventory_system`.`storekeeper_login` (
  `sk_id` INT NOT NULL AUTO_INCREMENT ,
  `username` VARCHAR(45) BINARY NULL ,
  `password` VARCHAR(45) BINARY NULL ,
  `man_id` INT NOT NULL ,
  PRIMARY KEY (`sk_id`, `man_id`) ,
  INDEX `fk_storekeeper_login_manager_login_idx` (`man_id` ASC) ,
  CONSTRAINT `fk_storekeeper_login_manager_login`
    FOREIGN KEY (`man_id` )
    REFERENCES `inventory_system`.`manager_login` (`man_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `inventory_system`.`product`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `inventory_system`.`product` (
  `prod_id` INT NOT NULL AUTO_INCREMENT ,
  `prod_name` VARCHAR(45) NOT NULL ,
  `prod_quantity` INT NOT NULL ,
  `prod_date` DATETIME NOT NULL ,
  PRIMARY KEY (`prod_id`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `inventory_system`.`customer`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `inventory_system`.`customer` (
  `cus_id` INT NOT NULL AUTO_INCREMENT ,
  `cus_amount_paid` INT NOT NULL ,
  `cus_date` DATETIME NOT NULL ,
  PRIMARY KEY (`cus_id`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `inventory_system`.`items`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `inventory_system`.`items` (
  `item_id` INT NOT NULL AUTO_INCREMENT ,
  `item_name` VARCHAR(45) NOT NULL ,
  `item_unit` VARCHAR(45) NOT NULL ,
  `item_cost_in_unit` INT NOT NULL ,
  `item_pc_per_pack` INT NOT NULL ,
  `item_cost_per_pc` INT NOT NULL ,
  `item_quantity` INT NOT NULL ,
  `item_selling_cost` INT NOT NULL ,
  `prod_id` INT NULL ,
  PRIMARY KEY (`item_id`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `inventory_system`.`supplier`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `inventory_system`.`supplier` (
  `sup_id` INT NOT NULL AUTO_INCREMENT ,
  `sup_name` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`sup_id`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `inventory_system`.`sk_product`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `inventory_system`.`sk_product` (
  `prod_id` INT NOT NULL ,
  `sk_id` INT NOT NULL ,
  PRIMARY KEY (`prod_id`, `sk_id`) ,
  INDEX `fk_product_has_storekeeper_login_storekeeper_login1_idx` (`sk_id` ASC) ,
  INDEX `fk_product_has_storekeeper_login_product1_idx` (`prod_id` ASC) ,
  CONSTRAINT `fk_product_has_storekeeper_login_product1`
    FOREIGN KEY (`prod_id` )
    REFERENCES `inventory_system`.`product` (`prod_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_product_has_storekeeper_login_storekeeper_login1`
    FOREIGN KEY (`sk_id` )
    REFERENCES `inventory_system`.`storekeeper_login` (`sk_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `inventory_system`.`product_items`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `inventory_system`.`product_items` (
  `prod_id` INT NOT NULL ,
  `item_id` INT NOT NULL ,
  `date_used` DATE NULL ,
  PRIMARY KEY (`prod_id`, `item_id`) ,
  INDEX `fk_product_has_items_items1_idx` (`item_id` ASC) ,
  INDEX `fk_product_has_items_product1_idx` (`prod_id` ASC) ,
  CONSTRAINT `fk_product_has_items_product1`
    FOREIGN KEY (`prod_id` )
    REFERENCES `inventory_system`.`product` (`prod_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_product_has_items_items1`
    FOREIGN KEY (`item_id` )
    REFERENCES `inventory_system`.`items` (`item_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `inventory_system`.`product_customer`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `inventory_system`.`product_customer` (
  `prod_id` INT NOT NULL ,
  `cus_id` INT NOT NULL ,
  PRIMARY KEY (`prod_id`, `cus_id`) ,
  INDEX `fk_product_has_customer_customer1_idx` (`cus_id` ASC) ,
  INDEX `fk_product_has_customer_product1_idx` (`prod_id` ASC) ,
  CONSTRAINT `fk_product_has_customer_product1`
    FOREIGN KEY (`prod_id` )
    REFERENCES `inventory_system`.`product` (`prod_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_product_has_customer_customer1`
    FOREIGN KEY (`cus_id` )
    REFERENCES `inventory_system`.`customer` (`cus_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `inventory_system`.`item_supplier`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `inventory_system`.`item_supplier` (
  `id` INT NOT NULL AUTO_INCREMENT ,
  `item_id` INT NOT NULL ,
  `sup_id` INT NOT NULL ,
  `quantity` INT NOT NULL ,
  `date_purchased` DATE NOT NULL ,
  PRIMARY KEY (`id`, `item_id`, `sup_id`) ,
  INDEX `fk_items_has_supplier_supplier1_idx` (`sup_id` ASC) ,
  INDEX `fk_items_has_supplier_items1_idx` (`item_id` ASC) ,
  CONSTRAINT `fk_items_has_supplier_items1`
    FOREIGN KEY (`item_id` )
    REFERENCES `inventory_system`.`items` (`item_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_items_has_supplier_supplier1`
    FOREIGN KEY (`sup_id` )
    REFERENCES `inventory_system`.`supplier` (`sup_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `inventory_system`.`manager_supplier`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `inventory_system`.`manager_supplier` (
  `man_id` INT NOT NULL ,
  `sup_id` INT NOT NULL ,
  `item` VARCHAR(45) NOT NULL ,
  `purchase_date` DATE NOT NULL ,
  `quantity` INT NOT NULL ,
  `total_amount` INT NOT NULL ,
  PRIMARY KEY (`man_id`, `sup_id`) ,
  INDEX `fk_manager_login_has_supplier_supplier1_idx` (`sup_id` ASC) ,
  INDEX `fk_manager_login_has_supplier_manager_login1_idx` (`man_id` ASC) ,
  CONSTRAINT `fk_manager_login_has_supplier_manager_login1`
    FOREIGN KEY (`man_id` )
    REFERENCES `inventory_system`.`manager_login` (`man_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_manager_login_has_supplier_supplier1`
    FOREIGN KEY (`sup_id` )
    REFERENCES `inventory_system`.`supplier` (`sup_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
