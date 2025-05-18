--Stored Atualizados 2025-05-18
USE [RESERVA_CANCHAS]
GO

ALTER proc [dbo].[MostrarHorarioReserva]
@fecha date,
@numero varchar(50)
as
SELECT R.Id_Reserva,CH.Numero as Cancha,CONVERT(char(5),H.Hora,108)as Hora,C.Nombre as Cliente,R.Fecha,R.Anticipo,R.Concluido,R.Cancelado FROM Horarios H  LEFT JOIN Reservas R ON H.Id_Horario = R.Id_Horario
LEFT JOIN Clientes C ON R.Id_Cliente = C.Id_Cliente LEFT JOIN Canchas CH on R.Id_Cancha = CH.Id_Cancha
WHERE R.Fecha = @fecha and CH.Numero = @numero AND( Cancelado = 0 OR Cancelado IS NULL)
ORDER BY Hora ASC
GO

ALTER proc [dbo].[AgregarReserva]
@id_cliente int,
@id_cancha int,
@id_horario int,
@fecha date,
@concluido bit,
@anticipo decimal(12,2),
@mensaje varchar(50) output
as

declare @cantidad int

set @cantidad =(select COUNT(*) from Reservas where Fecha = @fecha and Concluido = 0 and Id_Cancha = @id_cancha);
	
	IF(exists(select * from Reservas where Fecha = @fecha and Id_Horario = @id_horario and Id_Cancha = @id_cancha and Cancelado = 0))
		set @mensaje = 'El Horario ya esta reservado'
	else
		begin
			if(@cantidad >= 9)
				set @mensaje = 'Los horarios del dia estan completos'
			else
				begin
					insert into Reservas (Id_Cliente,Id_Cancha,Id_Horario,Fecha,Concluido,Anticipo,Cancelado) values (@id_cliente,@id_cancha,@id_horario,@fecha,0,@anticipo,0)
					set	@mensaje = 'Datos Agregados Correctamente'
				end
		end
