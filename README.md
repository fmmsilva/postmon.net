# postmon.net [![Build status](https://ci.appveyor.com/api/projects/status/xf1e5cpf8cmujjhw?svg=true)](https://ci.appveyor.com/project/fmmsilva/postmon-net)

Cliente [Postmon](http://www.postmon.com.br) para .NET

## Como utilizar?

### C# 
```c#
Postmon.Endereco endereco = Postmon.PostmonClient.ConsultarCEP("29050265");
```

### VB 
```vb
Dim endereco as Postmon.Endereco = Postmon.PostmonClient.ConsultarCEP("29050265")
```

O retorno será nulo caso o CEP seja inválido ou inexistente.
