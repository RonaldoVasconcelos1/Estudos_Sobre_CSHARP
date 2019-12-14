Create proc Corler
	@Id int
	as
	select Id, Nome from cor where Id = @Id