create database citas_medicas_db
GO
use citas_medicas_db
GO
create table cliente(
NoCedula varchar(20) primary key,
Nombre varchar(50) not null,
Apellido varchar(50) not null,
NoCelular varchar(20) not null,
Email varchar(50) not null,
fechaNac date not null,
Dirección varchar(max)
)
GO
create table historial_medico(
NoCedula varchar(20) foreign key references cliente(NoCedula),
FechaConsulta date not null,
SintomasPresentados varchar(max),
Receta varchar(max),
Diagnostico varchar(max),
ComentarioMedico varchar(max)
)
GO
create table citas(
NoCedula varchar(20) foreign key references cliente(NoCedula),
FechaCita date not null,
MotivoCita int not null,
ComentarioMedico varchar(max)
)
GO
create table motivo_cita(
IdMotivoCita int primary key,
Descripcion varchar(200)
)




