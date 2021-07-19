#r @"ProxectoCSharp\bin\Debug\net6.0\ProxectoCSharp.dll"

open ProxectoCSharp // Codigo F# para usar os novos types referenciados
let serena = Persona "Serena"
serena.ImprimirNome()

let longo = 
    [ "Tareixa"; "Alicia"; "Serxio"; "Laurie"; "Marion" ]
    |> List.map(fun nome -> Persona(nome)) //chamando a un constructor explicitamente
let abreviado =
    [ "Tareixa"; "Alicia"; "Serxio"; "Laurie"; "Marion" ]
    |> List.map Persona //tratando o constructor como unha funcion estandar
// F# considera un constructor como unha funcion, que cando se chama, devolve unha instancia do type (neste caso, Persona), co cal podes usar os constructores da mesma forma que calquera funcion.
// No codigo de arriba creamos cinco obxetos Persona usando unha lista de nomes
// Hai que observar que en ningun momento usamos a palabra new
// O constructor Persona e unha funcion que toma un string, o cal e o unico argumento usado en List.map, co cal podes omitir o argumento completamente

open System.Collections.Generic

type ComparadorDePersonas() = //definicion de clase con constructor por defecto
    interface IComparer<Persona> with 
        member this.Compare(x, y) = x.Nome.CompareTo(y.Nome) //implementando a interfaz
let comparadorPersona = ComparadorDePersonas() :> IComparer<Persona> //creando unha instancia da interfaz
comparadorPersona.Compare(serena, Persona "Patricio")

//Object Expressions
//F # ten outro truco na manga para traballar con interfaces, chamadas expresi�ns de obxecto.
//As expresi�ns de obxecto perm�tenche crear unha instancia dunha interface sen crear un type intermediario. Parece imposible, non? Aqu� tes o seu aspecto.
let comparadorP =
    { new IComparer<Persona> with //definicion da Interface
        member this.Compare(x, y) = x.Nome.CompareTo(y.Nome) } //Implementacion interface

//O tipo de pComparer aqu� � IComparer <Persoa>. O seu nome "real" � xerado polo compilador e nunca o podes ver (a non ser que uses reflection). Usar expresi�ns de obxectos perm�teche saltar a necesidade de constru�r manualmente un tipo para manter a implementaci�n. Podes crear a implementaci�n da interface como obxecto nun paso. 

//Nulls, nullables, e options
open System

let blank:string = null //Creando unha sleccion de strings e value types nulls e non nulls
let nome = "Vero"
let numero = Nullable 10
let blankComoOption = blank |> Option.ofObj //Null maps a None
let nomeAsOption = nome |> Option.ofObj //Non-null maps a Some
let numeroAsOption = numero |> Option.ofNullable
let numeroUnsafe = Some "Frodo" |> Option.toObj //as Options poden mapearse de volta a clases ou nullable types