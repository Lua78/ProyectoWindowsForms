create database farmacia;
go
use farmacia
go

go
go
sp_addlogin 'adm' , 'ad2022*' , 'farmacia'
go
sp_addsrvrolemember 'adm' , 'sysadmin'
go

go
create table CLIENTE(
idcliente int identity(1,1) primary key not null,
PNombre varchar(40) not null,
cedula varchar(20) not null,
telefono  char(8) check (telefono like '[5|7|8][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null
)


create table PROVEEDOR(
idPr int identity(1,1) primary key not null,
PNombreP varchar(40) not null,
DireccionP varchar(max) not null,
telefonoP  char(8) check (telefonoP like '[5|7|2|8][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
)
go


create table PRODUCTO(
idP int identity(1,1) primary key not null,
PNombrePr varchar(40) not null,
Descripcion varchar(max) not null,
presentacion varchar(max) not null,
Precio float not null,
cantidad int not null,
fecha_caducidad date not null,
id_proveedor int not null,
FOREIGN KEY (id_proveedor) REFERENCES PROVEEDOR(idpr)
)
go

create table FACTURA(
idfactura int identity(10000,1) primary key not null,
idCliente int not null,
Subtotal  float  not null,
total  float  not null,
fecha_y_hora datetime not null,
)
go

create table DETALLES_F(
idfactura  int not null,
idproducto int not null,
cantidadComprada int not null check (cantidadcomprada>0),
CONSTRAINT FK_No_idfactura_FACTURA FOREIGN KEY (idfactura) REFERENCES FACTURA(idfactura) on delete cascade,
CONSTRAINT FK_No_idproducto_PRODUCTO FOREIGN KEY (idproducto) REFERENCES PRODUCTO(idp) on delete cascade,
)
go

--procedimientos almacenados--
go
create procedure InsertarCliente
@PNombre varchar (40),
@cedula varchar (max),
@telefono char(8)
as
if (@telefono != '')
	 begin
		insert into CLIENTE VALUES (@PNombre, @cedula, @telefono)
	 end
	
else
	begin
		print 'No pueden haber campos nulos'
	end



 go
 create procedure NuevoProveedor
 @PNombreP varchar(40),
@DireccionP varchar(max) ,
@telefonoP  char(8) 
as
if (@PNombreP !=''  or @DireccionP !='' or @telefonoP != '')
	 begin
		insert into PROVEEDOR VALUES (@PNombreP, @DireccionP, @telefonoP)
	 end
	
else
	begin
		print 'No pueden haber campos nulos'
	end


go

create procedure NuevoProducto
@PNombrePr varchar(40), 
@Descripcion varchar(max),
@presentacion varchar(max), 
@Precio float, 
@cantidad int,
@fecha_caducidad date,
@proveedor varchar(5) 
as
if (@PNombrePr !='' )
	 begin
	 if(@Precio>0 or @cantidad>0)
	 begin
		insert into PRODUCTO VALUES (@PNombrePr,@Descripcion,@presentacion, @Precio,@cantidad, @fecha_caducidad,@proveedor)
		end
		else
		begin
		print 'La cantidad y el precio deben ser mayor a 0'
		end
		end
	else
	begin
		print 'No pueden haber campos nulos'
	end

go


create procedure NuevaFactura
@idCliente int,
@Subtotal  float,  
@total  float, 
@fecha_y_hora datetime 
as
if (@idCliente !=''  and  @fecha_y_hora !='' )
	 begin
	 if(@Subtotal>0 and @total>0)
	 begin
		insert into FACTURA VALUES (@idCliente,@Subtotal, @total,@fecha_y_hora)
		end
		else
		begin
		print 'El sub total y el total deben ser mayor a 0'
		end
		end
	else
	begin
		print 'No pueden haber campos nulos'
	end

	go

	
create procedure NuevoDetalle
@idfactura  int ,
@idproducto int ,
@cantidadComprada int
as
if (@idfactura !=''  and  @idproducto !='' )
	 begin
	 if(@cantidadComprada>0)
	 begin
		insert into DETALLES_F VALUES (@idfactura,@idproducto, @cantidadComprada)
		update PRODUCTO set cantidad = cantidad-@cantidadComprada where idP = @idproducto
		end
		else
		begin
		print 'La cantidad comprada debe ser mayor a  0'
		end
		end
	else
	begin
		print 'No pueden haber campos nulos'
	end

	go

	--procedimiento de eliminacion--
	go 
	create procedure EliminarCliente
	@idcliente int
	as
	if(@idcliente>0)
	begin
	if EXISTS(SELECT*FROM CLIENTE WHERE idcliente=@idcliente)
	BEGIN
	DELETE from FACTURA where idCliente = @idcliente
	DELETE FROM CLIENTE WHERE idcliente=@idcliente
	END
	ELSE
	begin
		print('cliente inexistente')
	end
	end
	else
	begin
		print('El id no puede estar vacio ')
	 end

	 go


	 create procedure Eliminarproveedor
	 @idPr int
	 as
	if(@idPr>0)
	begin
	if EXISTS(SELECT*FROM PROVEEDOR WHERE idPr=@idPr)
	BEGIN
	delete from PRODUCTO where id_proveedor = @idPr
	DELETE FROM PROVEEDOR WHERE idPr=@idPr
	END
	ELSE
	begin
		print('Proveedor inexistente')
	end
	end
	else
	begin
		print('El id no puede estar vacio ')
	 end
	  go




	 create procedure Eliminarproducto
	 @idP int
	 as
	if(@idP>0)
	begin
	if EXISTS(SELECT*FROM PRODUCTO WHERE idP=@idP)
	BEGIN
	delete from DETALLES_F where idproducto = @idP
	DELETE FROM PRODUCTO WHERE idP=@idP
	END
	ELSE
	begin
		print('Producto inexistente')
	end
	end
	else
	begin
		print('El id no puede estar vacio ')
	 end

	 go




	 create procedure Eliminarfactura
	 @idfactura int
	 as
	if(@idfactura>0)
	begin
	if EXISTS(SELECT*FROM FACTURA WHERE idfactura=@idfactura)
	BEGIN
	DELETE FROM DETALLES_F WHERE idfactura=@idfactura
	DELETE FROM FACTURA WHERE idfactura=@idfactura
	END
	ELSE
	begin
		print('factura inexistente')
	end
	end
	else
	begin
		print('El id no puede estar vacio ')
	 end
	 ----------------
	 go 



	 create procedure ListarClientes
	 as
	 select idcliente 'ID',PNombre 'Nombre',cedula 'Cedula', telefono 'Telefono' from CLIENTE
	 go
	 create procedure ListarClienteID
	 @idcliente int 
	 as
	  select idcliente 'ID',PNombre 'Nombre',cedula 'Cedula', telefono 'Telefono' from CLIENTE where idcliente=@idcliente
	 go
	 


	 go


	 create procedure listarProductosExistentes
	 as
	 select  pr.idP 'IDProducto', pr.PNombrePr 'Producto',pr.Descripcion, presentacion 'Presentacion',Precio,cantidad 'Cantidad',fecha_caducidad 'Vencimiento',p.PNombreP 'Proveedor'
	 from PRODUCTO pr inner join PROVEEDOR p
	 on pr.id_proveedor = p.idPr
	 where cantidad >0
	 order by pr.PNombrePr

	 go


	 create procedure listarProductosNOExistentes
	 as
	 select pr.idP 'IDProducto', pr.PNombrePr 'Producto',pr.Descripcion, presentacion 'Presentacion',Precio,cantidad 'Cantidad',fecha_caducidad 'Vencimiento',p.PNombreP 'Proveedor'
	 from PRODUCTO pr inner join PROVEEDOR p
	 on pr.id_proveedor = p.idPr
	 where cantidad = 0
	  order by pr.PNombrePr
	 	 go



	 create procedure listarProductos
	 as
	 select pr.idP 'IDProducto', pr.PNombrePr 'Producto',pr.Descripcion, presentacion 'Presentacion',Precio,cantidad 'Cantidad',fecha_caducidad 'Vencimiento',p.PNombreP 'Proveedor'
	 from PRODUCTO pr inner join PROVEEDOR p
	 on pr.id_proveedor = p.idPr
	  order by pr.PNombrePr

	 go

	 create procedure ProductosMasVendidos
	 as
	 select top 5  SUM(cantidadComprada)'Cantidad_Vendida', idproducto 'ID' , pr.PNombrePr 'Producto', pr.presentacion 'Presentacion' 
	 from DETALLES_F df
	 inner join PRODUCTO pr on df.idproducto = pr.idP
	 group by  df.idproducto , pr.PNombrePr, pr.presentacion order by SUM(cantidadComprada) desc
	 


	 go




	 create procedure listarProveedores
	 as
	 select idpr 'ID', PNombreP 'Nombre', DireccionP 'Direccion' , telefonoP 'Telefono' from PROVEEDOR

	 go
	   
	 create procedure listarProveedoresID
	 @idp int
	 as
	 select idpr 'ID', PNombreP 'Nombre', DireccionP 'Direccion' , telefonoP 'Telefono' from PROVEEDOR
	 where idPr=@idp
	 go
	   create procedure listarFacturas
	   as
	   select idfactura 'ID', cl.PNombre 'Clinte',cl.idcliente 'Id_cliente',fac.Subtotal 'SubTotal', fac.total 'Total', fac.fecha_y_hora 'Fecha'
	   from FACTURA fac inner join CLIENTE cl
	   on fac.idcliente = cl.idcliente
	 

	 go	   
	   create procedure listarFacturaID 
		 @idFac int
	   as
	   select idfactura 'ID', cl.PNombre 'Cliente',cl.cedula 'Cedula',cl.idcliente 'Id cliente',fac.Subtotal 'SubTotal', fac.total 'Total', fac.fecha_y_hora 'Fecha'
	   from FACTURA fac inner join CLIENTE cl
	   on fac.idCliente = cl.idcliente
	   where fac.idfactura = @idFac

	   go
	   go

	   create procedure getDetalles 
	   @idFac int
	   as
	   select pr.idP 'ID',pr.PNombrePr 'Producto',pr.presentacion 'Presentacion', pr.Descripcion,pr.Precio,df.cantidadComprada
	   from DETALLES_F df inner join PRODUCTO pr
	   on df.idproducto = pr.idP
	   where df.idfactura = @idFac
	   go

	 create procedure getProducto 
	   @id int
	   as
	 select pr.idP 'IDProducto', pr.PNombrePr 'Producto',pr.Descripcion, presentacion 'Presentacion',Precio,cantidad 'Cantidad',fecha_caducidad 'Vencimiento',p.PNombreP 'Proveedor'
	 from PRODUCTO pr inner join PROVEEDOR p
	 on pr.id_proveedor = p.idPr
	 where pr.idP = @id
	 go
	 ---


	 create procedure EditarCliente 
	 @id int,
	 @nombre varchar (50),
	 @cedula varchar (50),
	 @tel varchar(50)
	 as
	 if exists(select*from CLIENTE where idcliente= @id)
	 begin
	    update CLIENTE set PNombre=@nombre,cedula=@cedula,telefono=@tel
		where idcliente= @id
		end 


		go

create procedure EditarProducto
@id int,
@PNombrePr varchar(40), 
@Descripcion varchar(max),
@presentacion varchar(max), 
@Precio float, 
@proveedor varchar(30)
as
declare @idPro int
set @idpro = (select idPr from proveedor where PNombreP = @proveedor)
update PRODUCTO set PNombrePr = @PNombrePr,Descripcion = @Descripcion,presentacion=@presentacion,Precio=@Precio
where idP = @id

go


	create procedure GetUltimoIDFac
	as
	select  max(idfactura) from FACTURA


	go
	create procedure EditarProveedor
@id int,
@NombrePr varchar(40), 
@direccion varchar(max),
@telefono varchar(max)
as
update PROVEEDOR set PNombreP = @NombrePr, DireccionP = @direccion,telefonoP = @telefono
where idPr = @id

	go 

	create procedure SetStock
	@idPro int,
	@cantidadEntrante int
	as
	update PRODUCTO set cantidad = cantidad + @cantidadEntrante where idP = @idPro
	go




	go
