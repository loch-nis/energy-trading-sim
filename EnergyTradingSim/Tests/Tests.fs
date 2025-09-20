module Tests

open System
open Domain.Types
open Xunit

[<Fact>]
let ``given a state and an event, naiveBalancingStrategy returns an updated state and a list of orders`` () =
    Assert.True(true)

[<Fact>]
let ``executeOrder updates state and produces a Fill`` () =
    let ørstedAssets =
        [ Wind
              { id = Guid.NewGuid()
                name = "Horns Rev 1"
                area = DK1
                capacity = { value = 160; unit = Mw } }
          Gas
              { id = Guid.NewGuid()
                name = "Viborg Kraftvarmeværk"
                area = DK1
                capacity = { value = 55; unit = Mw }
                startupCost = Money(250000m, DKK)
                heatRate =
                  { value = 7.5
                    input = MMBtu
                    output = Mwh } } ]

    let ørsted =
        { name = "Ørsted"
          assets = ørstedAssets }
        
    // todo finish these tests

    Assert.True(true)

[<Fact>]
let ``forecast above expected production creates a Sell order`` () =
    Assert.True(true)

[<Fact>]
let ``forecast below expected production creates a Buy order`` () =
    Assert.True(true)