var $normalTab, $DCTab, $fourTab, $normalBooking, $DCBooking, $fourTogether;
$normalTab = $('#normalTab');
$DCTab = $('#DCTab');
$fourTab = $('#fourTab');
$normalBooking = $('#normalBooking');
$DCBooking = $('#DCBooking');
$fourTogether = $('#fourTogether');
// 메인 탭 클릭시 상단 탭 전환
$normalBooking.on('click', function () {
    $normalTab.addClass('active');
    $DCTab.removeClass('active')
    ;
    $fourTab.removeClass('active')
    ;
    
})
$DCBooking.on('click', function () {
    $DCTab.addClass('active');
    $normalTab.removeClass('active')
    ;
    $fourTab.removeClass('active')
    ;
})
$fourTogether.on('click', function () {
    $fourTab.addClass('active');
    $DCTab.removeClass('active')
    ;
    $normalTab.removeClass('active')
    ;
})
// 좌측(상단) 탭 클릭시 메인 탭 전환
$normalTab.on('click', function () {
    $normalBooking.addClass('active');
    $DCBooking.removeClass('active');
    $fourTogether.removeClass('active');
})
$DCTab.on('click', function () {
    $normalBooking.removeClass('active');
    $DCBooking.addClass('active');
    $fourTogether.removeClass('active');
})
$fourTab.on('click', function () {
    $normalBooking.removeClass('active');
    $DCBooking.removeClass('active');
    $fourTogether.addClass('active');
})

// 어른 정보 삽입

// $('.adult a').on('mouseover',function(){
//     $(this).css('background-color','yellow');
// }).on('mouseout', function(){
//     $(this).css('background-color','white');
// });

$('.adult a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#adult').text(this.text);
});


//어린이 정보 삽입
$('.children a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#children').text(this.text);
});


// 유아 정보 삽입
$('.baby a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#baby').text(this.text);
});


// 노인 정보 삽입
$('.order a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#order').text(this.text);
});

// 중증 장애 정보 삽입
$('.hardHandicap a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#hardHandicap').text(this.text);
});

// 경증 장애 정보 삽입
$('.lightHandicap a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#lightHandicap').text(this.text);
});


// 좌석 종류 선택 카테고리 1
$('.position a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#position').text(this.text);
});

// 좌석 종류 선택 카테고리 2
$('.direction a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#direction').text(this.text);
});

// 좌석 종류 선택 카테고리 3
$('.ect a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#ect').text(this.text);
});

// 출발역 도착역 변환 버튼
$('#changeBtn').on('click', function () {
    var temp;
    var $departStationName = $('#departStation').val();
    var $arriveStationName = $('#arriveStation').val();

    temp = $departStationName
    $('#departStation').val($arriveStationName);
    $('#arriveStation').val(temp);

    $('#departStation').attr('value', $arriveStationName);
    $('#arriveStation').attr('value', temp);

    // temp = document.getElementById('departStation').value;
    // document.getElementById('departStation').value = document.getElementById('arriveStation').value;
    // document.getElementById('arriveStation').value= temp;

})

// $('#TrainTypeSelector input').on('click', function(){
//     if($(this).hasClass('active'))
//     $(this).addClass('active');
// })


// 직통 radio 활성화시
// 출발일 dropdown 세팅
// 년
$('.year a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#year').text(this.text);
    getDayLabel();
});

// 월
$('.month a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#month').text(this.text);
    getDayLabel();
});

// 일
$('.date a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#date').text(this.text);
    getDayLabel();
});

// 시간
$('.time a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#time').text(this.text);
    getDayLabel();
});


// 요일
function getDayLabel() {
    var week = new Array('일', '월', '화', '수', '목', '금', '토');
    var $year = $('#year').html();
    var $month = $('#month').html();
    var $date = $('#date').html();

    var $day = new Date($year + '-' + $month + '-' + $date).getDay();
    var $dayLabel = week[$day];

    $('#day').val($dayLabel)
}

// $( "#calender" ).datepicker();
$(function () {

    $("#calender").datepicker({
        changeMonth: true,
        changeYear: true,
        dateFormat: "dd-mm-yy",
        dayNames: ['일요일', '월요일', '화요일', '수요일', '목요일', '금요일', '토요일'],
        dayNamesMin: ['일', '월', '화', '수', '목', '금', '토'],
        monthNamesShort: ["1월", "2월", "3월", "4월", "5월", "6월", "7월", "8월", "9월", "10월", "11월", "12월"],
        nextText: '다음 달', // next 아이콘의 툴팁.
        prevText: '이전 달', // prev 아이콘의 툴팁.
        yearRange: "2021:2023", //연도 범위
        onSelect: function (dateText, inst) {
            var date = $(this).datepicker('getDate'),
                day = date.getDate(),
                month = date.getMonth() + 1,
                year = date.getFullYear();
            $('#year').text(year);
            $('#month').text(month);
            $('#date').text(day);
            getDayLabel();
        }


    });


});

// 출발일 dropdown 세팅
// 년
$('.year a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#year').text(this.text);
    getDayLabel();
});

// 월
$('.month a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#month').text(this.text);
    getDayLabel();
});

// 일
$('.date a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#date').text(this.text);
    getDayLabel();
});

// 시간
$('.time a').hover(function () {
    $(this).css('background-color', 'lightblue');
}, function () {
    $(this).css('background-color', 'white');
}).on('mousedown', function () {
    $(this).css('background-color', 'lightgray');
}).on('mouseup', function () {
    $(this).css('background-color', 'white');
}).on('click', function () {
    $('#time').text(this.text);
    getDayLabel();
});


// 요일
function getDayLabel() {
    var week = new Array('일', '월', '화', '수', '목', '금', '토');
    var $year = $('#year').html();
    var $month = $('#month').html();
    var $date = $('#date').html();

    var $day = new Date($year + '-' + $month + '-' + $date).getDay();
    var $dayLabel = week[$day];

    $('#day').val($dayLabel)
}

// $( "#calender" ).datepicker();
$(function () {

    $("#calender").datepicker({
        changeMonth: true,
        changeYear: true,
        dateFormat: "dd-mm-yy",
        dayNames: ['일요일', '월요일', '화요일', '수요일', '목요일', '금요일', '토요일'],
        dayNamesMin: ['일', '월', '화', '수', '목', '금', '토'],
        monthNamesShort: ["1월", "2월", "3월", "4월", "5월", "6월", "7월", "8월", "9월", "10월", "11월", "12월"],
        nextText: '다음 달', // next 아이콘의 툴팁.
        prevText: '이전 달', // prev 아이콘의 툴팁.
        yearRange: "2021:2023", //연도 범위
        onSelect: function (dateText, inst) {
            var date = $(this).datepicker('getDate'),
                day = date.getDate(),
                month = date.getMonth() + 1,
                year = date.getFullYear();
            $('#year').text(year);
            $('#month').text(month);
            $('#date').text(day);
            getDayLabel();
        }


    });


});








// // 기차 조회 API
// /* Javascript 샘플 코드 */


// var xhr = new XMLHttpRequest();
// var url = 'http://openapi.tago.go.kr/openapi/service/TrainInfoService/getStrtpntAlocFndTrainInfo'; /*URL*/
// var queryParams = '?' + encodeURIComponent('ServiceKey') + '='+'gsClkYQY5L7abfYL7oyicjcCbDBXKny%2BiAx8pSuSBvevP%2B9XASascNCaoWJz%2F89mmb%2BHM53e2xibO743Dr%2BVVQ%3D%3D'; /*Service Key*/
// queryParams += '&' + encodeURIComponent('numOfRows') + '=' + encodeURIComponent('10'); /**/
// queryParams += '&' + encodeURIComponent('pageNo') + '=' + encodeURIComponent('1'); /**/
// queryParams += '&' + encodeURIComponent('depPlaceId') + '=' + encodeURIComponent('NAT010000'); /**/
// queryParams += '&' + encodeURIComponent('arrPlaceId') + '=' + encodeURIComponent('NAT011668'); /**/
// queryParams += '&' + encodeURIComponent('depPlandTime') + '=' + encodeURIComponent('20201201'); /**/
// queryParams += '&' + encodeURIComponent('trainGradeCode') + '=' + encodeURIComponent('00'); /**/
// xhr.open('GET', url + queryParams);
// xhr.onreadystatechange = function () {
//     if (this.readyState == 4) {
//         alert('Status: '+this.status+'nHeaders: '+JSON.stringify(this.getAllResponseHeaders())+'nBody: '+this.responseText);
//     }
// };

// xhr.send('');

/* Javascript 샘플 코드 */


// var xhr = new XMLHttpRequest();
// var url = 'http://openapi.tago.go.kr/openapi/service/TrainInfoService/getStrtpntAlocFndTrainInfo'; /*URL*/
// var queryParams = '?' + encodeURIComponent('ServiceKey') + '='+'gsClkYQY5L7abfYL7oyicjcCbDBXKny%2BiAx8pSuSBvevP%2B9XASascNCaoWJz%2F89mmb%2BHM53e2xibO743Dr%2BVVQ%3D%3D'; /*Service Key*/
// queryParams += '&' + encodeURIComponent('numOfRows') + '=' + encodeURIComponent('10'); /**/
// queryParams += '&' + encodeURIComponent('pageNo') + '=' + encodeURIComponent('1'); /**/
// queryParams += '&' + encodeURIComponent('depPlaceId') + '=' + encodeURIComponent('NAT010000'); /**/
// queryParams += '&' + encodeURIComponent('arrPlaceId') + '=' + encodeURIComponent('NAT011668'); /**/
// queryParams += '&' + encodeURIComponent('depPlandTime') + '=' + encodeURIComponent('20201201'); /**/
// queryParams += '&' + encodeURIComponent('trainGradeCode') + '=' + encodeURIComponent('00'); /**/
// xhr.open('GET', url + queryParams);
// xhr.onreadystatechange = function () {
//     if (this.readyState == 4) {
//         alert('Status: '+this.status+'nHeaders: '+JSON.stringify(this.getAllResponseHeaders())+'nBody: '+this.responseText);
//     }
// };

// xhr.send('');