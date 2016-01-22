create procedure SaveImage @img Image, @username nvarchar(100) as
update USER_INFORMATION
set Avatar = @img
where Username = @username

create procedure ReadImage @username nvarchar(100) as
select Avatar from USER_INFORMATION
where Username = @username