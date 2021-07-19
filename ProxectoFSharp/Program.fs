open System

[<EntryPoint>]
let main argv =
    let laurie = ProxectoCSharp.Persona "Laurie L'anui"
    laurie.ImprimirNome()
    0
// Aqui referenciamos un proxecto CSharp

// Como e un arquivo .fs referencianse os proxectos nos arquivos .csproj

// No caso dun arquivo de script .fsx para referenciar un proxecto externo faise doutra forma 

// Exemplos de uso:
// #r Referencia unha DLL para usar dentro dun script #r @"C:\orixen\app.dll"
// #I Engade unha ruta a ruta de busqueda de #r #I @"C:\orixen\"
// #load Carga e executa un arquivo .fsx ou .fs de F# #load @"C:\orixen\codigo.fsx"

// 1 Agora crearemos un novo script como novo item de solución chamado BlocDeApuntes.fsx.
// 2 Abriremos o arquivo de script e agregaremos codigo