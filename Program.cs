using Shop.Models;

var usb = new Article("USB", 9.99m);
var pc = new Article("PC", 1499.99m);
var ps5 = new Article("PS5", 499.99m);

var articles = new List<Article>
{
    usb, 
    pc, 
    ps5
};

AppMenu.DisplayMenu(articles);