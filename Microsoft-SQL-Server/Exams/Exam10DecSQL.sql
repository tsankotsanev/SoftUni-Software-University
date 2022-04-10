--1. DDL

CREATE TABLE Passengers
(
	Id INT PRIMARY KEY IDENTITY,
	FullName VARCHAR(100) UNIQUE NOT NULL,
	Email VARCHAR(50) UNIQUE NOT NULL
)

CREATE TABLE Pilots
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(30) UNIQUE NOT NULL,
	LastName VARCHAR(30) UNIQUE NOT NULL,
	Age TINYINT NOT NULL,
	CHECK (Age >= 21 AND AGE <= 62),
	Rating FLOAT,
	CHECK (Rating >= 0.0 AND Rating <= 10.0)
)

CREATE TABLE AircraftTypes
(
	Id INT PRIMARY KEY IDENTITY,
	TypeName VARCHAR(30) UNIQUE NOT NULL
)

CREATE TABLE Aircraft
(
	Id INT PRIMARY KEY IDENTITY,
	Manufacturer VARCHAR(25) NOT NULL,
	Model VARCHAR(30) NOT NULL,
	[Year] INT NOT NULL,
	FlightHours INT,
	Condition CHAR(1) NOT NULL,
	TypeId INT FOREIGN KEY REFERENCES AircraftTypes(Id) NOT NULL
)

CREATE TABLE PilotsAircraft
(
	AircraftId INT FOREIGN KEY REFERENCES Aircraft(Id) NOT NULL,
	PilotId INT FOREIGN KEY REFERENCES Pilots(Id) NOT NULL
	PRIMARY KEY (AircraftId, PilotId)
)

CREATE TABLE Airports
(
	Id INT PRIMARY KEY IDENTITY,
	AirportName VARCHAR(70) UNIQUE NOT NULL,
	Country VARCHAR(100) UNIQUE NOT NULL
)

CREATE TABLE FlightDestinations 
(
	Id INT PRIMARY KEY IDENTITY,
	AirportId INT FOREIGN KEY REFERENCES Airports(Id) NOT NULL,
	[Start] DATETIME NOT NULL,
	AircraftId INT FOREIGN KEY REFERENCES Aircraft(Id) NOT NULL,
	PassengerId INT FOREIGN KEY REFERENCES Passengers(Id) NOT NULL,
	TicketPrice DECIMAL(18,2) DEFAULT(15) NOT NULL
)

--2. Insert

INSERT INTO Passengers 
SELECT 
	CONCAT(p.FirstName, ' ' ,p.LastName) as FullName,
	CONCAT(p.FirstName, p.LastName, '@gmail.com') as Email
FROM Passengers as ps
JOIN Pilots as p ON p.Id = ps.id
WHERE p.Id >= 5 AND p.Id <= 15

--3. Update
 
UPDATE Aircraft 
SET Condition = 'A'
WHERE ((Condition = 'C' OR Condition = 'B') AND (FlightHours = NULL OR FlightHours <= 100) AND ([Year] >= 2013))

--4. Delete

DELETE FROM Passengers WHERE LEN(FullName) <= 10

--5. Aircraft

SELECT
	Manufacturer,
	Model,
	FlightHours,
	Condition
FROM Aircraft
ORDER BY FlightHours DESC

--6. Pilots and Aircraft

SELECT	p.FirstName,
		p.LastName,
		a.Manufacturer,
		a.Model,
		a.FlightHours
FROM PilotsAircraft AS pa
JOIN Pilots AS p ON pa.PilotId = p.Id
JOIN Aircraft AS a ON pa.AircraftId = a.Id
WHERE a.FlightHours = NULL OR a.FlightHours <= 304
ORDER BY a.FlightHours DESC, p.FirstName

--7. Top 20 Flight Destinations

SELECT	TOP(20)
		fd.Id AS DestinationId,
		fd.[Start],
		p.FullName,
		a.AirportName,
		fd.TicketPrice
FROM FlightDestinations AS fd
JOIN Airports AS a ON fd.AirportId = a.Id
JOIN Passengers AS p ON fd.PassengerId = p.Id
WHERE (SELECT DATEPART(DAY, [Start])) % 2 = 0
ORDER BY TicketPrice DESC, AirportName

--8. Number of Flights for Each Aircraft

SELECT	a.Id AS AircraftId,
		a.Manufacturer,
		a.FlightHours,
		
FROM FlightDestinations AS fd
JOIN Aircraft AS a ON fd.AircraftId = a.Id

SELECT * FROM FlightDestinations

--10. Full Info for Flight Destinations

SELECT	ap.AirportName,
		fd.[Start] AS DayTime,
		fd.TicketPrice,
		p.FullName,
		ac.Manufacturer,
		ac.Model
FROM FlightDestinations AS fd
JOIN Airports AS ap ON fd.AirportId = ap.Id
JOIN Aircraft AS ac ON fd.AircraftId = ac.Id
JOIN Passengers AS p ON fd.PassengerId = p.Id
WHERE (SELECT DATEPART(hour, fd.[Start])) >= 6 AND 
	  (SELECT DATEPART(hour, fd.[Start])) <= 20 AND fd.TicketPrice > 2500
ORDER BY ac.Model 



