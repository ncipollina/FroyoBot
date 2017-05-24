using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FroyoBot
{
    public enum SizeOptions
    {
        Small, Medium, Large, ExtraLarge
    }

    public enum FlavorOptions
    {
        Vanilla, Chocolate, Strawberry, Mint, Coconut, Mango, Espresso, TaroRoot, CookiesAndCream,
        Plain, Raspberry, Blueberry, CakeBatter, BirthdayCake, Cheesecake, Cinnamon
    }

    public enum ToppingOptions
    {
        ChocolateChips, Strawberries, Raspberries, WhippedCream, Pecans, GummyWorms, GrahmCrackerCrumbs, Fudge,
        Butterfinger, HeathBar, Sprinkles, Caramel, StrawberrySyrup, KitKat, Bananas, Cookies, CookieDough, Nerds,
        Peanuts, Cashews, Almonds, Cherries
    }

    [Serializable]
    public class FroyoOrder
    {
        public SizeOptions? Size;
        public FlavorOptions? Flavor;
        public List<ToppingOptions> Toppings;

        public static IForm<FroyoOrder> BuildForm()
        {
            return new FormBuilder<FroyoOrder>()
                .Message("Welcome to my Froyo Order bot!")
                .Build();
        }
    }
}