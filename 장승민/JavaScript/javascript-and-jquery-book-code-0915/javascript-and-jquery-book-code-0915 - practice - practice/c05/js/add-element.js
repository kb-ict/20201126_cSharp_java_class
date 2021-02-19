var newEl = document.createElement('li');
var newText = document.createTextNode('hello');
newEl.appendChild(newText);

// var position = document.getElementsByTagName('ul')[0];
var position = document.getElementById('todo')
position.appendChild(newEl);