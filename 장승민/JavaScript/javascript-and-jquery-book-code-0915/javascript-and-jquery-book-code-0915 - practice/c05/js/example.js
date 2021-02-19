
var list  = document.getElementsByTagName('ul')[0];

var newItemLast = document.createElement('li');
var newTextLast =  document.createTextNode('크림');
newItemLast.appendChild(newTextLast);
list.appendChild(newItemLast);

var newItemFirst =document.createElement('li');
var newTextFirst  = document.createTextNode('양배추');
newItemFirst.appendChild(newTextFirst);

list.insertBefore(newItemFirst,list.firstChild);

var listEl = document.getElementsByTagName('li');
// console.log(listEl);
for(let i=0; i<listEl.length;i++){
    listEl[i].className = 'cool';

}

var title = document.getElementsByTagName('h2')[0];
var titleContent = title.firstChild.nodeValue;
// console.log(titleContent);
var totalItem = listEl.length;
// console.log(totalItem);
var newTitle = titleContent+'<span>'+totalItem+'</span>';
title.innerHTML = newTitle;