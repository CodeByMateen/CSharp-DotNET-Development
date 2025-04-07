SELECT Course.CourseID, Section.SecID, Course.CourseName , Section.SecName , Course.CreditHrs , Section.Strength , Faculty.FacName
FROM Course , Section , Faculty
WHERE Course.CourseID = Section.CourseID AND Section.FacID = Faculty.FacID; 
