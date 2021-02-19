(function(){



var hotel = {
    name : 'Park',
    cost : 240,
    dcRate : 15,
    makeCost(){
        var afterCost = this.cost * (100-this.dcRate)/100 ;
        return afterCost;
    }
}

var elName = document.getElementById('hotelName');
elName.textContent = hotel.name;

var elRoomRate = document.getElementById('roomRate');
elRoomRate.textContent ='$'+hotel.cost.toFixed(2);

var elSpecialRate = document.getElementById('specialRate');
elSpecialRate.textContent ='$'+ hotel.makeCost();


var expireMsg;  //사용자에게 보낼 메세지
var today;      //오늘 날짜
var elEnds;     //메세지를 출력할 요소

function offerExpires(today){
    //함수 내에 지역변수 선언
    var weekFromToday, day, date, month, year, dayNames, monthNames;
    //날짜에 7일을 더한다 (7일에 해당하는 밀리초를 더한다)
    weekFromToday = new Date(today.getTime() + 7 * 24* 60*60*1000);
    //요일과 월 이름을 저장하는 배열을 선언
    dayNames = ['일요일', '월요일', '화요일', '수요일', '목요일', '금요일', '토요일'];
    monthNames=['1월','2월','3월','4월','5월','6월','7월','8월','9월','10월','11월','12월'];
    //페이지에 날짜를 출력하기 위해 날짜의 각 부분 값을 가져온다
    day = dayNames[weekFromToday.getDay()];
    date = weekFromToday.getDate();
    month = monthNames[weekFromToday.getMonth()];
    year = weekFromToday.getFullYear();

    //메세지를 생성
    expireMsg = '할인 행사는';
    expireMsg += day + '에 마감됩니다.<br>(' + year +'년' +month+'' + date + '일)';
    return expireMsg;


}

today=new Date();
elEnds = document.getElementById('offerEnds');
elEnds.innerHTML = offerExpires(today);
}());
