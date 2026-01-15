CREATE DATABASE mokshini13012026;
USE mokshini13012026;

-- Create the parent table for Subjects
CREATE TABLE Subjects (
    SubjectID INT PRIMARY KEY IDENTITY(1,1),
    SubjectName NVARCHAR(50) NOT NULL
);
 
-- Create the child table for Students
CREATE TABLE Students (
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    SubjectID INT, 
    EnrollmentDate DATE,
    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
);

-- Insert the 3 subject categories
INSERT INTO Subjects (SubjectName) 
VALUES ('Science'), ('Commerce'), ('Arts');
 
-- Insert 20 students linked to SubjectIDs
INSERT INTO Students (FullName, SubjectID, EnrollmentDate)
VALUES 
('Alice Johnson', 1, '2023-09-01'), ('Bob Smith', 2, '2023-09-02'),
('Charlie Davis', 3, '2023-09-01'), ('Diana Prince', 1, '2023-09-05'),
('Edward Norton', 2, '2023-08-28'), ('Fiona Gallagher', 3, '2023-09-10'),
('George Miller', 1, '2023-09-01'), ('Hannah Abbott', 2, '2023-09-03'),
('Ian Wright', 3, '2023-09-12'), ('Jenny Slate', 1, '2023-09-01'),
('Kevin Hart', 2, '2023-09-04'), ('Laura Palmer', 3, '2023-09-02'),
('Michael Scott', 2, '2023-08-25'), ('Nina Simone', 3, '2023-09-01'),
('Oscar Isaac', 1, '2023-09-07'), ('Peter Parker', 1, '2023-09-01'),
('Quinn Fabray', 3, '2023-09-03'), ('Riley Reid', 2, '2023-09-06'),
('Steven Strange', 1, '2023-09-01'), ('Tina Fey', 3, '2023-09-05');

