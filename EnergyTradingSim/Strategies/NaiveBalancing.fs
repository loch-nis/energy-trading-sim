module Strategies.NaiveBalancing

open Domain.Types

let naiveBalancingStrategy (producer: Producer) (state: State) (event: Event) : State * Order list =
    failwith "todo"
    // should likely pattern match on event type