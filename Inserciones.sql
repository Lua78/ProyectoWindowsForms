


use farmacia


go

INSERT INTO CLIENTE VALUES ('MARIA LUISA BARRERA ZAMORA','002-5656565-00H',78966322)
INSERT INTO CLIENTE VALUES ('ROSMARY DEL CARMEN ROCHA','001-2514521-002J',89663322)
INSERT INTO CLIENTE VALUES ('JOSE MARIA VARGAS MARENCO','003-215241-2506j',77889922)
INSERT INTO CLIENTE VALUES ('MARIO JOSUE RUIS ZAMORA','002-211439-2563K',88882222)
INSERT INTO CLIENTE VALUES ('BIANKA MARIA CABRERA','003-301298-3652P',79452233)
INSERT INTO CLIENTE VALUES ('BRANDON ARIEL CHAVEZ','001-121478-6541P',88556644)
INSERT INTO CLIENTE VALUES ('CARMEN DEL SOCORRO LOPEZ','002-230975-7451O',84868755)
INSERT INTO CLIENTE VALUES ('JAVIER DAVID CASTILLO MORGAN','003-041174-2165L',84863399)
INSERT INTO CLIENTE VALUES ('JEFFERSON DAVID JARQUIN MEDINA','4514-020299-3521K',81445588)
INSERT INTO CLIENTE VALUES ('MARIA JOSEFA ZAMORA','0212-121299-5241K',78966322)
go
INSERT INTO PROVEEDOR VALUES ('DISTRIBUIDORA DE MEDICAMENTOS CONFISA','VILLA VENEZUELA DEPARTAMENTO 11',71115600)
INSERT INTO PROVEEDOR VALUES ('DISTRIBUIDORA CESAR GUERRERO','ALTAMIRA 3 CUADRA ABAJO DEPARTAMENTO 25',81110000)
INSERT INTO PROVEEDOR VALUES ('DISTRIBUIDORA DICEGSA','COLEGIO BAUTISTA HEBRON 4 CUADRAS AL SUR DEPARTAMENTO 30',70002222)
INSERT INTO PROVEEDOR VALUES ('DISTRIBUDORA PHARMAINSA','BARRIO SAN JUDAS 3 ANDENES ARRIBA 2 CUADRAS AL ESTE DEPARTAMENTO 16',72226633)
INSERT INTO PROVEEDOR VALUES ('DISTRIBUIDORA RAMOS','BARRIO LA PRIMAVERA 25 VARAS AL SUR DEPARTAMENTO 44',77889022)
go
INSERT INTO PRODUCTO VALUES ('ACETAMINOFEN','ANALGESICO','TABLETAS',2,80,'12/02/28',003)
INSERT INTO PRODUCTO VALUES ('COMPLEJO B','VITAMINA','INYECTABLE',250,100,'10/04/26',002)
INSERT INTO PRODUCTO VALUES ('OMEPRAZOL','ALIVIO ESTOMACAL','TABLETAS',6,50,'05/01/24',003)
INSERT INTO PRODUCTO VALUES ('LEXOTIROXINA SODICA','PARA REEMPLAZAR LA TIROXINA','TABLETAS',15,50,'10/02/25',003)
INSERT INTO PRODUCTO VALUES ('RAMIPRIL','HIPERTENSION O INSUFICIENCIA CARDIACA','TABLETAS',30,80,'11/12/25',004)
INSERT INTO PRODUCTO VALUES ('PARACETAMOL','ANALGESICO','TABLETAS',2,90,'05/12/26',003)
INSERT INTO PRODUCTO VALUES ('ATORVASTATINA','PARA CONTROLAR EL COLESTEROL','TABLETAS',15,180,'11/02/24',005)
INSERT INTO PRODUCTO VALUES ('SALBUTAMOL','INHALADOR','TABLETAS',400,80,'11/02/24',005)
INSERT INTO PRODUCTO VALUES ('HIDROCORTISONA','AFECCIONES DE LA PIEL','CREMA',150,50,'02/02/26',003)
INSERT INTO PRODUCTO VALUES ('KETOCONAZOL','INFECCIONES POR HONGOS','TABLETAS',30,10,'08/02/23',002)
INSERT INTO PRODUCTO VALUES ('FRENADOL DESCONGESTIVO','PARA LA TOS','TABLETAS',15,60,'06/06/25',004)
INSERT INTO PRODUCTO VALUES ('FLUTOX','PARA LA TOS','JARABE',90,250,'08/11/24',005)
INSERT INTO PRODUCTO VALUES ('VICKS VAPORUB','ALIVIO DE LA TOS Y CONGESTION NASAL','POMADA',50,150,'06/01/28',001)
INSERT INTO PRODUCTO VALUES ('CANESTEN OVULO','PARA LA CANDIDIASIS VAGINAL NO COMPLICADA','OVULO(COMPRIMIDO VAGINAL)',100,150,'05/11/24',002)
INSERT INTO PRODUCTO VALUES ('IBUPROFENO','ANALGESICO','TABLETAS',3,300,'09/01/27',003)
INSERT INTO PRODUCTO VALUES ('ISDYN','REPELENTE PARA MOSQUITOS','SPRAY',200,150,'08/05/24',004)
INSERT INTO PRODUCTO VALUES ('DUREX','SALUD SEXUAL','PRESERVATIVO',90,250,'08/11/24',002)
INSERT INTO PRODUCTO VALUES ('ACENOFEN','ANALGESICO ','GOTAS',40,350,'01/02/25',003)
INSERT INTO PRODUCTO VALUES ('AZITROMICINA','ANTIBIOTICO','JARABE',130,50,'06/01/26',005)
INSERT INTO PRODUCTO VALUES ('DESITIN','PREVIENE LA PA�ALITIS','CREMA',180,60,'02/12/24',005)


go

---impuesto aplicado 1.15---
INSERT INTO FACTURA VALUES (1,500,575,'11/11/22 8:00PM')
INSERT INTO FACTURA VALUES (1,20,23,'10/11/22 7:00PM')
INSERT INTO FACTURA VALUES (3,12,13.8,'10/11/22 5:00PM')
INSERT INTO FACTURA VALUES (3,30,34.5,'10/10/22 8:00AM')
INSERT INTO FACTURA VALUES (2,90,135,'11/09/22 9:30AM')
INSERT INTO FACTURA VALUES (2,9,10.35,'10/11/22 11:45AM')
INSERT INTO FACTURA VALUES (4,45,51.75,'10/11/22 12:06PM')
INSERT INTO FACTURA VALUES (4,1200,1380,'10/12/22 5:00PM')
INSERT INTO FACTURA VALUES (5,300,345,'11/13/22 6:00PM')
INSERT INTO FACTURA VALUES (5,60,69,'10/18/22 8:00PM')
INSERT INTO FACTURA VALUES (6,45,51.75,'10/21/22 6:25PM')
INSERT INTO FACTURA VALUES (8,180,207,'10/20/22 8:00AM')
INSERT INTO FACTURA VALUES (8,200,230,'10/15/22 5:00PM')
INSERT INTO FACTURA VALUES (7,1000,1150,'11/10/22 9:45AM')
INSERT INTO FACTURA VALUES (7,200,230,'10/26/22 6:45PM')
INSERT INTO FACTURA VALUES (8,180,207,'10/23/22 7:45AM')
INSERT INTO FACTURA VALUES (9,120,138,'11/08/22 8:56AM')
INSERT INTO FACTURA VALUES (9,130,149.5,'11/01/22 4:00PM')
INSERT INTO FACTURA VALUES (10,180,207,'10/01/12 5:00PM')


go
INSERT INTO DETALLES_F VALUES (10001,2,2)
INSERT INTO DETALLES_F VALUES (10002,1,10)
INSERT INTO DETALLES_F VALUES (10003,3,2)
INSERT INTO DETALLES_F VALUES (10004,4,2)
INSERT INTO DETALLES_F VALUES (10005,5,3)
INSERT INTO DETALLES_F VALUES (10006,6,3)
INSERT INTO DETALLES_F VALUES (10007,7,3)
INSERT INTO DETALLES_F VALUES (10008,8,3)
INSERT INTO DETALLES_F VALUES (10009,9,2)
INSERT INTO DETALLES_F VALUES (10010,3,2)
INSERT INTO DETALLES_F VALUES (10011,5,3)
INSERT INTO DETALLES_F VALUES (10012,4,2)
INSERT INTO DETALLES_F VALUES (10013,3,4)
INSERT INTO DETALLES_F VALUES (10014,5,2)
INSERT INTO DETALLES_F VALUES (10015,4,10)
INSERT INTO DETALLES_F VALUES (10016,6,1)
INSERT INTO DETALLES_F VALUES (10017,7,2)
INSERT INTO DETALLES_F VALUES (10018,8,3)
INSERT INTO DETALLES_F VALUES (10018,6,1)
INSERT INTO DETALLES_F VALUES (10018,9,1)

