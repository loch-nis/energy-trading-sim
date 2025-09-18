module Domain.Types

open System

type Currency = DKK | EUR | USD

type Money = Money of decimal * Currency



type Area = DK1 | DK2 | DK3

type Side = Buy | Sell

type PowerUnit = W | Kw | Mw
type EnergyUnit = Wh | Kwh | Mwh

type Power = {
    value: float
    unit: PowerUnit
}

type Energy = {
    value: float
    unit: EnergyUnit
}

type WindFarm = {
    id: Guid
    name: string
    area: Area
    capacity: Power
}

type SolarFarm = {
    id: Guid
    name: string
    area: Area
    capacity: Power
}

type GasFiredPowerPlant = {
    id: Guid
    name: string
    area: Area
    capacity: Power
    startupCost: Money
    // heatRateMWhPerMWh?
    // variableCostEurPerMWh?
}

type Asset =
    | Wind of WindFarm
    | Solar of SolarFarm
    | Gas of GasFiredPowerPlant

type Producer = { // e.g. Ørsted
    id: Guid
    name: string
    assets: Asset list
}

type OrderId = OrderId of Guid
type Timestamp = Timestamp of DateTime

type Price = {
    amount: Money
    per: EnergyUnit
}

type Order =
    { id: OrderId
      ts: Timestamp
      side: Side
      energy: Energy }

type Fill =
    { orderId: OrderId
      ts: Timestamp
      px: Price // px is trader lingo for concrete price at a specific timestamp
      energy: Energy
      side: Side }



type PriceTick = { ts: Timestamp; price: Price }

type Forecast = { ts: Timestamp; expected: Energy }

type Realized = { ts: Timestamp; realized: Energy }

type Event =
    | PriceTick of PriceTick
    | ForecastUpdate of Forecast
    | RealizedProduction of Realized


type State =
    { netPosition: Energy
      cashBalance: Money
      lastPrice: Price option }
    
