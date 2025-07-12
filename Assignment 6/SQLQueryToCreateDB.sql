--Step 01
create database BarwonHealth_System
go
use BarwonHealth_System
go
-------------------------------------------------------------------------------------
--Step02
create table Doctors
(
Id varchar(50) Primary Key, 
Dr_Name varchar(50), 
Phone varchar(50), 
Email varchar(50), 
Specialty varchar(50), 
Years datetime
)
go
create table Patients
(
UR varchar(50) Primary Key,
Names varchar(50), 
Addresses varchar(50), 
Ages int, 
Email varchar(50), 
Phone varchar(50), 
Medicare_Card varchar(50),
Primary_Doc_Id varchar(50) references dbo.Doctors(Id)
)
go
create table Pharmaceutical_Companies
(
Id varchar(50) Primary Key,
Phrma_Name varchar(50), 
Phrma_Address varchar(50), 
Phone_Number varchar(50)
)
go
create table Drug
(
Trade_Name varchar(50) Primary Key, 
Drug_Strength varchar(50),
Pharmaceutical_Companies varchar(50) references dbo.Pharmaceutical_Companies(Id)
)
go
create table Patients_GetDrugFrom_Doctors
(
Patients_Id varchar(50) references dbo.Patients(UR),
Doc_Id varchar(50) references dbo.Doctors(Id),
Drug_Id varchar(50) references dbo.Drug(Trade_Name),
Date_Prescriptions Datetime,
Quantity int 
)
go
-------------------------------------------------------------------------------------