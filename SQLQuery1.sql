CREATE TABLE Trainees
(
	TraineeID INT primary key NOT NULL,
	TraineeName NVARCHAR(50) NOT NULL,
	Phone nvarchar(15) not null,
	AddmitionFee money not null,
	Age date not null,
	Picture nvarchar(30)
)
GO
CREATE TABLE Courses
(
	CourseID INT  PRIMARY KEY NOT NULL,
	CourseName NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE Modules
(
	ModuleID INT NOT NULL,
	ModuleName NVARCHAR(50) NOT NULL,
	PRIMARY KEY (ModuleID)
)
GO
CREATE TABLE CourseModules
(
	CourseID INT NOT NULL REFERENCES Courses(CourseID),
	ModuleID INT NOT NULL REFERENCES Modules(ModuleID),
	PRIMARY KEY (CourseID,ModuleID)
)
GO