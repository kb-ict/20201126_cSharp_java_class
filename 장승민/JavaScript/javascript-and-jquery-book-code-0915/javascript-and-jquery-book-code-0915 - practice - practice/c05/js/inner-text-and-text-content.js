var firstItem = document.getElementById('one');
var itemTextContent = firstItem.textContent;
var itemInnerText = firstItem.innerText;

var msg = '<p>itemTextContent:'+itemTextContent +'</p>';
 msg += '<p>itemInnerText:'+itemInnerText +'</p>';

var el = document.getElementById('scriptResults');
el.innerHTML = msg;