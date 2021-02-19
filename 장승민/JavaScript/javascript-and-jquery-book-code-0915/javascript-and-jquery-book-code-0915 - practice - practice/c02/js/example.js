var title_1 = 'Howdy Molly, ';
var title_2 ='please check ';
var title_3 = 'your order:';

var elTitle = document.getElementById('greeting');
elTitle.textContent = title_1+title_2+title_3;

var sign ='Montague House';

document.getElementById('userSign').textContent=sign;

var $tiles = sign.length;
document.getElementById('tiles').textContent=$tiles;

var subtotal = 5 * $tiles;
document.getElementById("subTotal").textContent="$"+subtotal;

var shipping = 7;
document.getElementById('shipping').textContent='$' + shipping;

var total = subtotal + shipping;
document.getElementById('grandTotal').textContent='$'+total;