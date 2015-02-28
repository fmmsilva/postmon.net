# postmon.net
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
