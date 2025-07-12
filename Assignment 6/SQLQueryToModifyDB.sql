----------------------------------------------------------------------------------------------------------------------
--1.SELECT: Retrieve all columns from the Doctor table.
select *
from dbo.Doctors
----------------------------------------------------------------------------------------------------------------------
--2.ORDER BY: List patients in the Patient table in ascending order of their ages.
select Ages
from dbo.Patients
order by Ages
----------------------------------------------------------------------------------------------------------------------
--3.OFFSET FETCH: Retrieve the first 10 patients from the Patient table, starting from the 5th record.
select *
from dbo.Patients
--Note: must add order by to use OFFSET FETC
order by UR
offset 4 rows
fetch first 10 rows ONLY
----------------------------------------------------------------------------------------------------------------------
--4.SELECT TOP: Retrieve the top 5 doctors from the Doctor table.
select top 5
*
from dbo.Doctors
--Note: must add order by to use OFFSET FETC
order by Id
----------------------------------------------------------------------------------------------------------------------
--5.SELECT DISTINCT: Get a list of unique address from the Patient table.
select distinct Addresses
from dbo.Patients
----------------------------------------------------------------------------------------------------------------------
--6.WHERE: Retrieve patients from the Patient table who are aged 25.
select Names
from dbo.Patients
where Ages=25
----------------------------------------------------------------------------------------------------------------------
--7.NULL: Retrieve patients from the Patient table whose email is not provided.
select Names
from dbo.Patients
where Email is null
----------------------------------------------------------------------------------------------------------------------
--8.AND: Retrieve doctors from the Doctor table who have experience greater than 5 years and specialize in 'Cardiology'.
select Dr_Name
from dbo.Doctors
where Years>5 and Specialty = 'Cardiology'
----------------------------------------------------------------------------------------------------------------------
--9.IN: Retrieve doctors from the Doctor table whose speciality is either 'Dermatology' or 'Oncology'.
select Dr_Name
from dbo.Doctors
where Specialty IN ( 'Dermatology' ,'Oncology')
----------------------------------------------------------------------------------------------------------------------
--10.BETWEEN: Retrieve patients from the Patient table whose ages are between 18 and 30.
select Names
from dbo.Patients
where Ages between 18 and 30
----------------------------------------------------------------------------------------------------------------------
--11.LIKE: Retrieve doctors from the Doctor table whose names start with 'Dr.'.
select Dr_Name
from dbo.Doctors
where Dr_Name like 'Dr%'
----------------------------------------------------------------------------------------------------------------------
--12.Column & Table Aliases: Select the name and email of doctors, aliasing them as 'DoctorName' and 'DoctorEmail'.
select Dr_Name as DoctorName ,Email as DoctorEmail
from dbo.Doctors
----------------------------------------------------------------------------------------------------------------------
--13.Joins: Retrieve all prescriptions with corresponding patient names.
select Names, Drug_Id
from dbo.Patients INNER JOIN dbo.Patients_GetDrugFrom_Doctors
on  UR= Patients_Id
----------------------------------------------------------------------------------------------------------------------
--14.GROUP BY: Retrieve the count of patients grouped by their cities.
select Names
from dbo.Patients
group by Addresses
----------------------------------------------------------------------------------------------------------------------
--15.HAVING: Retrieve cities with more than 3 patients.
select Addresses
from dbo.Patients
having
	count (UR)>3
----------------------------------------------------------------------------------------------------------------------
--16.GROUPING SETS: Retrieve counts of patients grouped by cities and ages.
select Addresses, count(*) patients_numbers
from dbo.Patients 
group by Addresses, ages 
----------------------------------------------------------------------------------------------------------------------
--17.CUBE: Retrieve counts of patients considering all possible combinations of city and age.
select Addresses,ages , count(*) patients_numbers
from dbo.Patients 
group by cube(Addresses,ages)
----------------------------------------------------------------------------------------------------------------------
--18.ROLLUP: Retrieve counts of patients rolled up by city.
select Addresses, count(*) patients_numbers
from dbo.Patients 
group by rollup(Addresses)
----------------------------------------------------------------------------------------------------------------------
--19.EXISTS: Retrieve patients who have at least one prescription.
select Names
from dbo.Patients 
where exists
			(select names
			from dbo.Patients INNER JOIN dbo.Patients_GetDrugFrom_Doctors on  UR= Patients_Id
			WHERE  UR= Patients_Id)
----------------------------------------------------------------------------------------------------------------------
--20.UNION: Retrieve a combined list of doctors and patients.
select Names
from dbo.Patients 
union
select Dr_Name
from dbo.Doctors
----------------------------------------------------------------------------------------------------------------------
--21.Common Table Expression (CTE): Retrieve patients along with their doctors using a CTE.

----------------------------------------------------------------------------------------------------------------------
--22.INSERT: Insert a new doctor into the Doctor table.

----------------------------------------------------------------------------------------------------------------------
--23.INSERT Multiple Rows: Insert multiple patients into the Patient table.

----------------------------------------------------------------------------------------------------------------------
--24.UPDATE: Update the phone number of a doctor.

----------------------------------------------------------------------------------------------------------------------
--25.UPDATE JOIN: Update the city of patients who have a prescription from a specific doctor.

----------------------------------------------------------------------------------------------------------------------
--26.DELETE: Delete a patient from the Patient table.

----------------------------------------------------------------------------------------------------------------------
--27.Transaction: Insert a new doctor and a patient, ensuring both operations succeed or fail together.

----------------------------------------------------------------------------------------------------------------------
--28.View: Create a view that combines patient and doctor information for easy access.

----------------------------------------------------------------------------------------------------------------------
--29.Index: Create an index on the 'phone' column of the Patient table to improve search performance.

----------------------------------------------------------------------------------------------------------------------
--30.Backup: Perform a backup of the entire database to ensure data safety.

----------------------------------------------------------------------------------------------------------------------