/*
 Navicat Premium Data Transfer

 Source Server         : local
 Source Server Type    : MySQL
 Source Server Version : 50619
 Source Host           : localhost:3306
 Source Schema         : etien

 Target Server Type    : MySQL
 Target Server Version : 50619
 File Encoding         : 65001

 Date: 26/08/2019 15:21:53
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for country
-- ----------------------------
DROP TABLE IF EXISTS `country`;
CREATE TABLE `country`  (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `iso` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `nicename` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `iso3` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `numcode` int(11) DEFAULT NULL,
  `phonecode` int(11) NOT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 240 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of country
-- ----------------------------
INSERT INTO `country` VALUES (1, 'AFGHANISTAN', 'AF', 'Afghanistan', 'AFG', 4, 93);
INSERT INTO `country` VALUES (2, 'ALBANIA', 'AL', 'Albania', 'ALB', 8, 355);
INSERT INTO `country` VALUES (3, 'ALGERIA', 'DZ', 'Algeria', 'DZA', 12, 213);
INSERT INTO `country` VALUES (4, 'AMERICAN SAMOA', 'AS', 'American Samoa', 'ASM', 16, 1684);
INSERT INTO `country` VALUES (5, 'ANDORRA', 'AD', 'Andorra', 'AND', 20, 376);
INSERT INTO `country` VALUES (6, 'ANGOLA', 'AO', 'Angola', 'AGO', 24, 244);
INSERT INTO `country` VALUES (7, 'ANGUILLA', 'AI', 'Anguilla', 'AIA', 660, 1264);
INSERT INTO `country` VALUES (8, 'ANTARCTICA', 'AQ', 'Antarctica', NULL, NULL, 0);
INSERT INTO `country` VALUES (9, 'ANTIGUA AND BARBUDA', 'AG', 'Antigua and Barbuda', 'ATG', 28, 1268);
INSERT INTO `country` VALUES (10, 'ARGENTINA', 'AR', 'Argentina', 'ARG', 32, 54);
INSERT INTO `country` VALUES (11, 'ARMENIA', 'AM', 'Armenia', 'ARM', 51, 374);
INSERT INTO `country` VALUES (12, 'ARUBA', 'AW', 'Aruba', 'ABW', 533, 297);
INSERT INTO `country` VALUES (13, 'AUSTRALIA', 'AU', 'Australia', 'AUS', 36, 61);
INSERT INTO `country` VALUES (14, 'AUSTRIA', 'AT', 'Austria', 'AUT', 40, 43);
INSERT INTO `country` VALUES (15, 'AZERBAIJAN', 'AZ', 'Azerbaijan', 'AZE', 31, 994);
INSERT INTO `country` VALUES (16, 'BAHAMAS', 'BS', 'Bahamas', 'BHS', 44, 1242);
INSERT INTO `country` VALUES (17, 'BAHRAIN', 'BH', 'Bahrain', 'BHR', 48, 973);
INSERT INTO `country` VALUES (18, 'BANGLADESH', 'BD', 'Bangladesh', 'BGD', 50, 880);
INSERT INTO `country` VALUES (19, 'BARBADOS', 'BB', 'Barbados', 'BRB', 52, 1246);
INSERT INTO `country` VALUES (20, 'BELARUS', 'BY', 'Belarus', 'BLR', 112, 375);
INSERT INTO `country` VALUES (21, 'BELGIUM', 'BE', 'Belgium', 'BEL', 56, 32);
INSERT INTO `country` VALUES (22, 'BELIZE', 'BZ', 'Belize', 'BLZ', 84, 501);
INSERT INTO `country` VALUES (23, 'BENIN', 'BJ', 'Benin', 'BEN', 204, 229);
INSERT INTO `country` VALUES (24, 'BERMUDA', 'BM', 'Bermuda', 'BMU', 60, 1441);
INSERT INTO `country` VALUES (25, 'BHUTAN', 'BT', 'Bhutan', 'BTN', 64, 975);
INSERT INTO `country` VALUES (26, 'BOLIVIA', 'BO', 'Bolivia', 'BOL', 68, 591);
INSERT INTO `country` VALUES (27, 'BOSNIA AND HERZEGOVINA', 'BA', 'Bosnia and Herzegovina', 'BIH', 70, 387);
INSERT INTO `country` VALUES (28, 'BOTSWANA', 'BW', 'Botswana', 'BWA', 72, 267);
INSERT INTO `country` VALUES (29, 'BOUVET ISLAND', 'BV', 'Bouvet Island', NULL, NULL, 0);
INSERT INTO `country` VALUES (30, 'BRAZIL', 'BR', 'Brazil', 'BRA', 76, 55);
INSERT INTO `country` VALUES (31, 'BRITISH INDIAN OCEAN TERRITORY', 'IO', 'British Indian Ocean Territory', NULL, NULL, 246);
INSERT INTO `country` VALUES (32, 'BRUNEI DARUSSALAM', 'BN', 'Brunei Darussalam', 'BRN', 96, 673);
INSERT INTO `country` VALUES (33, 'BULGARIA', 'BG', 'Bulgaria', 'BGR', 100, 359);
INSERT INTO `country` VALUES (34, 'BURKINA FASO', 'BF', 'Burkina Faso', 'BFA', 854, 226);
INSERT INTO `country` VALUES (35, 'BURUNDI', 'BI', 'Burundi', 'BDI', 108, 257);
INSERT INTO `country` VALUES (36, 'CAMBODIA', 'KH', 'Cambodia', 'KHM', 116, 855);
INSERT INTO `country` VALUES (37, 'CAMEROON', 'CM', 'Cameroon', 'CMR', 120, 237);
INSERT INTO `country` VALUES (38, 'CANADA', 'CA', 'Canada', 'CAN', 124, 1);
INSERT INTO `country` VALUES (39, 'CAPE VERDE', 'CV', 'Cape Verde', 'CPV', 132, 238);
INSERT INTO `country` VALUES (40, 'CAYMAN ISLANDS', 'KY', 'Cayman Islands', 'CYM', 136, 1345);
INSERT INTO `country` VALUES (41, 'CENTRAL AFRICAN REPUBLIC', 'CF', 'Central African Republic', 'CAF', 140, 236);
INSERT INTO `country` VALUES (42, 'CHAD', 'TD', 'Chad', 'TCD', 148, 235);
INSERT INTO `country` VALUES (43, 'CHILE', 'CL', 'Chile', 'CHL', 152, 56);
INSERT INTO `country` VALUES (44, 'CHINA', 'CN', 'China', 'CHN', 156, 86);
INSERT INTO `country` VALUES (45, 'CHRISTMAS ISLAND', 'CX', 'Christmas Island', NULL, NULL, 61);
INSERT INTO `country` VALUES (46, 'COCOS (KEELING) ISLANDS', 'CC', 'Cocos (Keeling) Islands', NULL, NULL, 672);
INSERT INTO `country` VALUES (47, 'COLOMBIA', 'CO', 'Colombia', 'COL', 170, 57);
INSERT INTO `country` VALUES (48, 'COMOROS', 'KM', 'Comoros', 'COM', 174, 269);
INSERT INTO `country` VALUES (49, 'CONGO', 'CG', 'Congo', 'COG', 178, 242);
INSERT INTO `country` VALUES (50, 'CONGO, THE DEMOCRATIC REPUBLIC OF THE', 'CD', 'Congo, the Democratic Republic of the', 'COD', 180, 242);
INSERT INTO `country` VALUES (51, 'COOK ISLANDS', 'CK', 'Cook Islands', 'COK', 184, 682);
INSERT INTO `country` VALUES (52, 'COSTA RICA', 'CR', 'Costa Rica', 'CRI', 188, 506);
INSERT INTO `country` VALUES (53, 'COTE D\'IVOIRE', 'CI', 'Cote D\'Ivoire', 'CIV', 384, 225);
INSERT INTO `country` VALUES (54, 'CROATIA', 'HR', 'Croatia', 'HRV', 191, 385);
INSERT INTO `country` VALUES (55, 'CUBA', 'CU', 'Cuba', 'CUB', 192, 53);
INSERT INTO `country` VALUES (56, 'CYPRUS', 'CY', 'Cyprus', 'CYP', 196, 357);
INSERT INTO `country` VALUES (57, 'CZECH REPUBLIC', 'CZ', 'Czech Republic', 'CZE', 203, 420);
INSERT INTO `country` VALUES (58, 'DENMARK', 'DK', 'Denmark', 'DNK', 208, 45);
INSERT INTO `country` VALUES (59, 'DJIBOUTI', 'DJ', 'Djibouti', 'DJI', 262, 253);
INSERT INTO `country` VALUES (60, 'DOMINICA', 'DM', 'Dominica', 'DMA', 212, 1767);
INSERT INTO `country` VALUES (61, 'DOMINICAN REPUBLIC', 'DO', 'Dominican Republic', 'DOM', 214, 1809);
INSERT INTO `country` VALUES (62, 'ECUADOR', 'EC', 'Ecuador', 'ECU', 218, 593);
INSERT INTO `country` VALUES (63, 'EGYPT', 'EG', 'Egypt', 'EGY', 818, 20);
INSERT INTO `country` VALUES (64, 'EL SALVADOR', 'SV', 'El Salvador', 'SLV', 222, 503);
INSERT INTO `country` VALUES (65, 'EQUATORIAL GUINEA', 'GQ', 'Equatorial Guinea', 'GNQ', 226, 240);
INSERT INTO `country` VALUES (66, 'ERITREA', 'ER', 'Eritrea', 'ERI', 232, 291);
INSERT INTO `country` VALUES (67, 'ESTONIA', 'EE', 'Estonia', 'EST', 233, 372);
INSERT INTO `country` VALUES (68, 'ETHIOPIA', 'ET', 'Ethiopia', 'ETH', 231, 251);
INSERT INTO `country` VALUES (69, 'FALKLAND ISLANDS (MALVINAS)', 'FK', 'Falkland Islands (Malvinas)', 'FLK', 238, 500);
INSERT INTO `country` VALUES (70, 'FAROE ISLANDS', 'FO', 'Faroe Islands', 'FRO', 234, 298);
INSERT INTO `country` VALUES (71, 'FIJI', 'FJ', 'Fiji', 'FJI', 242, 679);
INSERT INTO `country` VALUES (72, 'FINLAND', 'FI', 'Finland', 'FIN', 246, 358);
INSERT INTO `country` VALUES (73, 'FRANCE', 'FR', 'France', 'FRA', 250, 33);
INSERT INTO `country` VALUES (74, 'FRENCH GUIANA', 'GF', 'French Guiana', 'GUF', 254, 594);
INSERT INTO `country` VALUES (75, 'FRENCH POLYNESIA', 'PF', 'French Polynesia', 'PYF', 258, 689);
INSERT INTO `country` VALUES (76, 'FRENCH SOUTHERN TERRITORIES', 'TF', 'French Southern Territories', NULL, NULL, 0);
INSERT INTO `country` VALUES (77, 'GABON', 'GA', 'Gabon', 'GAB', 266, 241);
INSERT INTO `country` VALUES (78, 'GAMBIA', 'GM', 'Gambia', 'GMB', 270, 220);
INSERT INTO `country` VALUES (79, 'GEORGIA', 'GE', 'Georgia', 'GEO', 268, 995);
INSERT INTO `country` VALUES (80, 'GERMANY', 'DE', 'Germany', 'DEU', 276, 49);
INSERT INTO `country` VALUES (81, 'GHANA', 'GH', 'Ghana', 'GHA', 288, 233);
INSERT INTO `country` VALUES (82, 'GIBRALTAR', 'GI', 'Gibraltar', 'GIB', 292, 350);
INSERT INTO `country` VALUES (83, 'GREECE', 'GR', 'Greece', 'GRC', 300, 30);
INSERT INTO `country` VALUES (84, 'GREENLAND', 'GL', 'Greenland', 'GRL', 304, 299);
INSERT INTO `country` VALUES (85, 'GRENADA', 'GD', 'Grenada', 'GRD', 308, 1473);
INSERT INTO `country` VALUES (86, 'GUADELOUPE', 'GP', 'Guadeloupe', 'GLP', 312, 590);
INSERT INTO `country` VALUES (87, 'GUAM', 'GU', 'Guam', 'GUM', 316, 1671);
INSERT INTO `country` VALUES (88, 'GUATEMALA', 'GT', 'Guatemala', 'GTM', 320, 502);
INSERT INTO `country` VALUES (89, 'GUINEA', 'GN', 'Guinea', 'GIN', 324, 224);
INSERT INTO `country` VALUES (90, 'GUINEA-BISSAU', 'GW', 'Guinea-Bissau', 'GNB', 624, 245);
INSERT INTO `country` VALUES (91, 'GUYANA', 'GY', 'Guyana', 'GUY', 328, 592);
INSERT INTO `country` VALUES (92, 'HAITI', 'HT', 'Haiti', 'HTI', 332, 509);
INSERT INTO `country` VALUES (93, 'HEARD ISLAND AND MCDONALD ISLANDS', 'HM', 'Heard Island and Mcdonald Islands', NULL, NULL, 0);
INSERT INTO `country` VALUES (94, 'HOLY SEE (VATICAN CITY STATE)', 'VA', 'Holy See (Vatican City State)', 'VAT', 336, 39);
INSERT INTO `country` VALUES (95, 'HONDURAS', 'HN', 'Honduras', 'HND', 340, 504);
INSERT INTO `country` VALUES (96, 'HONG KONG', 'HK', 'Hong Kong', 'HKG', 344, 852);
INSERT INTO `country` VALUES (97, 'HUNGARY', 'HU', 'Hungary', 'HUN', 348, 36);
INSERT INTO `country` VALUES (98, 'ICELAND', 'IS', 'Iceland', 'ISL', 352, 354);
INSERT INTO `country` VALUES (99, 'INDIA', 'IN', 'India', 'IND', 356, 91);
INSERT INTO `country` VALUES (100, 'INDONESIA', 'ID', 'Indonesia', 'IDN', 360, 62);
INSERT INTO `country` VALUES (101, 'IRAN, ISLAMIC REPUBLIC OF', 'IR', 'Iran, Islamic Republic of', 'IRN', 364, 98);
INSERT INTO `country` VALUES (102, 'IRAQ', 'IQ', 'Iraq', 'IRQ', 368, 964);
INSERT INTO `country` VALUES (103, 'IRELAND', 'IE', 'Ireland', 'IRL', 372, 353);
INSERT INTO `country` VALUES (104, 'ISRAEL', 'IL', 'Israel', 'ISR', 376, 972);
INSERT INTO `country` VALUES (105, 'ITALY', 'IT', 'Italy', 'ITA', 380, 39);
INSERT INTO `country` VALUES (106, 'JAMAICA', 'JM', 'Jamaica', 'JAM', 388, 1876);
INSERT INTO `country` VALUES (107, 'JAPAN', 'JP', 'Japan', 'JPN', 392, 81);
INSERT INTO `country` VALUES (108, 'JORDAN', 'JO', 'Jordan', 'JOR', 400, 962);
INSERT INTO `country` VALUES (109, 'KAZAKHSTAN', 'KZ', 'Kazakhstan', 'KAZ', 398, 7);
INSERT INTO `country` VALUES (110, 'KENYA', 'KE', 'Kenya', 'KEN', 404, 254);
INSERT INTO `country` VALUES (111, 'KIRIBATI', 'KI', 'Kiribati', 'KIR', 296, 686);
INSERT INTO `country` VALUES (112, 'KOREA, DEMOCRATIC PEOPLE\'S REPUBLIC OF', 'KP', 'Korea, Democratic People\'s Republic of', 'PRK', 408, 850);
INSERT INTO `country` VALUES (113, 'KOREA, REPUBLIC OF', 'KR', 'Korea, Republic of', 'KOR', 410, 82);
INSERT INTO `country` VALUES (114, 'KUWAIT', 'KW', 'Kuwait', 'KWT', 414, 965);
INSERT INTO `country` VALUES (115, 'KYRGYZSTAN', 'KG', 'Kyrgyzstan', 'KGZ', 417, 996);
INSERT INTO `country` VALUES (116, 'LAO PEOPLE\'S DEMOCRATIC REPUBLIC', 'LA', 'Lao People\'s Democratic Republic', 'LAO', 418, 856);
INSERT INTO `country` VALUES (117, 'LATVIA', 'LV', 'Latvia', 'LVA', 428, 371);
INSERT INTO `country` VALUES (118, 'LEBANON', 'LB', 'Lebanon', 'LBN', 422, 961);
INSERT INTO `country` VALUES (119, 'LESOTHO', 'LS', 'Lesotho', 'LSO', 426, 266);
INSERT INTO `country` VALUES (120, 'LIBERIA', 'LR', 'Liberia', 'LBR', 430, 231);
INSERT INTO `country` VALUES (121, 'LIBYAN ARAB JAMAHIRIYA', 'LY', 'Libyan Arab Jamahiriya', 'LBY', 434, 218);
INSERT INTO `country` VALUES (122, 'LIECHTENSTEIN', 'LI', 'Liechtenstein', 'LIE', 438, 423);
INSERT INTO `country` VALUES (123, 'LITHUANIA', 'LT', 'Lithuania', 'LTU', 440, 370);
INSERT INTO `country` VALUES (124, 'LUXEMBOURG', 'LU', 'Luxembourg', 'LUX', 442, 352);
INSERT INTO `country` VALUES (125, 'MACAO', 'MO', 'Macao', 'MAC', 446, 853);
INSERT INTO `country` VALUES (126, 'MACEDONIA, THE FORMER YUGOSLAV REPUBLIC OF', 'MK', 'Macedonia, the Former Yugoslav Republic of', 'MKD', 807, 389);
INSERT INTO `country` VALUES (127, 'MADAGASCAR', 'MG', 'Madagascar', 'MDG', 450, 261);
INSERT INTO `country` VALUES (128, 'MALAWI', 'MW', 'Malawi', 'MWI', 454, 265);
INSERT INTO `country` VALUES (129, 'MALAYSIA', 'MY', 'Malaysia', 'MYS', 458, 60);
INSERT INTO `country` VALUES (130, 'MALDIVES', 'MV', 'Maldives', 'MDV', 462, 960);
INSERT INTO `country` VALUES (131, 'MALI', 'ML', 'Mali', 'MLI', 466, 223);
INSERT INTO `country` VALUES (132, 'MALTA', 'MT', 'Malta', 'MLT', 470, 356);
INSERT INTO `country` VALUES (133, 'MARSHALL ISLANDS', 'MH', 'Marshall Islands', 'MHL', 584, 692);
INSERT INTO `country` VALUES (134, 'MARTINIQUE', 'MQ', 'Martinique', 'MTQ', 474, 596);
INSERT INTO `country` VALUES (135, 'MAURITANIA', 'MR', 'Mauritania', 'MRT', 478, 222);
INSERT INTO `country` VALUES (136, 'MAURITIUS', 'MU', 'Mauritius', 'MUS', 480, 230);
INSERT INTO `country` VALUES (137, 'MAYOTTE', 'YT', 'Mayotte', NULL, NULL, 269);
INSERT INTO `country` VALUES (138, 'MEXICO', 'MX', 'Mexico', 'MEX', 484, 52);
INSERT INTO `country` VALUES (139, 'MICRONESIA, FEDERATED STATES OF', 'FM', 'Micronesia, Federated States of', 'FSM', 583, 691);
INSERT INTO `country` VALUES (140, 'MOLDOVA, REPUBLIC OF', 'MD', 'Moldova, Republic of', 'MDA', 498, 373);
INSERT INTO `country` VALUES (141, 'MONACO', 'MC', 'Monaco', 'MCO', 492, 377);
INSERT INTO `country` VALUES (142, 'MONGOLIA', 'MN', 'Mongolia', 'MNG', 496, 976);
INSERT INTO `country` VALUES (143, 'MONTSERRAT', 'MS', 'Montserrat', 'MSR', 500, 1664);
INSERT INTO `country` VALUES (144, 'MOROCCO', 'MA', 'Morocco', 'MAR', 504, 212);
INSERT INTO `country` VALUES (145, 'MOZAMBIQUE', 'MZ', 'Mozambique', 'MOZ', 508, 258);
INSERT INTO `country` VALUES (146, 'MYANMAR', 'MM', 'Myanmar', 'MMR', 104, 95);
INSERT INTO `country` VALUES (147, 'NAMIBIA', 'NA', 'Namibia', 'NAM', 516, 264);
INSERT INTO `country` VALUES (148, 'NAURU', 'NR', 'Nauru', 'NRU', 520, 674);
INSERT INTO `country` VALUES (149, 'NEPAL', 'NP', 'Nepal', 'NPL', 524, 977);
INSERT INTO `country` VALUES (150, 'NETHERLANDS', 'NL', 'Netherlands', 'NLD', 528, 31);
INSERT INTO `country` VALUES (151, 'NETHERLANDS ANTILLES', 'AN', 'Netherlands Antilles', 'ANT', 530, 599);
INSERT INTO `country` VALUES (152, 'NEW CALEDONIA', 'NC', 'New Caledonia', 'NCL', 540, 687);
INSERT INTO `country` VALUES (153, 'NEW ZEALAND', 'NZ', 'New Zealand', 'NZL', 554, 64);
INSERT INTO `country` VALUES (154, 'NICARAGUA', 'NI', 'Nicaragua', 'NIC', 558, 505);
INSERT INTO `country` VALUES (155, 'NIGER', 'NE', 'Niger', 'NER', 562, 227);
INSERT INTO `country` VALUES (156, 'NIGERIA', 'NG', 'Nigeria', 'NGA', 566, 234);
INSERT INTO `country` VALUES (157, 'NIUE', 'NU', 'Niue', 'NIU', 570, 683);
INSERT INTO `country` VALUES (158, 'NORFOLK ISLAND', 'NF', 'Norfolk Island', 'NFK', 574, 672);
INSERT INTO `country` VALUES (159, 'NORTHERN MARIANA ISLANDS', 'MP', 'Northern Mariana Islands', 'MNP', 580, 1670);
INSERT INTO `country` VALUES (160, 'NORWAY', 'NO', 'Norway', 'NOR', 578, 47);
INSERT INTO `country` VALUES (161, 'OMAN', 'OM', 'Oman', 'OMN', 512, 968);
INSERT INTO `country` VALUES (162, 'PAKISTAN', 'PK', 'Pakistan', 'PAK', 586, 92);
INSERT INTO `country` VALUES (163, 'PALAU', 'PW', 'Palau', 'PLW', 585, 680);
INSERT INTO `country` VALUES (164, 'PALESTINIAN TERRITORY, OCCUPIED', 'PS', 'Palestinian Territory, Occupied', NULL, NULL, 970);
INSERT INTO `country` VALUES (165, 'PANAMA', 'PA', 'Panama', 'PAN', 591, 507);
INSERT INTO `country` VALUES (166, 'PAPUA NEW GUINEA', 'PG', 'Papua New Guinea', 'PNG', 598, 675);
INSERT INTO `country` VALUES (167, 'PARAGUAY', 'PY', 'Paraguay', 'PRY', 600, 595);
INSERT INTO `country` VALUES (168, 'PERU', 'PE', 'Peru', 'PER', 604, 51);
INSERT INTO `country` VALUES (169, 'PHILIPPINES', 'PH', 'Philippines', 'PHL', 608, 63);
INSERT INTO `country` VALUES (170, 'PITCAIRN', 'PN', 'Pitcairn', 'PCN', 612, 0);
INSERT INTO `country` VALUES (171, 'POLAND', 'PL', 'Poland', 'POL', 616, 48);
INSERT INTO `country` VALUES (172, 'PORTUGAL', 'PT', 'Portugal', 'PRT', 620, 351);
INSERT INTO `country` VALUES (173, 'PUERTO RICO', 'PR', 'Puerto Rico', 'PRI', 630, 1787);
INSERT INTO `country` VALUES (174, 'QATAR', 'QA', 'Qatar', 'QAT', 634, 974);
INSERT INTO `country` VALUES (175, 'REUNION', 'RE', 'Reunion', 'REU', 638, 262);
INSERT INTO `country` VALUES (176, 'ROMANIA', 'RO', 'Romania', 'ROM', 642, 40);
INSERT INTO `country` VALUES (177, 'RUSSIAN FEDERATION', 'RU', 'Russian Federation', 'RUS', 643, 70);
INSERT INTO `country` VALUES (178, 'RWANDA', 'RW', 'Rwanda', 'RWA', 646, 250);
INSERT INTO `country` VALUES (179, 'SAINT HELENA', 'SH', 'Saint Helena', 'SHN', 654, 290);
INSERT INTO `country` VALUES (180, 'SAINT KITTS AND NEVIS', 'KN', 'Saint Kitts and Nevis', 'KNA', 659, 1869);
INSERT INTO `country` VALUES (181, 'SAINT LUCIA', 'LC', 'Saint Lucia', 'LCA', 662, 1758);
INSERT INTO `country` VALUES (182, 'SAINT PIERRE AND MIQUELON', 'PM', 'Saint Pierre and Miquelon', 'SPM', 666, 508);
INSERT INTO `country` VALUES (183, 'SAINT VINCENT AND THE GRENADINES', 'VC', 'Saint Vincent and the Grenadines', 'VCT', 670, 1784);
INSERT INTO `country` VALUES (184, 'SAMOA', 'WS', 'Samoa', 'WSM', 882, 684);
INSERT INTO `country` VALUES (185, 'SAN MARINO', 'SM', 'San Marino', 'SMR', 674, 378);
INSERT INTO `country` VALUES (186, 'SAO TOME AND PRINCIPE', 'ST', 'Sao Tome and Principe', 'STP', 678, 239);
INSERT INTO `country` VALUES (187, 'SAUDI ARABIA', 'SA', 'Saudi Arabia', 'SAU', 682, 966);
INSERT INTO `country` VALUES (188, 'SENEGAL', 'SN', 'Senegal', 'SEN', 686, 221);
INSERT INTO `country` VALUES (189, 'SERBIA AND MONTENEGRO', 'CS', 'Serbia and Montenegro', NULL, NULL, 381);
INSERT INTO `country` VALUES (190, 'SEYCHELLES', 'SC', 'Seychelles', 'SYC', 690, 248);
INSERT INTO `country` VALUES (191, 'SIERRA LEONE', 'SL', 'Sierra Leone', 'SLE', 694, 232);
INSERT INTO `country` VALUES (192, 'SINGAPORE', 'SG', 'Singapore', 'SGP', 702, 65);
INSERT INTO `country` VALUES (193, 'SLOVAKIA', 'SK', 'Slovakia', 'SVK', 703, 421);
INSERT INTO `country` VALUES (194, 'SLOVENIA', 'SI', 'Slovenia', 'SVN', 705, 386);
INSERT INTO `country` VALUES (195, 'SOLOMON ISLANDS', 'SB', 'Solomon Islands', 'SLB', 90, 677);
INSERT INTO `country` VALUES (196, 'SOMALIA', 'SO', 'Somalia', 'SOM', 706, 252);
INSERT INTO `country` VALUES (197, 'SOUTH AFRICA', 'ZA', 'South Africa', 'ZAF', 710, 27);
INSERT INTO `country` VALUES (198, 'SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS', 'GS', 'South Georgia and the South Sandwich Islands', NULL, NULL, 0);
INSERT INTO `country` VALUES (199, 'SPAIN', 'ES', 'Spain', 'ESP', 724, 34);
INSERT INTO `country` VALUES (200, 'SRI LANKA', 'LK', 'Sri Lanka', 'LKA', 144, 94);
INSERT INTO `country` VALUES (201, 'SUDAN', 'SD', 'Sudan', 'SDN', 736, 249);
INSERT INTO `country` VALUES (202, 'SURINAME', 'SR', 'Suriname', 'SUR', 740, 597);
INSERT INTO `country` VALUES (203, 'SVALBARD AND JAN MAYEN', 'SJ', 'Svalbard and Jan Mayen', 'SJM', 744, 47);
INSERT INTO `country` VALUES (204, 'SWAZILAND', 'SZ', 'Swaziland', 'SWZ', 748, 268);
INSERT INTO `country` VALUES (205, 'SWEDEN', 'SE', 'Sweden', 'SWE', 752, 46);
INSERT INTO `country` VALUES (206, 'SWITZERLAND', 'CH', 'Switzerland', 'CHE', 756, 41);
INSERT INTO `country` VALUES (207, 'SYRIAN ARAB REPUBLIC', 'SY', 'Syrian Arab Republic', 'SYR', 760, 963);
INSERT INTO `country` VALUES (208, 'TAIWAN, PROVINCE OF CHINA', 'TW', 'Taiwan, Province of China', 'TWN', 158, 886);
INSERT INTO `country` VALUES (209, 'TAJIKISTAN', 'TJ', 'Tajikistan', 'TJK', 762, 992);
INSERT INTO `country` VALUES (210, 'TANZANIA, UNITED REPUBLIC OF', 'TZ', 'Tanzania, United Republic of', 'TZA', 834, 255);
INSERT INTO `country` VALUES (211, 'THAILAND', 'TH', 'Thailand', 'THA', 764, 66);
INSERT INTO `country` VALUES (212, 'TIMOR-LESTE', 'TL', 'Timor-Leste', NULL, NULL, 670);
INSERT INTO `country` VALUES (213, 'TOGO', 'TG', 'Togo', 'TGO', 768, 228);
INSERT INTO `country` VALUES (214, 'TOKELAU', 'TK', 'Tokelau', 'TKL', 772, 690);
INSERT INTO `country` VALUES (215, 'TONGA', 'TO', 'Tonga', 'TON', 776, 676);
INSERT INTO `country` VALUES (216, 'TRINIDAD AND TOBAGO', 'TT', 'Trinidad and Tobago', 'TTO', 780, 1868);
INSERT INTO `country` VALUES (217, 'TUNISIA', 'TN', 'Tunisia', 'TUN', 788, 216);
INSERT INTO `country` VALUES (218, 'TURKEY', 'TR', 'Turkey', 'TUR', 792, 90);
INSERT INTO `country` VALUES (219, 'TURKMENISTAN', 'TM', 'Turkmenistan', 'TKM', 795, 7370);
INSERT INTO `country` VALUES (220, 'TURKS AND CAICOS ISLANDS', 'TC', 'Turks and Caicos Islands', 'TCA', 796, 1649);
INSERT INTO `country` VALUES (221, 'TUVALU', 'TV', 'Tuvalu', 'TUV', 798, 688);
INSERT INTO `country` VALUES (222, 'UGANDA', 'UG', 'Uganda', 'UGA', 800, 256);
INSERT INTO `country` VALUES (223, 'UKRAINE', 'UA', 'Ukraine', 'UKR', 804, 380);
INSERT INTO `country` VALUES (224, 'UNITED ARAB EMIRATES', 'AE', 'United Arab Emirates', 'ARE', 784, 971);
INSERT INTO `country` VALUES (225, 'UNITED KINGDOM', 'GB', 'United Kingdom', 'GBR', 826, 44);
INSERT INTO `country` VALUES (226, 'UNITED STATES', 'US', 'United States', 'USA', 840, 1);
INSERT INTO `country` VALUES (227, 'UNITED STATES MINOR OUTLYING ISLANDS', 'UM', 'United States Minor Outlying Islands', NULL, NULL, 1);
INSERT INTO `country` VALUES (228, 'URUGUAY', 'UY', 'Uruguay', 'URY', 858, 598);
INSERT INTO `country` VALUES (229, 'UZBEKISTAN', 'UZ', 'Uzbekistan', 'UZB', 860, 998);
INSERT INTO `country` VALUES (230, 'VANUATU', 'VU', 'Vanuatu', 'VUT', 548, 678);
INSERT INTO `country` VALUES (231, 'VENEZUELA', 'VE', 'Venezuela', 'VEN', 862, 58);
INSERT INTO `country` VALUES (232, 'VIET NAM', 'VN', 'Viet Nam', 'VNM', 704, 84);
INSERT INTO `country` VALUES (233, 'VIRGIN ISLANDS, BRITISH', 'VG', 'Virgin Islands, British', 'VGB', 92, 1284);
INSERT INTO `country` VALUES (234, 'VIRGIN ISLANDS, U.S.', 'VI', 'Virgin Islands, U.s.', 'VIR', 850, 1340);
INSERT INTO `country` VALUES (235, 'WALLIS AND FUTUNA', 'WF', 'Wallis and Futuna', 'WLF', 876, 681);
INSERT INTO `country` VALUES (236, 'WESTERN SAHARA', 'EH', 'Western Sahara', 'ESH', 732, 212);
INSERT INTO `country` VALUES (237, 'YEMEN', 'YE', 'Yemen', 'YEM', 887, 967);
INSERT INTO `country` VALUES (238, 'ZAMBIA', 'ZM', 'Zambia', 'ZMB', 894, 260);
INSERT INTO `country` VALUES (239, 'ZIMBABWE', 'ZW', 'Zimbabwe', 'ZWE', 716, 263);

-- ----------------------------
-- Table structure for preference
-- ----------------------------
DROP TABLE IF EXISTS `preference`;
CREATE TABLE `preference`  (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user`  (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `LastName` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `UserName` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Password` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Email` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `UserDeviceId` longtext CHARACTER SET utf8 COLLATE utf8_general_ci,
  `Cellphone` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `IsAdmin` tinyint(1) NOT NULL DEFAULT 0,
  `IsReseller` tinyint(1) NOT NULL DEFAULT 0,
  `Salt` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Token` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Gender` int(11) NOT NULL DEFAULT 1,
  `Status` int(11) NOT NULL DEFAULT 1,
  `CountryId` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`ID`) USING BTREE,
  INDEX `CountryId`(`CountryId`) USING BTREE,
  CONSTRAINT `CountryId` FOREIGN KEY (`CountryId`) REFERENCES `country` (`ID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for user_preferences
-- ----------------------------
DROP TABLE IF EXISTS `user_preferences`;
CREATE TABLE `user_preferences`  (
  `IdPreference` bigint(20) NOT NULL,
  `IdUser` bigint(20) NOT NULL,
  INDEX `IdPreference`(`IdPreference`) USING BTREE,
  INDEX `IdUser`(`IdUser`) USING BTREE,
  CONSTRAINT `FKE1F2B715A499AD91` FOREIGN KEY (`IdUser`) REFERENCES `user` (`ID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FKE1F2B7154BDFA4EC` FOREIGN KEY (`IdPreference`) REFERENCES `preference` (`ID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

SET FOREIGN_KEY_CHECKS = 1;
