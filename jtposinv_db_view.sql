/*
SQLyog Community v13.1.9 (64 bit)
MySQL - 10.5.5-MariaDB : Database - posinv_db
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`posinv_db` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `posinv_db`;

/*Table structure for table `cancelled_orders` */

DROP TABLE IF EXISTS `cancelled_orders`;

/*!50001 DROP VIEW IF EXISTS `cancelled_orders` */;
/*!50001 DROP TABLE IF EXISTS `cancelled_orders` */;

/*!50001 CREATE TABLE  `cancelled_orders`(
 `cID` int(11) ,
 `userID` int(11) ,
 `invoice` varchar(50) ,
 `productName` varchar(200) ,
 `price` decimal(10,2) ,
 `qty` int(11) ,
 `unit` varchar(50) ,
 `total` decimal(10,2) ,
 `sdate` date ,
 `fullname` varchar(200) ,
 `remarks` varchar(200) 
)*/;

/*Table structure for table `expenses` */

DROP TABLE IF EXISTS `expenses`;

/*!50001 DROP VIEW IF EXISTS `expenses` */;
/*!50001 DROP TABLE IF EXISTS `expenses` */;

/*!50001 CREATE TABLE  `expenses`(
 `id` int(11) ,
 `expID` int(11) ,
 `description` varchar(200) ,
 `amount` decimal(10,2) ,
 `edate` date ,
 `fullname` varchar(200) ,
 `deleted` tinyint(4) 
)*/;

/*Table structure for table `expiry_products` */

DROP TABLE IF EXISTS `expiry_products`;

/*!50001 DROP VIEW IF EXISTS `expiry_products` */;
/*!50001 DROP TABLE IF EXISTS `expiry_products` */;

/*!50001 CREATE TABLE  `expiry_products`(
 `prodID` int(11) ,
 `id` int(11) ,
 `referenceNo` varchar(200) ,
 `productName` varchar(200) ,
 `dateArrival` date ,
 `dateStockin` date ,
 `dateExpiry` date ,
 `onhand` int(11) ,
 `unitCode` varchar(50) ,
 `nDaysBExp` int(7) ,
 `stock_by` varchar(200) 
)*/;

/*Table structure for table `inventory` */

DROP TABLE IF EXISTS `inventory`;

/*!50001 DROP VIEW IF EXISTS `inventory` */;
/*!50001 DROP TABLE IF EXISTS `inventory` */;

/*!50001 CREATE TABLE  `inventory`(
 `prodID` int(11) ,
 `productName` varchar(200) ,
 `hasExpiry` tinyint(1) ,
 `reorder` int(11) ,
 `brand` varchar(200) ,
 `category` varchar(200) ,
 `onhand` decimal(32,0) ,
 `totalQtyPurchase` decimal(32,0) ,
 `totalAmntPurchase` decimal(42,2) ,
 `balance` decimal(42,2) ,
 `baseUnit` varchar(50) ,
 `ugID` int(11) ,
 `qty` double 
)*/;

/*Table structure for table `monthly_purchase` */

DROP TABLE IF EXISTS `monthly_purchase`;

/*!50001 DROP VIEW IF EXISTS `monthly_purchase` */;
/*!50001 DROP TABLE IF EXISTS `monthly_purchase` */;

/*!50001 CREATE TABLE  `monthly_purchase`(
 `totalPurchase` decimal(42,2) ,
 `mo` varchar(32) 
)*/;

/*Table structure for table `productpricelist` */

DROP TABLE IF EXISTS `productpricelist`;

/*!50001 DROP VIEW IF EXISTS `productpricelist` */;
/*!50001 DROP TABLE IF EXISTS `productpricelist` */;

/*!50001 CREATE TABLE  `productpricelist`(
 `prcID` int(11) ,
 `barcode` varchar(200) ,
 `prodID` int(11) ,
 `variant` varchar(200) ,
 `price` decimal(10,2) ,
 `sprice` decimal(10,2) ,
 `isSale` tinyint(1) ,
 `dateFrm` date ,
 `dateTo` date ,
 `productName` varchar(200) ,
 `onhand` decimal(32,0) ,
 `hasExpiry` tinyint(1) ,
 `reorder` int(11) ,
 `pUnit` varchar(50) ,
 `prUnit` varchar(50) ,
 `prQty` double 
)*/;

/*Table structure for table `sold_items` */

DROP TABLE IF EXISTS `sold_items`;

/*!50001 DROP VIEW IF EXISTS `sold_items` */;
/*!50001 DROP TABLE IF EXISTS `sold_items` */;

/*!50001 CREATE TABLE  `sold_items`(
 `catID` int(11) ,
 `userID` int(11) ,
 `prodID` int(11) ,
 `invoice` varchar(50) ,
 `productName` varchar(200) ,
 `isSale` tinyint(1) ,
 `price` decimal(10,2) ,
 `qty` int(11) ,
 `unit` varchar(50) ,
 `pUnit` varchar(50) ,
 `bQtyItem` double ,
 `total` decimal(10,2) ,
 `disc` decimal(10,2) ,
 `sdate` date ,
 `fullname` varchar(200) 
)*/;

/*Table structure for table `stockin` */

DROP TABLE IF EXISTS `stockin`;

/*!50001 DROP VIEW IF EXISTS `stockin` */;
/*!50001 DROP TABLE IF EXISTS `stockin` */;

/*!50001 CREATE TABLE  `stockin`(
 `stockID` int(11) ,
 `catID` int(11) ,
 `supplierID` int(11) ,
 `referenceNo` varchar(200) ,
 `prodID` int(11) ,
 `productName` varchar(200) ,
 `dateStockin` date ,
 `dateArrival` date ,
 `ExpiryDate` varchar(14) ,
 `qty` int(11) ,
 `unitCode` varchar(50) ,
 `purchasePrice` decimal(10,2) ,
 `totalAmntPurchase` decimal(20,2) ,
 `qtySold` bigint(13) ,
 `totalAmntSold` decimal(22,2) ,
 `qtyDmg` int(11) ,
 `totalLoss` decimal(20,2) ,
 `onhand` int(11) ,
 `totalBalance` decimal(20,2) ,
 `stock_by` varchar(200) ,
 `supplier` varchar(200) 
)*/;

/*Table structure for table `stock_adjustment` */

DROP TABLE IF EXISTS `stock_adjustment`;

/*!50001 DROP VIEW IF EXISTS `stock_adjustment` */;
/*!50001 DROP TABLE IF EXISTS `stock_adjustment` */;

/*!50001 CREATE TABLE  `stock_adjustment`(
 `referenceNo` varchar(200) ,
 `productName` varchar(200) ,
 `qty` double ,
 `datelogs` date ,
 `action` varchar(50) ,
 `remarks` varchar(200) ,
 `fullname` varchar(200) 
)*/;

/*Table structure for table `topsell_month` */

DROP TABLE IF EXISTS `topsell_month`;

/*!50001 DROP VIEW IF EXISTS `topsell_month` */;
/*!50001 DROP TABLE IF EXISTS `topsell_month` */;

/*!50001 CREATE TABLE  `topsell_month`(
 `productName` varchar(200) ,
 `sales` decimal(32,2) 
)*/;

/*Table structure for table `units` */

DROP TABLE IF EXISTS `units`;

/*!50001 DROP VIEW IF EXISTS `units` */;
/*!50001 DROP TABLE IF EXISTS `units` */;

/*!50001 CREATE TABLE  `units`(
 `id` int(11) ,
 `unitID` int(11) ,
 `prodID` int(11) ,
 `qty` double ,
 `deleted` tinyint(1) ,
 `defaultUnit` tinyint(4) ,
 `unitCode` varchar(50) ,
 `unitDesc` varchar(100) 
)*/;

/*Table structure for table `year_sales` */

DROP TABLE IF EXISTS `year_sales`;

/*!50001 DROP VIEW IF EXISTS `year_sales` */;
/*!50001 DROP TABLE IF EXISTS `year_sales` */;

/*!50001 CREATE TABLE  `year_sales`(
 `total` decimal(32,2) ,
 `yr` varchar(4) 
)*/;

/*View structure for view cancelled_orders */

/*!50001 DROP TABLE IF EXISTS `cancelled_orders` */;
/*!50001 DROP VIEW IF EXISTS `cancelled_orders` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `cancelled_orders` AS select `c`.`id` AS `cID`,`c`.`userID` AS `userID`,`c`.`invoice` AS `invoice`,`pr`.`productName` AS `productName`,`c`.`price` AS `price`,`c`.`qty` AS `qty`,`c`.`unit` AS `unit`,`c`.`total` AS `total`,`c`.`sdate` AS `sdate`,`u`.`fullname` AS `fullname`,`c`.`remarks` AS `remarks` from ((`tbl_cancelled_order` `c` join `productpricelist` `pr` on(`pr`.`prcID` = `c`.`prID`)) join `tbl_user` `u` on(`u`.`id` = `c`.`userID`)) order by `c`.`sdate` */;

/*View structure for view expenses */

/*!50001 DROP TABLE IF EXISTS `expenses` */;
/*!50001 DROP VIEW IF EXISTS `expenses` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `expenses` AS select `ex`.`id` AS `id`,`ex`.`expID` AS `expID`,`e`.`description` AS `description`,`ex`.`amount` AS `amount`,`ex`.`edate` AS `edate`,`u`.`fullname` AS `fullname`,`ex`.`deleted` AS `deleted` from ((`tbl_expenses` `ex` join `tbl_expenses_cat` `e` on(`e`.`id` = `ex`.`expID`)) join `tbl_user` `u` on(`u`.`id` = `ex`.`userID`)) */;

/*View structure for view expiry_products */

/*!50001 DROP TABLE IF EXISTS `expiry_products` */;
/*!50001 DROP VIEW IF EXISTS `expiry_products` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `expiry_products` AS select `p`.`id` AS `prodID`,`s`.`id` AS `id`,`s`.`referenceNo` AS `referenceNo`,`p`.`productName` AS `productName`,`s`.`dateArrival` AS `dateArrival`,`s`.`dateStockin` AS `dateStockin`,`s`.`dateExpiry` AS `dateExpiry`,`s`.`onhand` AS `onhand`,`units`.`unitCode` AS `unitCode`,to_days(`s`.`dateExpiry`) - to_days(current_timestamp()) AS `nDaysBExp`,`u`.`fullname` AS `stock_by` from (((`tbl_stockin` `s` join `tbl_product` `p` on(`p`.`id` = `s`.`prodID`)) join `units` on(`units`.`id` = `p`.`ugID`)) join `tbl_user` `u` on(`u`.`id` = `s`.`userID`)) where to_days(`s`.`dateExpiry`) - to_days(current_timestamp()) <= `p`.`dayBExpiry` and `p`.`hasExpiry` = 1 and `s`.`onhand` > 0 */;

/*View structure for view inventory */

/*!50001 DROP TABLE IF EXISTS `inventory` */;
/*!50001 DROP VIEW IF EXISTS `inventory` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventory` AS select `tbl_product`.`id` AS `prodID`,`tbl_product`.`productName` AS `productName`,`tbl_product`.`hasExpiry` AS `hasExpiry`,`tbl_product`.`reorder` AS `reorder`,`tbl_brand`.`brand` AS `brand`,`tbl_category`.`category` AS `category`,sum(`tbl_stockin`.`onhand`) AS `onhand`,sum(`tbl_stockin`.`qty`) AS `totalQtyPurchase`,sum(`tbl_stockin`.`qty` * `tbl_stockin`.`purchasePrice`) AS `totalAmntPurchase`,sum(`tbl_stockin`.`onhand` * `tbl_stockin`.`purchasePrice`) AS `balance`,`units`.`unitCode` AS `baseUnit`,`units`.`id` AS `ugID`,`units`.`qty` AS `qty` from ((((`tbl_product` join `tbl_stockin` on(`tbl_stockin`.`prodID` = `tbl_product`.`id`)) join `tbl_brand` on(`tbl_brand`.`id` = `tbl_product`.`brandID`)) join `tbl_category` on(`tbl_category`.`id` = `tbl_product`.`catID`)) join `units` on(`units`.`id` = `tbl_product`.`ugID`)) where `tbl_product`.`deleted` = 0 group by `tbl_stockin`.`prodID` order by `tbl_brand`.`brand`,`tbl_product`.`productName` */;

/*View structure for view monthly_purchase */

/*!50001 DROP TABLE IF EXISTS `monthly_purchase` */;
/*!50001 DROP VIEW IF EXISTS `monthly_purchase` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `monthly_purchase` AS select sum(`stockin`.`purchasePrice` * `stockin`.`qty`) AS `totalPurchase`,date_format(`stockin`.`dateArrival`,'%b') AS `mo` from `stockin` where date_format(`stockin`.`dateArrival`,'%Y') = date_format(curdate(),'%Y') group by month(`stockin`.`dateArrival`) */;

/*View structure for view productpricelist */

/*!50001 DROP TABLE IF EXISTS `productpricelist` */;
/*!50001 DROP VIEW IF EXISTS `productpricelist` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `productpricelist` AS select `pr`.`id` AS `prcID`,`pr`.`barcode` AS `barcode`,`pr`.`prodID` AS `prodID`,`pr`.`variant` AS `variant`,`pr`.`price` AS `price`,`pr`.`sprice` AS `sprice`,`pr`.`isSale` AS `isSale`,`pr`.`dateFrm` AS `dateFrm`,`pr`.`dateTo` AS `dateTo`,`inv`.`productName` AS `productName`,`inv`.`onhand` AS `onhand`,`inv`.`hasExpiry` AS `hasExpiry`,`inv`.`reorder` AS `reorder`,`pu`.`unitCode` AS `pUnit`,`u`.`unitCode` AS `prUnit`,`u`.`qty` AS `prQty` from (((`tbl_pricing` `pr` join `inventory` `inv` on(`inv`.`prodID` = `pr`.`prodID`)) join `units` `u` on(`u`.`id` = `pr`.`ugID`)) join `units` `pu` on(`pu`.`id` = `inv`.`ugID`)) order by `inv`.`productName`,`pr`.`variant` */;

/*View structure for view sold_items */

/*!50001 DROP TABLE IF EXISTS `sold_items` */;
/*!50001 DROP VIEW IF EXISTS `sold_items` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `sold_items` AS select `c`.`id` AS `catID`,`c`.`userID` AS `userID`,`pr`.`prodID` AS `prodID`,`c`.`invoice` AS `invoice`,`pr`.`productName` AS `productName`,`c`.`isSale` AS `isSale`,`c`.`price` AS `price`,`c`.`qty` AS `qty`,`c`.`unit` AS `unit`,`pr`.`pUnit` AS `pUnit`,`c`.`qty` * `pr`.`prQty` AS `bQtyItem`,`c`.`total` AS `total`,`c`.`disc` AS `disc`,`c`.`sdate` AS `sdate`,`u`.`fullname` AS `fullname` from ((`tbl_cart` `c` join `productpricelist` `pr` on(`pr`.`prcID` = `c`.`prID`)) join `tbl_user` `u` on(`u`.`id` = `c`.`userID`)) */;

/*View structure for view stockin */

/*!50001 DROP TABLE IF EXISTS `stockin` */;
/*!50001 DROP VIEW IF EXISTS `stockin` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `stockin` AS select `s`.`id` AS `stockID`,`cat`.`id` AS `catID`,`sp`.`id` AS `supplierID`,`s`.`referenceNo` AS `referenceNo`,`s`.`prodID` AS `prodID`,`p`.`productName` AS `productName`,`s`.`dateStockin` AS `dateStockin`,`s`.`dateArrival` AS `dateArrival`,case when `p`.`hasExpiry` = 1 then `s`.`dateExpiry` else 'No Expiry Date' end AS `ExpiryDate`,`s`.`qty` AS `qty`,`units`.`unitCode` AS `unitCode`,`s`.`purchasePrice` AS `purchasePrice`,`s`.`qty` * `s`.`purchasePrice` AS `totalAmntPurchase`,`s`.`qty` - `s`.`onhand` - `s`.`qtyDmg` AS `qtySold`,(`s`.`qty` - `s`.`onhand` - `s`.`qtyDmg`) * `s`.`purchasePrice` AS `totalAmntSold`,`s`.`qtyDmg` AS `qtyDmg`,`s`.`qtyDmg` * `s`.`purchasePrice` AS `totalLoss`,`s`.`onhand` AS `onhand`,`s`.`onhand` * `s`.`purchasePrice` AS `totalBalance`,`u`.`fullname` AS `stock_by`,`sp`.`businessName` AS `supplier` from (((((`tbl_stockin` `s` join `tbl_product` `p` on(`p`.`id` = `s`.`prodID`)) join `tbl_supplier` `sp` on(`sp`.`id` = `s`.`supplierID`)) join `tbl_user` `u` on(`u`.`id` = `s`.`userID`)) join `units` on(`units`.`id` = `p`.`ugID`)) join `tbl_category` `cat` on(`cat`.`id` = `p`.`catID`)) */;

/*View structure for view stock_adjustment */

/*!50001 DROP TABLE IF EXISTS `stock_adjustment` */;
/*!50001 DROP VIEW IF EXISTS `stock_adjustment` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `stock_adjustment` AS select `s`.`referenceNo` AS `referenceNo`,`p`.`productName` AS `productName`,`slogs`.`qty` AS `qty`,`slogs`.`datelogs` AS `datelogs`,`slogs`.`action` AS `action`,`slogs`.`remarks` AS `remarks`,`u`.`fullname` AS `fullname` from (((`tbl_stockinlogs` `slogs` join `tbl_stockin` `s` on(`s`.`id` = `slogs`.`stockinID`)) join `tbl_product` `p` on(`p`.`id` = `s`.`prodID`)) join `tbl_user` `u` on(`u`.`id` = `slogs`.`userID`)) */;

/*View structure for view topsell_month */

/*!50001 DROP TABLE IF EXISTS `topsell_month` */;
/*!50001 DROP VIEW IF EXISTS `topsell_month` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `topsell_month` AS select `pr`.`productName` AS `productName`,sum(`c`.`total`) AS `sales` from (`tbl_cart` `c` join `productpricelist` `pr` on(`pr`.`prcID` = `c`.`prID`)) where date_format(`c`.`sdate`,'%M-%Y') = date_format(current_timestamp(),'%M-%Y') group by `pr`.`productName` */;

/*View structure for view units */

/*!50001 DROP TABLE IF EXISTS `units` */;
/*!50001 DROP VIEW IF EXISTS `units` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `units` AS select `ug`.`id` AS `id`,`ug`.`unitID` AS `unitID`,`ug`.`prodID` AS `prodID`,`ug`.`qty` AS `qty`,`ug`.`deleted` AS `deleted`,`ug`.`defaultUnit` AS `defaultUnit`,`u`.`unitCode` AS `unitCode`,`u`.`unitDesc` AS `unitDesc` from (`tbl_unit_grp` `ug` join `tbl_unit` `u` on(`u`.`id` = `ug`.`unitID`)) where `ug`.`deleted` = 0 */;

/*View structure for view year_sales */

/*!50001 DROP TABLE IF EXISTS `year_sales` */;
/*!50001 DROP VIEW IF EXISTS `year_sales` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `year_sales` AS select sum(`tbl_cart`.`total`) AS `total`,date_format(`tbl_cart`.`sdate`,'%Y') AS `yr` from `tbl_cart` group by date_format(`tbl_cart`.`sdate`,'%Y') */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
