select * from sys.procedures

select * from AspNetUsers

delete from AspNetUsers
DELETE FROM dbo.AspNetUserRoles
select * from dbo.AspNetRoles
SELECT * FROM AspNetUserRoles

SELECT * FROM dbo.AspNetUsers WHERE id = (SELECT UserId FROM dbo.AspNetUserRoles)

INSERT INTO dbo.AspNetRoles
        ( Id, Name )
VALUES  ( '2', -- Id - nvarchar(128)
          'Student'  -- Name - nvarchar(max)
          )
		  SELECT * FROM 