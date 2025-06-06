	SELECT
			CASE
			WHEN DATEPART(MONTH,Fecha)=1 THEN 'Enero'
			WHEN DATEPART(MONTH,Fecha)=2 THEN 'Febrero'
			WHEN DATEPART(MONTH,Fecha)=3 THEN 'Marzo'
			WHEN DATEPART(MONTH,Fecha)=4 THEN 'Abril'
			WHEN DATEPART(MONTH,Fecha)=5 THEN 'Mayo'
			WHEN DATEPART(MONTH,Fecha)=6 THEN 'Junio'
			WHEN DATEPART(MONTH,Fecha)=7 THEN 'Julio'
			WHEN DATEPART(MONTH,Fecha)=8 THEN 'Agosto'
			WHEN DATEPART(MONTH,Fecha)=9 THEN 'Septiembre'
			WHEN DATEPART(MONTH,Fecha)=10 THEN 'Octubre'
			WHEN DATEPART(MONTH,Fecha)=11 THEN 'Noviembre'
			WHEN DATEPART(MONTH,Fecha)=12 THEN 'Diciembre'
			ELSE 'MES NO EXISTE'
			END AS Mes,
			SUM(Anticipo)AS [Recaudado]
			FROM Reservas
						WHERE YEAR(Fecha)=2025
			GROUP BY DATEPART(MONTH, Fecha)
			ORDER BY DATEPART(MONTH, Fecha) ASC
GO

-- cancha mas reservada por mes
CREATE PROCEDURE CanchaMasReservada 
@anio INT
as
	SELECT
			CASE
			WHEN DATEPART(MONTH,Fecha)=1 THEN 'Enero'
			WHEN DATEPART(MONTH,Fecha)=2 THEN 'Febrero'
			WHEN DATEPART(MONTH,Fecha)=3 THEN 'Marzo'
			WHEN DATEPART(MONTH,Fecha)=4 THEN 'Abril'
			WHEN DATEPART(MONTH,Fecha)=5 THEN 'Mayo'
			WHEN DATEPART(MONTH,Fecha)=6 THEN 'Junio'
			WHEN DATEPART(MONTH,Fecha)=7 THEN 'Julio'
			WHEN DATEPART(MONTH,Fecha)=8 THEN 'Agosto'
			WHEN DATEPART(MONTH,Fecha)=9 THEN 'Septiembre'
			WHEN DATEPART(MONTH,Fecha)=10 THEN 'Octubre'
			WHEN DATEPART(MONTH,Fecha)=11 THEN 'Noviembre'
			WHEN DATEPART(MONTH,Fecha)=12 THEN 'Diciembre'
			ELSE 'MES NO EXISTE'
			END AS Mes,
			COUNT(C.Id_Cancha)AS [Cantidad],C.Numero, C.Precio
			FROM Reservas R
			INNER JOIN Canchas C on R.Id_Cancha = C.Id_Cancha
						WHERE YEAR(Fecha)=@anio 
			GROUP BY DATEPART(MONTH, Fecha),C.Numero,C.Precio
			ORDER BY DATEPART(MONTH, Fecha) ASC
GO


-- Horario con mas reservas por mes

CREATE PROC HorarioMasReservasPorMes
@anio int,
@mes int
as
SELECT
	H.Hora,
    COUNT(R.Id_Horario) AS TotalReservas
FROM Horarios H
LEFT JOIN Reservas R
    ON H.Id_Horario = R.Id_Horario AND YEAR(R.Fecha) = @anio AND MONTH(R.Fecha) = @mes
GROUP BY H.Hora, DATEPART(MONTH, R.Fecha)
ORDER BY H.Hora ASC
GO

-- Clientes con mas reservas
CREATE PROCEDURE ClientesConMasReservas
@anio int
as
SELECT CONCAT(C.Nombre, ',',C.Apellido) AS Cliente, COUNT(R.Id_Cliente) AS Cantidad
FROM Clientes C
INNER JOIN Reservas R
ON C.Id_Cliente =R.Id_Cliente
WHERE YEAR(R.Fecha)=@anio 
GROUP BY DATEPART(MONTH, R.Fecha),C.Nombre,C.Apellido
GO