using System.ComponentModel.DataAnnotations;

namespace Website.Components.Enums;

public enum JustifyContent
{
    [Display(Name = "jc-center")] Center,
    [Display(Name = "jc-end")] End,
    [Display(Name = "jc-flex-start")] FlexStart,
    [Display(Name = "jc-flex-end")] FlexEnd,
    [Display(Name = "jc-normal")] Normal,
    [Display(Name = "jc-space-around")] SpaceAround,
    [Display(Name = "jc-space-between")] SpaceBetween,
    [Display(Name = "jc-space-evenly")] SpaceEvenly,
    [Display(Name = "jc-start")] Start,
    [Display(Name = "jc-stretch")] Stretch
}
