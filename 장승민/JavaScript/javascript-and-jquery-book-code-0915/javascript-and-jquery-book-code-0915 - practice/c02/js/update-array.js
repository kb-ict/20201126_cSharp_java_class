// 배열을 생성
var colors = ['white',
    'black',
    'custom'
];

colors[2] = 'beige';

var el= document.getElementById('colors');

el.textContent = colors[2];