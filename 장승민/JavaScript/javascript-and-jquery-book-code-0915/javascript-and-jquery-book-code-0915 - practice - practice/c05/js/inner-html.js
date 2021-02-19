var firstItem = document.getElementById('one');
var innerItem = firstItem.innerHTML;

firstItem.innerHTML = '<a href = \"http://example.org\">'+ innerItem+'</a>';