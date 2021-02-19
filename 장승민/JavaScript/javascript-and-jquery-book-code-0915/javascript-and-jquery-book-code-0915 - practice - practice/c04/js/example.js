var number =3;
var operator ='addition';
var msg ='';


if (operator==='addition') {
    for (let i = 1; i < 11; i++) {
        msg += i +' + '+ number+' = '+ (i+number) + '<br>';
        
    }
    
} else {
    msg += i +' x '+ number+' = ' +(i*number)+ '<br>';
    
}

document.getElementById('blackboard').innerHTML=msg;