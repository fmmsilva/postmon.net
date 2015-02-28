# postmon.net [![Build status](https://ci.appveyor.com/api/projects/status/xf1e5cpf8cmujjhw?svg=true)](https://ci.appveyor.com/project/fmmsilva/postmon-net)

Cliente [Postmon](http://www.postmon.com.br) para .NET

## Como utilizar?

### C# 
```c#
Postmon.Endereco endereco = Postmon.PostmonClient.ConsultarCEP("29050265");
Postmon.Estado es = Postmon.PostmonClient.ConsultarEstado("ES");
Postmon.Cidade vitoria = Postmon.PostmonClient.ConsultarCidade("ES", "Vitória", true);
```

### VB 
```vb
Dim endereco as Postmon.Endereco = Postmon.PostmonClient.ConsultarCEP("29050265")
Dim es as Postmon.Estado = Postmon.PostmonClient.ConsultarEstado("ES")
Dim vitoria as Postmon.Cidade = Postmon.PostmonClient.ConsultarCidade("ES", "Vitória", True)
```

O retorno será nulo caso o CEP, Cidade ou UF seja inválido ou inexistente.
