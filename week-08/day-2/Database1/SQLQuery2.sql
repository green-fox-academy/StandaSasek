CREATE DATABASE Latest;

USE Latest;

CREATE TABLE Students (
	name varchar(255),
	dumpling int,
	firstLanguage varchar(255),
);

INSERT INTO Students (name, dumpling, firstLanguage) VALUES ('Ondra', 5, 'PHP');
INSERT INTO Students (name, dumpling, firstLanguage) VALUES ('Honza', 6, 'Python');
INSERT INTO Students (name, dumpling, firstLanguage) VALUES ('Standa', 0, 'ATARI Basic');
INSERT INTO Students (name, dumpling, firstLanguage) VALUES ('Standas EVIL TWIN', 5, 'QBasic');

SELECT name FROM Students;

ALTER TABLE Students
ADD CONSTRAINT dumpling_min
DEFAULT 0 FOR dumpling;

DROP TABLE Students;

CREATE TABLE Students (
	id int NOT NULL PRIMARY KEY IDENTITY(1,1),
	name varchar(255) NOT NULL UNIQUE,
	dumpling bigint DEFAULT 0,
	firstLanguage varchar(255),
);

INSERT INTO Students (name, dumpling, firstLanguage) VALUES ('Ondra', 5, 'PHP');
INSERT INTO Students (name, dumpling, firstLanguage) VALUES ('Honza', 6, 'Python');
INSERT INTO Students (name, dumpling, firstLanguage) VALUES ('Standa', 0, 'ATARI Basic');
INSERT INTO Students (name, dumpling, firstLanguage) VALUES ('Standas EVIL TWIN', 5, 'QBasic');

EXEC sp_help STUDENTS; /* eqvivalent of DESCRIBE Students;*/

/*
C - Create: CREATE, INSERT
R - Read: SELECT
U - Update: UPDATE
D - Delete: DROP (Table, Database), DELETE
*/

DELETE FROM Students WHERE id = 3;

EXEC sp_help STUDENTS;

SELECT * FROM Students
WHERE firstLanguage = 'PHP' OR firstLanguage = '%Basic';

SELECT * FROM Students
WHERE name = 'Standa';

UPDATE Students SET
dumpling = 10
WHERE id = 5;

SELECT DISTINCT firstLanguage FROM Students;

SELECT * FROM Students GROUP BY firstLanguage;

SELECT TOP 2 * FROM Students WHERE id > 1 ORDER BY dumpling DESC; /* eqvivalent to LIMIT */

SELECT COUNT(id) FROM Students GROUP BY firstLanguage;

SELECT COUNT(id) AS 'First timers', firstLanguage FROM Students GROUP BY firstLanguage;

SELECT AVG(dumpling) FROM Students;

CREATE TABLE Students (
	id int NOT NULL PRIMARY KEY IDENTITY(1,1),
	name varchar(255) NOT NULL UNIQUE,
	dumpling bigint DEFAULT 0,
	firstLanguage varchar(255),

);

CREATE TABLE Applications (
	id int NOT NULL PRIMARY KEY IDENTITY(1,1),
	techPreference varchar(255),
	name varchar(255),
	student_id int,
	FOREIGN KEY (student_id) REFERENCES Students(id),
);

/* Other possible way */
CREATE TABLE StudentsApplications (
	application_id int,
	students_id int,
);

INSERT INTO Applications (techPreference, student_id)
VALUES ('CSharp', 2);

SELECT * FROM Applications;

DELETE FROM Students WHERE id = 2; /* not possible, because there is connection between Students and Applications in row 2 */

/*
 One to one relationship
 1:1
*/

CREATE TABLE TechSkills (
	id int NOT NULL PRIMARY KEY IDENTITY(1,1),
	skillName varchar(255),
	name varchar(255),
	student_id int,
	FOREIGN KEY (student_id) REFERENCES Students(id),
);

INSERT INTO TechSkills (skillName, student_id)
VALUES ('CSharp', 2);
INSERT INTO TechSkills (skillName, student_id)
VALUES ('HTML', 2);
INSERT INTO TechSkills (skillName, student_id)
VALUES ('SQL', 2);
INSERT INTO TechSkills (skillName, student_id)
VALUES ('QBasic', 3);

SELECT * FROM TechSkills;
/*
 One to many relationship
 1:M
*/

CREATE TABLE Mentor (
	id int NOT NULL PRIMARY KEY IDENTITY(1,1),
	name varchar(255),
);

INSERT INTO Mentor (name) VALUES ('Luki');
INSERT INTO Mentor (name) VALUES ('Ondra');

SELECT * FROM Mentor;

/*
JOIN TABLE
*/

CREATE TABLE StudiedUnder (
student_id int,
mentor_id int,
FOREIGN KEY (student_id) REFERENCES Students(id),
FOREIGN KEY (mentor_id) REFERENCES Mentor(id),
);

INSERT INTO StudiedUnder (student_id, mentor_id) VALUES (2, 2);
INSERT INTO StudiedUnder (student_id, mentor_id) VALUES (2, 1);


SELECT * FROM Students;
SELECT * FROM Applications;

/* JOINING */
SELECT * FROM Students JOIN TechSkills ON Students.id = TechSkills.student_id;

SELECT Students.name, TechSkills.skillName FROM Students JOIN TechSkills ON Students.id = TechSkills.student_id;

SELECT Students.name, TechSkills.skillName FROM Students JOIN TechSkills ON Students.id = TechSkills.student_id ORDER BY Students.id;

