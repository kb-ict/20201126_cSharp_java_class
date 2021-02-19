var hotel={
    name : 'Park',
    rooms:120,
    booked:77,
    checkAvailability : function(){
        var free = this.rooms - this.booked;
        return free;
    }
};

var elName = document.getElementById('hotelName');
elName.textContent=hotel.name;

var elRooms = document.getElementById('rooms');
elRooms.textContent=hotel.checkAvailability();