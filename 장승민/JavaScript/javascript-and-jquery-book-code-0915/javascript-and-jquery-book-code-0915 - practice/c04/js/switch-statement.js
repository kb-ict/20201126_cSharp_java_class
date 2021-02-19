var msg;
var level=2;

switch(level){
    case 1:
        msg='첫 번째 단계입니다. 행운을 빕니다.'
        break;
    case 2:
        msg='세 단계중 두번째 단계를 완료했습니다.힘내세요.'
        break;
    case 3:
        msg='마지막 단계입니다.이제 막바지예요!'
        break;
    default:
        msg='행운을 빕니다.'
        break;
}

document.getElementById('answer').innerHTML = msg;