
--all the employees
select all the employees
select * from Employees

--employes with role as a teacher
select * FROM Employees
WHERE EmployeeRole = 'Teacher'

--Get all the grades from the last month
SELECT s.FirstName, s.LastName, c.CourseName, g.Grade, g.DateGrade
FROM Students AS s
INNER JOIN Grades AS g ON s.StudentID = g.StudentID 
INNER jOIN Courses as c on g.CourseID = c.CourseID
WHERE DATEPART(m, g.DateGrade) = DATEPART(m, DATEADD(m, -1, GETDATE()))
AND DATEPART(YEAR, g.DateGrade) = DATEPART(yy, DATEADD(m, -1, GETDATE()))

 --Sort each course with a average, highest and lowest grade
SELECT c.CourseName,
	AVG(g.Grade) AS AverageGrade,
    MAX(g.Grade) AS HighestGrade,
    MIN(g.Grade) AS LowestGrade
FROM Courses AS c
JOIN Grades AS g ON c.CourseID = g.CourseID
GROUP BY c.CourseName

--Add new student
INSERT INTO Students (PersonNumber, FirstName, LastName,Class )
VALUES ('20020409-5393','Zlatan','Ibra','Fullstack JavaScript')