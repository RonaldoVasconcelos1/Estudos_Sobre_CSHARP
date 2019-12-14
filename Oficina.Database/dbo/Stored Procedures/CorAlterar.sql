create proc CorAlterar
	@id int,
		@nome nvarchar(200)
as
update Cor
set Nome = @nome
where Id = @id