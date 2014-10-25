module Zippy.Tests

open Xunit
open FsUnit.Xunit

open Zippy.Zippers
open FSharpx.Collections

[<Fact>]
let ``Zipping with 2 works`` () =
    zipWith2 (+)
        (LazyList.ofList [1;2;3])
        (LazyList.ofList [4;5;6])
    |> LazyList.toList
    |> should equal [5;7;9]

[<Fact>]
let ``Zipping with 3 works`` () =
    zipWith3 (fun x y z -> System.String.Join("/", [x;y;z]))
        (LazyList.ofList ["a";"b";"c"])
        (LazyList.ofList ["d";"e";"f"])
        (LazyList.ofList ["g";"h";"i"])
    |> LazyList.toList
    |> should equal ["a/d/g";"b/e/h";"c/f/i"]

