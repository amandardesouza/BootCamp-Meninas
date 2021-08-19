Feature: LoginComSucesso
	Acessar a area logada do site fotoscambo

@mytag
Scenario: Login OK
	Given acessar a pagina
	And preenhcer os campos
	When clique em login
	Then acessa a area logada