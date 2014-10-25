namespace Zippy

open FSharpx.Collections
open FSharpx.Collections.LazyList

module Zippers =
    let ($) f x = f x
    
    let repeat value =
        let rec repeat' v = seq {
            yield v
            yield! repeat' v
        }
        LazyList.ofSeq $ repeat' value

    let rec (<<) (f: ('a -> 'b) LazyList) (a: 'a LazyList): 'b LazyList =
        match (f, a) with
        | (Cons(fh, ft), Cons(ah, at)) -> cons (fh ah) (ft << at)
        | _ -> empty

    let succ n lazyFs lazyAs = n (lazyFs << lazyAs)
    
    let _0 = id
    let _1 l = succ _0 l
    let _2 l = succ _1 l
    let _3 l = succ _2 l
    let _4 l = succ _3 l
    let _5 l = succ _4 l
    let _6 l = succ _5 l
    let _7 l = succ _6 l
    let _8 l = succ _7 l
    // Can be extended with more... you get the idea

    let zipWith f n = n (repeat f)

    let zipWith2 f = zipWith f _2
    let zipWith3 f = zipWith f _3 
    let zipWith4 f = zipWith f _4
    let zipWith5 f = zipWith f _5
    let zipWith6 f = zipWith f _6
    let zipWith7 f = zipWith f _7
    let zipWith8 f = zipWith f _8
