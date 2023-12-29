SELECT AddDropRequest.Status, AddDropRequest.ReqID , AddDropRequest.StdID, Student.StdName , Course.CourseName,
		Section.SecName,AddDropRequest.ReqType, AddDropRequest.DateGenerated
FROM	AddDropRequest , Course , Section, Student
WHERE	AddDropRequest.StdID=Student.StdID AND Course.CourseID = Section.CourseID AND  AddDropRequest.SecID = Section.SecID AND AddDropRequest.Status = 'pending';