using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppRemesas
{
    public static class Global
    {
        public static int indiceAnio = 0; // Variable creada para guardar el Idanio de la tabla remesas por año.

        public static List<Remesas> remesas = new List<Remesas>()
        {
            //2000
            new Remesas (1,1,1,19.8),new Remesas (2,1,2,20.8),new Remesas (3,1,3,23.4), new Remesas (4,1,4,23.6), new Remesas (5,1,5,24.8),
            new Remesas (6,1,6,25.2),  new Remesas (7,1,7,26.3),  new Remesas (8,1,8,27.5), new Remesas (9,1,9,29.4),new Remesas (10,1,10,29.9),
            new Remesas (11,1,11,29.5), new Remesas (12,1,12,39.8),
            // 2001
            new Remesas (13,2,1,25.1),new Remesas (14,2,2,24.7),new Remesas (15,2,3,27.3), new Remesas (16,2,4,26.2), new Remesas (17,2,5,27.6),
            new Remesas (18,2,6,25.2),  new Remesas (19,2,7,27.4),  new Remesas (20,2,8,30.4), new Remesas (21,2,9,29.5),new Remesas (22,2,10,30.9),
            new Remesas (23,2,11,27.3), new Remesas (24,2,12,34.1),
            //2002
            new Remesas (25,3,1,30.3),new Remesas (26,3,2,29),new Remesas (27,3,3,32.1), new Remesas (28,3,4,32), new Remesas (29,3,5,33.5),
            new Remesas (30,3,6,29.3),  new Remesas (31,3,7,29.1),  new Remesas (32,3,8,30), new Remesas (33,3,9,32.8),new Remesas (34,3,10,33.8),
            new Remesas (35,3,11,29.4), new Remesas (36,3,12,35.2),
            // 2003
            new Remesas (37,4,1,33.5),new Remesas (38,4,2,31.8),new Remesas (39,4,3,35.6), new Remesas (40,4,4,33), new Remesas (41,4,5,36.2),
            new Remesas (42,4,6,33.2),  new Remesas (43,4,7,36.4),  new Remesas (44,4,8,38.1), new Remesas (45,4,9,39.6),new Remesas (46,4,10,38.1),
            new Remesas (47,4,11,38.2), new Remesas (48,4,12,45.1),
            // 2004
            new Remesas (49,5,1,38),new Remesas (50,5,2,37.2),new Remesas (51,5,3,42.3), new Remesas (52,5,4,40), new Remesas (53,5,5,43.4),
            new Remesas (54,5,6,41.5),  new Remesas (55,5,7,43.2),  new Remesas (56,5,8,43), new Remesas (57,5,9,48.9),new Remesas (58,5,10,47.9),
            new Remesas (59,5,11,46.1), new Remesas (60,5,12,47.3),        
            // 2005
            new Remesas (61,6,1,51.4),new Remesas (62,6,2,49.5),new Remesas (63,6,3,52.7), new Remesas (64,6,4,48.8), new Remesas (65,6,5,52.3),
            new Remesas (66,6,6,47.8),  new Remesas (67,6,7,49.8),  new Remesas (68,6,8,48.6), new Remesas (69,6,9,52.1),new Remesas (70,6,10,49.5),
            new Remesas (71,6,11,50.8), new Remesas (72,6,12,62.4), 
            // 2006
            new Remesas (73,7,1,57.8),new Remesas (74,7,2,54.6),new Remesas (75,7,3,61.2), new Remesas (76,7,4,54.7), new Remesas (77,7,5,60.2),
            new Remesas (78,7,6,53.6),  new Remesas (79,7,7,57.1),  new Remesas (80,7,8,58.1), new Remesas (81,7,9,63.4),new Remesas (82,7,10,61.2),
            new Remesas (83,7,11,52.9), new Remesas (84,7,12,62.7),
            // 2007
            new Remesas (85,8,1,51.4),new Remesas (86,8,2,52.6),new Remesas (87,8,3,61.1), new Remesas (88,8,4,57.3), new Remesas (89,8,5,63.9),
            new Remesas (90,8,6,59.9),  new Remesas (91,8,7,61.8),  new Remesas (92,8,8,65.2), new Remesas (93,8,9,62.7),new Remesas (94,8,10,66.5),
            new Remesas (95,8,11,65.7), new Remesas (96,8,12,71.5),
            // 2008
            new Remesas (97,9,1,60.8),new Remesas (98,9,2,63.4),new Remesas (99,9,3,71.5), new Remesas (100,9,4,67.7), new Remesas (101,9,5,73.6),
            new Remesas (102,9,6,66.8),  new Remesas (103,9,7,66.9),  new Remesas (104,9,8,69.5), new Remesas (105,9,9,70.8),new Remesas (106,9,10,67.5),
            new Remesas (107,9,11,66.1), new Remesas (108,9,12,73.5),
            // 2009
            new Remesas (109,10,1,62.7),new Remesas (110,10,2,62.8),new Remesas (111,10,3,70.4), new Remesas (112,10,4,62.5), new Remesas (113,10,5,66.2),
            new Remesas (114,10,6,62.1),  new Remesas (115,10,7,61.3),  new Remesas (116,10,8,60.7), new Remesas (117,10,9,62.2),new Remesas (118,10,10,64.4),
            new Remesas (119,10,11,61.9), new Remesas (120,10,12,71.2),
            // 2010
            new Remesas (121,11,1,60.7),new Remesas (122,11,2,64.1),new Remesas (123,11,3,77), new Remesas (124,11,4,63.8), new Remesas (125,11,5,70.2),
            new Remesas (126,11,6,63.5),  new Remesas (127,11,7,66.5),  new Remesas (128,11,8,66.5), new Remesas (129,11,9,67.9),new Remesas (130,11,10,70.3),
            new Remesas (131,11,11,70.6), new Remesas (132,11,12,81.7),
            // 2011
            new Remesas (133,12,1,67.4),new Remesas (134,12,2,69.3),new Remesas (135,12,3,77.5), new Remesas (136,12,4,73.4), new Remesas (137,12,5,77.8),
            new Remesas (138,12,6,70),  new Remesas (139,12,7,74.5),  new Remesas (140,12,8,77.3), new Remesas (141,12,9,74.8),new Remesas (142,12,10,79.4),
            new Remesas (143,12,11,75.7), new Remesas (144,12,12,94.5),
            // 2012
            new Remesas (145,13,1,78.1),new Remesas (146,13,2,82.3),new Remesas (147,13,3,89.7), new Remesas (148,13,4,80.1), new Remesas (149,13,5,85.2),
            new Remesas (150,13,6,78.9),  new Remesas (151,13,7,80.9),  new Remesas (152,13,8,82.4), new Remesas (153,13,9,82.9),new Remesas (154,13,10,87.3),
            new Remesas (155,13,11,82.8), new Remesas (156,13,12,103.6),
            // 2013
            new Remesas (157,14,1,83.4),new Remesas (158,14,2,83.7),new Remesas (159,14,3,90.2), new Remesas (160,14,4,90.7), new Remesas (161,14,5,92.7),
            new Remesas (162,14,6,80.9),  new Remesas (163,14,7,86.6),  new Remesas (164,14,8,88.6), new Remesas (165,14,9,90.5),new Remesas (166,14,10,90.3),
            new Remesas (167,14,11,89.1), new Remesas (168,14,12,111),
            // 2014
            new Remesas (169,15,1,85.6),new Remesas (170,15,2,90),new Remesas (171,15,3,101.6), new Remesas (172,15,4,91.1), new Remesas (173,15,5,98.5),
            new Remesas (174,15,6,88.4),  new Remesas (175,15,7,92.6),  new Remesas (176,15,8,92.2), new Remesas (177,15,9,94.7),new Remesas (178,15,10,93.5),
            new Remesas (179,15,11,91), new Remesas (180,15,12,116.6),
            // 2015
            new Remesas (181,16,1,88.9),new Remesas (182,16,2,94.1),new Remesas (183,16,3,106.2), new Remesas (184,16,4,94.4), new Remesas (185,16,5,104.9),
            new Remesas (186,16,6,93.1),  new Remesas (187,16,7,97.6),  new Remesas (188,16,8,96.6), new Remesas (189,16,9,98.7),new Remesas (190,16,10,102.6),
            new Remesas (191,16,11,95.7), new Remesas (192,16,12,120.6),
            // 2016
            new Remesas (193,17,1,91.2),new Remesas (194,17,2,103.4),new Remesas (195,17,3,107.7), new Remesas (196,17,4,103.5), new Remesas (197,17,5,107.4),
            new Remesas (198,17,6,95.5),  new Remesas (199,17,7,98.7),  new Remesas (200,17,8,107.9), new Remesas (201,17,9,106.3),new Remesas (202,17,10,108.1),
            new Remesas (203,17,11,104.3), new Remesas (204,17,12,130.1),
            // 2017
            new Remesas (205,18,1,102.1),new Remesas (206,18,2,107.6),new Remesas (207,18,3,113.6), new Remesas (208,18,4,108.4), new Remesas (209,18,5,121.2),
            new Remesas (210,18,6,111.1),  new Remesas (211,18,7,122.4),  new Remesas (212,18,8,120.4), new Remesas (213,18,9,112.8),new Remesas (214,18,10,118.5),
            new Remesas (215,18,11,116), new Remesas (216,18,12,136.7),


        };

        public static List<Anio> anios = new List<Anio>()
        {
            new Anio(1, 2000),
            new Anio(2, 2001),
            new Anio(3, 2002),
            new Anio(4, 2003),
            new Anio(5, 2004),
            new Anio(6, 2005),
            new Anio(7, 2006),
            new Anio(8, 2007),
            new Anio(9, 2008),
            new Anio(10, 2009),
            new Anio(11, 2010),
            new Anio(12, 2011),
            new Anio(13, 2012),
            new Anio(14, 2013),
            new Anio(15, 2014),
            new Anio(16, 2015),
            new Anio(17, 2016),
            new Anio(18, 2017),
        };


    }

    //Estructuras
    public class Anio
    {
        //Campos
        int id;
        int numanio;

        //Constructor
        public Anio(int id, int numanio)
        {
            this.Id = id;
            this.Numanio = numanio;
        }

        //Propiedades
        public int Id { get => id; set => id = value; }
        public int Numanio { get => numanio; set => numanio = value; }

    }

    public class Mes
    {
        //Campos
        int id;
        string nombremes;
        double datomes;

        //Constructor
        public Mes(int id, string nombremes, double datomes)
        {
            this.Id = id;
            this.Nombremes = nombremes;
            this.Datomes = datomes;
        }

        //Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombremes { get => nombremes; set => nombremes = value; }
        public double Datomes { get => datomes; set => datomes = value; }

    }

    public class Remesas
    {
        //Campos
        int id;
        int idanio;
        int idmes;
        double datomes;

        //Constructor
        public Remesas(int id, int idanio, int idmes, double datomes)
        {
            this.Id = id;
            this.Idanio = idanio;
            this.Idmes = idmes;
            this.Datomes = datomes;
        }

        //Propiedades
        public int Id { get => id; set => id = value; }
        public int Idanio { get => idanio; set => idanio = value; }   
        public int Idmes { get => idmes; set => idmes = value; }     
        public double Datomes { get => datomes; set => datomes = value; }

    }
}