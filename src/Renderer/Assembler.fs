﻿module Assembler

open System
open Elmish.React
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.MaterialUI.MaterialDesignIcons
open Fable.MaterialUI.Icons
open Feliz
open Feliz.MaterialUI


type Model =
  { Count: int }

type Msg =
  | Increment
  | Decrement

let init () =
  { Count = 2 }

let update msg m =
  match msg with
  | Increment -> { m with Count = m.Count + 1 }
  | Decrement -> { m with Count = m.Count - 1 }


// Domain/Elmish above, view below


let private useStyles = Styles.makeStyles(fun styles theme ->
  {|
    description = styles.create [
      style.marginBottom (theme.spacing 3)
    ]
    margin = styles.create [
      style.marginRight (theme.spacing 2)
    ]
  |}
)

let AssemblerPage = FunctionComponent.Of((fun (model, dispatch) ->
  let c = useStyles ()
  Html.div [
    Mui.typography [
      typography.classes.root c.description
      typography.paragraph true
      typography.children "The badge becomes invisible when count = 0."
    ]

    Mui.iconButton [
      iconButton.classes.root c.margin
      iconButton.children [
        Mui.badge [
          badge.color.secondary
          badge.badgeContent model.Count
          badge.children [ notificationsIcon [] ]
        ]
      ]
    ]

    Mui.iconButton [
      prop.onClick (fun _ -> dispatch Decrement)
      iconButton.disabled (model.Count <= 0)
      iconButton.children [ minusIcon [] ]
    ]

    Mui.iconButton [
      prop.onClick (fun _ -> dispatch Increment)
      iconButton.children [ plusIcon [] ]
    ]
  ]
), "AssemblerPage", memoEqualsButFunctions)
